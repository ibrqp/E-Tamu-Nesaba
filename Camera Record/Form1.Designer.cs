namespace Camera_Record
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox10 = new AForge.Controls.PictureBox();
            this.pictureBox9 = new AForge.Controls.PictureBox();
            this.pictureBox8 = new AForge.Controls.PictureBox();
            this.pictureBox7 = new AForge.Controls.PictureBox();
            this.pictureBox6 = new AForge.Controls.PictureBox();
            this.pictureBox5 = new AForge.Controls.PictureBox();
            this.pictureBox4 = new AForge.Controls.PictureBox();
            this.pictureBox3 = new AForge.Controls.PictureBox();
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.radioButton9 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.radioButton8 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.radioButton7 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.radioButton6 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.radioButton5 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.radioButton4 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.radioButton3 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.radioButton2 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.radioButton1 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.textBox_Alamat = new System.Windows.Forms.TextBox();
            this.textBox_Nama = new System.Windows.Forms.TextBox();
            this.textBox_NoHp = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.textBox_AsalSekolah = new System.Windows.Forms.TextBox();
            this.labelAsalSekolah = new System.Windows.Forms.Label();
            this.labelNoHp = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(808, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(395, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.videoSourcePlayer1.Location = new System.Drawing.Point(809, 171);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(393, 385);
            this.videoSourcePlayer1.TabIndex = 5;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1209, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Webcam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(591, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Voting Stand Pameran Jurusan Terbaik";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 636);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(391, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 112);
            this.panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox_Alamat);
            this.groupBox1.Controls.Add(this.textBox_Nama);
            this.groupBox1.Controls.Add(this.textBox_NoHp);
            this.groupBox1.Controls.Add(this.labelNama);
            this.groupBox1.Controls.Add(this.textBox_AsalSekolah);
            this.groupBox1.Controls.Add(this.labelAsalSekolah);
            this.groupBox1.Controls.Add(this.labelNoHp);
            this.groupBox1.Controls.Add(this.labelAlamat);
            this.groupBox1.Location = new System.Drawing.Point(63, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(713, 583);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "o";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuLabel9);
            this.groupBox2.Controls.Add(this.bunifuLabel8);
            this.groupBox2.Controls.Add(this.bunifuLabel7);
            this.groupBox2.Controls.Add(this.bunifuLabel6);
            this.groupBox2.Controls.Add(this.bunifuLabel5);
            this.groupBox2.Controls.Add(this.bunifuLabel4);
            this.groupBox2.Controls.Add(this.bunifuLabel3);
            this.groupBox2.Controls.Add(this.bunifuLabel2);
            this.groupBox2.Controls.Add(this.bunifuLabel1);
            this.groupBox2.Controls.Add(this.pictureBox10);
            this.groupBox2.Controls.Add(this.pictureBox9);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 292);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(685, 279);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilih Jurusan Terbaik";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AllowParentOverrides = false;
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel9.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel9.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuLabel9.Location = new System.Drawing.Point(569, 259);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(59, 15);
            this.bunifuLabel9.TabIndex = 58;
            this.bunifuLabel9.Text = "BRODCAST";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel9.Visible = false;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel8.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel8.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuLabel8.Location = new System.Drawing.Point(467, 256);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(81, 15);
            this.bunifuLabel8.TabIndex = 57;
            this.bunifuLabel8.Text = "MEKATRONIKA";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel8.Visible = false;
            this.bunifuLabel8.Click += new System.EventHandler(this.bunifuLabel8_Click);
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel7.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel7.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuLabel7.Location = new System.Drawing.Point(335, 256);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(15, 15);
            this.bunifuLabel7.TabIndex = 56;
            this.bunifuLabel7.Text = "TEI";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel7.Visible = false;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel6.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuLabel6.Location = new System.Drawing.Point(207, 259);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(21, 15);
            this.bunifuLabel6.TabIndex = 55;
            this.bunifuLabel6.Text = "TITL";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel6.Visible = false;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel5.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuLabel5.Location = new System.Drawing.Point(80, 259);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(73, 15);
            this.bunifuLabel5.TabIndex = 54;
            this.bunifuLabel5.Text = "OTOTRONIKA";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel5.Visible = false;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuLabel4.Location = new System.Drawing.Point(581, 127);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(23, 15);
            this.bunifuLabel4.TabIndex = 53;
            this.bunifuLabel4.Text = "TJKT";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel4.Visible = false;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuLabel3.Location = new System.Drawing.Point(395, 127);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(46, 15);
            this.bunifuLabel3.TabIndex = 52;
            this.bunifuLabel3.Text = "BUSANA";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel3.Visible = false;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuLabel2.Location = new System.Drawing.Point(220, 127);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(22, 15);
            this.bunifuLabel2.TabIndex = 51;
            this.bunifuLabel2.Text = "DKV";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel2.Visible = false;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuLabel1.Location = new System.Drawing.Point(152, 127);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(28, 15);
            this.bunifuLabel1.TabIndex = 50;
            this.bunifuLabel1.Text = "PPLG";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Visible = false;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::Camera_Record.Properties.Resources.brodcast_removebg_preview;
            this.pictureBox10.Location = new System.Drawing.Point(565, 159);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(63, 95);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 49;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::Camera_Record.Properties.Resources.titl_removebg_preview;
            this.pictureBox9.Location = new System.Drawing.Point(183, 154);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(65, 95);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 48;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Camera_Record.Properties.Resources.busana_removebg_preview;
            this.pictureBox8.Location = new System.Drawing.Point(378, 43);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(63, 83);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 44;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Camera_Record.Properties.Resources.meka_removebg_preview;
            this.pictureBox7.Location = new System.Drawing.Point(441, 159);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(63, 83);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 47;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Camera_Record.Properties.Resources.oto_removebg_preview;
            this.pictureBox6.Location = new System.Drawing.Point(62, 152);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(63, 102);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 46;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Camera_Record.Properties.Resources.dkv_removebg_preview;
            this.pictureBox5.Location = new System.Drawing.Point(248, 43);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(63, 83);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Camera_Record.Properties.Resources.elctro_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(310, 159);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 83);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Camera_Record.Properties.Resources.tjkt_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(512, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Camera_Record.Properties.Resources.pplg_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(130, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton9
            // 
            this.radioButton9.AllowBindingControlLocation = false;
            this.radioButton9.BackColor = System.Drawing.Color.Transparent;
            this.radioButton9.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButton9.BorderThickness = 1;
            this.radioButton9.Checked = false;
            this.radioButton9.Location = new System.Drawing.Point(518, 175);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButton9.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton9.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButton9.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButton9.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton9.Size = new System.Drawing.Size(42, 42);
            this.radioButton9.TabIndex = 41;
            this.radioButton9.Text = null;
            // 
            // radioButton8
            // 
            this.radioButton8.AllowBindingControlLocation = false;
            this.radioButton8.BackColor = System.Drawing.Color.Transparent;
            this.radioButton8.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButton8.BorderThickness = 1;
            this.radioButton8.Checked = false;
            this.radioButton8.Location = new System.Drawing.Point(136, 180);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButton8.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton8.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButton8.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButton8.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton8.Size = new System.Drawing.Size(42, 42);
            this.radioButton8.TabIndex = 40;
            this.radioButton8.Text = null;
            // 
            // radioButton7
            // 
            this.radioButton7.AllowBindingControlLocation = false;
            this.radioButton7.BackColor = System.Drawing.Color.Transparent;
            this.radioButton7.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButton7.BorderThickness = 1;
            this.radioButton7.Checked = false;
            this.radioButton7.Location = new System.Drawing.Point(321, 61);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButton7.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton7.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButton7.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButton7.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton7.Size = new System.Drawing.Size(42, 42);
            this.radioButton7.TabIndex = 39;
            this.radioButton7.Text = null;
            // 
            // radioButton6
            // 
            this.radioButton6.AllowBindingControlLocation = false;
            this.radioButton6.BackColor = System.Drawing.Color.Transparent;
            this.radioButton6.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButton6.BorderThickness = 1;
            this.radioButton6.Checked = false;
            this.radioButton6.Location = new System.Drawing.Point(381, 180);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButton6.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton6.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButton6.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButton6.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton6.Size = new System.Drawing.Size(42, 42);
            this.radioButton6.TabIndex = 38;
            this.radioButton6.Text = null;
            // 
            // radioButton5
            // 
            this.radioButton5.AllowBindingControlLocation = false;
            this.radioButton5.BackColor = System.Drawing.Color.Transparent;
            this.radioButton5.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButton5.BorderThickness = 1;
            this.radioButton5.Checked = false;
            this.radioButton5.Location = new System.Drawing.Point(13, 177);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButton5.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton5.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButton5.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButton5.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton5.Size = new System.Drawing.Size(42, 42);
            this.radioButton5.TabIndex = 37;
            this.radioButton5.Text = null;
            // 
            // radioButton4
            // 
            this.radioButton4.AllowBindingControlLocation = false;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButton4.BorderThickness = 1;
            this.radioButton4.Checked = false;
            this.radioButton4.Location = new System.Drawing.Point(197, 61);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButton4.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton4.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButton4.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButton4.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton4.Size = new System.Drawing.Size(42, 42);
            this.radioButton4.TabIndex = 36;
            this.radioButton4.Text = null;
            // 
            // radioButton3
            // 
            this.radioButton3.AllowBindingControlLocation = false;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButton3.BorderThickness = 1;
            this.radioButton3.Checked = false;
            this.radioButton3.Location = new System.Drawing.Point(253, 177);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButton3.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton3.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButton3.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButton3.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton3.Size = new System.Drawing.Size(42, 42);
            this.radioButton3.TabIndex = 35;
            this.radioButton3.Text = null;
            // 
            // radioButton2
            // 
            this.radioButton2.AllowBindingControlLocation = false;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButton2.BorderThickness = 1;
            this.radioButton2.Checked = false;
            this.radioButton2.Location = new System.Drawing.Point(452, 61);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButton2.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton2.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButton2.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButton2.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton2.Size = new System.Drawing.Size(42, 42);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.Text = null;
            // 
            // radioButton1
            // 
            this.radioButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.radioButton1.AllowBindingControlLocation = false;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.BackgroundImage = global::Camera_Record.Properties.Resources.pplg_removebg_preview;
            this.radioButton1.BindingControl = this.radioButton1;
            this.radioButton1.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButton1.BorderThickness = 1;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton1.Location = new System.Drawing.Point(83, 61);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButton1.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton1.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButton1.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButton1.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButton1.Size = new System.Drawing.Size(42, 42);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.Text = null;
            this.radioButton1.CheckedChanged2 += new System.EventHandler<Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs>(this.radioButton1_CheckedChanged2_1);
            // 
            // textBox_Alamat
            // 
            this.textBox_Alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Alamat.Location = new System.Drawing.Point(172, 199);
            this.textBox_Alamat.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Alamat.Name = "textBox_Alamat";
            this.textBox_Alamat.Size = new System.Drawing.Size(500, 38);
            this.textBox_Alamat.TabIndex = 36;
            // 
            // textBox_Nama
            // 
            this.textBox_Nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nama.Location = new System.Drawing.Point(172, 33);
            this.textBox_Nama.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Nama.Name = "textBox_Nama";
            this.textBox_Nama.Size = new System.Drawing.Size(500, 38);
            this.textBox_Nama.TabIndex = 33;
            // 
            // textBox_NoHp
            // 
            this.textBox_NoHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NoHp.Location = new System.Drawing.Point(172, 145);
            this.textBox_NoHp.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NoHp.Name = "textBox_NoHp";
            this.textBox_NoHp.Size = new System.Drawing.Size(500, 38);
            this.textBox_NoHp.TabIndex = 35;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(29, 40);
            this.labelNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(70, 24);
            this.labelNama.TabIndex = 29;
            this.labelNama.Text = "Nama :";
            // 
            // textBox_AsalSekolah
            // 
            this.textBox_AsalSekolah.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AsalSekolah.Location = new System.Drawing.Point(172, 88);
            this.textBox_AsalSekolah.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_AsalSekolah.Name = "textBox_AsalSekolah";
            this.textBox_AsalSekolah.Size = new System.Drawing.Size(500, 38);
            this.textBox_AsalSekolah.TabIndex = 34;
            // 
            // labelAsalSekolah
            // 
            this.labelAsalSekolah.AutoSize = true;
            this.labelAsalSekolah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsalSekolah.Location = new System.Drawing.Point(29, 97);
            this.labelAsalSekolah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAsalSekolah.Name = "labelAsalSekolah";
            this.labelAsalSekolah.Size = new System.Drawing.Size(129, 24);
            this.labelAsalSekolah.TabIndex = 30;
            this.labelAsalSekolah.Text = "Asal Sekolah :";
            // 
            // labelNoHp
            // 
            this.labelNoHp.AutoSize = true;
            this.labelNoHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoHp.Location = new System.Drawing.Point(30, 154);
            this.labelNoHp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoHp.Name = "labelNoHp";
            this.labelNoHp.Size = new System.Drawing.Size(75, 24);
            this.labelNoHp.TabIndex = 31;
            this.labelNoHp.Text = "No Hp :";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlamat.Location = new System.Drawing.Point(30, 209);
            this.labelAlamat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(77, 24);
            this.labelAlamat.TabIndex = 32;
            this.labelAlamat.Text = "Alamat :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(809, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(394, 386);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(812, 582);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(391, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "VOTING";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.UI.WinForms.BunifuRadioButton radioButton9;
        private Bunifu.UI.WinForms.BunifuRadioButton radioButton8;
        private Bunifu.UI.WinForms.BunifuRadioButton radioButton7;
        private Bunifu.UI.WinForms.BunifuRadioButton radioButton6;
        private Bunifu.UI.WinForms.BunifuRadioButton radioButton5;
        private Bunifu.UI.WinForms.BunifuRadioButton radioButton4;
        private Bunifu.UI.WinForms.BunifuRadioButton radioButton3;
        private Bunifu.UI.WinForms.BunifuRadioButton radioButton2;
        private Bunifu.UI.WinForms.BunifuRadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox_Alamat;
        private System.Windows.Forms.TextBox textBox_NoHp;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.TextBox textBox_AsalSekolah;
        private System.Windows.Forms.Label labelAsalSekolah;
        private System.Windows.Forms.TextBox textBox_Nama;
        private System.Windows.Forms.Label labelNoHp;
        private System.Windows.Forms.Label labelAlamat;
        private AForge.Controls.PictureBox pictureBox10;
        private AForge.Controls.PictureBox pictureBox9;
        private AForge.Controls.PictureBox pictureBox8;
        private AForge.Controls.PictureBox pictureBox7;
        private AForge.Controls.PictureBox pictureBox6;
        private AForge.Controls.PictureBox pictureBox5;
        private AForge.Controls.PictureBox pictureBox4;
        private AForge.Controls.PictureBox pictureBox3;
        private AForge.Controls.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private System.Windows.Forms.Button button2;
    }
}

