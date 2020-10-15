namespace HotelMg
{
    partial class searchguest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchguest));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nameonlyname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dateandname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datedate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.nameonlyerr = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dateandnameerr = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.searcherr = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelss = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(82, 42);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(128, 15);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Enter Guest\'s Name";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(23, 13);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(153, 15);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Search by Guest\'s Name";
            // 
            // nameonlyname
            // 
            this.nameonlyname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameonlyname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameonlyname.ForeColor = System.Drawing.Color.Gainsboro;
            this.nameonlyname.HintForeColor = System.Drawing.SystemColors.ControlLight;
            this.nameonlyname.HintText = "Name";
            this.nameonlyname.isPassword = false;
            this.nameonlyname.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.nameonlyname.LineIdleColor = System.Drawing.Color.Gray;
            this.nameonlyname.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.nameonlyname.LineThickness = 3;
            this.nameonlyname.Location = new System.Drawing.Point(217, 27);
            this.nameonlyname.Margin = new System.Windows.Forms.Padding(4);
            this.nameonlyname.Name = "nameonlyname";
            this.nameonlyname.Size = new System.Drawing.Size(246, 42);
            this.nameonlyname.TabIndex = 11;
            this.nameonlyname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameonlyname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check1);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Search";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(496, 42);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(114, 38);
            this.bunifuFlatButton1.TabIndex = 12;
            this.bunifuFlatButton1.Text = "Search";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Search";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(815, 155);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(114, 38);
            this.bunifuFlatButton2.TabIndex = 16;
            this.bunifuFlatButton2.Text = "Search";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // dateandname
            // 
            this.dateandname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateandname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dateandname.ForeColor = System.Drawing.Color.Gainsboro;
            this.dateandname.HintForeColor = System.Drawing.SystemColors.ControlLight;
            this.dateandname.HintText = "Name";
            this.dateandname.isPassword = false;
            this.dateandname.LineFocusedColor = System.Drawing.Color.SlateGray;
            this.dateandname.LineIdleColor = System.Drawing.Color.Gray;
            this.dateandname.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.dateandname.LineThickness = 3;
            this.dateandname.Location = new System.Drawing.Point(217, 151);
            this.dateandname.Margin = new System.Windows.Forms.Padding(4);
            this.dateandname.Name = "dateandname";
            this.dateandname.Size = new System.Drawing.Size(246, 42);
            this.dateandname.TabIndex = 15;
            this.dateandname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dateandname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check1);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(23, 137);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(266, 15);
            this.bunifuCustomLabel3.TabIndex = 14;
            this.bunifuCustomLabel3.Text = "Search by Guest\'s Name and Booking Date";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(82, 166);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(128, 15);
            this.bunifuCustomLabel4.TabIndex = 13;
            this.bunifuCustomLabel4.Text = "Enter Guest\'s Name";
            // 
            // datedate
            // 
            this.datedate.BackColor = System.Drawing.Color.Transparent;
            this.datedate.BorderRadius = 0;
            this.datedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datedate.ForeColor = System.Drawing.Color.Red;
            this.datedate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datedate.FormatCustom = null;
            this.datedate.Location = new System.Drawing.Point(496, 142);
            this.datedate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datedate.Name = "datedate";
            this.datedate.Size = new System.Drawing.Size(233, 51);
            this.datedate.TabIndex = 17;
            this.datedate.Value = new System.DateTime(2019, 2, 26, 23, 52, 8, 471);
            // 
            // nameonlyerr
            // 
            this.nameonlyerr.AutoSize = true;
            this.nameonlyerr.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameonlyerr.ForeColor = System.Drawing.Color.Red;
            this.nameonlyerr.Location = new System.Drawing.Point(214, 94);
            this.nameonlyerr.Name = "nameonlyerr";
            this.nameonlyerr.Size = new System.Drawing.Size(0, 15);
            this.nameonlyerr.TabIndex = 18;
            // 
            // dateandnameerr
            // 
            this.dateandnameerr.AutoSize = true;
            this.dateandnameerr.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateandnameerr.ForeColor = System.Drawing.Color.Red;
            this.dateandnameerr.Location = new System.Drawing.Point(214, 232);
            this.dateandnameerr.Name = "dateandnameerr";
            this.dateandnameerr.Size = new System.Drawing.Size(0, 15);
            this.dateandnameerr.TabIndex = 19;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(26, 344);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(938, 228);
            this.listBox1.TabIndex = 20;
            // 
            // searcherr
            // 
            this.searcherr.AutoSize = true;
            this.searcherr.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searcherr.ForeColor = System.Drawing.Color.Red;
            this.searcherr.Location = new System.Drawing.Point(214, 266);
            this.searcherr.Name = "searcherr";
            this.searcherr.Size = new System.Drawing.Size(0, 15);
            this.searcherr.TabIndex = 21;
            // 
            // labelss
            // 
            this.labelss.AutoSize = true;
            this.labelss.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelss.ForeColor = System.Drawing.Color.OldLace;
            this.labelss.Location = new System.Drawing.Point(23, 308);
            this.labelss.Name = "labelss";
            this.labelss.Size = new System.Drawing.Size(43, 15);
            this.labelss.TabIndex = 22;
            this.labelss.Text = "Name";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.OldLace;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(168, 308);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(98, 15);
            this.bunifuCustomLabel5.TabIndex = 23;
            this.bunifuCustomLabel5.Text = "Phone number";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.OldLace;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(325, 308);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(57, 15);
            this.bunifuCustomLabel6.TabIndex = 24;
            this.bunifuCustomLabel6.Text = "Address";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.OldLace;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(440, 308);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(36, 15);
            this.bunifuCustomLabel7.TabIndex = 25;
            this.bunifuCustomLabel7.Text = "Date";
            // 
            // searchguest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.labelss);
            this.Controls.Add(this.searcherr);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateandnameerr);
            this.Controls.Add(this.nameonlyerr);
            this.Controls.Add(this.datedate);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.dateandname);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.nameonlyname);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "searchguest";
            this.Size = new System.Drawing.Size(988, 575);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameonlyname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox dateandname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuDatepicker datedate;
        private Bunifu.Framework.UI.BunifuCustomLabel nameonlyerr;
        private Bunifu.Framework.UI.BunifuCustomLabel dateandnameerr;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel searcherr;
        private Bunifu.Framework.UI.BunifuCustomLabel labelss;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
    }
}
