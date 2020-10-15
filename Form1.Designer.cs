namespace HotelMg
{
    partial class login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loggg = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.uname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.errr = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 100;
            this.bunifuElipse1.TargetControl = this;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(225, 68);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(123, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Login Here";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(533, 25);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(59, 43);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 29);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(112, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 29);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // loggg
            // 
            this.loggg.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loggg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loggg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loggg.BorderRadius = 0;
            this.loggg.ButtonText = "LogIn";
            this.loggg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loggg.DisabledColor = System.Drawing.Color.Gray;
            this.loggg.Iconcolor = System.Drawing.Color.Transparent;
            this.loggg.Iconimage = ((System.Drawing.Image)(resources.GetObject("loggg.Iconimage")));
            this.loggg.Iconimage_right = null;
            this.loggg.Iconimage_right_Selected = null;
            this.loggg.Iconimage_Selected = null;
            this.loggg.IconMarginLeft = 0;
            this.loggg.IconMarginRight = 0;
            this.loggg.IconRightVisible = true;
            this.loggg.IconRightZoom = 0D;
            this.loggg.IconVisible = true;
            this.loggg.IconZoom = 90D;
            this.loggg.IsTab = false;
            this.loggg.Location = new System.Drawing.Point(57, 444);
            this.loggg.Name = "loggg";
            this.loggg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loggg.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.loggg.OnHoverTextColor = System.Drawing.Color.White;
            this.loggg.selected = false;
            this.loggg.Size = new System.Drawing.Size(138, 48);
            this.loggg.TabIndex = 6;
            this.loggg.Text = "LogIn";
            this.loggg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loggg.Textcolor = System.Drawing.Color.White;
            this.loggg.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggg.Click += new System.EventHandler(this.loggg_Click);
            // 
            // cancel
            // 
            this.cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cancel.BackColor = System.Drawing.Color.Maroon;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.BorderRadius = 0;
            this.cancel.ButtonText = "Cancel";
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.DisabledColor = System.Drawing.Color.Gray;
            this.cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.cancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("cancel.Iconimage")));
            this.cancel.Iconimage_right = null;
            this.cancel.Iconimage_right_Selected = null;
            this.cancel.Iconimage_Selected = null;
            this.cancel.IconMarginLeft = 0;
            this.cancel.IconMarginRight = 0;
            this.cancel.IconRightVisible = true;
            this.cancel.IconRightZoom = 0D;
            this.cancel.IconVisible = true;
            this.cancel.IconZoom = 90D;
            this.cancel.IsTab = false;
            this.cancel.Location = new System.Drawing.Point(385, 444);
            this.cancel.Name = "cancel";
            this.cancel.Normalcolor = System.Drawing.Color.Maroon;
            this.cancel.OnHovercolor = System.Drawing.Color.Maroon;
            this.cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.cancel.selected = false;
            this.cancel.Size = new System.Drawing.Size(140, 48);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel.Textcolor = System.Drawing.Color.White;
            this.cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // uname
            // 
            this.uname.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.uname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uname.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.uname.BorderThickness = 1;
            this.uname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.uname.isPassword = false;
            this.uname.Location = new System.Drawing.Point(112, 167);
            this.uname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(413, 57);
            this.uname.TabIndex = 8;
            this.uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // pass
            // 
            this.pass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.pass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.pass.BorderThickness = 1;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.pass.isPassword = true;
            this.pass.Location = new System.Drawing.Point(112, 301);
            this.pass.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(413, 57);
            this.pass.TabIndex = 10;
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // errr
            // 
            this.errr.AutoSize = true;
            this.errr.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errr.ForeColor = System.Drawing.Color.Red;
            this.errr.Location = new System.Drawing.Point(81, 405);
            this.errr.Name = "errr";
            this.errr.Size = new System.Drawing.Size(0, 18);
            this.errr.TabIndex = 12;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(604, 531);
            this.Controls.Add(this.errr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.loggg);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel title;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton cancel;
        private Bunifu.Framework.UI.BunifuFlatButton loggg;
        private Bunifu.Framework.UI.BunifuMetroTextbox uname;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox pass;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel errr;
    }
}

