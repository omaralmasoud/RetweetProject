namespace Retweet_Done
{
    partial class SupportUserControl
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
            this.subscribs = new System.Windows.Forms.Panel();
            this.numberofusers = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.subscribs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // subscribs
            // 
            this.subscribs.BackColor = System.Drawing.Color.DimGray;
            this.subscribs.Controls.Add(this.pictureBox16);
            this.subscribs.Controls.Add(this.label28);
            this.subscribs.Controls.Add(this.label29);
            this.subscribs.Controls.Add(this.numberofusers);
            this.subscribs.Location = new System.Drawing.Point(101, 24);
            this.subscribs.Name = "subscribs";
            this.subscribs.Size = new System.Drawing.Size(843, 352);
            this.subscribs.TabIndex = 3;
            // 
            // numberofusers
            // 
            this.numberofusers.AutoSize = true;
            this.numberofusers.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberofusers.ForeColor = System.Drawing.Color.LightGray;
            this.numberofusers.Location = new System.Drawing.Point(385, 151);
            this.numberofusers.Name = "numberofusers";
            this.numberofusers.Size = new System.Drawing.Size(119, 35);
            this.numberofusers.TabIndex = 0;
            this.numberofusers.Text = "،،، قريبا";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::Retweet_Done.Properties.Resources.Headset_32px;
            this.pictureBox16.Location = new System.Drawing.Point(514, 108);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(36, 34);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 9;
            this.pictureBox16.TabStop = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.LightGray;
            this.label28.Location = new System.Drawing.Point(427, 108);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(81, 16);
            this.label28.TabIndex = 8;
            this.label28.Text = "الدعم الفني";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.LightGray;
            this.label29.Location = new System.Drawing.Point(327, 124);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(181, 13);
            this.label29.TabIndex = 7;
            this.label29.Text = "دائما سوف نبقيك على تواصل معنا";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = global::Retweet_Done.Properties.Resources.Delete_32px1;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(9, 7);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(35, 36);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 70;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // SupportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.subscribs);
            this.Name = "SupportUserControl";
            this.Size = new System.Drawing.Size(965, 400);
            this.subscribs.ResumeLayout(false);
            this.subscribs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel subscribs;
        private System.Windows.Forms.Label numberofusers;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}
