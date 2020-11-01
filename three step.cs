using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retweet_Done
{
    public partial class three_step : UserControl
    {
        public three_step()
        {
            InitializeComponent();
        }

        public void setlabel(string x="")
        {
            if(x != "") { donepick.Visible = true; username.Visible = true; logtxt.Visible = true; username.Text = x; newusername = username.Text; }
            
        }
        public static string newusername ;
        private void loginbtn_Click(object sender, EventArgs e)
        {
            Work work = new Work();
            if (!CheckForm(work))
            {
                Startwork uc = new Startwork();
                if (!loginbtn.Contains(uc))
                {



                    this.Controls.Add(uc);

                    uc.Dock = DockStyle.Fill;
                    
                    uc.BringToFront();
                }
                else { uc.BringToFront(); }
            }
            else
            {

                MessageBox.Show("لا يمكن تبديل او تسجيل دخول او خروج اثناء تشغيل شاشة العمل");

            }




            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void getlistbtn_Click(object sender, EventArgs e)
        {
            GetUsersControl uc = new GetUsersControl();
            if (!loginbtn.Contains(uc))
            {



                this.Controls.Add(uc);

                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else { uc.BringToFront(); }
        }
        private bool CheckForm(Form work)
        {
            work = Application.OpenForms[work.Text];
            if (work != null)
                return true;
            else
                return false;
        }
        private void startworkbtn_Click(object sender, EventArgs e)
        {
            if (username.Text != "")
            {
                Work work = new Work();
                if (!CheckForm(work))
                {
                    work.Show();
                }
                else
                {
                    ((Form)work.TopLevelControl).WindowState = FormWindowState.Normal;
                    work.WindowState = FormWindowState.Normal;
                    work.BringToFront();
                    work.Activate();
                    work.Dock = DockStyle.Fill;
                    work.Focus();


                }

            //  this.WindowState = FormWindowState.Minimized;

            // ((Form)this.TopLevelControl).WindowState = FormWindowState.Minimized;
            ((Form)this.TopLevelControl).Close();
            }
            else { MessageBox.Show("يرجى التأكد من تسجيل الدخول بحساب تويتر"); }
        }

        private void three_step_Load(object sender, EventArgs e)
        {

        }
    }
}
