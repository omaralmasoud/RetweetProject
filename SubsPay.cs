using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Retweet_Done.Classes;

namespace Retweet_Done
{
    public partial class SubsPay : UserControl
    {
        public SubsPay()
        {
            InitializeComponent();
        }

        private void Nextsu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nametext.Text) || String.IsNullOrWhiteSpace(banknametext.Text))
            {
                MessageBox.Show( "هناك حقول فارغة يرجى تعبئة جميع الحقول بمعلومات صحيحة");
            }
            else { 
                int phone =Convert.ToInt32( Loading.Phonetext);
            Operations.OrderRequst(nametext.Text,Home.username,banknametext.Text, phone, dateofsend.Value,Loading.GetNistTime(),Loading.Value());
                PaymentSent uc = new PaymentSent();
                if (!nametext.Contains(uc))
                {



                    this.Controls.Add(uc);

                    uc.Dock = DockStyle.Fill;
                    uc.BringToFront();
                }
                else { uc.BringToFront(); }
            }
        }

        private void SubsPay_Load(object sender, EventArgs e)
        {
            mcodtext.Text = Loading.Value();
            mcodtext.Enabled = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
