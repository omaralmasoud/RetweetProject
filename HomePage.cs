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
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Banerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuImageButton4_Click(object sender, EventArgs e)
        {
          
          
        }

        private void STW_Click(object sender, EventArgs e)
        {

            if(Home.internetconn == false) { MessageBox.Show("يرجى التأكد من اتصالك بالانترنت"); }
            else { 
            three_step uc = new three_step();
            if (!STW.Contains(uc))
            {



                this.Controls.Add(uc);

                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else { uc.BringToFront(); }
        }
        }

        private void profbtn_Click(object sender, EventArgs e)
        {
            if (Home.internetconn == false) { MessageBox.Show("يرجى التأكد من اتصالك بالانترنت"); }
            else
            {
                Profile uc = new Profile();
                if (!STW.Contains(uc))
                {



                    this.Controls.Add(uc);
                    
                    uc.Dock = DockStyle.Fill;
                    uc.BringToFront();
                }
                else {  uc.BringToFront(); }

            }
        }

        private void settbtn_Click(object sender, EventArgs e)
        {
            if (Home.internetconn == false) { MessageBox.Show("يرجى التأكد من اتصالك بالانترنت"); }
            else
            {
                SettingsControl uc = new SettingsControl();
                if (!STW.Contains(uc))
                {



                    this.Controls.Add(uc);
                   
                    uc.Dock = DockStyle.Fill;
                    uc.BringToFront();
                }
                else {  uc.BringToFront(); }
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            mynameP.Text = Loading.Nametext;
            Usernametext.Text = Loading.Usernametext;
            Phonetext.Text = Loading.Phonetext;
           
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (Home.internetconn == false) { MessageBox.Show("يرجى التأكد من اتصالك بالانترنت"); }
            else
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
        }

        private void w8_Tick(object sender, EventArgs e)
        {
        }
    }
}
