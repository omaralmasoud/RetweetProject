using Retweet_Done.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retweet_Done
{
    public partial class Loading : Form
    {
        public static DateTime GetNistTime()
        {
            var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
            var response = myHttpWebRequest.GetResponse();
            string todaysDates = response.Headers["date"];
            return DateTime.ParseExact(todaysDates,
                                       "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                                       CultureInfo.InvariantCulture.DateTimeFormat,
                                       DateTimeStyles.AssumeUniversal);
        }
        private static string GetHash(string s)
        {
            //Initialize a new MD5 Crypto Service Provider in order to generate a hash
            MD5 sec = new MD5CryptoServiceProvider();
            //Grab the bytes of the variable 's'
            byte[] bt = Encoding.ASCII.GetBytes(s);
            //Grab the Hexadecimal value of the MD5 hash
            return GetHexString(sec.ComputeHash(bt));
        }
        private static string GetHexString(IList<byte> bt)
        {
            string s = string.Empty;
            for (int i = 0; i < bt.Count; i++)
            {
                byte b = bt[i];
                int n = b;
                int n1 = n & 15;
                int n2 = (n >> 4) & 15;
                if (n2 > 9)
                    s += ((char)(n2 - 10 + 'A')).ToString(CultureInfo.InvariantCulture);
                else
                    s += n2.ToString(CultureInfo.InvariantCulture);
                if (n1 > 9)
                    s += ((char)(n1 - 10 + 'A')).ToString(CultureInfo.InvariantCulture);
                else
                    s += n1.ToString(CultureInfo.InvariantCulture);
                if ((i + 1) != bt.Count && (i + 1) % 2 == 0) s += "-";
            }
            return s;
        }
        private static string _fingerPrint = string.Empty;
        public static string Value()
        {
            //You don't need to generate the HWID again if it has already been generated. This is better for performance
            //Also, your HWID generally doesn't change when your computer is turned on but it can happen.
            //It's up to you if you want to keep generating a HWID or not if the function is called.
            if (string.IsNullOrEmpty(_fingerPrint))
            {
                _fingerPrint = GetHash("CPU >> " + CpuId() + "\nBIOS >> " + BiosId());
            }
            return _fingerPrint;
        }
        private static string Identifier(string wmiClass, string wmiProperty)
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementBaseObject mo in moc)
            {
                //Only get the first one
                if (result != "") continue;
                try
                {
                    result = mo[wmiProperty].ToString();
                    break;
                }
                catch
                {
                }
            }
            return result;
        }
        private static string CpuId()
        {
            //Uses first CPU identifier available in order of preference
            //Don't get all identifiers, as it is very time consuming
            string retVal = Identifier("Win32_Processor", "UniqueId");
            if (retVal != "") return retVal;
            retVal = Identifier("Win32_Processor", "ProcessorId");
            if (retVal != "") return retVal;
            retVal = Identifier("Win32_Processor", "Name");
            if (retVal == "") //If no Name, use Manufacturer
            {
                retVal = Identifier("Win32_Processor", "Manufacturer");
            }
            //Add clock speed for extra security
            retVal += Identifier("Win32_Processor", "MaxClockSpeed");
            return retVal;
        }
        //BIOS Identifier
        private static string BiosId()
        {
            return Identifier("Win32_BIOS", "Manufacturer") + Identifier("Win32_BIOS", "SMBIOSBIOSVersion") + Identifier("Win32_BIOS", "IdentificationCode") + Identifier("Win32_BIOS", "SerialNumber") + Identifier("Win32_BIOS", "ReleaseDate") + Identifier("Win32_BIOS", "Version");
        }
        public Loading()
        {
            InitializeComponent();
            color.Add(Color.FromArgb(0, 158, 71));
            color.Add(Color.FromArgb(112, 191, 83));
            color.Add(Color.FromArgb(216, 155, 40));
            color.Add(Color.FromArgb(217, 102, 41));
            color.Add(Color.FromArgb(235, 83, 104));
            color.Add(Color.FromArgb(223, 128, 255));
            color.Add(Color.FromArgb(0, 158, 71));
            color.Add(Color.FromArgb(0, 158, 71));
        }
        List<Color> color = new List<Color>();
      
        private void Loding_Load(object sender, EventArgs e)
        {


            

        }
        int v;

        int n;
        private void fade_Tick(object sender, EventArgs e)
        {
           // fade.Enabled = false;
            if (v < 100 ) {
                bunifuColorTransition1.ProgessValue = v;
                this.BackColor = bunifuColorTransition1.Value;
                v =v+2;
               
            }
            if (v >= 100) {
                bunifuColorTransition2.ProgessValue = n;
                this.BackColor = bunifuColorTransition2.Value;
                n = n + 2;
            
            }
         
            if (n >= 100) { v = 0; n = 0; }
        }

        private void DBC_Tick(object sender, EventArgs e)
        {

            DBC.Stop();
            Operations.GetCustomers();


            List<Users> userlist;


            try
            {
                userlist = Operations.GetCustomers();
                if (userlist.Count > 0)
                {
                    Users mbl;
                    for (int i = 0; i < userlist.Count; i++)
                    {
                        mbl = userlist[i];
                        Nametext = mbl.Name;
                        Usernametext = mbl.User;
                        Phonetext = mbl.Phone.ToString();
                        Twtext = mbl.Twuser;
                        Dateregtext = mbl.Dateofreg.ToShortDateString();
                        dateofendtext = mbl.Dateofend.ToShortDateString();
                        Actives = mbl.Active;
                        Readys = mbl.Ready;
                        pricetext = mbl.Price.ToString();
                        Mcod = mbl.Mcod.ToString();
                        dateofend = (DateTime)mbl.Dateofend;
                    }
                }
                else { }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.GetType().ToString()); }


            Operations.GetState();


            List<SystemOP> userlist1;


            try
            {
                userlist1 = Operations.GetState();
                if (userlist1.Count > 0)
                {
                    SystemOP mbl;
                    for (int i = 0; i < userlist1.Count; i++)
                    {
                        mbl = userlist1[i];
                        ReadySystem = mbl.Ready;
                        Prioud_end = mbl.Prioud_end;
                        Noti = mbl.Noti.ToString();

                    }
                }
                else { }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.GetType().ToString()); }
            if (Actives == 1) { }
            else { var exists = System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1;
                if (exists == true) { MessageBox.Show("RetweetSwap مشغل بالفعل"); Environment.Exit(0); } }
                if (dateofend >= GetNistTime())
            { if (Mcod == Value())
                { Home home = new Home(); home.Show(); this.Close(); }
                else {
                    //Go to form told you u can't work in this pc 
                    NotSubPC uc = new NotSubPC();
                    if (!pictureBox1.Contains(uc))
                    {



                        this.Controls.Add(uc);

                        uc.Dock = DockStyle.Fill;
                        uc.BringToFront();
                    }
                    else { uc.BringToFront(); }
                }
            }
            else
            {
                if (Mcod == Value())
                {
                    //Go to sub month offer
                    SubsControl uc = new SubsControl();
                    if (!pictureBox1.Contains(uc))
                    {



                        this.Controls.Add(uc);

                        uc.Dock = DockStyle.Fill;
                        uc.BringToFront();
                    }
                    else { uc.BringToFront(); }
                }
                else
                {
                    SubsControl uc = new SubsControl();
                    if (!pictureBox1.Contains(uc))
                    {



                        this.Controls.Add(uc);

                        uc.Dock = DockStyle.Fill;
                        uc.BringToFront();
                    }
                    else { uc.BringToFront(); }

                }
                
            }
        }

        
public static   string Nametext { get; set; }
public static  string Usernametext { get; set; }
public static  string Phonetext { get; set; }
public  static string Twtext { get; set; }
public static string Dateregtext { get; set; }
public static  string dateofendtext { get; set; }
public static int Actives { get; set; }
public static int Readys { get; set; }
public static string pricetext { get; set; }
        public string Mcod { get;  set; }
        public static int ReadySystem { get; set; }
        public static DateTime dateofend { get; set; }
public static int Prioud_end { get; set; }

public static string Noti { get; set; }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            foreach (HtmlElement el in webBrowser1.Document.GetElementsByTagName("div"))


                if (el.GetAttribute("id") == "stop")
                {
                    DialogResult dialogResult = MessageBox.Show("تم ايقاف عمل البرنامج يرجى التواصل مع المطور ", "!انتبه", MessageBoxButtons.OK);
                    if (dialogResult == DialogResult.OK)
                    {
                        Environment.Exit(0);

                    }
                    else { Environment.Exit(0); }
                   
                    
                   
                }
        }
    }

    }

