namespace HotelMg
{
    partial class room1
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.regroomno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.regroomtype = new System.Windows.Forms.ComboBox();
            this.AddRoom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.regroomerr = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.delroomno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.delroomerr = new System.Windows.Forms.Label();
            this.deletebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updateroomtype = new System.Windows.Forms.ComboBox();
            this.updateroomno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.updateroomerr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(149)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(113, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(96, 19);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Add Rooms";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.regroomerr);
            this.panel1.Controls.Add(this.AddRoom);
            this.panel1.Controls.Add(this.regroomtype);
            this.panel1.Controls.Add(this.regroomno);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 332);
            this.panel1.TabIndex = 1;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(25, 95);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(111, 18);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Room Number";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(25, 177);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(90, 18);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Room Type";
            // 
            // regroomno
            // 
            this.regroomno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regroomno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.regroomno.ForeColor = System.Drawing.Color.Black;
            this.regroomno.HintForeColor = System.Drawing.Color.Empty;
            this.regroomno.HintText = "Room Number";
            this.regroomno.isPassword = false;
            this.regroomno.LineFocusedColor = System.Drawing.Color.Gray;
            this.regroomno.LineIdleColor = System.Drawing.Color.Gray;
            this.regroomno.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.regroomno.LineThickness = 3;
            this.regroomno.Location = new System.Drawing.Point(143, 82);
            this.regroomno.Margin = new System.Windows.Forms.Padding(4);
            this.regroomno.Name = "regroomno";
            this.regroomno.Size = new System.Drawing.Size(206, 44);
            this.regroomno.TabIndex = 4;
            this.regroomno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.regroomno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check);
            // 
            // regroomtype
            // 
            this.regroomtype.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regroomtype.FormattingEnabled = true;
            this.regroomtype.Items.AddRange(new object[] {
            "Normal",
            "Double Bed",
            "Family Sweet",
            "Honey Moon Sweet"});
            this.regroomtype.Location = new System.Drawing.Point(143, 177);
            this.regroomtype.Name = "regroomtype";
            this.regroomtype.Size = new System.Drawing.Size(160, 25);
            this.regroomtype.TabIndex = 5;
            // 
            // AddRoom
            // 
            this.AddRoom.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.AddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.AddRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddRoom.BorderRadius = 0;
            this.AddRoom.ButtonText = "Add";
            this.AddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRoom.DisabledColor = System.Drawing.Color.Gray;
            this.AddRoom.Iconcolor = System.Drawing.Color.Transparent;
            this.AddRoom.Iconimage = null;
            this.AddRoom.Iconimage_right = null;
            this.AddRoom.Iconimage_right_Selected = null;
            this.AddRoom.Iconimage_Selected = null;
            this.AddRoom.IconMarginLeft = 0;
            this.AddRoom.IconMarginRight = 0;
            this.AddRoom.IconRightVisible = true;
            this.AddRoom.IconRightZoom = 0D;
            this.AddRoom.IconVisible = true;
            this.AddRoom.IconZoom = 90D;
            this.AddRoom.IsTab = false;
            this.AddRoom.Location = new System.Drawing.Point(117, 264);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.AddRoom.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.AddRoom.OnHoverTextColor = System.Drawing.Color.White;
            this.AddRoom.selected = false;
            this.AddRoom.Size = new System.Drawing.Size(105, 34);
            this.AddRoom.TabIndex = 6;
            this.AddRoom.Text = "Add";
            this.AddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddRoom.Textcolor = System.Drawing.Color.White;
            this.AddRoom.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRoom.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // regroomerr
            // 
            this.regroomerr.AutoSize = true;
            this.regroomerr.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regroomerr.ForeColor = System.Drawing.Color.DarkSalmon;
            this.regroomerr.Location = new System.Drawing.Point(140, 139);
            this.regroomerr.Name = "regroomerr";
            this.regroomerr.Size = new System.Drawing.Size(0, 18);
            this.regroomerr.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deletebtn);
            this.panel2.Controls.Add(this.delroomerr);
            this.panel2.Controls.Add(this.delroomno);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Location = new System.Drawing.Point(1, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 388);
            this.panel2.TabIndex = 2;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(149)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(113, 14);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(116, 19);
            this.bunifuCustomLabel4.TabIndex = 1;
            this.bunifuCustomLabel4.Text = "Remove Room";
            // 
            // delroomno
            // 
            this.delroomno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.delroomno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.delroomno.ForeColor = System.Drawing.Color.Black;
            this.delroomno.HintForeColor = System.Drawing.Color.Empty;
            this.delroomno.HintText = "Room Number";
            this.delroomno.isPassword = false;
            this.delroomno.LineFocusedColor = System.Drawing.Color.Gray;
            this.delroomno.LineIdleColor = System.Drawing.Color.Gray;
            this.delroomno.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.delroomno.LineThickness = 3;
            this.delroomno.Location = new System.Drawing.Point(141, 89);
            this.delroomno.Margin = new System.Windows.Forms.Padding(4);
            this.delroomno.Name = "delroomno";
            this.delroomno.Size = new System.Drawing.Size(206, 44);
            this.delroomno.TabIndex = 6;
            this.delroomno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.delroomno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(23, 102);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(111, 18);
            this.bunifuCustomLabel5.TabIndex = 5;
            this.bunifuCustomLabel5.Text = "Room Number";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 322);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(352, 35);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // delroomerr
            // 
            this.delroomerr.AutoSize = true;
            this.delroomerr.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delroomerr.ForeColor = System.Drawing.Color.DarkSalmon;
            this.delroomerr.Location = new System.Drawing.Point(136, 157);
            this.delroomerr.Name = "delroomerr";
            this.delroomerr.Size = new System.Drawing.Size(0, 18);
            this.delroomerr.TabIndex = 8;
            // 
            // deletebtn
            // 
            this.deletebtn.Activecolor = System.Drawing.Color.Maroon;
            this.deletebtn.BackColor = System.Drawing.Color.Maroon;
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebtn.BorderRadius = 0;
            this.deletebtn.ButtonText = "Delete";
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.DisabledColor = System.Drawing.Color.Gray;
            this.deletebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.deletebtn.Iconimage = null;
            this.deletebtn.Iconimage_right = null;
            this.deletebtn.Iconimage_right_Selected = null;
            this.deletebtn.Iconimage_Selected = null;
            this.deletebtn.IconMarginLeft = 0;
            this.deletebtn.IconMarginRight = 0;
            this.deletebtn.IconRightVisible = true;
            this.deletebtn.IconRightZoom = 0D;
            this.deletebtn.IconVisible = true;
            this.deletebtn.IconZoom = 90D;
            this.deletebtn.IsTab = false;
            this.deletebtn.Location = new System.Drawing.Point(117, 187);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Normalcolor = System.Drawing.Color.Maroon;
            this.deletebtn.OnHovercolor = System.Drawing.Color.Maroon;
            this.deletebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deletebtn.selected = false;
            this.deletebtn.Size = new System.Drawing.Size(105, 34);
            this.deletebtn.TabIndex = 9;
            this.deletebtn.Text = "Delete";
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletebtn.Textcolor = System.Drawing.Color.White;
            this.deletebtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.bunifuCustomLabel6);
            this.panel3.Location = new System.Drawing.Point(357, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 740);
            this.panel3.TabIndex = 4;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(149)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(103, 17);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(116, 19);
            this.bunifuCustomLabel6.TabIndex = 1;
            this.bunifuCustomLabel6.Text = "List of Rooms";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.listView1.Font = new System.Drawing.Font("Georgia Ref", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(3, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(412, 513);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.updateroomerr);
            this.panel4.Controls.Add(this.bunifuFlatButton1);
            this.panel4.Controls.Add(this.updateroomtype);
            this.panel4.Controls.Add(this.updateroomno);
            this.panel4.Controls.Add(this.bunifuCustomLabel8);
            this.panel4.Controls.Add(this.bunifuCustomLabel9);
            this.panel4.Controls.Add(this.bunifuCustomLabel7);
            this.panel4.Location = new System.Drawing.Point(781, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 420);
            this.panel4.TabIndex = 5;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(149)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(83, 15);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(113, 19);
            this.bunifuCustomLabel7.TabIndex = 2;
            this.bunifuCustomLabel7.Text = "Update Room";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Update";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(124, 233);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(105, 34);
            this.bunifuFlatButton1.TabIndex = 11;
            this.bunifuFlatButton1.Text = "Update";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // updateroomtype
            // 
            this.updateroomtype.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateroomtype.FormattingEnabled = true;
            this.updateroomtype.Items.AddRange(new object[] {
            "Normal",
            "Double Bed",
            "Family Sweet",
            "Honey Moon Sweet"});
            this.updateroomtype.Location = new System.Drawing.Point(124, 152);
            this.updateroomtype.Name = "updateroomtype";
            this.updateroomtype.Size = new System.Drawing.Size(160, 25);
            this.updateroomtype.TabIndex = 10;
            // 
            // updateroomno
            // 
            this.updateroomno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateroomno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.updateroomno.ForeColor = System.Drawing.Color.Black;
            this.updateroomno.HintForeColor = System.Drawing.Color.Empty;
            this.updateroomno.HintText = "Room Number";
            this.updateroomno.isPassword = false;
            this.updateroomno.LineFocusedColor = System.Drawing.Color.Gray;
            this.updateroomno.LineIdleColor = System.Drawing.Color.Gray;
            this.updateroomno.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.updateroomno.LineThickness = 3;
            this.updateroomno.Location = new System.Drawing.Point(124, 57);
            this.updateroomno.Margin = new System.Windows.Forms.Padding(4);
            this.updateroomno.Name = "updateroomno";
            this.updateroomno.Size = new System.Drawing.Size(206, 44);
            this.updateroomno.TabIndex = 9;
            this.updateroomno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.updateroomno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(6, 152);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(90, 18);
            this.bunifuCustomLabel8.TabIndex = 8;
            this.bunifuCustomLabel8.Text = "Room Type";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(6, 70);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(111, 18);
            this.bunifuCustomLabel9.TabIndex = 7;
            this.bunifuCustomLabel9.Text = "Room Number";
            // 
            // updateroomerr
            // 
            this.updateroomerr.AutoSize = true;
            this.updateroomerr.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateroomerr.ForeColor = System.Drawing.Color.DarkSalmon;
            this.updateroomerr.Location = new System.Drawing.Point(100, 199);
            this.updateroomerr.Name = "updateroomerr";
            this.updateroomerr.Size = new System.Drawing.Size(0, 18);
            this.updateroomerr.TabIndex = 12;
            // 
            // room1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "room1";
            this.Size = new System.Drawing.Size(1118, 743);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox regroomno;
        private System.Windows.Forms.ComboBox regroomtype;
        private Bunifu.Framework.UI.BunifuFlatButton AddRoom;
        private System.Windows.Forms.Label regroomerr;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox delroomno;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label delroomerr;
        private Bunifu.Framework.UI.BunifuFlatButton deletebtn;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.ComboBox updateroomtype;
        private Bunifu.Framework.UI.BunifuMaterialTextbox updateroomno;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.Label updateroomerr;
    }
}
