using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retweet_Done
{
    public partial class Home : Form
    {
        public static bool internetconn;

        public Home()
        {
            
            InitializeComponent();

        }

     
        private void fader_Tick(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            Work work = new Work();
            if (!CheckForm(work))
            {
                Environment.Exit(0);
            }
            else
            {
                // this.WindowState = FormWindowState.Minimized;

                this.Close();
            }
            

            
        }

        private void HomeBtm_Click(object sender, EventArgs e)
        {
            HomePage uc = new HomePage();
            if (!this.Contains(uc))
            {



                this.Controls.Add(uc);

                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else { uc.BringToFront(); }





        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btmmune_Click(object sender, EventArgs e)
        {
            if (Slider.Width == 50)
            {


                Slider.Visible = false;
                Slider.Width = 200;
                panalbunifuTransition1.ShowSync(Slider);
                LogobunifuTransition1.ShowSync(Logo);


            }
            else {
                LogobunifuTransition1.Hide(Logo);
                Slider.Visible = false;
                Slider.Width = 50;
                panalbunifuTransition1.ShowSync(Slider);
            
            
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Tutorial uc = new Tutorial();
            if (!this.Contains(uc))
            {



                this.Controls.Add(uc);

                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else { uc.BringToFront(); }
        }

        private void Home_Move(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000, "Retweet Done", "البرنامج الان يعمل في الخلفية اذا كنت تقوم بعملية تبادل الريتويت يرجى عدم الخروج", ToolTipIcon.Info);

            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }

          
        }

       

      

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            this.Activate();
            this.Dock = DockStyle.Fill;
            this.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        public static string username { get; set; }
        public void Setlabel(string x)
        {
            if (x != "") { Startwork usc = (Startwork)this.Parent; usc.Setlabel("Hi"); }

        }
        private void Home_Load_1(object sender, EventArgs e)
        {
            todaydatetext.Text =Loading.GetNistTime().ToShortDateString();
            checknet.Start();
            if (username == "") {

                MessageBox.Show("هناك خطأ في عملية تسجيل الدخول");
                Environment.Exit(0);
            }
            else { usernameL.Text = username; }
            HomePage uc = new HomePage();
            if (!this.Contains(uc))
            {



                this.Controls.Add(uc);

                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else { uc.BringToFront(); }
            if (Loading.dateofend < Loading.GetNistTime())
            { activetext.Text = "غير فعال"; activetext.ForeColor = Color.Red; }
            else { activetext.Text = "فعال"; activetext.ForeColor = Color.Green; }
            if (IsInternetAvailable() == true)
            {
                netcheck.Text = "متصل"; netcheck.ForeColor = Color.Green;
                connimg.Visible = true;
                notconnimg.Visible = false;
                internetconn = true;
            }
            else
            {
                netcheck.Text = "غير متصل"; netcheck.ForeColor = Color.White; connimg.Visible = false; notconnimg.Visible = true;
                internetconn = false;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Profile uc = new Profile();
            if (!this.Contains(uc))
            {



                this.Controls.Add(uc);

                uc.Dock = DockStyle.Fill;
                uc.BringToFront();

            }
            else { uc.BringToFront(); }



            

        }

        public static int En { get; set; }

        private void profile1_Load(object sender, EventArgs e)
        {
            
        }

        private void Home_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            SettingsControl uc = new SettingsControl();
            if (!this.Contains(uc))
            {

               

               
                this.Controls.Add(uc);
                
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
                
            }
            else { uc.BringToFront();  }

        }

        private bool CheckForm(Form work)
        {
            work = Application.OpenForms[work.Text];
            if (work != null)
                return true;
            else
                return false;
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Work work = new Work();
            if (!CheckForm(work))
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("لا يمكنك تسجيل الخروج اثناء تشغيل لوحة العمل !");

            }


           
        }

        private void FormFace_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Updatesbtn_Click(object sender, EventArgs e)
        {
            UpdatesUserControl uc = new UpdatesUserControl();
            if (!this.Contains(uc))
            {



                this.Controls.Add(uc);

                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else { uc.BringToFront(); }
        }

        private void Supportbtn_Click(object sender, EventArgs e)
        {
            SupportUserControl uc = new SupportUserControl();
            if (!this.Contains(uc))
            {



                this.Controls.Add(uc);

                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else { uc.BringToFront(); }
        }


        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool IsInternetAvailable()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                int nDescription;
                return InternetGetConnectedState(out nDescription, 0);

            }

            return false;
        }
        private void checknet_Tick(object sender, EventArgs e)
        {
            if(IsInternetAvailable() == true)
            {
                netcheck.Text = "متصل"; netcheck.ForeColor = Color.Green;
                connimg.Visible = true;
                notconnimg.Visible = false;
                internetconn = true;
            }
            else {
                netcheck.Text = "غير متصل"; netcheck.ForeColor = Color.White; connimg.Visible = false; notconnimg.Visible = true;
                internetconn = false;
            }
           

            

        }
    }
}
