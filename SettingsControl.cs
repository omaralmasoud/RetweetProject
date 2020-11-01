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
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("حدث خطأ اثناء تعديل معلوماتك");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("هذه الخاصية غير مفعلة لديك");
        }

        private void Nextsu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("حسابك لا يتيح لك هذه الميزة");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("حسابك لا يتيح لك هذه الميزة");
        }
    }
}
