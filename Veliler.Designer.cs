namespace OgrenciBilgiSistemi.cs
{
    partial class Veliler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veliler));
            this.dgv_veliler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ogrid = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_telno2 = new System.Windows.Forms.TextBox();
            this.txt_telno = new System.Windows.Forms.TextBox();
            this.lbl_telno2 = new System.Windows.Forms.Label();
            this.lbl_telno = new System.Windows.Forms.Label();
            this.txt_babaad = new System.Windows.Forms.TextBox();
            this.txt_annead = new System.Windows.Forms.TextBox();
            this.txt_ıd = new System.Windows.Forms.TextBox();
            this.lbl_babaad = new System.Windows.Forms.Label();
            this.lbl_annead = new System.Windows.Forms.Label();
            this.lbl_ıd = new System.Windows.Forms.Label();
            this.btn_yenikayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veliler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_veliler
            // 
            this.dgv_veliler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_veliler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_veliler.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_veliler.Location = new System.Drawing.Point(-1, 0);
            this.dgv_veliler.Name = "dgv_veliler";
            this.dgv_veliler.RowHeadersVisible = false;
            this.dgv_veliler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_veliler.Size = new System.Drawing.Size(934, 571);
            this.dgv_veliler.TabIndex = 0;
            this.dgv_veliler.SelectionChanged += new System.EventHandler(this.dgv_veliler_SelectionChanged);
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
            this.tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.ımageList1;
            this.tabControl1.Location = new System.Drawing.Point(939, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(377, 571);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ImageIndex = 7;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(369, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Veli Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_yenikayit);
            this.groupBox1.Controls.Add(this.ogrid);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Controls.Add(this.lbl_mail);
            this.groupBox1.Controls.Add(this.txt_telno2);
            this.groupBox1.Controls.Add(this.txt_telno);
            this.groupBox1.Controls.Add(this.lbl_telno2);
            this.groupBox1.Controls.Add(this.lbl_telno);
            this.groupBox1.Controls.Add(this.txt_babaad);
            this.groupBox1.Controls.Add(this.txt_annead);
            this.groupBox1.Controls.Add(this.txt_ıd);
            this.groupBox1.Controls.Add(this.lbl_babaad);
            this.groupBox1.Controls.Add(this.lbl_annead);
            this.groupBox1.Controls.Add(this.lbl_ıd);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 532);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ogrid
            // 
            this.ogrid.AutoSize = true;
            this.ogrid.Location = new System.Drawing.Point(146, 19);
            this.ogrid.Name = "ogrid";
            this.ogrid.Size = new System.Drawing.Size(38, 15);
            this.ogrid.TabIndex = 20;
            this.ogrid.Text = "ogrid";
            this.ogrid.Visible = false;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.ImageIndex = 3;
            this.btn_kaydet.ImageList = this.ımageList1;
            this.btn_kaydet.Location = new System.Drawing.Point(161, 267);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(110, 39);
            this.btn_kaydet.TabIndex = 17;
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
            this.ımageList1.Images.SetKeyName(7, "parents (1).png");
            this.ımageList1.Images.SetKeyName(8, "add.png");
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(149, 197);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(139, 23);
            this.txt_mail.TabIndex = 16;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail.Location = new System.Drawing.Point(91, 197);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(32, 15);
            this.lbl_mail.TabIndex = 15;
            this.lbl_mail.Text = "Mail";
            // 
            // txt_telno2
            // 
            this.txt_telno2.Location = new System.Drawing.Point(149, 168);
            this.txt_telno2.Name = "txt_telno2";
            this.txt_telno2.Size = new System.Drawing.Size(139, 23);
            this.txt_telno2.TabIndex = 14;
            // 
            // txt_telno
            // 
            this.txt_telno.Location = new System.Drawing.Point(149, 137);
            this.txt_telno.Name = "txt_telno";
            this.txt_telno.Size = new System.Drawing.Size(139, 23);
            this.txt_telno.TabIndex = 13;
            // 
            // lbl_telno2
            // 
            this.lbl_telno2.AutoSize = true;
            this.lbl_telno2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telno2.Location = new System.Drawing.Point(6, 168);
            this.lbl_telno2.Name = "lbl_telno2";
            this.lbl_telno2.Size = new System.Drawing.Size(117, 15);
            this.lbl_telno2.TabIndex = 12;
            this.lbl_telno2.Text = "Telefon Numarası 2";
            // 
            // lbl_telno
            // 
            this.lbl_telno.AutoSize = true;
            this.lbl_telno.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telno.Location = new System.Drawing.Point(16, 137);
            this.lbl_telno.Name = "lbl_telno";
            this.lbl_telno.Size = new System.Drawing.Size(107, 15);
            this.lbl_telno.TabIndex = 11;
            this.lbl_telno.Text = "Telefon Numarası";
            // 
            // txt_babaad
            // 
            this.txt_babaad.Location = new System.Drawing.Point(149, 108);
            this.txt_babaad.Name = "txt_babaad";
            this.txt_babaad.Size = new System.Drawing.Size(139, 23);
            this.txt_babaad.TabIndex = 10;
            // 
            // txt_annead
            // 
            this.txt_annead.Location = new System.Drawing.Point(149, 77);
            this.txt_annead.Name = "txt_annead";
            this.txt_annead.Size = new System.Drawing.Size(139, 23);
            this.txt_annead.TabIndex = 9;
            // 
            // txt_ıd
            // 
            this.txt_ıd.Enabled = false;
            this.txt_ıd.Location = new System.Drawing.Point(149, 46);
            this.txt_ıd.Name = "txt_ıd";
            this.txt_ıd.Size = new System.Drawing.Size(139, 23);
            this.txt_ıd.TabIndex = 8;
            this.txt_ıd.Visible = false;
            // 
            // lbl_babaad
            // 
            this.lbl_babaad.AutoSize = true;
            this.lbl_babaad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_babaad.Location = new System.Drawing.Point(68, 108);
            this.lbl_babaad.Name = "lbl_babaad";
            this.lbl_babaad.Size = new System.Drawing.Size(55, 15);
            this.lbl_babaad.TabIndex = 2;
            this.lbl_babaad.Text = "Baba Ad";
            // 
            // lbl_annead
            // 
            this.lbl_annead.AutoSize = true;
            this.lbl_annead.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_annead.Location = new System.Drawing.Point(68, 77);
            this.lbl_annead.Name = "lbl_annead";
            this.lbl_annead.Size = new System.Drawing.Size(55, 15);
            this.lbl_annead.TabIndex = 1;
            this.lbl_annead.Text = "Anne Ad";
            // 
            // lbl_ıd
            // 
            this.lbl_ıd.AutoSize = true;
            this.lbl_ıd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ıd.Location = new System.Drawing.Point(104, 46);
            this.lbl_ıd.Name = "lbl_ıd";
            this.lbl_ıd.Size = new System.Drawing.Size(19, 15);
            this.lbl_ıd.TabIndex = 0;
            this.lbl_ıd.Text = "ID";
            this.lbl_ıd.Visible = false;
            // 
            // btn_yenikayit
            // 
            this.btn_yenikayit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yenikayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yenikayit.ImageIndex = 8;
            this.btn_yenikayit.ImageList = this.ımageList1;
            this.btn_yenikayit.Location = new System.Drawing.Point(259, 15);
            this.btn_yenikayit.Name = "btn_yenikayit";
            this.btn_yenikayit.Size = new System.Drawing.Size(92, 23);
            this.btn_yenikayit.TabIndex = 33;
            this.btn_yenikayit.Text = "Yeni Kayıt Ekle";
            this.btn_yenikayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_yenikayit.UseVisualStyleBackColor = true;
            this.btn_yenikayit.Click += new System.EventHandler(this.btn_yenikayit_Click);
            // 
            // Veliler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 571);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgv_veliler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Veliler";
            this.Text = "Veliler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Veliler_Load);
            this.Shown += new System.EventHandler(this.Veliler_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veliler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_veliler;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_babaad;
        private System.Windows.Forms.TextBox txt_annead;
        private System.Windows.Forms.TextBox txt_ıd;
        private System.Windows.Forms.Label lbl_babaad;
        private System.Windows.Forms.Label lbl_annead;
        private System.Windows.Forms.Label lbl_ıd;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txt_telno2;
        private System.Windows.Forms.TextBox txt_telno;
        private System.Windows.Forms.Label lbl_telno2;
        private System.Windows.Forms.Label lbl_telno;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label ogrid;
        private System.Windows.Forms.Button btn_yenikayit;
    }
}