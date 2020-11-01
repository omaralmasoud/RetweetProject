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
    public partial class WorkingControll : UserControl
    {
        public WorkingControll()
        {
            InitializeComponent();
        }
        public void EmbedForm(Work frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Visible = true;
            frm.Dock = DockStyle.Fill;   // optional
            this.Controls.Add(frm);
        }
        private void WorkingControll_Load(object sender, EventArgs e)
        {
            Work frm = new Work();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Visible = true;
            frm.Dock = DockStyle.Fill;   // optional
            this.Controls.Add(frm);
        }
    }
}
