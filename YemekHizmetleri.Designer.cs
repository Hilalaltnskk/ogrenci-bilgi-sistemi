namespace OgrenciBilgiSistemi.cs
{
    partial class YemekHizmetleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YemekHizmetleri));
            this.cbx_yemekservis = new System.Windows.Forms.CheckBox();
            this.cbx_beslenme = new System.Windows.Forms.CheckBox();
            this.cbx_gida = new System.Windows.Forms.CheckBox();
            this.cbx_personelgider = new System.Windows.Forms.CheckBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgv_yemekhizmetleri = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_ikramlar = new System.Windows.Forms.CheckBox();
            this.txt_toplam = new System.Windows.Forms.TextBox();
            this.txt_ikramlar = new System.Windows.Forms.TextBox();
            this.txt_yemekservis = new System.Windows.Forms.TextBox();
            this.txt_beslenme = new System.Windows.Forms.TextBox();
            this.txt_gida = new System.Windows.Forms.TextBox();
            this.txt_personelgider = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.ogrid = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yemekhizmetleri)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_yemekservis
            // 
            this.cbx_yemekservis.AutoSize = true;
            this.cbx_yemekservis.Location = new System.Drawing.Point(283, 159);
            this.cbx_yemekservis.Name = "cbx_yemekservis";
            this.cbx_yemekservis.Size = new System.Drawing.Size(15, 14);
            this.cbx_yemekservis.TabIndex = 56;
            this.cbx_yemekservis.UseVisualStyleBackColor = true;
            this.cbx_yemekservis.CheckedChanged += new System.EventHandler(this.cbx_yemekservis_CheckedChanged);
            // 
            // cbx_beslenme
            // 
            this.cbx_beslenme.AutoSize = true;
            this.cbx_beslenme.Location = new System.Drawing.Point(283, 128);
            this.cbx_beslenme.Name = "cbx_beslenme";
            this.cbx_beslenme.Size = new System.Drawing.Size(15, 14);
            this.cbx_beslenme.TabIndex = 55;
            this.cbx_beslenme.UseVisualStyleBackColor = true;
            this.cbx_beslenme.CheckedChanged += new System.EventHandler(this.cbx_beslenme_CheckedChanged);
            // 
            // cbx_gida
            // 
            this.cbx_gida.AutoSize = true;
            this.cbx_gida.Location = new System.Drawing.Point(283, 94);
            this.cbx_gida.Name = "cbx_gida";
            this.cbx_gida.Size = new System.Drawing.Size(15, 14);
            this.cbx_gida.TabIndex = 54;
            this.cbx_gida.UseVisualStyleBackColor = true;
            this.cbx_gida.CheckedChanged += new System.EventHandler(this.cbx_gida_CheckedChanged);
            // 
            // cbx_personelgider
            // 
            this.cbx_personelgider.AutoSize = true;
            this.cbx_personelgider.Location = new System.Drawing.Point(283, 65);
            this.cbx_personelgider.Name = "cbx_personelgider";
            this.cbx_personelgider.Size = new System.Drawing.Size(15, 14);
            this.cbx_personelgider.TabIndex = 53;
            this.cbx_personelgider.UseVisualStyleBackColor = true;
            this.cbx_personelgider.CheckedChanged += new System.EventHandler(this.cbx_personelgider_CheckedChanged);
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
            // dgv_yemekhizmetleri
            // 
            this.dgv_yemekhizmetleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_yemekhizmetleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yemekhizmetleri.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_yemekhizmetleri.Location = new System.Drawing.Point(376, 25);
            this.dgv_yemekhizmetleri.Name = "dgv_yemekhizmetleri";
            this.dgv_yemekhizmetleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_yemekhizmetleri.Size = new System.Drawing.Size(550, 375);
            this.dgv_yemekhizmetleri.TabIndex = 49;
            this.dgv_yemekhizmetleri.SelectionChanged += new System.EventHandler(this.dgv_yemekhizmetleri_SelectionChanged);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(94, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Toplam Gider";
            // 
            // cbx_ikramlar
            // 
            this.cbx_ikramlar.AutoSize = true;
            this.cbx_ikramlar.Location = new System.Drawing.Point(283, 188);
            this.cbx_ikramlar.Name = "cbx_ikramlar";
            this.cbx_ikramlar.Size = new System.Drawing.Size(15, 14);
            this.cbx_ikramlar.TabIndex = 57;
            this.cbx_ikramlar.UseVisualStyleBackColor = true;
            this.cbx_ikramlar.CheckedChanged += new System.EventHandler(this.cbx_ikramlar_CheckedChanged);
            // 
            // txt_toplam
            // 
            this.txt_toplam.Enabled = false;
            this.txt_toplam.Location = new System.Drawing.Point(190, 225);
            this.txt_toplam.Name = "txt_toplam";
            this.txt_toplam.Size = new System.Drawing.Size(87, 20);
            this.txt_toplam.TabIndex = 45;
            // 
            // txt_ikramlar
            // 
            this.txt_ikramlar.Enabled = false;
            this.txt_ikramlar.Location = new System.Drawing.Point(190, 189);
            this.txt_ikramlar.Name = "txt_ikramlar";
            this.txt_ikramlar.Size = new System.Drawing.Size(87, 20);
            this.txt_ikramlar.TabIndex = 43;
            // 
            // txt_yemekservis
            // 
            this.txt_yemekservis.Enabled = false;
            this.txt_yemekservis.Location = new System.Drawing.Point(190, 157);
            this.txt_yemekservis.Name = "txt_yemekservis";
            this.txt_yemekservis.Size = new System.Drawing.Size(87, 20);
            this.txt_yemekservis.TabIndex = 42;
            // 
            // txt_beslenme
            // 
            this.txt_beslenme.Enabled = false;
            this.txt_beslenme.Location = new System.Drawing.Point(190, 125);
            this.txt_beslenme.Name = "txt_beslenme";
            this.txt_beslenme.Size = new System.Drawing.Size(87, 20);
            this.txt_beslenme.TabIndex = 41;
            // 
            // txt_gida
            // 
            this.txt_gida.Enabled = false;
            this.txt_gida.Location = new System.Drawing.Point(190, 94);
            this.txt_gida.Name = "txt_gida";
            this.txt_gida.Size = new System.Drawing.Size(87, 20);
            this.txt_gida.TabIndex = 40;
            // 
            // txt_personelgider
            // 
            this.txt_personelgider.Enabled = false;
            this.txt_personelgider.Location = new System.Drawing.Point(190, 62);
            this.txt_personelgider.Name = "txt_personelgider";
            this.txt_personelgider.Size = new System.Drawing.Size(87, 20);
            this.txt_personelgider.TabIndex = 39;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(190, 10);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(52, 20);
            this.txt_id.TabIndex = 38;
            this.txt_id.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(25, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "İkramlar ve Özel Etkinlikler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(45, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Yemek Servis Ekipmanı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(54, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Beslenme Danışmanı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(80, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Gıda Maliyetleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Personel Giderler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(136, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(151, 6);
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
            this.button1.Location = new System.Drawing.Point(896, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 59;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.ImageIndex = 3;
            this.btn_kaydet.ImageList = this.ımageList1;
            this.btn_kaydet.Location = new System.Drawing.Point(181, 258);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(108, 33);
            this.btn_kaydet.TabIndex = 50;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hesapla.ImageIndex = 10;
            this.btn_hesapla.ImageList = this.ımageList1;
            this.btn_hesapla.Location = new System.Drawing.Point(283, 225);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(73, 24);
            this.btn_hesapla.TabIndex = 46;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // ogrid
            // 
            this.ogrid.AutoSize = true;
            this.ogrid.Location = new System.Drawing.Point(94, 12);
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
            this.button2.Location = new System.Drawing.Point(12, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 86;
            this.button2.Text = "Yeni Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // YemekHizmetleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 403);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ogrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_yemekservis);
            this.Controls.Add(this.cbx_beslenme);
            this.Controls.Add(this.cbx_gida);
            this.Controls.Add(this.cbx_personelgider);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.dgv_yemekhizmetleri);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbx_ikramlar);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.txt_toplam);
            this.Controls.Add(this.txt_ikramlar);
            this.Controls.Add(this.txt_yemekservis);
            this.Controls.Add(this.txt_beslenme);
            this.Controls.Add(this.txt_gida);
            this.Controls.Add(this.txt_personelgider);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YemekHizmetleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.YemekHizmetleri_Load);
            this.Shown += new System.EventHandler(this.YemekHizmetleri_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yemekhizmetleri)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbx_yemekservis;
        private System.Windows.Forms.CheckBox cbx_beslenme;
        private System.Windows.Forms.CheckBox cbx_gida;
        private System.Windows.Forms.CheckBox cbx_personelgider;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.DataGridView dgv_yemekhizmetleri;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbx_ikramlar;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.TextBox txt_toplam;
        private System.Windows.Forms.TextBox txt_ikramlar;
        private System.Windows.Forms.TextBox txt_yemekservis;
        private System.Windows.Forms.TextBox txt_beslenme;
        private System.Windows.Forms.TextBox txt_gida;
        private System.Windows.Forms.TextBox txt_personelgider;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ogrid;
        private System.Windows.Forms.Button button2;
    }
}