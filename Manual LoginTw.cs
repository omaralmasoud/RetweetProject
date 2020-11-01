using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retweet_Done
{
    public partial class Manual_LoginTw : Form
    {
        Startwork st = new Startwork();
        public Manual_LoginTw(Startwork st1)
        {
            st = st1;
            InitializeComponent();
        }
       
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            string x = "hi";
            //Startwork s = (Startwork)this.Parent;
            
            st.Setlabel(x);
            
           
           
          
            this.Close();
        }
    }
}
