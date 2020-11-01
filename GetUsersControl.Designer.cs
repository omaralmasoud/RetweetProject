namespace Retweet_Done
{
    partial class GetUsersControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetUsersControl));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numb = new System.Windows.Forms.Label();
            this.weblist = new System.Windows.Forms.WebBrowser();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.uerslist = new System.Windows.Forms.ListBox();
            this.log = new System.Windows.Forms.Label();
            this.url = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.listname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.get = new System.Windows.Forms.Timer(this.components);
            this.getmore = new System.Windows.Forms.Timer(this.components);
            this.stopbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.cp1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cp2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.getlistbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.getlistbtnb = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.stopbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getlistbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(369, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 144;
            this.label6.Text = "ايقاف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(430, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 142;
            this.label5.Text = "اضغط هنا للبدأ";
            // 
            // msg
            // 
            this.msg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.msg.BackColor = System.Drawing.Color.White;
            this.msg.ForeColor = System.Drawing.Color.Crimson;
            this.msg.Location = new System.Drawing.Point(570, 88);
            this.msg.Name = "msg";
            this.msg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.msg.Size = new System.Drawing.Size(304, 13);
            this.msg.TabIndex = 141;
            this.msg.Text = "اذا كنت لا تملك حساب يمكنك انشاء واحد خلال دقيقية";
            this.msg.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.msg.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(235, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 140;
            this.label1.Text = "معلومات القائمة";
            // 
            // numb
            // 
            this.numb.AutoSize = true;
            this.numb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numb.ForeColor = System.Drawing.Color.Silver;
            this.numb.Location = new System.Drawing.Point(237, 113);
            this.numb.Name = "numb";
            this.numb.Size = new System.Drawing.Size(15, 16);
            this.numb.TabIndex = 139;
            this.numb.Text = "0";
            // 
            // weblist
            // 
            this.weblist.Location = new System.Drawing.Point(873, 295);
            this.weblist.MinimumSize = new System.Drawing.Size(20, 20);
            this.weblist.Name = "weblist";
            this.weblist.ScriptErrorsSuppressed = true;
            this.weblist.Size = new System.Drawing.Size(47, 39);
            this.weblist.TabIndex = 138;
            this.weblist.Visible = false;
            this.weblist.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.weblist_DocumentCompleted_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.label3.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(45, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 26);
            this.label3.TabIndex = 137;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(90, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 136;
            this.label2.Text = "عدد الحسابات التي تم جلبها";
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "تفريغ القائمة";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 55D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 50D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(224, 261);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton4.selected = true;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(89, 29);
            this.bunifuFlatButton4.TabIndex = 135;
            this.bunifuFlatButton4.Text = "تفريغ القائمة";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("GE SS Two Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "حذف عنصر";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 55D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(224, 226);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton2.selected = true;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(89, 27);
            this.bunifuFlatButton2.TabIndex = 134;
            this.bunifuFlatButton2.Text = "حذف عنصر";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("GE SS Two Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // uerslist
            // 
            this.uerslist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.uerslist.ForeColor = System.Drawing.Color.White;
            this.uerslist.FormattingEnabled = true;
            this.uerslist.Location = new System.Drawing.Point(60, 67);
            this.uerslist.Name = "uerslist";
            this.uerslist.Size = new System.Drawing.Size(171, 264);
            this.uerslist.TabIndex = 133;
            // 
            // log
            // 
            this.log.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.log.BackColor = System.Drawing.Color.White;
            this.log.ForeColor = System.Drawing.Color.Crimson;
            this.log.Location = new System.Drawing.Point(618, 295);
            this.log.Name = "log";
            this.log.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.log.Size = new System.Drawing.Size(262, 17);
            this.log.TabIndex = 132;
            this.log.Text = "اذا كنت لا تملك حساب يمكنك انشاء واحد خلال دقيقية";
            this.log.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.log.Visible = false;
            // 
            // url
            // 
            this.url.BorderColorFocused = System.Drawing.Color.White;
            this.url.BorderColorIdle = System.Drawing.Color.Silver;
            this.url.BorderColorMouseHover = System.Drawing.Color.White;
            this.url.BorderThickness = 1;
            this.url.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.url.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url.ForeColor = System.Drawing.Color.Silver;
            this.url.isPassword = false;
            this.url.Location = new System.Drawing.Point(557, 126);
            this.url.Margin = new System.Windows.Forms.Padding(4);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(304, 32);
            this.url.TabIndex = 131;
            this.url.Text = "ضع هنا رابط القائمة";
            this.url.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.url.Click += new System.EventHandler(this.url_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(359, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 130;
            this.label15.Text = "العمل المنجز";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightGray;
            this.label14.Location = new System.Drawing.Point(476, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 129;
            this.label14.Text = "العمل الان";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label20.Location = new System.Drawing.Point(620, 222);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(220, 13);
            this.label20.TabIndex = 126;
            this.label20.Text = "اذا وضعت اسم قائمة سابق سيتم الحفظ عليها";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listname
            // 
            this.listname.BorderColorFocused = System.Drawing.Color.White;
            this.listname.BorderColorIdle = System.Drawing.Color.Silver;
            this.listname.BorderColorMouseHover = System.Drawing.Color.White;
            this.listname.BorderThickness = 1;
            this.listname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listname.ForeColor = System.Drawing.Color.Silver;
            this.listname.isPassword = false;
            this.listname.Location = new System.Drawing.Point(602, 186);
            this.listname.Margin = new System.Windows.Forms.Padding(4);
            this.listname.Name = "listname";
            this.listname.Size = new System.Drawing.Size(238, 32);
            this.listname.TabIndex = 125;
            this.listname.Text = "ضع اسم القائمة هنا";
            this.listname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.listname.Click += new System.EventHandler(this.listname_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "حفظ القائمة";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 55D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 50D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(668, 247);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton3.selected = true;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(104, 39);
            this.bunifuFlatButton3.TabIndex = 124;
            this.bunifuFlatButton3.Text = "حفظ القائمة";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("GE SS Two Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(352, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(512, 13);
            this.label4.TabIndex = 122;
            this.label4.Text = "تمكنك هذه الخاصية من جلب الحسابات الموجودة في القوائم والتعديل على القائمة بسهولة" +
    " وحفظها لطلبها لاحقا";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(614, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(250, 13);
            this.label13.TabIndex = 123;
            this.label13.Text = "ادخل على اي قائمة في تويتر وضع رابطها في الاسفل";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(769, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 119;
            this.label7.Text = "اجلب العوضيات";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(670, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 13);
            this.label8.TabIndex = 118;
            this.label8.Text = "قم بجلب قائمة لعمل لعضوياتها منشن";
            // 
            // get
            // 
            this.get.Interval = 1000;
            this.get.Tick += new System.EventHandler(this.get_Tick);
            // 
            // getmore
            // 
            this.getmore.Interval = 1000;
            this.getmore.Tick += new System.EventHandler(this.getmore_Tick);
            // 
            // stopbtn
            // 
            this.stopbtn.BackColor = System.Drawing.Color.Transparent;
            this.stopbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopbtn.Enabled = false;
            this.stopbtn.Image = global::Retweet_Done.Properties.Resources.Cancel_104px;
            this.stopbtn.ImageActive = null;
            this.stopbtn.Location = new System.Drawing.Point(355, 268);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(59, 48);
            this.stopbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stopbtn.TabIndex = 143;
            this.stopbtn.TabStop = false;
            this.stopbtn.Zoom = 10;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // cp1
            // 
            this.cp1.animated = false;
            this.cp1.animationIterval = 5;
            this.cp1.animationSpeed = 300;
            this.cp1.BackColor = System.Drawing.Color.Transparent;
            this.cp1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cp1.BackgroundImage")));
            this.cp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cp1.ForeColor = System.Drawing.Color.White;
            this.cp1.LabelVisible = true;
            this.cp1.LineProgressThickness = 5;
            this.cp1.LineThickness = 3;
            this.cp1.Location = new System.Drawing.Point(465, 126);
            this.cp1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cp1.MaxValue = 100;
            this.cp1.Name = "cp1";
            this.cp1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cp1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.cp1.Size = new System.Drawing.Size(78, 78);
            this.cp1.TabIndex = 128;
            this.cp1.Value = 0;
            // 
            // cp2
            // 
            this.cp2.animated = false;
            this.cp2.animationIterval = 5;
            this.cp2.animationSpeed = 300;
            this.cp2.BackColor = System.Drawing.Color.Transparent;
            this.cp2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cp2.BackgroundImage")));
            this.cp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cp2.ForeColor = System.Drawing.Color.White;
            this.cp2.LabelVisible = true;
            this.cp2.LineProgressThickness = 8;
            this.cp2.LineThickness = 5;
            this.cp2.Location = new System.Drawing.Point(346, 104);
            this.cp2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cp2.MaxValue = 100;
            this.cp2.Name = "cp2";
            this.cp2.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cp2.ProgressColor = System.Drawing.Color.SeaGreen;
            this.cp2.Size = new System.Drawing.Size(100, 100);
            this.cp2.TabIndex = 127;
            this.cp2.Value = 0;
            // 
            // getlistbtn
            // 
            this.getlistbtn.BackColor = System.Drawing.Color.Transparent;
            this.getlistbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getlistbtn.Image = ((System.Drawing.Image)(resources.GetObject("getlistbtn.Image")));
            this.getlistbtn.ImageActive = null;
            this.getlistbtn.Location = new System.Drawing.Point(419, 223);
            this.getlistbtn.Name = "getlistbtn";
            this.getlistbtn.Size = new System.Drawing.Size(96, 93);
            this.getlistbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.getlistbtn.TabIndex = 121;
            this.getlistbtn.TabStop = false;
            this.getlistbtn.Zoom = 10;
            this.getlistbtn.Click += new System.EventHandler(this.getlistbtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(873, 28);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 120;
            this.pictureBox4.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = global::Retweet_Done.Properties.Resources.Delete_32px1;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(4, 4);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(35, 36);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 145;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // getlistbtnb
            // 
            this.getlistbtnb.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.getlistbtnb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.getlistbtnb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.getlistbtnb.BorderRadius = 0;
            this.getlistbtnb.ButtonText = "جلب قائمة";
            this.getlistbtnb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getlistbtnb.DisabledColor = System.Drawing.Color.Gray;
            this.getlistbtnb.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getlistbtnb.Iconcolor = System.Drawing.Color.Transparent;
            this.getlistbtnb.Iconimage = null;
            this.getlistbtnb.Iconimage_right = null;
            this.getlistbtnb.Iconimage_right_Selected = null;
            this.getlistbtnb.Iconimage_Selected = null;
            this.getlistbtnb.IconMarginLeft = 0;
            this.getlistbtnb.IconMarginRight = 0;
            this.getlistbtnb.IconRightVisible = true;
            this.getlistbtnb.IconRightZoom = 55D;
            this.getlistbtnb.IconVisible = true;
            this.getlistbtnb.IconZoom = 50D;
            this.getlistbtnb.IsTab = true;
            this.getlistbtnb.Location = new System.Drawing.Point(224, 191);
            this.getlistbtnb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getlistbtnb.Name = "getlistbtnb";
            this.getlistbtnb.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.getlistbtnb.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.getlistbtnb.OnHoverTextColor = System.Drawing.Color.White;
            this.getlistbtnb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.getlistbtnb.selected = true;
            this.getlistbtnb.Size = new System.Drawing.Size(89, 27);
            this.getlistbtnb.TabIndex = 146;
            this.getlistbtnb.Text = "جلب قائمة";
            this.getlistbtnb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.getlistbtnb.Textcolor = System.Drawing.Color.Silver;
            this.getlistbtnb.TextFont = new System.Drawing.Font("GE SS Two Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.getlistbtnb.Click += new System.EventHandler(this.getlistbtnb_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(209)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "حفظ txt";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 55D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(224, 298);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(89, 27);
            this.bunifuFlatButton1.TabIndex = 147;
            this.bunifuFlatButton1.Text = "حفظ txt";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("GE SS Two Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // GetUsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.getlistbtnb);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numb);
            this.Controls.Add(this.weblist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.uerslist);
            this.Controls.Add(this.log);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cp1);
            this.Controls.Add(this.cp2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.listname);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.getlistbtn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "GetUsersControl";
            this.Size = new System.Drawing.Size(965, 362);
            this.Load += new System.EventHandler(this.GetUsersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stopbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getlistbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton stopbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numb;
        private System.Windows.Forms.WebBrowser weblist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.ListBox uerslist;
        private System.Windows.Forms.Label log;
        private Bunifu.Framework.UI.BunifuMetroTextbox url;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cp1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cp2;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuMetroTextbox listname;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuImageButton getlistbtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer get;
        private System.Windows.Forms.Timer getmore;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuFlatButton getlistbtnb;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}
