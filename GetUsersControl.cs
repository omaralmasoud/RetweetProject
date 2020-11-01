using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace Retweet_Done
{
    public partial class GetUsersControl : UserControl
    {
        String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Motab3 Company/Retweet Swap/";
        public GetUsersControl()
        {
            InitializeComponent();
        }

        private void getlistbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(url.Text))
            {
                msg.Visible = true;
                msg.Text = "يرجى وضع رابط القائمة المراد سحبها";
                log.Visible = true;
                log.Text = "يجري الان التعرف على القائمة ...";
            }
            else
               if (url.Text.StartsWith(@"https://twitter.com"))
            {
                weblist.Navigate(new Uri(url.Text + "/members"));
                msg.Visible = true; msg.Text = "يجري العمل الان";
                url.Enabled = false;
                getlistbtn.Enabled = false;
                stopbtn.Enabled = true;
            }
            else { msg.Visible = true; msg.Text = "يرجى وضع رابط القائمة المراد سحبها بشكل صحيح"; }

        }
    

   

        private void weblist_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            get.Start();
        }

        private void get_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uerslist.Text))
            {

                MessageBox.Show("لا يوجد حسابات لحفظها !");
            }
            else
            {
                XmlTextWriter writer = new XmlTextWriter(path + "/lists/" + listname.Text + ".xml", Encoding.UTF8);
                writer.WriteStartDocument();
                writer.WriteStartElement("SAVED");
                writer.WriteStartElement("TITLE");
                writer.WriteEndElement(); //TITLE
                foreach (string item in uerslist.Items)
                {
                    writer.WriteStartElement("ITEM");
                    writer.WriteString(item);
                    writer.WriteEndElement(); //ITEM
                }
                writer.WriteEndElement(); //SAVED
                writer.WriteEndDocument();
                writer.Close();
                uerslist.Items.Clear();
                listname.Text = "";
                string[] files = Directory.GetFiles(path + "lists/", "*.xml", SearchOption.AllDirectories);
                var namesOnly = files.Select(f => Path.GetFileNameWithoutExtension(f)).ToArray();

                label3.Text = "0";
                MessageBox.Show("تم الحفظ بنجاح");
                msg.Text = "تم الحفظ بنجاح";
            }

        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            get.Stop();
            getmore.Stop();
            url.Enabled = true;
            getlistbtn.Enabled = true;
            stopbtn.Enabled = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uerslist.Text))
            {

                msg.Visible = true;
                msg.Text = "حدد عنصر لحذفه";
                MessageBox.Show("حدد عنصر لحذفه !");
            }
            else
            {
                object item = uerslist.SelectedItem;
                uerslist.Items.Remove(item);

            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("سوف تخسر جميع البيانات ، هل انت متأكد ؟ ", "!انتبه", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                uerslist.Items.Clear();

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void getmore_Tick(object sender, EventArgs e)
        {
            getmore.Stop();


            Point scrollPoint = new Point(50, 100000);
            weblist.Document.Window.ScrollTo(scrollPoint);


            get.Start();
        }

        private void url_Click(object sender, EventArgs e)
        {
            if (url.Text == "ضع هنا رابط القائمة") { url.Text = ""; }
        }

        private void listname_Click(object sender, EventArgs e)
        {
            if (listname.Text == "ضع اسم القائمة هنا") { listname.Text = ""; }
        }

        private void get_Tick(object sender, EventArgs e)
        {
            get.Stop();


            uerslist.Items.Clear();

            
            foreach (HtmlElement el in weblist.Document.GetElementsByTagName("ul"))
                if (el.GetAttribute("className") == "stats")
                {

                    numb.Text = el.InnerText;
                    string usernumber = el.InnerText;
                    int indexOfSteam = usernumber.IndexOf("Subscribers");
                    if (indexOfSteam >= 0)
                    {
                        usernumber = usernumber.Remove(indexOfSteam);
                        usernumber = Regex.Replace(usernumber, "[^0-9]+", string.Empty);
                        cp2.MaxValue = Convert.ToInt32(usernumber);
                    }
                    
                }
            foreach (HtmlElement el in weblist.Document.GetElementsByTagName("div"))
                if (el.GetAttribute("className") == "account  js-actionable-user js-profile-popup-actionable ")
                {
                    uerslist.Items.Add(el.GetAttribute("data-screen-name"));
                    // label10.Visible = false;
                    label3.Text = uerslist.Items.Count.ToString();
                    uerslist.SelectedIndex = 0;
                    cp2.Value = uerslist.Items.Count;
                    if (uerslist.Items.Count == cp2.MaxValue)
                    {
                        get.Stop();
                        getmore.Stop();
                        url.Enabled = true;
                        getlistbtn.Enabled = true;
                        stopbtn.Enabled = false;
                        msg.Text = "تم جلب القائمة بشكل كامل";
                    }
                    else { getmore.Start(); }
                }
                else
                {
                    int n = Convert.ToInt32(cp2.MaxValue);
                    if (n == 0)
                    {

                        msg.Text = "هناك خطأ ما لا توجد نتيجة!";

                        url.Enabled = true;
                        getlistbtn.Enabled = true;
                        stopbtn.Enabled = false;
                    }
                }

        }

        private void GetUsersControl_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Motab3 Company"));
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Motab3 Company/", "Retweet Swap", "lists"));
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void getlistbtnb_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {

                uerslist.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        uerslist.Items.Add(line);
                        uerslist.SelectedIndex = 0;
                    }
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Text (*.txt)|*.txt";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in uerslist.Items)
                        sw.Write(item.ToString() + Environment.NewLine);
                MessageBox.Show("تم الحفظ بنجاح");
            }
        }
    }
}
