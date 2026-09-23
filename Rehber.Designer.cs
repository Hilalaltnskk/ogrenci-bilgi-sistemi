namespace OgrenciBilgiSistemi.cs
{
    partial class Rehber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rehber));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_okullar = new System.Windows.Forms.TabPage();
            this.dgv_okullar = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_veliler = new System.Windows.Forms.TabPage();
            this.dgv_veliler = new System.Windows.Forms.DataGridView();
            this.tabPage_ogretmenler = new System.Windows.Forms.TabPage();
            this.dgv_ogretmenler = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dtgv_ogretmenbilgi = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ogrid = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_muduryrdtel = new System.Windows.Forms.TextBox();
            this.txt_mudurtel = new System.Windows.Forms.TextBox();
            this.txt_muduryrdad = new System.Windows.Forms.TextBox();
            this.txt_mudurad = new System.Windows.Forms.TextBox();
            this.txt_okulad = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_okullar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_okullar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage_veliler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veliler)).BeginInit();
            this.tabPage_ogretmenler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ogretmenler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ogretmenbilgi)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
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
            this.ımageList1.Images.SetKeyName(9, "add.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_okullar);
            this.tabControl1.Controls.Add(this.tabPage_veliler);
            this.tabControl1.Controls.Add(this.tabPage_ogretmenler);
            this.tabControl1.ImageList = this.ımageList1;
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 421);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage_okullar
            // 
            this.tabPage_okullar.Controls.Add(this.dgv_okullar);
            this.tabPage_okullar.ImageIndex = 8;
            this.tabPage_okullar.Location = new System.Drawing.Point(4, 30);
            this.tabPage_okullar.Name = "tabPage_okullar";
            this.tabPage_okullar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_okullar.Size = new System.Drawing.Size(621, 387);
            this.tabPage_okullar.TabIndex = 2;
            this.tabPage_okullar.Text = "Okullar";
            this.tabPage_okullar.UseVisualStyleBackColor = true;
            this.tabPage_okullar.Enter += new System.EventHandler(this.tabPage_okullar_Enter);
            // 
            // dgv_okullar
            // 
            this.dgv_okullar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_okullar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_okullar.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_okullar.Location = new System.Drawing.Point(-4, 2);
            this.dgv_okullar.Name = "dgv_okullar";
            this.dgv_okullar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_okullar.Size = new System.Drawing.Size(625, 385);
            this.dgv_okullar.TabIndex = 0;
            this.dgv_okullar.SelectionChanged += new System.EventHandler(this.dgv_okullar_SelectionChanged);
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
            // tabPage_veliler
            // 
            this.tabPage_veliler.Controls.Add(this.dgv_veliler);
            this.tabPage_veliler.ImageIndex = 8;
            this.tabPage_veliler.Location = new System.Drawing.Point(4, 30);
            this.tabPage_veliler.Name = "tabPage_veliler";
            this.tabPage_veliler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_veliler.Size = new System.Drawing.Size(621, 387);
            this.tabPage_veliler.TabIndex = 0;
            this.tabPage_veliler.Text = "Veliler";
            this.tabPage_veliler.UseVisualStyleBackColor = true;
            this.tabPage_veliler.Enter += new System.EventHandler(this.tabPage_veliler_Enter);
            // 
            // dgv_veliler
            // 
            this.dgv_veliler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_veliler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_veliler.Location = new System.Drawing.Point(0, 2);
            this.dgv_veliler.Name = "dgv_veliler";
            this.dgv_veliler.RowHeadersVisible = false;
            this.dgv_veliler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_veliler.Size = new System.Drawing.Size(625, 389);
            this.dgv_veliler.TabIndex = 0;
            this.dgv_veliler.SelectionChanged += new System.EventHandler(this.dgv_veliler_SelectionChanged);
            // 
            // tabPage_ogretmenler
            // 
            this.tabPage_ogretmenler.Controls.Add(this.dgv_ogretmenler);
            this.tabPage_ogretmenler.Controls.Add(this.listView1);
            this.tabPage_ogretmenler.ImageIndex = 8;
            this.tabPage_ogretmenler.Location = new System.Drawing.Point(4, 30);
            this.tabPage_ogretmenler.Name = "tabPage_ogretmenler";
            this.tabPage_ogretmenler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ogretmenler.Size = new System.Drawing.Size(621, 387);
            this.tabPage_ogretmenler.TabIndex = 1;
            this.tabPage_ogretmenler.Text = "Öğretmenler";
            this.tabPage_ogretmenler.UseVisualStyleBackColor = true;
            this.tabPage_ogretmenler.Enter += new System.EventHandler(this.tabPage_ogretmenler_Enter);
            // 
            // dgv_ogretmenler
            // 
            this.dgv_ogretmenler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ogretmenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ogretmenler.Location = new System.Drawing.Point(0, 0);
            this.dgv_ogretmenler.Name = "dgv_ogretmenler";
            this.dgv_ogretmenler.RowHeadersVisible = false;
            this.dgv_ogretmenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ogretmenler.Size = new System.Drawing.Size(618, 387);
            this.dgv_ogretmenler.TabIndex = 1;
            this.dgv_ogretmenler.SelectionChanged += new System.EventHandler(this.dgv_ogretmenler_SelectionChanged);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(615, 381);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dtgv_ogretmenbilgi
            // 
            this.dtgv_ogretmenbilgi.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dtgv_ogretmenbilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ogretmenbilgi.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgv_ogretmenbilgi.Location = new System.Drawing.Point(-1, 0);
            this.dtgv_ogretmenbilgi.Name = "dtgv_ogretmenbilgi";
            this.dtgv_ogretmenbilgi.Size = new System.Drawing.Size(629, 421);
            this.dtgv_ogretmenbilgi.TabIndex = 5;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.ImageList = this.ımageList1;
            this.tabControl2.Location = new System.Drawing.Point(634, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(307, 409);
            this.tabControl2.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.ogrid);
            this.tabPage3.Controls.Add(this.btn_kaydet);
            this.tabPage3.Controls.Add(this.txt_muduryrdtel);
            this.tabPage3.Controls.Add(this.txt_mudurtel);
            this.tabPage3.Controls.Add(this.txt_muduryrdad);
            this.tabPage3.Controls.Add(this.txt_mudurad);
            this.tabPage3.Controls.Add(this.txt_okulad);
            this.tabPage3.Controls.Add(this.txt_id);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(299, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Okullar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ogrid
            // 
            this.ogrid.AutoSize = true;
            this.ogrid.Location = new System.Drawing.Point(52, 33);
            this.ogrid.Name = "ogrid";
            this.ogrid.Size = new System.Drawing.Size(38, 15);
            this.ogrid.TabIndex = 15;
            this.ogrid.Text = "ogrid";
            this.ogrid.Visible = false;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.ImageIndex = 3;
            this.btn_kaydet.ImageList = this.ımageList1;
            this.btn_kaydet.Location = new System.Drawing.Point(159, 230);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(100, 35);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_muduryrdtel
            // 
            this.txt_muduryrdtel.Location = new System.Drawing.Point(159, 183);
            this.txt_muduryrdtel.Name = "txt_muduryrdtel";
            this.txt_muduryrdtel.Size = new System.Drawing.Size(100, 23);
            this.txt_muduryrdtel.TabIndex = 11;
            // 
            // txt_mudurtel
            // 
            this.txt_mudurtel.Location = new System.Drawing.Point(159, 153);
            this.txt_mudurtel.Name = "txt_mudurtel";
            this.txt_mudurtel.Size = new System.Drawing.Size(100, 23);
            this.txt_mudurtel.TabIndex = 10;
            // 
            // txt_muduryrdad
            // 
            this.txt_muduryrdad.Location = new System.Drawing.Point(159, 123);
            this.txt_muduryrdad.Name = "txt_muduryrdad";
            this.txt_muduryrdad.Size = new System.Drawing.Size(100, 23);
            this.txt_muduryrdad.TabIndex = 9;
            // 
            // txt_mudurad
            // 
            this.txt_mudurad.Location = new System.Drawing.Point(159, 93);
            this.txt_mudurad.Name = "txt_mudurad";
            this.txt_mudurad.Size = new System.Drawing.Size(100, 23);
            this.txt_mudurad.TabIndex = 8;
            // 
            // txt_okulad
            // 
            this.txt_okulad.Location = new System.Drawing.Point(159, 63);
            this.txt_okulad.Name = "txt_okulad";
            this.txt_okulad.Size = new System.Drawing.Size(100, 23);
            this.txt_okulad.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(159, 30);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(54, 23);
            this.txt_id.TabIndex = 6;
            this.txt_id.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Müdür Yrd. Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Müdür Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Müdür Yardımcısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müdür Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Okul Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 9;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(201, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Yeni Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 422);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dtgv_ogretmenbilgi);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rehber";
            this.Text = "Rehber";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rehber_Load);
            this.Shown += new System.EventHandler(this.Rehber_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_okullar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_okullar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage_veliler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veliler)).EndInit();
            this.tabPage_ogretmenler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ogretmenler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ogretmenbilgi)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_veliler;
        private System.Windows.Forms.DataGridView dgv_veliler;
        private System.Windows.Forms.TabPage tabPage_ogretmenler;
        private System.Windows.Forms.DataGridView dgv_ogretmenler;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage_okullar;
        private System.Windows.Forms.DataGridView dgv_okullar;
        private System.Windows.Forms.DataGridView dtgv_ogretmenbilgi;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_muduryrdtel;
        private System.Windows.Forms.TextBox txt_mudurtel;
        private System.Windows.Forms.TextBox txt_muduryrdad;
        private System.Windows.Forms.TextBox txt_mudurad;
        private System.Windows.Forms.TextBox txt_okulad;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label ogrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
    }
}