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
    public partial class SubsControl : UserControl
    {
        public SubsControl()
        {
            InitializeComponent();
        }

        private void subscribs_MouseHover(object sender, EventArgs e)
        {
            subscribs.BackColor = Color.FromArgb(0, 97, 209);
        }

        private void payement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void payement_MouseHover(object sender, EventArgs e)
        {
            payement.BackColor = Color.FromArgb(0, 97, 209);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void payement_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void subscribs_MouseLeave(object sender, EventArgs e)
        {
            subscribs.BackColor = Color.DimGray;
        }

        private void payement_MouseLeave(object sender, EventArgs e)
        {
            payement.BackColor = Color.FromArgb(218, 0, 89); 
        }

        private void SubsControl_Load(object sender, EventArgs e)
        {

        }

        private void subscribs_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void subscribs_Click(object sender, EventArgs e)
        {
            FreeSub uc = new FreeSub();
            if (!subscribs.Contains(uc))
            {



                this.Controls.Add(uc);

                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else { this.Hide(); uc.BringToFront(); }
        }

        private void payement_Click(object sender, EventArgs e)
        {
            SubsPay uc = new SubsPay();
            if (!subscribs.Contains(uc))
            {



                this.Controls.Add(uc);

                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else { this.Hide(); uc.BringToFront(); }
        }
    }
}
