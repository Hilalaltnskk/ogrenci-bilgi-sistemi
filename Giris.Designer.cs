namespace OgrenciBilgiSistemi.cs
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.lbl_kullanici = new System.Windows.Forms.Label();
            this.lbl_girissifre = new System.Windows.Forms.Label();
            this.txt_kullanici = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_yonetici = new System.Windows.Forms.Button();
            this.btn_ogretmen = new System.Windows.Forms.Button();
            this.btn_ogrenci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kullanici
            // 
            this.lbl_kullanici.AutoSize = true;
            this.lbl_kullanici.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullanici.Location = new System.Drawing.Point(247, 175);
            this.lbl_kullanici.Name = "lbl_kullanici";
            this.lbl_kullanici.Size = new System.Drawing.Size(78, 22);
            this.lbl_kullanici.TabIndex = 0;
            this.lbl_kullanici.Text = "Kullanıcı";
            // 
            // lbl_girissifre
            // 
            this.lbl_girissifre.AutoSize = true;
            this.lbl_girissifre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_girissifre.Location = new System.Drawing.Point(247, 225);
            this.lbl_girissifre.Name = "lbl_girissifre";
            this.lbl_girissifre.Size = new System.Drawing.Size(77, 22);
            this.lbl_girissifre.TabIndex = 1;
            this.lbl_girissifre.Text = "   Şifre   ";
            // 
            // txt_kullanici
            // 
            this.txt_kullanici.Location = new System.Drawing.Point(342, 175);
            this.txt_kullanici.Name = "txt_kullanici";
            this.txt_kullanici.Size = new System.Drawing.Size(140, 20);
            this.txt_kullanici.TabIndex = 2;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(342, 228);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(140, 20);
            this.txt_sifre.TabIndex = 3;
            // 
            // btn_yonetici
            // 
            this.btn_yonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_yonetici.BackgroundImage")));
            this.btn_yonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_yonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yonetici.Location = new System.Drawing.Point(112, 306);
            this.btn_yonetici.Name = "btn_yonetici";
            this.btn_yonetici.Size = new System.Drawing.Size(141, 101);
            this.btn_yonetici.TabIndex = 4;
            this.btn_yonetici.UseVisualStyleBackColor = true;
            this.btn_yonetici.Click += new System.EventHandler(this.btn_yonetici_Click);
            // 
            // btn_ogretmen
            // 
            this.btn_ogretmen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ogretmen.BackgroundImage")));
            this.btn_ogretmen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ogretmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ogretmen.Location = new System.Drawing.Point(295, 306);
            this.btn_ogretmen.Name = "btn_ogretmen";
            this.btn_ogretmen.Size = new System.Drawing.Size(141, 101);
            this.btn_ogretmen.TabIndex = 5;
            this.btn_ogretmen.UseVisualStyleBackColor = true;
            this.btn_ogretmen.Click += new System.EventHandler(this.btn_ogretmen_Click);
            // 
            // btn_ogrenci
            // 
            this.btn_ogrenci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ogrenci.BackgroundImage")));
            this.btn_ogrenci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ogrenci.Location = new System.Drawing.Point(478, 306);
            this.btn_ogrenci.Name = "btn_ogrenci";
            this.btn_ogrenci.Size = new System.Drawing.Size(141, 101);
            this.btn_ogrenci.TabIndex = 6;
            this.btn_ogrenci.UseVisualStyleBackColor = true;
            this.btn_ogrenci.Click += new System.EventHandler(this.btn_ogrenci_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 571);
            this.Controls.Add(this.btn_ogrenci);
            this.Controls.Add(this.btn_ogretmen);
            this.Controls.Add(this.btn_yonetici);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullanici);
            this.Controls.Add(this.lbl_girissifre);
            this.Controls.Add(this.lbl_kullanici);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kullanici;
        private System.Windows.Forms.Label lbl_girissifre;
        private System.Windows.Forms.TextBox txt_kullanici;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_yonetici;
        private System.Windows.Forms.Button btn_ogretmen;
        private System.Windows.Forms.Button btn_ogrenci;
    }
}