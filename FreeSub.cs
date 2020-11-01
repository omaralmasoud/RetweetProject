using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Cryptography;
using System.Net;
using MySql.Data.MySqlClient;
using Retweet_Done.Classes;

namespace Retweet_Done
{
    public partial class FreeSub : UserControl
    {
        public FreeSub()
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

        private void FreeSub_Load(object sender, EventArgs e)
        {
            codvalue.Text = Loading.Value();
            datetext.Text = Convert.ToDateTime(GetNistTime()).ToString();
            Connectimer.Start();
        }
        private static Conn conn;
        private void Connectimer_Tick(object sender, EventArgs e)
        {
            Connectimer.Stop();
            conn = new Conn();


            try
            {
                conn.open();
                string query = "select * from users where mcod ='" + Loading.Value() + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn.maincon);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int count = 0;
                while (dataReader.Read())
                {
                    count = count + 1;
                }
                dataReader.Close();
                if (count == 1) { logtxt.Text = "هذا الجهاز سبق وان تم تفعيل له التجربة المجانية يرجى التوجه الى شاشة الاشتراكات"; }

                else
                {



                    DateTime date = GetNistTime().AddDays(3);

                    Operations.RegFreeSub(Loading.Value(), 1, date);


                    logtxt.Text = "لقد تم تفعيل اشتراكك بنجاح لمدة 3 ايام";
                    Application.Restart();




                }
            }
            catch (Exception ex) { ex.Message.ToString(); }
            finally { conn.close(); }




        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
