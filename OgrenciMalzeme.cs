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

namespace OgrenciBilgiSistemi.cs
{
    public partial class OgrenciMalzeme : Form
    {
        string connection = "Server=localhost;database=ogrencibilgisistemi;Uid=root;password=123Hilal123.;";
        MySqlConnection baglanti = new MySqlConnection();
        public OgrenciMalzeme()
        {
            InitializeComponent();
            baglanti.ConnectionString = connection;
        }

        private void OgrenciMalzeme_Load(object sender, EventArgs e)
        {
            listele();
            dgv_ogrencimalzeme.Columns[0].Visible = false;
            dgv_ogrencimalzeme.Columns[0].Visible = false;
            dgv_ogrencimalzeme.Columns["malzemeTARİH"].HeaderText = "Tarih";
            dgv_ogrencimalzeme.Columns["malzemeRESİM"].HeaderText = "Resim ve Sanat Malzemeleri";
            dgv_ogrencimalzeme.Columns["malzemeSPOR"].HeaderText = "Spor Malzemeleri";
            dgv_ogrencimalzeme.Columns["malzemeKUTUPHANE"].HeaderText = "Kütüphane Kaynakları";
            dgv_ogrencimalzeme.Columns["malzemeLABORATUVAR"].HeaderText = "Laboratuvar Malzemeleri";
            dgv_ogrencimalzeme.Columns["malzemeEGİTİM"].HeaderText = "Eğitim Teknolojileri";
            dgv_ogrencimalzeme.Columns["malzemeTOPLAM"].HeaderText = "Toplam";
        }
        void listele()
        {
            baglanti.Open();

            string query = "SELECT * FROM ogrencimalzeme";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv_ogrencimalzeme.DataSource = datatable;

            baglanti.Close();

        }
        void Temizle()
        {
            txt_id.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txt_resimmal.Clear();
            txt_spormal.Clear();
            txt_kutuphanemal.Clear();
            txt_labaratuvarmal.Clear();
            txt_egitimmal.Clear();
            txt_toplam.Clear();
            cbx_resimmal.Checked = false;
            cbx_spormal.Checked = false;
            cbx_kutuphanemal.Checked = false;
            cbx_labaratuvarmal.Checked = false;
            cbx_egitimmal.Checked = false;
        }
        private void dgv_ogrencimalzeme_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_ogrencimalzeme.CurrentRow != null)
            {
                txt_id.Text = dgv_ogrencimalzeme.CurrentRow.Cells[0].Value.ToString();
                dateTimePicker1.Text = dgv_ogrencimalzeme.CurrentRow.Cells[1].Value.ToString();
                txt_resimmal.Text = dgv_ogrencimalzeme.CurrentRow.Cells[2].Value.ToString();
                txt_spormal.Text = dgv_ogrencimalzeme.CurrentRow.Cells[3].Value.ToString();
                txt_kutuphanemal.Text = dgv_ogrencimalzeme.CurrentRow.Cells[4].Value.ToString();
                txt_labaratuvarmal.Text = dgv_ogrencimalzeme.CurrentRow.Cells[5].Value.ToString();
                txt_egitimmal.Text = dgv_ogrencimalzeme.CurrentRow.Cells[6].Value.ToString();
                txt_toplam.Text = dgv_ogrencimalzeme.CurrentRow.Cells[7].Value.ToString();
            }

        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            double resim = (cbx_resimmal.Checked) ? Convert.ToDouble(txt_resimmal.Text) : 0.00;
            double spor = (cbx_spormal.Checked) ? Convert.ToDouble(txt_spormal.Text) : 0.00;
            double kutuphane = (cbx_kutuphanemal.Checked) ? Convert.ToDouble(txt_kutuphanemal.Text) : 0.00;
            double labaratuvar = (cbx_labaratuvarmal.Checked) ? Convert.ToDouble(txt_labaratuvarmal.Text) : 0.00;
            double egitim = (cbx_egitimmal.Checked) ? Convert.ToDouble(txt_egitimmal.Text) : 0.00;

            double gider = 0; // Toplam giderleri başlat
            if (cbx_resimmal.Checked)
            {

                gider += resim;
            }

            if (cbx_spormal.Checked)
            {

                gider += spor;
            }
            if (cbx_kutuphanemal.Checked)
            {

                gider += kutuphane;
            }
            if (cbx_labaratuvarmal.Checked)
            {

                gider += labaratuvar;
            }
            if (cbx_egitimmal.Checked)
            {

                gider += egitim;
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
                                string query = "UPDATE ogrencimalzeme SET malzemeTARİH=@p1, malzemeRESİM=@p2, malzemeSPOR=@p3, malzemeKUTUPHANE=@p4, malzemeLABORATUVAR=@p5, malzemeEGİTİM=@p6, malzemeTOPLAM=@p7 WHERE malzemeID=@p8";

                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
                                komut.Parameters.AddWithValue("@p2", txt_resimmal.Text);
                                komut.Parameters.AddWithValue("@p3", txt_spormal.Text);
                                komut.Parameters.AddWithValue("@p4", txt_kutuphanemal.Text);
                                komut.Parameters.AddWithValue("@p5", txt_labaratuvarmal.Text);
                                komut.Parameters.AddWithValue("@p6", txt_egitimmal.Text);
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
                                Temizle();
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string query = "INSERT INTO ogrencimalzeme (malzemeTARİH,malzemeRESİM,malzemeSPOR,malzemeKUTUPHANE,malzemeLABORATUVAR,malzemeEGİTİM,malzemeTOPLAM) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
                                komut.Parameters.AddWithValue("@p2", txt_resimmal.Text);
                                komut.Parameters.AddWithValue("@p3", txt_spormal.Text);
                                komut.Parameters.AddWithValue("@p4", txt_kutuphanemal.Text);
                                komut.Parameters.AddWithValue("@p5", txt_labaratuvarmal.Text);
                                komut.Parameters.AddWithValue("@p6", txt_egitimmal.Text);

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
                                Temizle();
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
    

        private void cbx_resimmal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_resimmal.Checked)
            {
                txt_resimmal.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_resimmal.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_spormal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_spormal.Checked)
            {
                txt_spormal.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_spormal.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_kutuphanemal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_kutuphanemal.Checked)
            {
                txt_kutuphanemal.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_kutuphanemal.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_labaratuvarmal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_labaratuvarmal.Checked)
            {
                txt_labaratuvarmal.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_labaratuvarmal.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void cbx_egitimmal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_egitimmal.Checked)
            {
                txt_egitimmal.Enabled = true; // CheckBox işaretliyse TextBox'i etkinleştir
            }
            else
            {
                txt_egitimmal.Enabled = false; // CheckBox işaretsizse TextBox'i devre dışı bırak
            }
        }

        private void OgrenciMalzeme_Shown(object sender, EventArgs e)
        {
            ogrid.Text = "0";
            Temizle();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_ogrencimalzeme.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_ogrencimalzeme.SelectedRows[0].Cells["malzemeID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM ogrencimalzeme WHERE malzemeID = @malzemeID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@malzemeID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_ogrencimalzeme.Rows.RemoveAt(dgv_ogrencimalzeme.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}