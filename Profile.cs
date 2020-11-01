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
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {




            Nametext.Text = Loading.Nametext;
            Usernametext.Text = Loading.Usernametext;
            Phonetext.Text = Loading.Phonetext;
            Twtext.Text = Loading.Twtext;
            Dateregtext.Text = dateofregtext.Text = Loading.Dateregtext;
            dateofendtext.Text = Loading.dateofendtext;
            pricetext.Text = Loading.pricetext;
                if (Loading.dateofend < Loading.GetNistTime())
                { activetext.Text = "غير فعال"; activetext.ForeColor = Color.Red; }
            else { activetext.Text = "فعال"; activetext.ForeColor = Color.Green; }
        }
                  

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            

        }

        private void Nextsu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("لقد حاولنا بالفعل تعديل معلومات ولكن واجهنا خطأ اثناء ذلك يرجى التواصل مع فريق الدعم الفني");
        }
    }
}
