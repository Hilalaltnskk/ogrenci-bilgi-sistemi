using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OgrenciBilgiSistemi.cs
{
    public partial class YonetimVeOfis : Form
    {
        
        string connection = "Server=localhost;database=ogrencibilgisistemi;Uid=root;password=123Hilal123.;";
        MySqlConnection baglanti = new MySqlConnection();
        public YonetimVeOfis()
        {
            InitializeComponent();
            baglanti.ConnectionString = connection;
            
        }

        private void YonetimVeOfis_Load(object sender, EventArgs e)
        {
           
            listele();
            dgv_yonetimofis.Columns[0].Visible = false;
            dgv_yonetimofis.Columns[0].Visible = false;
            dgv_yonetimofis.Columns["yonetimveofisTARİH"].HeaderText = "Tarih";
            dgv_yonetimofis.Columns["sigorta"].HeaderText = "Sigorta";
            dgv_yonetimofis.Columns["idariyazilim"].HeaderText = "İdari Yazılım";
            dgv_yonetimofis.Columns["toplantiegitim"].HeaderText = "Toplantı Eğitim";
            dgv_yonetimofis.Columns["reklamtanitim"].HeaderText = "Reklam Tanıtım";
            dgv_yonetimofis.Columns["ofismobilya"].HeaderText = "Ofis Mobilya";
            dgv_yonetimofis.Columns["ofistoplam"].HeaderText = "Toplam";

        }
         void ToollarıTemizle()
        {
            txt_id.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txt_idariyazilim.Clear();
            txt_ofismobilya.Clear();
            txt_reklam.Clear();
            txt_sigorta.Clear();
            txt_toplam.Clear();
            txt_toplantiegitim.Clear();
            cbx_idariyazilim.Checked = false;
            cbx_ofismobilya.Checked = false;
            cbx_reklamtanitim.Checked = false;
            cbx_sigorta.Checked = false;
            cbx_toplantiegitim.Checked = false;
        }
        void listele()
        {
            baglanti.Open();

            string query = "SELECT * FROM yonetimveofis";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_yonetimofis.DataSource = dataTable;

            baglanti.Close();
        }
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            double sigorta = (cbx_sigorta.Checked) ? Convert.ToDouble(txt_sigorta.Text) : 0.00;
            double idariyazilim = (cbx_idariyazilim.Checked) ? Convert.ToDouble(txt_idariyazilim.Text) : 0.00;
            double toplantiegitim = (cbx_toplantiegitim.Checked) ? Convert.ToDouble(txt_toplantiegitim.Text) : 0.00;
            double reklam = (cbx_reklamtanitim.Checked) ? Convert.ToDouble(txt_reklam.Text) : 0.00;
            double ofismobilya = (cbx_ofismobilya.Checked) ? Convert.ToDouble(txt_ofismobilya.Text) : 0.00;

            double gider = 0; // Toplam giderleri başlat
            if (cbx_sigorta.Checked)
            {

                gider += sigorta;
            }

            if (cbx_idariyazilim.Checked)
            {

                gider += idariyazilim;
            }
            if (cbx_toplantiegitim.Checked)
            {

                gider += toplantiegitim;
            }
            if (cbx_reklamtanitim.Checked)
            {

                gider += reklam;
            }
            if (cbx_ofismobilya.Checked)
            {

                gider += ofismobilya;
            }

            double ort = gider;
            txt_toplam.Text = " " + ort.ToString();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                {
                    if (ogrid.Text == "0")
                    {
                        if (!String.IsNullOrEmpty(txt_id.Text))
                        {
                            DialogResult result = MessageBox.Show("Yeni bir güncelleme yapılacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "UPDATE yonetimveofis SET yonetimveofisTARİH=@p1, sigorta=@p2, idariyazilim=@p3, toplantiegitim=@p4, reklamtanitim=@p5, ofismobilya=@p6, ofistoplam=@p7 WHERE yonetimveofisID=@p8";

                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
                                komut.Parameters.AddWithValue("@p2", txt_sigorta.Text);
                                komut.Parameters.AddWithValue("@p3", txt_idariyazilim.Text);
                                komut.Parameters.AddWithValue("@p4", txt_toplantiegitim.Text);
                                komut.Parameters.AddWithValue("@p5", txt_reklam.Text);
                                komut.Parameters.AddWithValue("@p6", txt_ofismobilya.Text);
                                double ortalama = 0.0;
                                if (double.TryParse(txt_toplam.Text, out ortalama))
                                {

                                    komut.Parameters.AddWithValue("@p7", ortalama);
                                }
                                else
                                {

                                    komut.Parameters.AddWithValue("@p7", DBNull.Value);
                                }

                                komut.Parameters.AddWithValue("@p8", txt_id.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                                ToollarıTemizle();
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string query = "INSERT INTO yonetimveofis (yonetimveofisTARİH,sigorta,idariyazilim,toplantiegitim,reklamtanitim,ofismobilya,ofistoplam) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
                                komut.Parameters.AddWithValue("@p2", txt_sigorta.Text);
                                komut.Parameters.AddWithValue("@p3", txt_idariyazilim.Text);
                                komut.Parameters.AddWithValue("@p4", txt_toplantiegitim.Text);
                                komut.Parameters.AddWithValue("@p5", txt_reklam.Text);
                                komut.Parameters.AddWithValue("@p6", txt_ofismobilya.Text);

                                double ortalama = 0.0;
                                if (double.TryParse(txt_toplam.Text, out ortalama))
                                {

                                    komut.Parameters.AddWithValue("@p7", ortalama);
                                }
                                else
                                {

                                    komut.Parameters.AddWithValue("@p7", DBNull.Value);
                                }


                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Giderlere Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                                ToollarıTemizle();
                            }
                            
                        }     
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbx_sigorta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_sigorta.Checked)
            {
                txt_sigorta.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_sigorta.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_idariyazilim_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_idariyazilim.Checked)
            {
                txt_idariyazilim.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_idariyazilim.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_toplantiegitim_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_toplantiegitim.Checked)
            {
                txt_toplantiegitim.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_toplantiegitim.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_reklamtanitim_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_reklamtanitim.Checked)
            {
                txt_reklam.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_reklam.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_ofismobilya_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_ofismobilya.Checked)
            {
                txt_ofismobilya.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_ofismobilya.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_yonetimofis.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_yonetimofis.SelectedRows[0].Cells["yonetimveofisID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM yonetimveofis WHERE yonetimveofisID = @yonetimveofisID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@yonetimveofisID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_yonetimofis.Rows.RemoveAt(dgv_yonetimofis.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void dgv_yonetimofis_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_yonetimofis.CurrentRow != null)
            {
                txt_id.Text = dgv_yonetimofis.CurrentRow.Cells[0].Value.ToString();
                dateTimePicker1.Text = dgv_yonetimofis.CurrentRow.Cells[1].Value.ToString();
                txt_sigorta.Text = dgv_yonetimofis.CurrentRow.Cells[2].Value.ToString();
                txt_idariyazilim.Text = dgv_yonetimofis.CurrentRow.Cells[3].Value.ToString();
                txt_toplantiegitim.Text = dgv_yonetimofis.CurrentRow.Cells[4].Value.ToString();
                txt_reklam.Text = dgv_yonetimofis.CurrentRow.Cells[5].Value.ToString();
                txt_ofismobilya.Text = dgv_yonetimofis.CurrentRow.Cells[6].Value.ToString();
                txt_toplam.Text = dgv_yonetimofis.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void YonetimVeOfis_Shown(object sender, EventArgs e)
        {
            ogrid.Text = "0";
            ToollarıTemizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToollarıTemizle();
        }
    } 
}
