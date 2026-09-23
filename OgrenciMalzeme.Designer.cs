namespace OgrenciBilgiSistemi.cs
{
    partial class OgrenciMalzeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciMalzeme));
            this.cbx_egitimmal = new System.Windows.Forms.CheckBox();
            this.cbx_labaratuvarmal = new System.Windows.Forms.CheckBox();
            this.cbx_kutuphanemal = new System.Windows.Forms.CheckBox();
            this.cbx_spormal = new System.Windows.Forms.CheckBox();
            this.cbx_resimmal = new System.Windows.Forms.CheckBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.dgv_ogrencimalzeme = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.txt_toplam = new System.Windows.Forms.TextBox();
            this.txt_egitimmal = new System.Windows.Forms.TextBox();
            this.txt_labaratuvarmal = new System.Windows.Forms.TextBox();
            this.txt_kutuphanemal = new System.Windows.Forms.TextBox();
            this.txt_spormal = new System.Windows.Forms.TextBox();
            this.txt_resimmal = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ogrid = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ogrencimalzeme)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_egitimmal
            // 
            this.cbx_egitimmal.AutoSize = true;
            this.cbx_egitimmal.Location = new System.Drawing.Point(296, 196);
            this.cbx_egitimmal.Name = "cbx_egitimmal";
            this.cbx_egitimmal.Size = new System.Drawing.Size(15, 14);
            this.cbx_egitimmal.TabIndex = 57;
            this.cbx_egitimmal.UseVisualStyleBackColor = true;
            this.cbx_egitimmal.CheckedChanged += new System.EventHandler(this.cbx_egitimmal_CheckedChanged);
            // 
            // cbx_labaratuvarmal
            // 
            this.cbx_labaratuvarmal.AutoSize = true;
            this.cbx_labaratuvarmal.Location = new System.Drawing.Point(296, 167);
            this.cbx_labaratuvarmal.Name = "cbx_labaratuvarmal";
            this.cbx_labaratuvarmal.Size = new System.Drawing.Size(15, 14);
            this.cbx_labaratuvarmal.TabIndex = 56;
            this.cbx_labaratuvarmal.UseVisualStyleBackColor = true;
            this.cbx_labaratuvarmal.CheckedChanged += new System.EventHandler(this.cbx_labaratuvarmal_CheckedChanged);
            // 
            // cbx_kutuphanemal
            // 
            this.cbx_kutuphanemal.AutoSize = true;
            this.cbx_kutuphanemal.Location = new System.Drawing.Point(296, 136);
            this.cbx_kutuphanemal.Name = "cbx_kutuphanemal";
            this.cbx_kutuphanemal.Size = new System.Drawing.Size(15, 14);
            this.cbx_kutuphanemal.TabIndex = 55;
            this.cbx_kutuphanemal.UseVisualStyleBackColor = true;
            this.cbx_kutuphanemal.CheckedChanged += new System.EventHandler(this.cbx_kutuphanemal_CheckedChanged);
            // 
            // cbx_spormal
            // 
            this.cbx_spormal.AutoSize = true;
            this.cbx_spormal.Location = new System.Drawing.Point(296, 102);
            this.cbx_spormal.Name = "cbx_spormal";
            this.cbx_spormal.Size = new System.Drawing.Size(15, 14);
            this.cbx_spormal.TabIndex = 54;
            this.cbx_spormal.UseVisualStyleBackColor = true;
            this.cbx_spormal.CheckedChanged += new System.EventHandler(this.cbx_spormal_CheckedChanged);
            // 
            // cbx_resimmal
            // 
            this.cbx_resimmal.AutoSize = true;
            this.cbx_resimmal.Location = new System.Drawing.Point(296, 73);
            this.cbx_resimmal.Name = "cbx_resimmal";
            this.cbx_resimmal.Size = new System.Drawing.Size(15, 14);
            this.cbx_resimmal.TabIndex = 53;
            this.cbx_resimmal.UseVisualStyleBackColor = true;
            this.cbx_resimmal.CheckedChanged += new System.EventHandler(this.cbx_resimmal_CheckedChanged);
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
            this.ımageList1.Images.SetKeyName(7, "man.png");
            this.ımageList1.Images.SetKeyName(8, "employee.png");
            this.ımageList1.Images.SetKeyName(9, "calculator.png");
            this.ımageList1.Images.SetKeyName(10, "calculator (1).png");
            this.ımageList1.Images.SetKeyName(11, "close (1).png");
            this.ımageList1.Images.SetKeyName(12, "add.png");
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.ImageIndex = 3;
            this.btn_kaydet.ImageList = this.ımageList1;
            this.btn_kaydet.Location = new System.Drawing.Point(193, 261);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(108, 33);
            this.btn_kaydet.TabIndex = 50;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // dgv_ogrencimalzeme
            // 
            this.dgv_ogrencimalzeme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ogrencimalzeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ogrencimalzeme.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_ogrencimalzeme.Location = new System.Drawing.Point(373, 30);
            this.dgv_ogrencimalzeme.Name = "dgv_ogrencimalzeme";
            this.dgv_ogrencimalzeme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ogrencimalzeme.Size = new System.Drawing.Size(550, 370);
            this.dgv_ogrencimalzeme.TabIndex = 49;
            this.dgv_ogrencimalzeme.SelectionChanged += new System.EventHandler(this.dgv_ogrencimalzeme_SelectionChanged);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(113, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Toplam Gider";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hesapla.ImageIndex = 10;
            this.btn_hesapla.ImageList = this.ımageList1;
            this.btn_hesapla.Location = new System.Drawing.Point(296, 221);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(71, 24);
            this.btn_hesapla.TabIndex = 46;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // txt_toplam
            // 
            this.txt_toplam.Enabled = false;
            this.txt_toplam.Location = new System.Drawing.Point(203, 223);
            this.txt_toplam.Name = "txt_toplam";
            this.txt_toplam.Size = new System.Drawing.Size(87, 20);
            this.txt_toplam.TabIndex = 45;
            // 
            // txt_egitimmal
            // 
            this.txt_egitimmal.Enabled = false;
            this.txt_egitimmal.Location = new System.Drawing.Point(203, 197);
            this.txt_egitimmal.Name = "txt_egitimmal";
            this.txt_egitimmal.Size = new System.Drawing.Size(87, 20);
            this.txt_egitimmal.TabIndex = 43;
            // 
            // txt_labaratuvarmal
            // 
            this.txt_labaratuvarmal.Enabled = false;
            this.txt_labaratuvarmal.Location = new System.Drawing.Point(203, 165);
            this.txt_labaratuvarmal.Name = "txt_labaratuvarmal";
            this.txt_labaratuvarmal.Size = new System.Drawing.Size(87, 20);
            this.txt_labaratuvarmal.TabIndex = 42;
            // 
            // txt_kutuphanemal
            // 
            this.txt_kutuphanemal.Enabled = false;
            this.txt_kutuphanemal.Location = new System.Drawing.Point(203, 133);
            this.txt_kutuphanemal.Name = "txt_kutuphanemal";
            this.txt_kutuphanemal.Size = new System.Drawing.Size(87, 20);
            this.txt_kutuphanemal.TabIndex = 41;
            // 
            // txt_spormal
            // 
            this.txt_spormal.Enabled = false;
            this.txt_spormal.Location = new System.Drawing.Point(203, 102);
            this.txt_spormal.Name = "txt_spormal";
            this.txt_spormal.Size = new System.Drawing.Size(87, 20);
            this.txt_spormal.TabIndex = 40;
            // 
            // txt_resimmal
            // 
            this.txt_resimmal.Enabled = false;
            this.txt_resimmal.Location = new System.Drawing.Point(203, 70);
            this.txt_resimmal.Name = "txt_resimmal";
            this.txt_resimmal.Size = new System.Drawing.Size(87, 20);
            this.txt_resimmal.TabIndex = 39;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(203, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(52, 20);
            this.txt_id.TabIndex = 38;
            this.txt_id.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(-1, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "İç Sanal Sınıf ve Eğitim Teknolojileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(53, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = " Labaratuvar malzemeleri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(68, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Kütüphane Kaynakları";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(91, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Spor Malzemeleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Resim ve Sanat Malzemeleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(157, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(172, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.ImageIndex = 11;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(893, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 58;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ogrid
            // 
            this.ogrid.AutoSize = true;
            this.ogrid.Location = new System.Drawing.Point(123, 7);
            this.ogrid.Name = "ogrid";
            this.ogrid.Size = new System.Drawing.Size(30, 13);
            this.ogrid.TabIndex = 85;
            this.ogrid.Text = "ogrid";
            this.ogrid.Visible = false;
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 12;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 86;
            this.button2.Text = "Yeni Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OgrenciMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 403);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ogrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_egitimmal);
            this.Controls.Add(this.cbx_labaratuvarmal);
            this.Controls.Add(this.cbx_kutuphanemal);
            this.Controls.Add(this.cbx_spormal);
            this.Controls.Add(this.cbx_resimmal);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.dgv_ogrencimalzeme);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.txt_toplam);
            this.Controls.Add(this.txt_egitimmal);
            this.Controls.Add(this.txt_labaratuvarmal);
            this.Controls.Add(this.txt_kutuphanemal);
            this.Controls.Add(this.txt_spormal);
            this.Controls.Add(this.txt_resimmal);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciMalzeme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OgrenciMalzeme_Load);
            this.Shown += new System.EventHandler(this.OgrenciMalzeme_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ogrencimalzeme)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbx_egitimmal;
        private System.Windows.Forms.CheckBox cbx_labaratuvarmal;
        private System.Windows.Forms.CheckBox cbx_kutuphanemal;
        private System.Windows.Forms.CheckBox cbx_spormal;
        private System.Windows.Forms.CheckBox cbx_resimmal;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.DataGridView dgv_ogrencimalzeme;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.TextBox txt_toplam;
        private System.Windows.Forms.TextBox txt_egitimmal;
        private System.Windows.Forms.TextBox txt_labaratuvarmal;
        private System.Windows.Forms.TextBox txt_kutuphanemal;
        private System.Windows.Forms.TextBox txt_spormal;
        private System.Windows.Forms.TextBox txt_resimmal;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ogrid;
        private System.Windows.Forms.Button button2;
    }
}