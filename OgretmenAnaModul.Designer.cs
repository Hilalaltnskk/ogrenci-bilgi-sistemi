namespace OgrenciBilgiSistemi.cs
{
    partial class OgretmenAnaModul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenAnaModul));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_website = new System.Windows.Forms.Button();
            this.btn_notlar = new System.Windows.Forms.Button();
            this.btn_raporlar = new System.Windows.Forms.Button();
            this.btn_rehber = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_devamsızlık = new System.Windows.Forms.Button();
            this.bnt_istatistik = new System.Windows.Forms.Button();
            this.btn_notgiris = new System.Windows.Forms.Button();
            this.btn_veliler = new System.Windows.Forms.Button();
            this.btn_ogrenciler = new System.Windows.Forms.Button();
            this.btn_ogretmenler = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "home (2).png");
            this.ımageList1.Images.SetKeyName(1, "boy_4537038.png");
            this.ımageList1.Images.SetKeyName(2, "graduated_3135755.png");
            this.ımageList1.Images.SetKeyName(3, "parents.png");
            this.ımageList1.Images.SetKeyName(4, "documents.png");
            this.ımageList1.Images.SetKeyName(5, "report.png");
            this.ımageList1.Images.SetKeyName(6, "analytics.png");
            this.ımageList1.Images.SetKeyName(7, "portfolio.png");
            this.ımageList1.Images.SetKeyName(8, "file (1).png");
            this.ımageList1.Images.SetKeyName(9, "budget.png");
            this.ımageList1.Images.SetKeyName(10, "note-book.png");
            this.ımageList1.Images.SetKeyName(11, "internet.png");
            this.ımageList1.Images.SetKeyName(12, "settings (1).png");
            // 
            // btn_website
            // 
            this.btn_website.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_website.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_website.ImageIndex = 11;
            this.btn_website.ImageList = this.ımageList1;
            this.btn_website.Location = new System.Drawing.Point(1037, 6);
            this.btn_website.Name = "btn_website";
            this.btn_website.Size = new System.Drawing.Size(85, 85);
            this.btn_website.TabIndex = 21;
            this.btn_website.Text = "WEB SİTESİ";
            this.btn_website.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_website.UseVisualStyleBackColor = true;
            // 
            // btn_notlar
            // 
            this.btn_notlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_notlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notlar.ImageIndex = 10;
            this.btn_notlar.ImageList = this.ımageList1;
            this.btn_notlar.Location = new System.Drawing.Point(946, 6);
            this.btn_notlar.Name = "btn_notlar";
            this.btn_notlar.Size = new System.Drawing.Size(85, 85);
            this.btn_notlar.TabIndex = 18;
            this.btn_notlar.Text = "NOTLAR";
            this.btn_notlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_notlar.UseVisualStyleBackColor = true;
            // 
            // btn_raporlar
            // 
            this.btn_raporlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_raporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raporlar.ImageIndex = 5;
            this.btn_raporlar.ImageList = this.ımageList1;
            this.btn_raporlar.Location = new System.Drawing.Point(855, 6);
            this.btn_raporlar.Name = "btn_raporlar";
            this.btn_raporlar.Size = new System.Drawing.Size(85, 85);
            this.btn_raporlar.TabIndex = 15;
            this.btn_raporlar.Text = "RAPORLAR";
            this.btn_raporlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_raporlar.UseVisualStyleBackColor = true;
            // 
            // btn_rehber
            // 
            this.btn_rehber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rehber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rehber.ImageIndex = 7;
            this.btn_rehber.ImageList = this.ımageList1;
            this.btn_rehber.Location = new System.Drawing.Point(764, 5);
            this.btn_rehber.Name = "btn_rehber";
            this.btn_rehber.Size = new System.Drawing.Size(85, 85);
            this.btn_rehber.TabIndex = 1;
            this.btn_rehber.Text = "REHBER";
            this.btn_rehber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rehber.UseVisualStyleBackColor = true;
            this.btn_rehber.Click += new System.EventHandler(this.btn_rehber_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_website);
            this.panel1.Controls.Add(this.btn_notlar);
            this.panel1.Controls.Add(this.btn_raporlar);
            this.panel1.Controls.Add(this.btn_rehber);
            this.panel1.Controls.Add(this.btn_devamsızlık);
            this.panel1.Controls.Add(this.bnt_istatistik);
            this.panel1.Controls.Add(this.btn_notgiris);
            this.panel1.Controls.Add(this.btn_veliler);
            this.panel1.Controls.Add(this.btn_ogrenciler);
            this.panel1.Controls.Add(this.btn_ogretmenler);
            this.panel1.Controls.Add(this.btn_anasayfa);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 99);
            this.panel1.TabIndex = 2;
            // 
            // btn_devamsızlık
            // 
            this.btn_devamsızlık.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_devamsızlık.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_devamsızlık.ImageIndex = 8;
            this.btn_devamsızlık.ImageList = this.ımageList1;
            this.btn_devamsızlık.Location = new System.Drawing.Point(648, 5);
            this.btn_devamsızlık.Name = "btn_devamsızlık";
            this.btn_devamsızlık.Size = new System.Drawing.Size(110, 85);
            this.btn_devamsızlık.TabIndex = 1;
            this.btn_devamsızlık.Text = "DEVAMSIZLIKLAR";
            this.btn_devamsızlık.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_devamsızlık.UseVisualStyleBackColor = true;
            this.btn_devamsızlık.Click += new System.EventHandler(this.btn_devamsızlık_Click);
            // 
            // bnt_istatistik
            // 
            this.bnt_istatistik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bnt_istatistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_istatistik.ImageIndex = 6;
            this.bnt_istatistik.ImageList = this.ımageList1;
            this.bnt_istatistik.Location = new System.Drawing.Point(544, 5);
            this.bnt_istatistik.Name = "bnt_istatistik";
            this.bnt_istatistik.Size = new System.Drawing.Size(98, 85);
            this.bnt_istatistik.TabIndex = 5;
            this.bnt_istatistik.Text = "İSTATİSTİKLER";
            this.bnt_istatistik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bnt_istatistik.UseVisualStyleBackColor = true;
            this.bnt_istatistik.Click += new System.EventHandler(this.bnt_istatistik_Click_1);
            // 
            // btn_notgiris
            // 
            this.btn_notgiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_notgiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notgiris.ImageIndex = 4;
            this.btn_notgiris.ImageList = this.ımageList1;
            this.btn_notgiris.Location = new System.Drawing.Point(453, 5);
            this.btn_notgiris.Name = "btn_notgiris";
            this.btn_notgiris.Size = new System.Drawing.Size(85, 85);
            this.btn_notgiris.TabIndex = 4;
            this.btn_notgiris.Text = "NOT GİRİŞ";
            this.btn_notgiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_notgiris.UseVisualStyleBackColor = true;
            this.btn_notgiris.Click += new System.EventHandler(this.btn_notgiris_Click);
            // 
            // btn_veliler
            // 
            this.btn_veliler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_veliler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_veliler.ImageIndex = 3;
            this.btn_veliler.ImageList = this.ımageList1;
            this.btn_veliler.Location = new System.Drawing.Point(354, 5);
            this.btn_veliler.Name = "btn_veliler";
            this.btn_veliler.Size = new System.Drawing.Size(93, 85);
            this.btn_veliler.TabIndex = 3;
            this.btn_veliler.Text = "VELİLER";
            this.btn_veliler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_veliler.UseVisualStyleBackColor = true;
            this.btn_veliler.Click += new System.EventHandler(this.btn_veliler_Click);
            // 
            // btn_ogrenciler
            // 
            this.btn_ogrenciler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ogrenciler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ogrenciler.ImageIndex = 2;
            this.btn_ogrenciler.ImageList = this.ımageList1;
            this.btn_ogrenciler.Location = new System.Drawing.Point(236, 5);
            this.btn_ogrenciler.Name = "btn_ogrenciler";
            this.btn_ogrenciler.Size = new System.Drawing.Size(112, 85);
            this.btn_ogrenciler.TabIndex = 2;
            this.btn_ogrenciler.Text = "ÖĞRENCİLER";
            this.btn_ogrenciler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ogrenciler.UseVisualStyleBackColor = true;
            this.btn_ogrenciler.Click += new System.EventHandler(this.btn_ogrenciler_Click);
            // 
            // btn_ogretmenler
            // 
            this.btn_ogretmenler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ogretmenler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ogretmenler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogretmenler.ImageIndex = 1;
            this.btn_ogretmenler.ImageList = this.ımageList1;
            this.btn_ogretmenler.Location = new System.Drawing.Point(125, 5);
            this.btn_ogretmenler.Name = "btn_ogretmenler";
            this.btn_ogretmenler.Size = new System.Drawing.Size(105, 85);
            this.btn_ogretmenler.TabIndex = 1;
            this.btn_ogretmenler.Text = "ÖĞRETMENLER";
            this.btn_ogretmenler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ogretmenler.UseVisualStyleBackColor = true;
            this.btn_ogretmenler.Click += new System.EventHandler(this.btn_ogretmenler_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.BackColor = System.Drawing.Color.Transparent;
            this.btn_anasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_anasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anasayfa.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anasayfa.ImageIndex = 0;
            this.btn_anasayfa.ImageList = this.ımageList1;
            this.btn_anasayfa.Location = new System.Drawing.Point(20, 6);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(99, 85);
            this.btn_anasayfa.TabIndex = 0;
            this.btn_anasayfa.Text = "ANA SAYFA";
            this.btn_anasayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_anasayfa.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 610);
            this.panel2.TabIndex = 3;
            // 
            // OgretmenAnaModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "OgretmenAnaModul";
            this.Text = "OgretmenAnaModul";
            this.Load += new System.EventHandler(this.OgretmenAnaModul_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_website;
        private System.Windows.Forms.Button btn_notlar;
        private System.Windows.Forms.Button btn_raporlar;
        private System.Windows.Forms.Button btn_rehber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_devamsızlık;
        private System.Windows.Forms.Button bnt_istatistik;
        private System.Windows.Forms.Button btn_notgiris;
        private System.Windows.Forms.Button btn_veliler;
        private System.Windows.Forms.Button btn_ogrenciler;
        private System.Windows.Forms.Button btn_ogretmenler;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.Panel panel2;
    }
}