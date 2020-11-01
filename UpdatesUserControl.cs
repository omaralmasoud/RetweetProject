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
    public partial class UpdatesUserControl : UserControl
    {
        public UpdatesUserControl()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            if(bunifuDropdown1.selectedIndex == 0) { up1.Visible = false; up3.Visible = true; up2.Visible = false; }
            if (bunifuDropdown1.selectedIndex == 1) { up1.Visible = false; up3.Visible = false; up2.Visible = true; }
            if (bunifuDropdown1.selectedIndex == 2) { up1.Visible = true; up2.Visible = false; up3.Visible = false; }
        }
    }
}
