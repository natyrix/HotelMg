namespace HotelMg
{
    partial class users
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.regusererr = new System.Windows.Forms.Label();
            this.adduser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.regusertitle = new System.Windows.Forms.ComboBox();
            this.regusername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.reguserlname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.reguserfrstname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.reguserpno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.reguserpass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.reguserconpass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // regusererr
            // 
            this.regusererr.AutoSize = true;
            this.regusererr.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regusererr.ForeColor = System.Drawing.Color.DarkSalmon;
            this.regusererr.Location = new System.Drawing.Point(67, 588);
            this.regusererr.Name = "regusererr";
            this.regusererr.Size = new System.Drawing.Size(0, 18);
            this.regusererr.TabIndex = 14;
            // 
            // adduser
            // 
            this.adduser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.adduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.adduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adduser.BorderRadius = 0;
            this.adduser.ButtonText = "Add";
            this.adduser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adduser.DisabledColor = System.Drawing.Color.Gray;
            this.adduser.Iconcolor = System.Drawing.Color.Transparent;
            this.adduser.Iconimage = null;
            this.adduser.Iconimage_right = null;
            this.adduser.Iconimage_right_Selected = null;
            this.adduser.Iconimage_Selected = null;
            this.adduser.IconMarginLeft = 0;
            this.adduser.IconMarginRight = 0;
            this.adduser.IconRightVisible = true;
            this.adduser.IconRightZoom = 0D;
            this.adduser.IconVisible = true;
            this.adduser.IconZoom = 90D;
            this.adduser.IsTab = false;
            this.adduser.Location = new System.Drawing.Point(119, 662);
            this.adduser.Name = "adduser";
            this.adduser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.adduser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.adduser.OnHoverTextColor = System.Drawing.Color.White;
            this.adduser.selected = false;
            this.adduser.Size = new System.Drawing.Size(105, 34);
            this.adduser.TabIndex = 13;
            this.adduser.Text = "Add";
            this.adduser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adduser.Textcolor = System.Drawing.Color.White;
            this.adduser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduser.Click += new System.EventHandler(this.adduser_Click);
            // 
            // regusertitle
            // 
            this.regusertitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regusertitle.FormattingEnabled = true;
            this.regusertitle.Items.AddRange(new object[] {
            "Security",
            "Waiter",
            "Frontoffice",
            "Chef"});
            this.regusertitle.Location = new System.Drawing.Point(119, 519);
            this.regusertitle.Name = "regusertitle";
            this.regusertitle.Size = new System.Drawing.Size(160, 25);
            this.regusertitle.TabIndex = 12;
            // 
            // regusername
            // 
            this.regusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regusername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regusername.ForeColor = System.Drawing.Color.Black;
            this.regusername.HintForeColor = System.Drawing.Color.Empty;
            this.regusername.HintText = "Username";
            this.regusername.isPassword = false;
            this.regusername.LineFocusedColor = System.Drawing.Color.Gray;
            this.regusername.LineIdleColor = System.Drawing.Color.Gray;
            this.regusername.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.regusername.LineThickness = 3;
            this.regusername.Location = new System.Drawing.Point(119, 58);
            this.regusername.Margin = new System.Windows.Forms.Padding(4);
            this.regusername.Name = "regusername";
            this.regusername.Size = new System.Drawing.Size(206, 41);
            this.regusername.TabIndex = 11;
            this.regusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.regusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check1);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(67, 526);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(41, 18);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "Title";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(30, 81);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(78, 18);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "Username";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(149)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(141, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(88, 19);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Add Users";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reguserconpass);
            this.panel1.Controls.Add(this.reguserpass);
            this.panel1.Controls.Add(this.bunifuCustomLabel8);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.reguserpno);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.reguserfrstname);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.reguserlname);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.regusererr);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.adduser);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.regusertitle);
            this.panel1.Controls.Add(this.regusername);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 737);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(25, 201);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(83, 18);
            this.bunifuCustomLabel4.TabIndex = 15;
            this.bunifuCustomLabel4.Text = "Last Name";
            // 
            // reguserlname
            // 
            this.reguserlname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reguserlname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reguserlname.ForeColor = System.Drawing.Color.Black;
            this.reguserlname.HintForeColor = System.Drawing.Color.Empty;
            this.reguserlname.HintText = "Last Name";
            this.reguserlname.isPassword = false;
            this.reguserlname.LineFocusedColor = System.Drawing.Color.Gray;
            this.reguserlname.LineIdleColor = System.Drawing.Color.Gray;
            this.reguserlname.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.reguserlname.LineThickness = 3;
            this.reguserlname.Location = new System.Drawing.Point(119, 187);
            this.reguserlname.Margin = new System.Windows.Forms.Padding(4);
            this.reguserlname.Name = "reguserlname";
            this.reguserlname.Size = new System.Drawing.Size(206, 41);
            this.reguserlname.TabIndex = 16;
            this.reguserlname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(22, 133);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(86, 18);
            this.bunifuCustomLabel5.TabIndex = 17;
            this.bunifuCustomLabel5.Text = "First Name";
            // 
            // reguserfrstname
            // 
            this.reguserfrstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reguserfrstname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reguserfrstname.ForeColor = System.Drawing.Color.Black;
            this.reguserfrstname.HintForeColor = System.Drawing.Color.Empty;
            this.reguserfrstname.HintText = "First Name";
            this.reguserfrstname.isPassword = false;
            this.reguserfrstname.LineFocusedColor = System.Drawing.Color.Gray;
            this.reguserfrstname.LineIdleColor = System.Drawing.Color.Gray;
            this.reguserfrstname.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.reguserfrstname.LineThickness = 3;
            this.reguserfrstname.Location = new System.Drawing.Point(119, 124);
            this.reguserfrstname.Margin = new System.Windows.Forms.Padding(4);
            this.reguserfrstname.Name = "reguserfrstname";
            this.reguserfrstname.Size = new System.Drawing.Size(206, 41);
            this.reguserfrstname.TabIndex = 18;
            this.reguserfrstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(1, 273);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(107, 18);
            this.bunifuCustomLabel6.TabIndex = 19;
            this.bunifuCustomLabel6.Text = "Phone number";
            // 
            // reguserpno
            // 
            this.reguserpno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reguserpno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reguserpno.ForeColor = System.Drawing.Color.Black;
            this.reguserpno.HintForeColor = System.Drawing.Color.Empty;
            this.reguserpno.HintText = "Phone number";
            this.reguserpno.isPassword = false;
            this.reguserpno.LineFocusedColor = System.Drawing.Color.Gray;
            this.reguserpno.LineIdleColor = System.Drawing.Color.Gray;
            this.reguserpno.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.reguserpno.LineThickness = 3;
            this.reguserpno.Location = new System.Drawing.Point(119, 260);
            this.reguserpno.Margin = new System.Windows.Forms.Padding(4);
            this.reguserpno.Name = "reguserpno";
            this.reguserpno.Size = new System.Drawing.Size(206, 41);
            this.reguserpno.TabIndex = 20;
            this.reguserpno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reguserpno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(22, 417);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(138, 18);
            this.bunifuCustomLabel7.TabIndex = 21;
            this.bunifuCustomLabel7.Text = "Confirm Password";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(33, 348);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(75, 18);
            this.bunifuCustomLabel8.TabIndex = 22;
            this.bunifuCustomLabel8.Text = "Password";
            // 
            // reguserpass
            // 
            this.reguserpass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.reguserpass.BorderColorIdle = System.Drawing.Color.Black;
            this.reguserpass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.reguserpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reguserpass.BorderThickness = 1;
            this.reguserpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reguserpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reguserpass.ForeColor = System.Drawing.Color.Black;
            this.reguserpass.isPassword = true;
            this.reguserpass.Location = new System.Drawing.Point(119, 333);
            this.reguserpass.Margin = new System.Windows.Forms.Padding(4);
            this.reguserpass.Name = "reguserpass";
            this.reguserpass.Size = new System.Drawing.Size(206, 44);
            this.reguserpass.TabIndex = 23;
            this.reguserpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // reguserconpass
            // 
            this.reguserconpass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.reguserconpass.BorderColorIdle = System.Drawing.Color.Black;
            this.reguserconpass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.reguserconpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reguserconpass.BorderThickness = 1;
            this.reguserconpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reguserconpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reguserconpass.ForeColor = System.Drawing.Color.Black;
            this.reguserconpass.isPassword = true;
            this.reguserconpass.Location = new System.Drawing.Point(119, 456);
            this.reguserconpass.Margin = new System.Windows.Forms.Padding(4);
            this.reguserconpass.Name = "reguserconpass";
            this.reguserconpass.Size = new System.Drawing.Size(206, 44);
            this.reguserconpass.TabIndex = 24;
            this.reguserconpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bunifuCustomLabel9);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(377, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 737);
            this.panel2.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(98, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(523, 464);
            this.listBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listBox1, "Select User To Update or Delete");
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(149)))), ((int)(((byte)(153)))));
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(268, 13);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(52, 19);
            this.bunifuCustomLabel9.TabIndex = 9;
            this.bunifuCustomLabel9.Text = "Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(110, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select a user to update or delete";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Refresh";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(272, 662);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(105, 34);
            this.bunifuFlatButton1.TabIndex = 16;
            this.bunifuFlatButton1.Text = "Refresh";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "users";
            this.Size = new System.Drawing.Size(1118, 743);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label regusererr;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton adduser;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox regusertitle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox regusername;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox reguserfrstname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox reguserlname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox reguserpno;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMetroTextbox reguserpass;
        private Bunifu.Framework.UI.BunifuMetroTextbox reguserconpass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}
