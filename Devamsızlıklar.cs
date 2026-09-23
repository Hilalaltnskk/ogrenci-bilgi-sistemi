using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

using System.IO;

namespace OgrenciBilgiSistemi.cs
{
    public partial class Devamsızlıklar : Form
    {

        string connection = "Server=localhost;database=ogrencibilgisistemi;Uid=root;password=123Hilal123.;";
        MySqlConnection baglanti = new MySqlConnection();
        public Devamsızlıklar()
        {
            InitializeComponent();
            baglanti.ConnectionString = connection;
        }

        private void Devamsızlıklar_Load(object sender, EventArgs e)
        {

            devamsizlikgetir();
            sınıfgetir();
            dgv_devamsizlik.Columns[0].Visible = false;
            lbl_ogretmenad.Text = GirisYapanBilgileri.AdSoyad;
            lbl_brans.Text = GirisYapanBilgileri.Brans;
            lbl_tc.Text = GirisYapanBilgileri.TC;
            pictureBox1.ImageLocation = GirisYapanBilgileri.Foto;
        }
        void devamsizlikgetir()
        {
            baglanti.Open();
            string query = " SELECT * FROM devamsızlıklar";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_devamsizlik.DataSource = dataTable;
            baglanti.Close();
        }
        void sınıfgetir()
        {
            baglanti.Open();
            string query = "SELECT DISTINCT ogrenciSINIF FROM ogrenciler";
            MySqlCommand cmd = new MySqlCommand(query, baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmb_dvmsinif.Items.Add(reader.GetString(0));
            }

            baglanti.Close();
        }
        void temizle()
        {
            txt_dvmid.Clear();
            cmb_dvmsinif.Text = null;
            cmb_dvmadsoyad.Text = null;
            dateTimePicker1.Value = DateTime.Now;
            txt_dvmdurum.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void cmb_dvmsinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }
            cmb_dvmadsoyad.Items.Clear();

            string selectedSinif = cmb_dvmsinif.SelectedItem != null ? cmb_dvmsinif.SelectedItem.ToString() : string.Empty;
            string query = "SELECT CONCAT(ogrenciAD, ' ', ogrenciSOYAD) AS ogrenciADSOYAD, ogrenciTC FROM ogrenciler WHERE ogrenciSINIF = @sinif";
            MySqlCommand komut = new MySqlCommand(query, baglanti);
            komut.Parameters.AddWithValue("@sinif", selectedSinif);

            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_dvmadsoyad.Items.Add(dr["ogrenciADSOYAD"].ToString());

            }
            dr.Close();
            baglanti.Close();
        }

        private void dgv_devamsizlik_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_devamsizlik.CurrentRow != null)
            {
                txt_dvmid.Text = dgv_devamsizlik.CurrentRow.Cells[0].Value.ToString();
                cmb_dvmadsoyad.Text = dgv_devamsizlik.CurrentRow.Cells[1].Value.ToString();
                cmb_dvmsinif.Text = dgv_devamsizlik.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text = dgv_devamsizlik.CurrentRow.Cells[3].Value.ToString();
                txt_dvmdurum.Text = dgv_devamsizlik.CurrentRow.Cells[4].Value.ToString();
                string tur = dgv_devamsizlik.CurrentRow.Cells[5].Value.ToString();
                if (tur == "İzinli")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else if (tur == "İzinsiz")
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
                else
                {
                    // Belirli bir durum yoksa, her ikisini de temizleyin
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                }

                dgv_devamsizlik.Columns["devamsızlıkADSOYAD"].HeaderText = "Ad Soyad";
                dgv_devamsizlik.Columns["devamsızlıkSINIF"].HeaderText = "Sınıf";
                dgv_devamsizlik.Columns["devamsızlıkTARİH"].HeaderText = "Tarih";
                dgv_devamsizlik.Columns["devamsızlıkDURUM"].HeaderText = "Devamsızlık Durum";
                dgv_devamsizlik.Columns["devamsızlıkTUR"].HeaderText = "Devamsızlık Tür";
            }
        }
        public string tur;
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                {
                    if (ogrid.Text == "0")
                    {
                        if (!String.IsNullOrEmpty(txt_dvmid.Text))
                        {
                            DialogResult result = MessageBox.Show("Yeni bir güncelleme yapılacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "UPDATE devamsızlıklar SET devamsızlıkADSOYAD=@p1, devamsızlıkSINIF=@p2,  devamsızlıkTARİH=@p3, devamsızlıkDURUM=@p4, devamsızlıkTUR=@p5 WHERE devamsızlıkID=@p6";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", cmb_dvmadsoyad.Text);
                                komut.Parameters.AddWithValue("@p2", cmb_dvmsinif.Text);
                                komut.Parameters.AddWithValue("@p3", dateTimePicker1.Text);
                                komut.Parameters.AddWithValue("@p4", "Gelmedi");
                                if (radioButton1.Checked == true)
                                {
                                    komut.Parameters.AddWithValue("@p5", tur = "İzinli");
                                }
                                else
                                {
                                    komut.Parameters.AddWithValue("@p5", tur = "İzinsiz");
                                }
                                komut.Parameters.AddWithValue("@p6", txt_dvmid.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();

                                MessageBox.Show("Devamsızlık Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                devamsizlikgetir();
                                temizle();
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string query = "INSERT INTO devamsızlıklar (devamsızlıkADSOYAD, devamsızlıkSINIF, devamsızlıkTARİH, devamsızlıkDURUM, devamsızlıkTUR) VALUES (@p1, @p2, @p3, @p4, @p5)";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", cmb_dvmadsoyad.Text);
                                komut.Parameters.AddWithValue("@p2", cmb_dvmsinif.Text);
                                komut.Parameters.AddWithValue("@p3", dateTimePicker1.Text);
                                komut.Parameters.AddWithValue("@p4", "Gelmedi");

                                if (radioButton1.Checked == true)
                                {
                                    komut.Parameters.AddWithValue("@p5", tur = "İzinli");
                                }
                                else
                                {
                                    komut.Parameters.AddWithValue("@p5", tur = "İzinsiz");
                                }

                                komut.ExecuteNonQuery();
                                baglanti.Close();

                                MessageBox.Show("Devamsızlık Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                devamsizlikgetir();
                                temizle();
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



        private void Devamsızlıklar_Shown(object sender, EventArgs e)
        {
            ogrid.Text = "0";
            temizle();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_devamsizlik.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_devamsizlik.SelectedRows[0].Cells["devamsızlıkID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM devamsızlıklar WHERE devamsızlıkID = @devamsızlıkID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@devamsızlıkID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_devamsizlik.Rows.RemoveAt(dgv_devamsizlik.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}

