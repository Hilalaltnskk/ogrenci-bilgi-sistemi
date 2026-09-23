namespace OgrenciBilgiSistemi.cs
{
    partial class Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_ogretmenayarlar = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_ogrenciler = new System.Windows.Forms.DataGridView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_yenikayit = new System.Windows.Forms.Button();
            this.ogrid = new System.Windows.Forms.Label();
            this.cmb_ogretmenad = new System.Windows.Forms.ComboBox();
            this.txt_brans = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.pctrbx_ogretmenfoto = new System.Windows.Forms.PictureBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_brans = new System.Windows.Forms.Label();
            this.lbl_ogrtad = new System.Windows.Forms.Label();
            this.lbl_ıd = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_ogrenciad = new System.Windows.Forms.ComboBox();
            this.btn_ogrkaydet = new System.Windows.Forms.Button();
            this.txt_ogrsinif = new System.Windows.Forms.TextBox();
            this.pctrbx_ogrenciresim = new System.Windows.Forms.PictureBox();
            this.txt_ogrsifre = new System.Windows.Forms.TextBox();
            this.txt_ogrtc = new System.Windows.Forms.TextBox();
            this.txt_ogrıd = new System.Windows.Forms.TextBox();
            this.lbl_ogrsifre = new System.Windows.Forms.Label();
            this.lbl_ogrtc = new System.Windows.Forms.Label();
            this.lbl_ogrsinif = new System.Windows.Forms.Label();
            this.lbl_ograd = new System.Windows.Forms.Label();
            this.lbl_ogrıd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ogretmenayarlar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ogrenciler)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_ogretmenfoto)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_ogrenciresim)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.ımageList1;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 571);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_ogretmenayarlar);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(926, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğretmenler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_ogretmenayarlar
            // 
            this.dgv_ogretmenayarlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ogretmenayarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ogretmenayarlar.Location = new System.Drawing.Point(0, 0);
            this.dgv_ogretmenayarlar.Name = "dgv_ogretmenayarlar";
            this.dgv_ogretmenayarlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ogretmenayarlar.Size = new System.Drawing.Size(926, 545);
            this.dgv_ogretmenayarlar.TabIndex = 0;
            this.dgv_ogretmenayarlar.SelectionChanged += new System.EventHandler(this.dgv_ogretmenayarlar_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_ogrenciler);
            this.tabPage2.ImageIndex = 9;
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(926, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Öğrenciler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_ogrenciler
            // 
            this.dgv_ogrenciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ogrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ogrenciler.Location = new System.Drawing.Point(0, 0);
            this.dgv_ogrenciler.Name = "dgv_ogrenciler";
            this.dgv_ogrenciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ogrenciler.Size = new System.Drawing.Size(926, 537);
            this.dgv_ogrenciler.TabIndex = 0;
            this.dgv_ogrenciler.SelectionChanged += new System.EventHandler(this.dgv_ogrenciler_SelectionChanged);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "placeholder.png");
            this.ımageList1.Images.SetKeyName(1, "professor.png");
            this.ımageList1.Images.SetKeyName(2, "picture.png");
            this.ımageList1.Images.SetKeyName(3, "save.png");
            this.ımageList1.Images.SetKeyName(4, "delete (1).png");
            this.ımageList1.Images.SetKeyName(5, "exchange.png");
            this.ımageList1.Images.SetKeyName(6, "clear-filter.png");
            this.ımageList1.Images.SetKeyName(7, "parents (1).png");
            this.ımageList1.Images.SetKeyName(8, "graduated.png");
            this.ımageList1.Images.SetKeyName(9, "student.png");
            this.ımageList1.Images.SetKeyName(10, "settings (1).png");
            this.ımageList1.Images.SetKeyName(11, "add.png");
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.ImageList = this.ımageList1;
            this.tabControl2.Location = new System.Drawing.Point(939, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(377, 567);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.ImageIndex = 1;
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(369, 537);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Öğretmenler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.btn_yenikayit);
            this.groupBox1.Controls.Add(this.ogrid);
            this.groupBox1.Controls.Add(this.cmb_ogretmenad);
            this.groupBox1.Controls.Add(this.txt_brans);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.pctrbx_ogretmenfoto);
            this.groupBox1.Controls.Add(this.txt_sifre);
            this.groupBox1.Controls.Add(this.txt_tc);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.lbl_sifre);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.lbl_brans);
            this.groupBox1.Controls.Add(this.lbl_ogrtad);
            this.groupBox1.Controls.Add(this.lbl_ıd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 532);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Kullanıcı Ayarları";
            // 
            // btn_yenikayit
            // 
            this.btn_yenikayit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yenikayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yenikayit.ImageIndex = 11;
            this.btn_yenikayit.ImageList = this.ımageList1;
            this.btn_yenikayit.Location = new System.Drawing.Point(257, 13);
            this.btn_yenikayit.Name = "btn_yenikayit";
            this.btn_yenikayit.Size = new System.Drawing.Size(92, 23);
            this.btn_yenikayit.TabIndex = 33;
            this.btn_yenikayit.Text = "Yeni Kayıt Ekle";
            this.btn_yenikayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_yenikayit.UseVisualStyleBackColor = true;
            this.btn_yenikayit.Click += new System.EventHandler(this.btn_yenikayit_Click);
            // 
            // ogrid
            // 
            this.ogrid.AutoSize = true;
            this.ogrid.Location = new System.Drawing.Point(36, 125);
            this.ogrid.Name = "ogrid";
            this.ogrid.Size = new System.Drawing.Size(41, 17);
            this.ogrid.TabIndex = 26;
            this.ogrid.Text = "ogrid";
            this.ogrid.Visible = false;
            // 
            // cmb_ogretmenad
            // 
            this.cmb_ogretmenad.FormattingEnabled = true;
            this.cmb_ogretmenad.Location = new System.Drawing.Point(145, 181);
            this.cmb_ogretmenad.Name = "cmb_ogretmenad";
            this.cmb_ogretmenad.Size = new System.Drawing.Size(139, 25);
            this.cmb_ogretmenad.TabIndex = 25;
            this.cmb_ogretmenad.SelectedIndexChanged += new System.EventHandler(this.cmb_ogretmenad_SelectedIndexChanged);
            // 
            // txt_brans
            // 
            this.txt_brans.Enabled = false;
            this.txt_brans.Location = new System.Drawing.Point(145, 209);
            this.txt_brans.Name = "txt_brans";
            this.txt_brans.Size = new System.Drawing.Size(139, 24);
            this.txt_brans.TabIndex = 24;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.ImageIndex = 3;
            this.btn_kaydet.ImageList = this.ımageList1;
            this.btn_kaydet.Location = new System.Drawing.Point(162, 329);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(110, 39);
            this.btn_kaydet.TabIndex = 22;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // pctrbx_ogretmenfoto
            // 
            this.pctrbx_ogretmenfoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrbx_ogretmenfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctrbx_ogretmenfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrbx_ogretmenfoto.Location = new System.Drawing.Point(162, 42);
            this.pctrbx_ogretmenfoto.Name = "pctrbx_ogretmenfoto";
            this.pctrbx_ogretmenfoto.Size = new System.Drawing.Size(122, 100);
            this.pctrbx_ogretmenfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbx_ogretmenfoto.TabIndex = 16;
            this.pctrbx_ogretmenfoto.TabStop = false;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(145, 274);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(139, 24);
            this.txt_sifre.TabIndex = 11;
            // 
            // txt_tc
            // 
            this.txt_tc.Enabled = false;
            this.txt_tc.Location = new System.Drawing.Point(145, 243);
            this.txt_tc.MaxLength = 11;
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(139, 24);
            this.txt_tc.TabIndex = 11;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(145, 151);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(139, 24);
            this.txt_id.TabIndex = 8;
            this.txt_id.Visible = false;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sifre.Location = new System.Drawing.Point(81, 274);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(33, 15);
            this.lbl_sifre.TabIndex = 4;
            this.lbl_sifre.Text = "Şifre";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tc.Location = new System.Drawing.Point(52, 243);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(64, 15);
            this.lbl_tc.TabIndex = 3;
            this.lbl_tc.Text = "T.C. Kimlik";
            // 
            // lbl_brans
            // 
            this.lbl_brans.AutoSize = true;
            this.lbl_brans.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brans.Location = new System.Drawing.Point(76, 213);
            this.lbl_brans.Name = "lbl_brans";
            this.lbl_brans.Size = new System.Drawing.Size(38, 15);
            this.lbl_brans.TabIndex = 2;
            this.lbl_brans.Text = "Branş";
            // 
            // lbl_ogrtad
            // 
            this.lbl_ogrtad.AutoSize = true;
            this.lbl_ogrtad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ogrtad.Location = new System.Drawing.Point(36, 182);
            this.lbl_ogrtad.Name = "lbl_ogrtad";
            this.lbl_ogrtad.Size = new System.Drawing.Size(83, 15);
            this.lbl_ogrtad.TabIndex = 1;
            this.lbl_ogrtad.Text = "Öğretmen Ad";
            // 
            // lbl_ıd
            // 
            this.lbl_ıd.AutoSize = true;
            this.lbl_ıd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ıd.Location = new System.Drawing.Point(98, 151);
            this.lbl_ıd.Name = "lbl_ıd";
            this.lbl_ıd.Size = new System.Drawing.Size(19, 15);
            this.lbl_ıd.TabIndex = 0;
            this.lbl_ıd.Text = "ID";
            this.lbl_ıd.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.ImageIndex = 9;
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(369, 537);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Öğrenciler";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cmb_ogrenciad);
            this.groupBox2.Controls.Add(this.btn_ogrkaydet);
            this.groupBox2.Controls.Add(this.txt_ogrsinif);
            this.groupBox2.Controls.Add(this.pctrbx_ogrenciresim);
            this.groupBox2.Controls.Add(this.txt_ogrsifre);
            this.groupBox2.Controls.Add(this.txt_ogrtc);
            this.groupBox2.Controls.Add(this.txt_ogrıd);
            this.groupBox2.Controls.Add(this.lbl_ogrsifre);
            this.groupBox2.Controls.Add(this.lbl_ogrtc);
            this.groupBox2.Controls.Add(this.lbl_ogrsinif);
            this.groupBox2.Controls.Add(this.lbl_ograd);
            this.groupBox2.Controls.Add(this.lbl_ogrıd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 532);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Kullanıcı Ayarları";
            // 
            // cmb_ogrenciad
            // 
            this.cmb_ogrenciad.FormattingEnabled = true;
            this.cmb_ogrenciad.Location = new System.Drawing.Point(143, 182);
            this.cmb_ogrenciad.Name = "cmb_ogrenciad";
            this.cmb_ogrenciad.Size = new System.Drawing.Size(139, 25);
            this.cmb_ogrenciad.TabIndex = 36;
            this.cmb_ogrenciad.SelectedIndexChanged += new System.EventHandler(this.cmb_ogrenciad_SelectedIndexChanged);
            // 
            // btn_ogrkaydet
            // 
            this.btn_ogrkaydet.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ogrkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ogrkaydet.ImageIndex = 3;
            this.btn_ogrkaydet.ImageList = this.ımageList1;
            this.btn_ogrkaydet.Location = new System.Drawing.Point(160, 319);
            this.btn_ogrkaydet.Name = "btn_ogrkaydet";
            this.btn_ogrkaydet.Size = new System.Drawing.Size(110, 39);
            this.btn_ogrkaydet.TabIndex = 35;
            this.btn_ogrkaydet.Text = "Kaydet";
            this.btn_ogrkaydet.UseVisualStyleBackColor = true;
            this.btn_ogrkaydet.Click += new System.EventHandler(this.btn_ogrkaydet_Click);
            // 
            // txt_ogrsinif
            // 
            this.txt_ogrsinif.Enabled = false;
            this.txt_ogrsinif.Location = new System.Drawing.Point(143, 213);
            this.txt_ogrsinif.Name = "txt_ogrsinif";
            this.txt_ogrsinif.Size = new System.Drawing.Size(139, 24);
            this.txt_ogrsinif.TabIndex = 34;
            // 
            // pctrbx_ogrenciresim
            // 
            this.pctrbx_ogrenciresim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrbx_ogrenciresim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctrbx_ogrenciresim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrbx_ogrenciresim.Location = new System.Drawing.Point(160, 46);
            this.pctrbx_ogrenciresim.Name = "pctrbx_ogrenciresim";
            this.pctrbx_ogrenciresim.Size = new System.Drawing.Size(122, 100);
            this.pctrbx_ogrenciresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbx_ogrenciresim.TabIndex = 30;
            this.pctrbx_ogrenciresim.TabStop = false;
            // 
            // txt_ogrsifre
            // 
            this.txt_ogrsifre.Location = new System.Drawing.Point(143, 275);
            this.txt_ogrsifre.Name = "txt_ogrsifre";
            this.txt_ogrsifre.Size = new System.Drawing.Size(139, 24);
            this.txt_ogrsifre.TabIndex = 28;
            // 
            // txt_ogrtc
            // 
            this.txt_ogrtc.Enabled = false;
            this.txt_ogrtc.Location = new System.Drawing.Point(143, 244);
            this.txt_ogrtc.MaxLength = 11;
            this.txt_ogrtc.Name = "txt_ogrtc";
            this.txt_ogrtc.Size = new System.Drawing.Size(139, 24);
            this.txt_ogrtc.TabIndex = 29;
            // 
            // txt_ogrıd
            // 
            this.txt_ogrıd.Location = new System.Drawing.Point(143, 152);
            this.txt_ogrıd.Name = "txt_ogrıd";
            this.txt_ogrıd.Size = new System.Drawing.Size(139, 24);
            this.txt_ogrıd.TabIndex = 25;
            this.txt_ogrıd.Visible = false;
            // 
            // lbl_ogrsifre
            // 
            this.lbl_ogrsifre.AutoSize = true;
            this.lbl_ogrsifre.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ogrsifre.Location = new System.Drawing.Point(79, 275);
            this.lbl_ogrsifre.Name = "lbl_ogrsifre";
            this.lbl_ogrsifre.Size = new System.Drawing.Size(33, 15);
            this.lbl_ogrsifre.TabIndex = 24;
            this.lbl_ogrsifre.Text = "Şifre";
            // 
            // lbl_ogrtc
            // 
            this.lbl_ogrtc.AutoSize = true;
            this.lbl_ogrtc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ogrtc.Location = new System.Drawing.Point(50, 244);
            this.lbl_ogrtc.Name = "lbl_ogrtc";
            this.lbl_ogrtc.Size = new System.Drawing.Size(64, 15);
            this.lbl_ogrtc.TabIndex = 23;
            this.lbl_ogrtc.Text = "T.C. Kimlik";
            // 
            // lbl_ogrsinif
            // 
            this.lbl_ogrsinif.AutoSize = true;
            this.lbl_ogrsinif.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ogrsinif.Location = new System.Drawing.Point(81, 214);
            this.lbl_ogrsinif.Name = "lbl_ogrsinif";
            this.lbl_ogrsinif.Size = new System.Drawing.Size(31, 15);
            this.lbl_ogrsinif.TabIndex = 22;
            this.lbl_ogrsinif.Text = "Sınıf";
            // 
            // lbl_ograd
            // 
            this.lbl_ograd.AutoSize = true;
            this.lbl_ograd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ograd.Location = new System.Drawing.Point(42, 183);
            this.lbl_ograd.Name = "lbl_ograd";
            this.lbl_ograd.Size = new System.Drawing.Size(70, 15);
            this.lbl_ograd.TabIndex = 21;
            this.lbl_ograd.Text = "Öğrenci Ad";
            // 
            // lbl_ogrıd
            // 
            this.lbl_ogrıd.AutoSize = true;
            this.lbl_ogrıd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ogrıd.Location = new System.Drawing.Point(96, 152);
            this.lbl_ogrıd.Name = "lbl_ogrıd";
            this.lbl_ogrıd.Size = new System.Drawing.Size(19, 15);
            this.lbl_ogrıd.TabIndex = 20;
            this.lbl_ogrıd.Text = "ID";
            this.lbl_ogrıd.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 11;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(257, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Yeni Kayıt Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 571);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.Shown += new System.EventHandler(this.Ayarlar_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ogretmenayarlar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ogrenciler)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_ogretmenfoto)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_ogrenciresim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_ogretmenayarlar;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dgv_ogrenciler;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctrbx_ogretmenfoto;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_brans;
        private System.Windows.Forms.Label lbl_ogrtad;
        private System.Windows.Forms.Label lbl_ıd;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pctrbx_ogrenciresim;
        private System.Windows.Forms.TextBox txt_ogrsifre;
        private System.Windows.Forms.TextBox txt_ogrtc;
        private System.Windows.Forms.TextBox txt_ogrıd;
        private System.Windows.Forms.Label lbl_ogrsifre;
        private System.Windows.Forms.Label lbl_ogrtc;
        private System.Windows.Forms.Label lbl_ogrsinif;
        private System.Windows.Forms.Label lbl_ograd;
        private System.Windows.Forms.Label lbl_ogrıd;
        private System.Windows.Forms.TextBox txt_ogrsinif;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_ogrkaydet;
        private System.Windows.Forms.TextBox txt_brans;
        private System.Windows.Forms.ComboBox cmb_ogretmenad;
        private System.Windows.Forms.ComboBox cmb_ogrenciad;
        private System.Windows.Forms.Label ogrid;
        private System.Windows.Forms.Button btn_yenikayit;
        private System.Windows.Forms.Button button1;
    }
}