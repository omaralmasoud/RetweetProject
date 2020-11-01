using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retweet_Done
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Signup fram = new Signup();
            fram.Show();
           
        }
        private static Conn conn;
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            conn = new Conn();
            try
            {
                conn.open();
                string query = "select * from users where user ='" + this.UsernameT.Text + "'and pass ='" + this.PasswordT.Text+"'";
                MySqlCommand cmd = new MySqlCommand(query, conn.maincon);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                int count = 0;
                while (dataReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1) { Home.username = UsernameT.Text; Loading w8 = new Loading(); w8.Show(); this.Hide(); }
                else if (count > 1) { msg.Visible = true; msg.Text = "هناك خطأ في تسجيل دخولك يرجى مراسلة الادارة"; }
                else { msg.Visible = true; msg.Text = "اسم المستخدم او كلمة المرور خطأ يرجى التأكد او ان عضويتك غير مفعلة"; }
                dataReader.Close();
            }

            catch (Exception ex) { ex.Message.ToString(); }
            finally { conn.close(); }
        }
        public static string[] fontpath = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();
        string FileName = string.Format("Resources\\GE SS Two Light.otf");
        private void Login_Load(object sender, EventArgs e)
        {

           

           // var exists = System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1;
            //if (exists == true) { MessageBox.Show("RetweetSwap مشغل بالفعل"); Environment.Exit(0); }
        }
    }
}
