using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using Retweet_Done.Classes;
using System.Net;
using System.Net.Cache;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Retweet_Done
{
    public partial class SignupControl : UserControl
    {
        public SignupControl()
        {
            InitializeComponent();
        }


        public static DateTime GetNistTime()
        {
            var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
            var response = myHttpWebRequest.GetResponse();
            string todaysDates = response.Headers["date"];
            return DateTime.ParseExact(todaysDates,
                                       "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                                       CultureInfo.InvariantCulture.DateTimeFormat,
                                       DateTimeStyles.AssumeUniversal);
        }

        private void SignupControl_Load(object sender, EventArgs e)
        {
            datetext.Text = Convert.ToString(GetNistTime());
        }

    
        public String Usertext
        {
            get { return usertext.Text; }
            set { usertext.Text = value; }
        }
        public String Nametext
        {
            get { return nametext.Text; }
            set { nametext.Text = value; }
        }
       
        public string  Phonetext
        {
            get { return phonetext.Text; }
            set { phonetext.Text = value; }
        }
        public String Passtext
        {
            get { return passtext1.Text; }
            set { passtext1.Text = value; }
        }
        public String Twusertext
        {
            get { return twusertext.Text; }
            set { twusertext.Text = value; }
        }
        public String Datetext
        {
            get { return datetext.Text; }
            set { datetext.Text = value; }
        }

        public bool Checkbox
        {
            get { return checkboxsu.Checked; }
            set { checkboxsu.Checked = value; }
        }

        private void phonetext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private static Conn conn;
        private void Nextsu_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(Usertext) || String.IsNullOrWhiteSpace(Passtext) || String.IsNullOrWhiteSpace(Twusertext) || String.IsNullOrWhiteSpace(Nametext) || String.IsNullOrWhiteSpace(Phonetext))
            {
                erorrmsg.Visible = true; erorrmsg.Text = "هناك حقول فارغة يرجى تعبئة جميع الحقول بمعلومات صحيحة";
            }
            else
            {
                if (checkboxsu.Checked == false)
                {

                    erorrmsg.Visible = true; erorrmsg.Text = "يرجى الموافقة على بنود الخدمة وسياسة الخصوصية";

                }
                else
                {

                    conn = new Conn();
                    try
                    {
                        conn.open();
                        string query = "select * from users where user ='" + Usertext + "'";
                        MySqlCommand cmd = new MySqlCommand(query, conn.maincon);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        int count = 0;
                        while (dataReader.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1) { erorrmsg.Visible = true; erorrmsg.Text = "اسم المستخدم هذا بالفعل مسجل لدينا برجى المحاولة باسم مستخدم آخر"; }
                        else if (count > 1) { erorrmsg.Visible = true; erorrmsg.Text = "اسم المستخدم هذا بالفعل مسجل لدينا برجى المحاولة باسم مستخدم آخر"; }
                        else
                        {
                            dataReader.Close();
                            
                            string query1 = "select * from twaccounts where twuser ='" + Twusertext + "'";
                            MySqlCommand cmd1 = new MySqlCommand(query1, conn.maincon);
                            MySqlDataReader dataReader1 = cmd1.ExecuteReader();
                            int count1 = 0;
                            while (dataReader1.Read())
                            {
                                count1 = count1 + 1;
                            }
                            if (count1 == 1) { erorrmsg.Visible = true; erorrmsg.Text = "حساب تويتر الذي تحاول التسجيل به موجود لدينا بالفعل !"; }
                            else if (count1 > 1) { erorrmsg.Visible = true; erorrmsg.Text = "حساب تويتر الذي تحاول التسجيل به موجود لدينا بالفعل !"; }
                            else
                            {

                                DateTime datereg = Convert.ToDateTime(Datetext);

                                Operations.RegUser(Nametext, Usertext, Passtext, Phonetext, datereg);

                                Operations.RegUserTw(Usertext, Twusertext, datereg);
                                
                                ThankForReg uc = new ThankForReg();
                                if (!label1.Contains(uc))
                                {



                                    this.Controls.Add(uc);

                                    uc.Dock = DockStyle.Fill;
                                    uc.BringToFront();
                                }
                                else { uc.BringToFront(); }
                            }
                            
                            dataReader1.Close();
                        }
                    }

                    catch (Exception ex) { ex.Message.ToString(); }
                    finally { conn.close(); }
                }
            }


          
        }
    }
}
