namespace OgrenciBilgiSistemi.cs
{
    partial class Ogretmenler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogretmenler));
            this.dtgv_ogretmenbilgi = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pctrbx_ogretmenresim = new System.Windows.Forms.PictureBox();
            this.cmbx_brans = new System.Windows.Forms.ComboBox();
            this.cmbx_ilce = new System.Windows.Forms.ComboBox();
            this.cmbx_il = new System.Windows.Forms.ComboBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_ıd = new System.Windows.Forms.TextBox();
            this.lbl_brans = new System.Windows.Forms.Label();
            this.lbl_ilce = new System.Windows.Forms.Label();
            this.lbl_il = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_ıd = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ogrid = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_resimsec = new System.Windows.Forms.Button();
            this.rxhtxt_adres = new System.Windows.Forms.RichTextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.btn_yenikayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ogretmenbilgi)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_ogretmenresim)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_ogretmenbilgi
            // 
            this.dtgv_ogretmenbilgi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ogretmenbilgi.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgv_ogretmenbilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ogretmenbilgi.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgv_ogretmenbilgi.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgv_ogretmenbilgi.Location = new System.Drawing.Point(1, 0);
            this.dtgv_ogretmenbilgi.Name = "dtgv_ogretmenbilgi";
            this.dtgv_ogretmenbilgi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ogretmenbilgi.Size = new System.Drawing.Size(934, 571);
            this.dtgv_ogretmenbilgi.TabIndex = 0;
            this.dtgv_ogretmenbilgi.SelectionChanged += new System.EventHandler(this.dtgv_ogretmenbilgi_SelectionChanged);
            this.dtgv_ogretmenbilgi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgv_ogretmenbilgi_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::OgrenciBilgiSistemi.cs.Properties.Resources.delete;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem1.Text = "Sil";
            this.toolStripMenuItem1.ToolTipText = "ToolStripButton";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.ımageList1;
            this.tabControl1.Location = new System.Drawing.Point(937, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(377, 571);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(369, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğretmen Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_yenikayit);
            this.groupBox1.Controls.Add(this.pctrbx_ogretmenresim);
            this.groupBox1.Controls.Add(this.cmbx_brans);
            this.groupBox1.Controls.Add(this.cmbx_ilce);
            this.groupBox1.Controls.Add(this.cmbx_il);
            this.groupBox1.Controls.Add(this.txt_tel);
            this.groupBox1.Controls.Add(this.txt_tc);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.txt_ıd);
            this.groupBox1.Controls.Add(this.lbl_brans);
            this.groupBox1.Controls.Add(this.lbl_ilce);
            this.groupBox1.Controls.Add(this.lbl_il);
            this.groupBox1.Controls.Add(this.lbl_tel);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.lbl_soyad);
            this.groupBox1.Controls.Add(this.lbl_ad);
            this.groupBox1.Controls.Add(this.lbl_ıd);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 532);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pctrbx_ogretmenresim
            // 
            this.pctrbx_ogretmenresim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrbx_ogretmenresim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctrbx_ogretmenresim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrbx_ogretmenresim.Location = new System.Drawing.Point(168, 38);
            this.pctrbx_ogretmenresim.Name = "pctrbx_ogretmenresim";
            this.pctrbx_ogretmenresim.Size = new System.Drawing.Size(122, 100);
            this.pctrbx_ogretmenresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbx_ogretmenresim.TabIndex = 16;
            this.pctrbx_ogretmenresim.TabStop = false;
            // 
            // cmbx_brans
            // 
            this.cmbx_brans.FormattingEnabled = true;
            this.cmbx_brans.Location = new System.Drawing.Point(151, 378);
            this.cmbx_brans.Name = "cmbx_brans";
            this.cmbx_brans.Size = new System.Drawing.Size(139, 23);
            this.cmbx_brans.TabIndex = 15;
            // 
            // cmbx_ilce
            // 
            this.cmbx_ilce.FormattingEnabled = true;
            this.cmbx_ilce.Location = new System.Drawing.Point(151, 344);
            this.cmbx_ilce.Name = "cmbx_ilce";
            this.cmbx_ilce.Size = new System.Drawing.Size(139, 23);
            this.cmbx_ilce.TabIndex = 14;
            // 
            // cmbx_il
            // 
            this.cmbx_il.FormattingEnabled = true;
            this.cmbx_il.Location = new System.Drawing.Point(151, 309);
            this.cmbx_il.Name = "cmbx_il";
            this.cmbx_il.Size = new System.Drawing.Size(139, 23);
            this.cmbx_il.TabIndex = 13;
            this.cmbx_il.SelectedIndexChanged += new System.EventHandler(this.cmbx_il_SelectedIndexChanged);
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(151, 277);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(139, 23);
            this.txt_tel.TabIndex = 11;
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(151, 246);
            this.txt_tc.MaxLength = 11;
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(139, 23);
            this.txt_tc.TabIndex = 11;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(151, 216);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(139, 23);
            this.txt_soyad.TabIndex = 10;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(151, 185);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(139, 23);
            this.txt_ad.TabIndex = 9;
            // 
            // txt_ıd
            // 
            this.txt_ıd.Enabled = false;
            this.txt_ıd.Location = new System.Drawing.Point(151, 154);
            this.txt_ıd.Name = "txt_ıd";
            this.txt_ıd.Size = new System.Drawing.Size(139, 23);
            this.txt_ıd.TabIndex = 8;
            this.txt_ıd.Visible = false;
            // 
            // lbl_brans
            // 
            this.lbl_brans.AutoSize = true;
            this.lbl_brans.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brans.Location = new System.Drawing.Point(84, 378);
            this.lbl_brans.Name = "lbl_brans";
            this.lbl_brans.Size = new System.Drawing.Size(38, 15);
            this.lbl_brans.TabIndex = 7;
            this.lbl_brans.Text = "Branş";
            // 
            // lbl_ilce
            // 
            this.lbl_ilce.AutoSize = true;
            this.lbl_ilce.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ilce.Location = new System.Drawing.Point(97, 344);
            this.lbl_ilce.Name = "lbl_ilce";
            this.lbl_ilce.Size = new System.Drawing.Size(26, 15);
            this.lbl_ilce.TabIndex = 6;
            this.lbl_ilce.Text = "İlçe";
            // 
            // lbl_il
            // 
            this.lbl_il.AutoSize = true;
            this.lbl_il.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_il.Location = new System.Drawing.Point(110, 309);
            this.lbl_il.Name = "lbl_il";
            this.lbl_il.Size = new System.Drawing.Size(13, 15);
            this.lbl_il.TabIndex = 5;
            this.lbl_il.Text = "İl";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel.Location = new System.Drawing.Point(18, 277);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(107, 15);
            this.lbl_tel.TabIndex = 4;
            this.lbl_tel.Text = "Telefon Numarası";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tc.Location = new System.Drawing.Point(58, 246);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(64, 15);
            this.lbl_tc.TabIndex = 3;
            this.lbl_tc.Text = "T.C. Kimlik";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soyad.Location = new System.Drawing.Point(82, 216);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(43, 15);
            this.lbl_soyad.TabIndex = 2;
            this.lbl_soyad.Text = "Soyad";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ad.Location = new System.Drawing.Point(102, 185);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(23, 15);
            this.lbl_ad.TabIndex = 1;
            this.lbl_ad.Text = "Ad";
            // 
            // lbl_ıd
            // 
            this.lbl_ıd.AutoSize = true;
            this.lbl_ıd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ıd.Location = new System.Drawing.Point(104, 154);
            this.lbl_ıd.Name = "lbl_ıd";
            this.lbl_ıd.Size = new System.Drawing.Size(19, 15);
            this.lbl_ıd.TabIndex = 0;
            this.lbl_ıd.Text = "ID";
            this.lbl_ıd.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.ImageKey = "placeholder.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(369, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Öğretmen Bilgileri-2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ogrid);
            this.groupBox2.Controls.Add(this.btn_kaydet);
            this.groupBox2.Controls.Add(this.btn_resimsec);
            this.groupBox2.Controls.Add(this.rxhtxt_adres);
            this.groupBox2.Controls.Add(this.txt_mail);
            this.groupBox2.Controls.Add(this.lbl_adres);
            this.groupBox2.Controls.Add(this.lbl_mail);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 532);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // ogrid
            // 
            this.ogrid.AutoSize = true;
            this.ogrid.Location = new System.Drawing.Point(120, 65);
            this.ogrid.Name = "ogrid";
            this.ogrid.Size = new System.Drawing.Size(38, 15);
            this.ogrid.TabIndex = 10;
            this.ogrid.Text = "ogrid";
            this.ogrid.Visible = false;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.ImageIndex = 3;
            this.btn_kaydet.ImageList = this.ımageList1;
            this.btn_kaydet.Location = new System.Drawing.Point(146, 278);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(110, 39);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
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
            this.ımageList1.Images.SetKeyName(7, "add.png");
            // 
            // btn_resimsec
            // 
            this.btn_resimsec.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resimsec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_resimsec.ImageIndex = 2;
            this.btn_resimsec.ImageList = this.ımageList1;
            this.btn_resimsec.Location = new System.Drawing.Point(146, 233);
            this.btn_resimsec.Name = "btn_resimsec";
            this.btn_resimsec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_resimsec.Size = new System.Drawing.Size(110, 39);
            this.btn_resimsec.TabIndex = 4;
            this.btn_resimsec.Text = "Resim Seç";
            this.btn_resimsec.UseVisualStyleBackColor = true;
            this.btn_resimsec.Click += new System.EventHandler(this.btn_resimsec_Click);
            // 
            // rxhtxt_adres
            // 
            this.rxhtxt_adres.Location = new System.Drawing.Point(123, 126);
            this.rxhtxt_adres.Name = "rxhtxt_adres";
            this.rxhtxt_adres.Size = new System.Drawing.Size(150, 95);
            this.rxhtxt_adres.TabIndex = 3;
            this.rxhtxt_adres.Text = "";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(123, 83);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(150, 23);
            this.txt_mail.TabIndex = 2;
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adres.Location = new System.Drawing.Point(61, 108);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(39, 15);
            this.lbl_adres.TabIndex = 1;
            this.lbl_adres.Text = "Adres";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail.Location = new System.Drawing.Point(61, 83);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(32, 15);
            this.lbl_mail.TabIndex = 0;
            this.lbl_mail.Text = "Mail";
            // 
            // btn_yenikayit
            // 
            this.btn_yenikayit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yenikayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yenikayit.ImageIndex = 7;
            this.btn_yenikayit.ImageList = this.ımageList1;
            this.btn_yenikayit.Location = new System.Drawing.Point(249, 9);
            this.btn_yenikayit.Name = "btn_yenikayit";
            this.btn_yenikayit.Size = new System.Drawing.Size(92, 23);
            this.btn_yenikayit.TabIndex = 32;
            this.btn_yenikayit.Text = "Yeni Kayıt Ekle";
            this.btn_yenikayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_yenikayit.UseVisualStyleBackColor = true;
            this.btn_yenikayit.Click += new System.EventHandler(this.btn_yenikayit_Click);
            // 
            // Ogretmenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1310, 571);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dtgv_ogretmenbilgi);
            this.Name = "Ogretmenler";
            this.Text = "Ogretmenler";
            this.Load += new System.EventHandler(this.Ogretmenler_Load);
            this.Shown += new System.EventHandler(this.Ogretmenler_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ogretmenbilgi)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_ogretmenresim)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ogretmenbilgi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_brans;
        private System.Windows.Forms.Label lbl_ilce;
        private System.Windows.Forms.Label lbl_il;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_ıd;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_ıd;
        private System.Windows.Forms.ComboBox cmbx_brans;
        private System.Windows.Forms.ComboBox cmbx_ilce;
        private System.Windows.Forms.ComboBox cmbx_il;
        private System.Windows.Forms.RichTextBox rxhtxt_adres;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_resimsec;
        private System.Windows.Forms.PictureBox pctrbx_ogretmenresim;
        private System.Windows.Forms.Label ogrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btn_yenikayit;
    }
}