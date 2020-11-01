using Retweet_Done.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Retweet_Done
{
    public partial class Work : Form
    {
        public Work()
        {
            InitializeComponent();
        }
        int v = 0;
        int n = 0;
        private void fade_Tick(object sender, EventArgs e)
        {
            // fade.Enabled = false;
            if (v < 100)
            {
                bunifuColorTransition1.ProgessValue = v;
                this.BackColor = bunifuColorTransition1.Value;
                UsersList.ForeColor = Color.White;
                UsersList.BackColor = bunifuColorTransition1.Value;
                Loglist.BackColor = bunifuColorTransition1.Value;
                msgtext.BackColor = bunifuColorTransition1.Value;
                v = v + 2;
                

            }
            if (v >= 100)
            {
                bunifuColorTransition2.ProgessValue = n;
                this.BackColor = bunifuColorTransition2.Value;
                UsersList.BackColor = bunifuColorTransition2.Value;
                Loglist.BackColor = bunifuColorTransition2.Value;
                msgtext.BackColor = bunifuColorTransition2.Value;
                n = n + 2;

            }

            if (n >= 100) { v = 0; n = 0; }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void STW_Click(object sender, EventArgs e)
        {
            
           
           

        }
       
        System.Timers.Timer timer = new System.Timers.Timer();
        private System.Timers.Timer tw = new System.Timers.Timer();
        public  void Work_Load(object sender, EventArgs e)
        {
            Usernametext.Text = three_step.newusername;
            musername.Text = Loading.Usernametext;


            retbar.Value = retbar.MaximumValue;
            
            timer.Interval = 1000;
            timer.Elapsed += timer_Elapsed;
            timer.Start();
            if (String.IsNullOrEmpty(noti.Text)) { }
            else
            {
                noti.Text = Loading.Noti;
                noti.Visible = true;
            }

            
            
            tw.Interval = 1000;
            tw.Elapsed += tw_Elapsed;
            tw.Start();
          //  tw.AutoReset = false;
            Loglist.Items.Add(DateTime.Now.ToString("T") + " يجري الان التحضير للعمل يرجى الانتظار ... ");
            
            string[] files = Directory.GetFiles(path + "lists/", "*.xml", SearchOption.AllDirectories);
            var namesOnly = files.Select(f => Path.GetFileNameWithoutExtension(f)).ToArray();
            
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(namesOnly);
            
            UsersList.Items.Clear();
           
        }

        void tw_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
        //    Invoke(new MethodInvoker(delegate()
          //  {
            //    cp1.MaxValue = SystemCheck.Interval + 10000;
              //  if (cp1.Value == SystemCheck.Interval+10000) { tw.Stop(); }
                //else { cp1.Value += 1000; }
        //    }));
        }

       

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            Invoke(new MethodInvoker(delegate()
            {
                timetxt.Text = DateTime.Now.ToString("T");
                
            }));

           
        }


        private void DBC_Tick(object sender, EventArgs e)
        {
         
        }

        private void CDBC_Tick(object sender, EventArgs e)
        {
            
            
        }
        private void checkLiks_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        public int modulos { get; set; }

        private void modcheck_Tick(object sender, EventArgs e)
        {
            
            int n = UsersList.Items.Count;
            if (modulos == 0) { nofnow.Text =Convert.ToString( UsersList.SelectedIndex + 1); LikeCheck.Start(); Loglist.Items.Add(timetxt.Text + " يتم الان فحص المفضلة ... "); }
            if (modulos == 1)
            {
                if (tweetsid.Items.Count == 0) { Loglist.Items.Add(timetxt.Text + " فشل في استخراج تغريدات المفضلة "); modulos = 2; }
                else { if (tweet >= 5) { modulos = 2; } else { RetweetCheck.Start(); Loglist.Items.Add(timetxt.Text + " يتم الان اعادة التغريد للمفضلة ... "); } }

            }
           
            if (modulos == 2) { if (rnum < retbar.Value) { modulos = 3; } else { msgsend.Start(); Loglist.Items.Add(timetxt.Text + "يتم الارن ارسال رسالتك للمستخدم ..");
                    int itemsPerPage = (int)(Loglist.Height / Loglist.ItemHeight);
                    Loglist.TopIndex = Loglist.Items.Count - itemsPerPage;
                } }
            if (modulos == 3)
            {

                string result = "";
                if(rnum >= retbar.Value) { 
                // form.InvokeMember("submit");
                foreach (HtmlElement el1 in sendmsg.Document.GetElementsByTagName("div"))
                    if (el1.GetAttribute("className") == "message")
                    {
                        result = el1.InnerText;
                        Loglist.Items.Add(timetxt.Text + result);
                        // MessageBox.Show("Loaded");
                        //  groupBox1.Enabled = true;
                        // progressBar.Visible = false;



                    }
                    int itemsPerPage = (int)(Loglist.Height / Loglist.ItemHeight);
                    Loglist.TopIndex = Loglist.Items.Count - itemsPerPage;
                }
                if (UsersList.SelectedIndex + 1 < n) {
                    modulos = 0;
                    tweet = 0;
                    UsersList.SelectedIndex = UsersList.SelectedIndex + 1;
                    usernow.Text = UsersList.SelectedItem.ToString();
                    rnum = 0;
                    nt.Text = "0";
                    int numnow = UsersList.SelectedIndex;
                    nofnow.Text = Convert.ToString (numnow);
                    tweetsid.Items.Clear();
                     }

                else
                {

                    modcheck.Stop(); modulos = 0; Loglist.Items.Add(timetxt.Text + " تم الانتهاء من العمل ... ");
                    tweetsid.Items.Clear();
                    tweet = 0;
                    cp1intarvel.Stop();
                    cp1.Value = 0;
                    modcheck.Stop();
                    rigthpanel.Enabled = true;
                    msgtext.Enabled = true;
                    startbtn.Enabled = true;
                    stopbtn.Enabled = false;
                    fade.Stop();
                    weknow.Text = "تم اكمال العمل بالكامل";
                    cp2.Value = cp2.MaxValue;
                    rnum = 0;
                    retbar.Enabled = true;

                    //   if (checkBox1.Checked == true) { MessageBox.Show("تنبيه ! ، لقد تم الانتهاء من العمل"); }

                }
            }
        }

        private void LikeCheck_Tick(object sender, EventArgs e)
        {
            LikeCheck.Stop();
           
            this.newlikecheck.Navigate("https://mobile.twitter.com/" + UsersList.SelectedItem.ToString() + "/favorites");
        }

        public int tweet { get; set; }
        public int nr { get; set; }
         
        private void RetweetCheck_Tick(object sender, EventArgs e)
        {int nar = nr / 5;
            RetweetCheck.Stop();
            if (tweetsid.Items.Count >= 5)
            {
                if (tweet == 0)
                {
                    tweetsid.SelectedIndex = 0;
                    tweetidtxt.Text = Convert.ToString((tweetsid.SelectedIndex + 1));
                    this.RetweetB.Navigate("https://mobile.twitter.com/statuses/" + tweetsid.SelectedItem.ToString() + "/retweet?p=t"); 
                    nr += 1;
                    nt.Text = nar.ToString();
                    nat.Text = nr.ToString();
                }

                else
                {
                    if (tweet == 1)
                    {
                        tweetsid.SelectedIndex = tweetsid.SelectedIndex + 1;
                        tweetidtxt.Text =Convert.ToString( (tweetsid.SelectedIndex + 1));
                        this.RetweetB.Navigate("https://mobile.twitter.com/statuses/" + tweetsid.SelectedItem.ToString() + "/retweet?p=t"); nr += 1;
                    }
                    else
                    {
                        if (tweet == 2)
                        {
                            tweetsid.SelectedIndex = tweetsid.SelectedIndex + 1;
                            tweetidtxt.Text = Convert.ToString((tweetsid.SelectedIndex + 1));
                            this.RetweetB.Navigate("https://mobile.twitter.com/statuses/" + tweetsid.SelectedItem.ToString() + "/retweet?p=t"); nr += 1;
                        }
                        else
                        {
                            if (tweet == 3)
                            {
                                tweetsid.SelectedIndex = tweetsid.SelectedIndex + 1;
                                tweetidtxt.Text = Convert.ToString((tweetsid.SelectedIndex + 1));
                                this.RetweetB.Navigate("https://mobile.twitter.com/statuses/" + tweetsid.SelectedItem.ToString() + "/retweet?p=t"); nr += 1;
                            }
                            else
                            {
                                if (tweet == 4)
                                {
                                 
                                    tweetsid.SelectedIndex = tweetsid.SelectedIndex + 1;
                                    tweetidtxt.Text = Convert.ToString((tweetsid.SelectedIndex + 1));
                                    this.RetweetB.Navigate("https://mobile.twitter.com/statuses/" + tweetsid.SelectedItem.ToString() + "/retweet?p=t"); nr += 1;
                                }
                            }
                        }
                    }
                }
            }else { UsersList.SelectedIndex = UsersList.SelectedIndex + 1; modulos = 0; Loglist.Items.Add(timetxt.Text + " عدد تغريدات المفضلة لهذا الحساب اقل من خمسة "); }
        }
        int rnum = 0;
        int ru;
        private void RetweetB_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            foreach (HtmlElement el in RetweetB.Document.GetElementsByTagName("input"))
                if (el.GetAttribute("value") == "Retweet" || el.GetAttribute("value") == "إعادة التغريد")
                {
                    HtmlDocument doc = RetweetB.Document;
                    // HtmlElement submit = doc.GetElementsByTagName("button").GetElementsByName("Logout")[0];
                    foreach (HtmlElement form in RetweetB.Document.Forms)
                        form.InvokeMember("submit");
                    Loglist.Items.Add(timetxt.Text + " تم عمل ريتويت بنجاح ");
                    ru = 1;
                    rnum += 1;
                    nt.Text = rnum.ToString();
                    int itemsPerPage = (int)(Loglist.Height / Loglist.ItemHeight);
                    Loglist.TopIndex = Loglist.Items.Count - itemsPerPage;
                    //Unretweet
                    if (tweet < 5) { tweet = tweet + 1; }
                    if(tweet == 5) { ru = 0; }
                }

                
                    if(ru == 1) {  }
                    else {

                foreach (HtmlElement el in RetweetB.Document.GetElementsByTagName("input"))
                    if (el.GetAttribute("value") == "Unretweet" || el.GetAttribute("value") == "إلغاء إعادة التغريد")
                {

                    Loglist.Items.Add(timetxt.Text + " لقد قمت بالفعل بإعادة تغريد هذه التغريدة ");
                    int itemsPerPage1 = (int)(Loglist.Height / Loglist.ItemHeight);

                    Loglist.TopIndex = Loglist.Items.Count - itemsPerPage1;
                    if (tweet < 5) { tweet = tweet + 1; }
                            //Unretweet
                            ru = 0;

                }
            }
                

        }

        private void RetweetB_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {

          //  if (e.MaximumProgress != 0)
             //   cp1.Value = (int)(((double)e.CurrentProgress * 100) / e.MaximumProgress);
          


        }

        private void checkLiks_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {

        //    if (e.MaximumProgress != 0)
          //      cp1.Value = (int)(((double)e.CurrentProgress * 100) / e.MaximumProgress);
          



        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        public int ReadySystem { get; set; }

        public int Readys { get; set; }

        public int Prioud_end { get; set; }

        private void SystemCheck_Tick(object sender, EventArgs e)
        {
            
           
           
        }

        public string Noti { get; set; }
        String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Motab3 Company/Retweet Swap/";
       

        private void pictureBox10_Click(object sender, EventArgs e)
        {
           
            string[] files = Directory.GetFiles(path + "lists/", "*.xml", SearchOption.AllDirectories);
            var namesOnly = files.Select(f => Path.GetFileNameWithoutExtension(f)).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(namesOnly);
           




        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsersList.Items.Clear();
            string Pathx = path + "/lists/" + comboBox1.SelectedItem.ToString() + ".xml";
            XmlTextReader xmlReader = new XmlTextReader(Pathx);

            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {

                    case XmlNodeType.Text:
                        UsersList.Items.Add(xmlReader.Value);
                        break;


                }


            }

            xmlReader.Close();
            if (ok == 1) { UsersList.Items.Add("apps_motab3"); }
            int tweetsums = UsersList.Items.Count;
            UsersList.SelectedIndex = 0;
            // label7.Text = tweetsums + "";
            nofusers.Text = Convert.ToString(UsersList.Items.Count);

        }

        private void Loglist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getlistbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msgtext.Text) || string.IsNullOrEmpty(UsersList.Text))
            {

                MessageBox.Show("هل نسيت ادخال عضويات او رسالة ؟");
                
                
            }
            else
            {
                if (msgtext.TextLength < 8) { MessageBox.Show("الرسالة التي ادخلتها قصيرة جدا !"); }
                else { 
                if (UsersList.SelectedIndex != -1) { }else  { UsersList.SelectedIndex = 0; }
                retbar.Enabled = false;
                modcheck.Start();
                //STW.Enabled = false;
                fade.Start();
                usernow.Text = UsersList.SelectedItem.ToString();
                weknow.Text = "جاري العمل ...";
                rigthpanel.Enabled = false;
                msgtext.Enabled = false;
                startbtn.Enabled = false;
                stopbtn.Enabled = true;
                cp1intarvel.Start();
                nofnow.Text = Convert.ToString(UsersList.SelectedIndex + 1);
                rnum = 0;
                    int timetoends =Convert.ToInt32( (UsersList.Items.Count * 2.25) / 60);
                    timetoend.Text = Convert.ToString(timetoends) + " ساعة";
            }
            }
        }

        private void sendmsg_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (modulos == 2)
            {
                foreach (HtmlElement el in sendmsg.Document.GetElementsByTagName("input"))
                    if (el.GetAttribute("name") == "message[recipient_screen_name]")
                    {

                        el.SetAttribute("value", UsersList.SelectedItem.ToString());
                        foreach (HtmlElement mass in sendmsg.Document.GetElementsByTagName("textarea"))
                            if (mass.GetAttribute("name") == "message[text]")
                            {

                                mass.InnerText = msgtext.Text;

                            }
                        foreach (HtmlElement mass in sendmsg.Document.GetElementsByTagName("input"))
                            if (mass.GetAttribute("name") == "commit")
                            {

                                mass.InvokeMember("click");
                                modulos = 3;
                            }

                        //message
                    }// listBox3.Items.Add(time + "تم ارسال رسالة للمستخدم ..");
            }

           
        }

        private void msgsend_Tick(object sender, EventArgs e)
        {
            msgsend.Stop();

            this.sendmsg.Navigate("https://mobile.twitter.com/messages?commit=Direct+Messages");
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            modcheck.Stop();
            rigthpanel.Enabled = true;
            msgtext.Enabled = true;
            startbtn.Enabled = true;
            stopbtn.Enabled = false;
            fade.Stop();
            weknow.Text = "تم ايقاف العمل";
            cp1intarvel.Stop();
            cp1.Value = 0;
            rnum = 0;
            retbar.Enabled = true;
            modulos = 0;
            tweet = 0;
            ru = 0;
            int itemsPerPage = (int)(Loglist.Height / Loglist.ItemHeight);

            Loglist.TopIndex = Loglist.Items.Count - itemsPerPage;
        }

        private void cp1intarvel_Tick(object sender, EventArgs e)
        {
            cp1.MaxValue = modcheck.Interval;
            if(cp1.Value == modcheck.Interval) { cp1.Value = 0; }
            else { cp1.Value += cp1intarvel.Interval; }
            cp2.MaxValue = UsersList.Items.Count;
            if(cp2.Value == UsersList.Items.Count) { cp2.Value = 0; }
            else { cp2.Value = UsersList.SelectedIndex; }
            
        }

        private void retbar_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void retbar_ValueChanged_1(object sender, EventArgs e)
        {
            if (retbar.Value < 5) { retbar.IndicatorColor = Color.Red; } else { retbar.IndicatorColor = Color.Green; }
            barnum.Text = Convert.ToString(retbar.Value);
        }

        private void msgtext_TextChanged(object sender, EventArgs e)
        {
            lntxt.Text =Convert.ToString(- msgtext.TextLength + 140);
        }
       
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            if(startbtn.Enabled == false) { this.WindowState = FormWindowState.Minimized; }
            else { timer.Stop(); this.Close(); Home home = new Home(); home.Show(); }
            
        }

        private void newlikecheck_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            foreach (HtmlElement el in newlikecheck.Document.GetElementsByTagName("div"))
                if (el.GetAttribute("className") == "tweet-text")
                {
                    string result = "";
                    result = el.GetAttribute("data-id");

                    tweetsid.Items.Add(result);

                }
            modulos = 1;
        }
        private bool CheckForm(Form home)
        {
            home = Application.OpenForms[home.Text];
            if (home != null)
                return true;
            else
                return false;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            if (!CheckForm(home))
            {
               // home.Show();
            }
            else
            {
                //home.Show();
                home.WindowState = FormWindowState.Normal;
                home.BringToFront();
                home.Activate();
                home.Dock = DockStyle.Fill;
                home.Focus();


            }
           
            
        }

        private void bunifuImageButton2_MouseHover(object sender, EventArgs e)
        {
            msgexit.Visible = true;
        }

        private void Readtextlist_Tick(object sender, EventArgs e)
        {

        }

        private void downloadlistbtn_Click(object sender, EventArgs e)
        {
           
        }

        public static string DownloadString(string address)
        {
            string text;
            using (var client = new WebClient())
            {
                text = client.DownloadString(address);
            }
            return text;
        }

        private void downlistbtn_Click(object sender, EventArgs e)
        {
            String pathlists = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Motab3 Company/Retweet Swap/lists/";
            // DownloadString(pathlists);
            var xml = DownloadString(@"http://motab3.com/RetweetSwap/update/lists.xml");
            File.WriteAllText(pathlists + "List-online.xml", xml);
            dowtxt.Text = "تم التحميل";
            downlistbtn.Enabled = false;
            string[] files = Directory.GetFiles(path + "lists/", "*.xml", SearchOption.AllDirectories);
            var namesOnly = files.Select(f => Path.GetFileNameWithoutExtension(f)).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(namesOnly);
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(path + "lists/", "*.xml", SearchOption.AllDirectories);
            var namesOnly = files.Select(f => Path.GetFileNameWithoutExtension(f)).ToArray();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(namesOnly);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
         
        }
        int ok;
        private void nobtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            msgtext.Text = "للحصول على اشتراك رسائل جماعية @apps_motab3";
            ok = 1;
        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            msgtext.Text = "";
        }
    }
}
