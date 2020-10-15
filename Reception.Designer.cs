namespace HotelMg
{
    partial class Reception
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reception));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.recuname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.todaydate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.booked = new Bunifu.Framework.UI.BunifuFlatButton();
            this.available = new Bunifu.Framework.UI.BunifuFlatButton();
            this.serguest = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchguest1 = new HotelMg.searchguest();
            this.bookedrooms1 = new HotelMg.bookedrooms();
            this.availablerooms1 = new HotelMg.availablerooms();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.DarkGray;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1148, -4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.recuname);
            this.panel2.Controls.Add(this.todaydate);
            this.panel2.Location = new System.Drawing.Point(2, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 71);
            this.panel2.TabIndex = 2;
            // 
            // recuname
            // 
            this.recuname.AutoSize = true;
            this.recuname.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuname.Location = new System.Drawing.Point(665, 23);
            this.recuname.Name = "recuname";
            this.recuname.Size = new System.Drawing.Size(0, 18);
            this.recuname.TabIndex = 26;
            // 
            // todaydate
            // 
            this.todaydate.AutoSize = true;
            this.todaydate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaydate.Location = new System.Drawing.Point(40, 23);
            this.todaydate.Name = "todaydate";
            this.todaydate.Size = new System.Drawing.Size(0, 18);
            this.todaydate.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.serguest);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.booked);
            this.panel1.Controls.Add(this.available);
            this.panel1.Location = new System.Drawing.Point(2, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 581);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(229, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(988, 575);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(109)))));
            this.panel3.Location = new System.Drawing.Point(3, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 56);
            this.panel3.TabIndex = 3;
            // 
            // booked
            // 
            this.booked.Activecolor = System.Drawing.Color.Transparent;
            this.booked.BackColor = System.Drawing.Color.Transparent;
            this.booked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.booked.BorderRadius = 0;
            this.booked.ButtonText = "Booked Rooms";
            this.booked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.booked.DisabledColor = System.Drawing.Color.Gray;
            this.booked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booked.Iconcolor = System.Drawing.Color.Transparent;
            this.booked.Iconimage = ((System.Drawing.Image)(resources.GetObject("booked.Iconimage")));
            this.booked.Iconimage_right = null;
            this.booked.Iconimage_right_Selected = null;
            this.booked.Iconimage_Selected = null;
            this.booked.IconMarginLeft = 0;
            this.booked.IconMarginRight = 0;
            this.booked.IconRightVisible = true;
            this.booked.IconRightZoom = 0D;
            this.booked.IconVisible = true;
            this.booked.IconZoom = 90D;
            this.booked.IsTab = false;
            this.booked.Location = new System.Drawing.Point(15, 75);
            this.booked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.booked.Name = "booked";
            this.booked.Normalcolor = System.Drawing.Color.Transparent;
            this.booked.OnHovercolor = System.Drawing.Color.Gray;
            this.booked.OnHoverTextColor = System.Drawing.Color.Bisque;
            this.booked.selected = false;
            this.booked.Size = new System.Drawing.Size(208, 56);
            this.booked.TabIndex = 4;
            this.booked.Text = "Booked Rooms";
            this.booked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booked.Textcolor = System.Drawing.Color.White;
            this.booked.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booked.Click += new System.EventHandler(this.booked_Click);
            // 
            // available
            // 
            this.available.Activecolor = System.Drawing.Color.Transparent;
            this.available.BackColor = System.Drawing.Color.Transparent;
            this.available.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.available.BorderRadius = 0;
            this.available.ButtonText = "Available Rooms";
            this.available.Cursor = System.Windows.Forms.Cursors.Hand;
            this.available.DisabledColor = System.Drawing.Color.Gray;
            this.available.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available.Iconcolor = System.Drawing.Color.Transparent;
            this.available.Iconimage = ((System.Drawing.Image)(resources.GetObject("available.Iconimage")));
            this.available.Iconimage_right = null;
            this.available.Iconimage_right_Selected = null;
            this.available.Iconimage_Selected = null;
            this.available.IconMarginLeft = 0;
            this.available.IconMarginRight = 0;
            this.available.IconRightVisible = true;
            this.available.IconRightZoom = 0D;
            this.available.IconVisible = true;
            this.available.IconZoom = 90D;
            this.available.IsTab = false;
            this.available.Location = new System.Drawing.Point(15, 9);
            this.available.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.available.Name = "available";
            this.available.Normalcolor = System.Drawing.Color.Transparent;
            this.available.OnHovercolor = System.Drawing.Color.Gray;
            this.available.OnHoverTextColor = System.Drawing.Color.Bisque;
            this.available.selected = false;
            this.available.Size = new System.Drawing.Size(208, 56);
            this.available.TabIndex = 3;
            this.available.Text = "Available Rooms";
            this.available.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.available.Textcolor = System.Drawing.Color.White;
            this.available.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // serguest
            // 
            this.serguest.Activecolor = System.Drawing.Color.Transparent;
            this.serguest.BackColor = System.Drawing.Color.Transparent;
            this.serguest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.serguest.BorderRadius = 0;
            this.serguest.ButtonText = "Search Guest";
            this.serguest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serguest.DisabledColor = System.Drawing.Color.Gray;
            this.serguest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serguest.Iconcolor = System.Drawing.Color.Transparent;
            this.serguest.Iconimage = ((System.Drawing.Image)(resources.GetObject("serguest.Iconimage")));
            this.serguest.Iconimage_right = null;
            this.serguest.Iconimage_right_Selected = null;
            this.serguest.Iconimage_Selected = null;
            this.serguest.IconMarginLeft = 0;
            this.serguest.IconMarginRight = 0;
            this.serguest.IconRightVisible = true;
            this.serguest.IconRightZoom = 0D;
            this.serguest.IconVisible = true;
            this.serguest.IconZoom = 90D;
            this.serguest.IsTab = false;
            this.serguest.Location = new System.Drawing.Point(15, 141);
            this.serguest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serguest.Name = "serguest";
            this.serguest.Normalcolor = System.Drawing.Color.Transparent;
            this.serguest.OnHovercolor = System.Drawing.Color.Gray;
            this.serguest.OnHoverTextColor = System.Drawing.Color.Bisque;
            this.serguest.selected = false;
            this.serguest.Size = new System.Drawing.Size(208, 56);
            this.serguest.TabIndex = 5;
            this.serguest.Text = "Search Guest";
            this.serguest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serguest.Textcolor = System.Drawing.Color.White;
            this.serguest.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serguest.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // searchguest1
            // 
            this.searchguest1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.searchguest1.Location = new System.Drawing.Point(228, 70);
            this.searchguest1.Name = "searchguest1";
            this.searchguest1.Size = new System.Drawing.Size(988, 575);
            this.searchguest1.TabIndex = 5;
            // 
            // bookedrooms1
            // 
            this.bookedrooms1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.bookedrooms1.Location = new System.Drawing.Point(228, 70);
            this.bookedrooms1.Name = "bookedrooms1";
            this.bookedrooms1.Size = new System.Drawing.Size(988, 575);
            this.bookedrooms1.TabIndex = 4;
            // 
            // availablerooms1
            // 
            this.availablerooms1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.availablerooms1.Location = new System.Drawing.Point(228, 70);
            this.availablerooms1.Name = "availablerooms1";
            this.availablerooms1.Size = new System.Drawing.Size(988, 575);
            this.availablerooms1.TabIndex = 3;
            // 
            // Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1217, 651);
            this.Controls.Add(this.searchguest1);
            this.Controls.Add(this.bookedrooms1);
            this.Controls.Add(this.availablerooms1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reception";
            this.Text = "Reception";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton available;
        private Bunifu.Framework.UI.BunifuFlatButton booked;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private availablerooms availablerooms1;
        private bookedrooms bookedrooms1;
        private Bunifu.Framework.UI.BunifuCustomLabel todaydate;
        private Bunifu.Framework.UI.BunifuCustomLabel recuname;
        private Bunifu.Framework.UI.BunifuFlatButton serguest;
        private searchguest searchguest1;
    }
}