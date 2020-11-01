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
    public partial class Startwork : UserControl
    {
        public Startwork()
        {
            InitializeComponent();
        }

        public void Setlabel(string x)
        {
            if (x != "") { twitterlogin.Navigate(new Uri("https://mobile.twitter.com/account")); }

        }
        private void Startwork_Load(object sender, EventArgs e)
        {
            


            //   usernamerT.Text = Loading.Twtext;

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void twitterlogin_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string result = "";
            foreach (HtmlElement el in twitterlogin.Document.GetElementsByTagName("td"))
                if (el.GetAttribute("className") == "home selected")
                {
                    

                    twitterlogin.Navigate(new Uri("https://mobile.twitter.com/account"));

                    //  MessageBox.Show("Loaded");


                } foreach (HtmlElement el1 in twitterlogin.Document.GetElementsByTagName("span"))
                if (el1.GetAttribute("className") == "screen-name")
                {
                    result = el1.InnerText;
                   state.Text = "تسجيل دخول ناجح لعضوية " + result;
                    // MessageBox.Show("Loaded");
                    //  groupBox1.Enabled = true;
                    // progressBar.Visible = false;
                    
                    three_step usc = (three_step)this.Parent;
                    usc.setlabel(result);
                    loginbtn.Enabled = false;
                    logoutbtn.Enabled = true;
                    usernamerT.Enabled = false;
                    PassT.Enabled = false;
                    usernamerT.Text = result;
                    //this.Hide();
                //   Home h = new Home();
                 //  var frm = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Home").FirstOrDefault();
                 //  if (null != frm)
                 //  {
                 //      frm.Hide();
                //   }
                   
                 //  Work work = new Work();
                  // work.Show();
                  
                   
                   
                  
                    
                }

            foreach (HtmlElement el1 in twitterlogin.Document.GetElementsByTagName("input"))
                if (el1.GetAttribute("className") == "text-input")
                {
                  //  listBox2.Items.Add("تسجيل خروج ناجح ...");
                    state.Text = "انت الان جاهز لتسجيل الدخول";
                    usernamerT.Enabled = true;
                    PassT.Enabled = true;
                    loginbtn.Enabled = true;
                    manualbtn.Enabled = true;
                }

            foreach (HtmlElement el in twitterlogin.Document.GetElementsByTagName("div"))
                if (el.GetAttribute("className") == "message")
                {
                    result = el.InnerText;
                    if (result == "The username and password you entered did not match our records. Please double-check and try again. ")
                    {
                        state.Text = "يرجى التأكد من اسم المستخدم او كلمة المرور صحيحة";
                        //  listBox2.Items.Add("تسجيل الدخول خطأ : تأكد من اسم المستخدم وكلمة المرور");
                    }
                    else
                    {
                      
                      //  listBox2.Items.Add(result);
                    }


                    //  MessageBox.Show("Loaded");


                }
            if (twitterlogin.Url.ToString() == "https://mobile.twitter.com/logout") {

               state.Text = "يتم الان تسجيل الخروج";
              foreach (HtmlElement form in twitterlogin.Document.Forms)
                   form.InvokeMember("submit");
                loginbtn.Enabled = true;
                logoutbtn.Enabled = false;
                manualbtn.Enabled = true;
            }

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            state.Text = "يتم الان تسجيل الدخول";
            HtmlDocument doc = twitterlogin.Document;
            HtmlElement email = doc.GetElementById("session[username_or_email]");
            HtmlElement pass = doc.GetElementById("session[password]");

            HtmlElement submit = doc.GetElementsByTagName("input").GetElementsByName("commit")[0];
            if (string.IsNullOrEmpty(PassT.Text))
            {
                state.Text = "يرجى ادخال كلمة المرور";

            }
            else
            {
                email.SetAttribute("value", usernamerT.Text);
                pass.SetAttribute("value", PassT.Text);
                submit.InvokeMember("click");
                loginbtn.Enabled = false;
            }
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            twitterlogin.Navigate(new Uri("https://mobile.twitter.com/logout"));
            logoutbtn.Enabled = false;
        }
        public void checking(string link) { }
        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Manual_LoginTw login = new Manual_LoginTw(this);
            login.Show();
        }
    }
    
}
