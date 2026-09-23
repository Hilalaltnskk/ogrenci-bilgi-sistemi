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
    public partial class Ogrenciler : Form
    {
        public string dosyayolu;
        int ID;
        public Ogrenciler()
        {
            InitializeComponent();
            baglanti.ConnectionString = conneciton;
        }
        string conneciton = "Server= localhost;Uid= root;Pwd= 123Hilal123.;Database= ogrencibilgisistemi";
        MySqlConnection baglanti = new MySqlConnection();

        void listele()
        {

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                string query = "Select * From ogrenciler where ogrenciSINIF='9.Sınıf'";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
                //9.Sınıf
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_9sinif.DataSource = dataTable;

                //10.Sınıf
                string query1 = "Select * From ogrenciler where ogrenciSINIF='10.Sınıf'";

                MySqlDataAdapter adapter1 = new MySqlDataAdapter(query1, baglanti);
                DataTable dataTable2 = new DataTable();
                adapter1.Fill(dataTable2);
                dgv_10sinif.DataSource = dataTable2;

                //11.Sınıf
                string query2 = "Select * From ogrenciler where ogrenciSINIF='11.Sınıf'";

                MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, baglanti);
                DataTable dataTable3 = new DataTable();
                adapter2.Fill(dataTable3);
                dgv_11sinif.DataSource = dataTable3;

                //12.sınıf
                string query3 = "Select * From ogrenciler where ogrenciSINIF='12.Sınıf'";

                MySqlDataAdapter adapter3 = new MySqlDataAdapter(query3, baglanti);
                DataTable dataTable4 = new DataTable();
                adapter3.Fill(dataTable4);
                dgv_12sinif.DataSource = dataTable4;
                baglanti.Close();
            }
        }

        void ilekle()
        {
            baglanti.Open();
            string query = "Select  * from il";

            MySqlCommand cmd = new MySqlCommand(query, baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbx_il.Items.Add(reader.GetString(1));

            }
            baglanti.Close();

        }
        void velilistele()
        {
            baglanti.Open();
            string query = "SELECT velilerID, CONCAT(velilerANNE, '  ', velilerBABA) AS 'veliANNEBABA' FROM veliler;";
            MySqlCommand cmd = new MySqlCommand(query, baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbx_veli.Items.Add(reader.GetString(1));
            }
            baglanti.Close();

        }
        void temizle()
        {
            txt_ıd.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_ogrno.Clear();
            cmbx_sinif.Text="";
            dtp_dt.Value = DateTime.Now;
            rb_erkek.Checked = false;
            rb_kiz.Checked = false;
            cmbx_veli.Text="";
            txt_tc.Clear();
            cmbx_il.Text=null;
            cmbx_ilce.Text=null;
            rxhtxt_adres.Clear();
            pctrbx_ogretmenresim.ImageLocation = null;
        }
        private void Ogrenciler_Load(object sender, EventArgs e)
        {
            listele();
            ilekle();
            velilistele();
            dgv_9sinif.Columns["ogrenciID"].Visible = false;
            dgv_9sinif.Columns["ogrenciID"].HeaderText = "ID";
            dgv_9sinif.Columns["ogrenciAD"].HeaderText = "Ad";
            dgv_9sinif.Columns["ogrenciSOYAD"].HeaderText = "Soyad";
            dgv_9sinif.Columns["ogrenciNO"].HeaderText = "Okul No";
            dgv_9sinif.Columns["ogrenciSINIF"].HeaderText = "Sınıf";
            dgv_9sinif.Columns["ogrenciDTARİH"].HeaderText = "Doğum Tarihi";
            dgv_9sinif.Columns["ogrenciCİNSİYET"].HeaderText = "Cinsiyet";
            dgv_9sinif.Columns["ogrenciVELIID"].HeaderText = "Veli ID";
            dgv_9sinif.Columns["ogrenciTC"].HeaderText = "T.C Kimlik";
            dgv_9sinif.Columns["ogrenciIL"].HeaderText = "İl";
            dgv_9sinif.Columns["ogrenciILCE"].HeaderText = "İlçe";
            dgv_9sinif.Columns["ogrenciADRES"].HeaderText = "Adres";
            dgv_9sinif.Columns["ogrenciFOTO"].HeaderText = "Fotoğraf";

            dgv_10sinif.Columns[0].Visible = false;
            dgv_10sinif.Columns["ogrenciID"].HeaderText = "ID";
            dgv_10sinif.Columns["ogrenciAD"].HeaderText = "Ad";
            dgv_10sinif.Columns["ogrenciSOYAD"].HeaderText = "Soyad";
            dgv_10sinif.Columns["ogrenciNO"].HeaderText = "Okul No";
            dgv_10sinif.Columns["ogrenciSINIF"].HeaderText = "Sınıf";
            dgv_10sinif.Columns["ogrenciDTARİH"].HeaderText = "Doğum Tarihi";
            dgv_10sinif.Columns["ogrenciCİNSİYET"].HeaderText = "Cinsiyet";
            dgv_10sinif.Columns["ogrenciVELIID"].HeaderText = "Veli ID";
            dgv_10sinif.Columns["ogrenciTC"].HeaderText = "T.C Kimlik";
            dgv_10sinif.Columns["ogrenciIL"].HeaderText = "İl";
            dgv_10sinif.Columns["ogrenciILCE"].HeaderText = "İlçe";
            dgv_10sinif.Columns["ogrenciADRES"].HeaderText = "Adres";
            dgv_10sinif.Columns["ogrenciFOTO"].HeaderText = "Fotoğraf";

            dgv_11sinif.Columns[0].Visible = false;
            dgv_11sinif.Columns["ogrenciID"].HeaderText = "ID";
            dgv_11sinif.Columns["ogrenciAD"].HeaderText = "Ad";
            dgv_11sinif.Columns["ogrenciSOYAD"].HeaderText = "Soyad";
            dgv_11sinif.Columns["ogrenciNO"].HeaderText = "Okul No";
            dgv_11sinif.Columns["ogrenciSINIF"].HeaderText = "Sınıf";
            dgv_11sinif.Columns["ogrenciDTARİH"].HeaderText = "Doğum Tarihi";
            dgv_11sinif.Columns["ogrenciCİNSİYET"].HeaderText = "Cinsiyet";
            dgv_11sinif.Columns["ogrenciVELIID"].HeaderText = "Veli ID";
            dgv_11sinif.Columns["ogrenciTC"].HeaderText = "T.C Kimlik";
            dgv_11sinif.Columns["ogrenciIL"].HeaderText = "İl";
            dgv_11sinif.Columns["ogrenciILCE"].HeaderText = "İlçe";
            dgv_11sinif.Columns["ogrenciADRES"].HeaderText = "Adres";
            dgv_11sinif.Columns["ogrenciFOTO"].HeaderText = "Fotoğraf";

            dgv_12sinif.Columns[0].Visible = false;
            dgv_12sinif.Columns["ogrenciID"].HeaderText = "ID";
            dgv_12sinif.Columns["ogrenciAD"].HeaderText = "Ad";
            dgv_12sinif.Columns["ogrenciSOYAD"].HeaderText = "Soyad";
            dgv_12sinif.Columns["ogrenciNO"].HeaderText = "Okul No";
            dgv_12sinif.Columns["ogrenciSINIF"].HeaderText = "Sınıf";
            dgv_12sinif.Columns["ogrenciDTARİH"].HeaderText = "Doğum Tarihi";
            dgv_12sinif.Columns["ogrenciCİNSİYET"].HeaderText = "Cinsiyet";
            dgv_12sinif.Columns["ogrenciVELIID"].HeaderText = "Veli ID";
            dgv_12sinif.Columns["ogrenciTC"].HeaderText = "T.C Kimlik";
            dgv_12sinif.Columns["ogrenciIL"].HeaderText = "İl";
            dgv_12sinif.Columns["ogrenciILCE"].HeaderText = "İlçe";
            dgv_12sinif.Columns["ogrenciADRES"].HeaderText = "Adres";
            dgv_12sinif.Columns["ogrenciFOTO"].HeaderText = "Fotoğraf";


        }



        private void cmbx_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbx_ilce.Items.Clear();
            string connectionString = "Server=localhost;Database=ogrencibilgisistemi;Uid=root;Pwd=123Hilal123.;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM ilce WHERE il_no = @p1";
            MySqlCommand komut = new MySqlCommand(query, connection);
            komut.Parameters.AddWithValue("@p1", cmbx_il.SelectedIndex + 1);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbx_ilce.Items.Add(dr["isim"].ToString());
            }
        }
        public string cinsiyet;
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();

                    if (ogrid.Text == "0")
                    {
                        if (!String.IsNullOrEmpty(txt_ıd.Text))
                        {

                            DialogResult result = MessageBox.Show("Yeni bir güncelleme yapılacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "UPDATE ogrenciler SET ogrenciAD=@p1, ogrenciSOYAD=@p2,  ogrenciNO=@p3, ogrenciSINIF=@p4, ogrenciDTARİH=@p5, ogrenciCİNSİYET=@p6, ogrenciVELIID=@p7,ogrenciTC=@p8, ogrenciIL=@p9, ogrenciILCE=@p10, ogrenciADRES=@p11, ogrenciFOTO=@p12 WHERE ogrenciID=@p13";

                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", txt_ad.Text);
                                komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
                                komut.Parameters.AddWithValue("@p3", txt_ogrno.Text);
                                komut.Parameters.AddWithValue("@p4", cmbx_sinif.Text);
                                komut.Parameters.AddWithValue(@"p5", dtp_dt.Text);
                                if (rb_erkek.Checked == true)
                                {
                                    komut.Parameters.AddWithValue("@p6", cinsiyet = "E");
                                }
                                else
                                {
                                    komut.Parameters.AddWithValue("@p6", cinsiyet = "K");
                                }
                                komut.Parameters.AddWithValue("@p7", cmbx_veli.Text);
                                komut.Parameters.AddWithValue("@p8", txt_tc.Text);
                                komut.Parameters.AddWithValue("@p9", cmbx_il.Text);
                                komut.Parameters.AddWithValue("@p10", cmbx_ilce.Text);
                                komut.Parameters.AddWithValue("@p11", rxhtxt_adres.Text);
                                komut.Parameters.AddWithValue("@p12", dosyayolu);
                                komut.Parameters.AddWithValue("@p13", txt_ıd.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();

                                MessageBox.Show("Öğrenci Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                                temizle();
                            }
                        }

                        else
                        {
                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string query = "INSERT INTO ogrenciler (ogrenciAD, ogrenciSOYAD, ogrenciNO, ogrenciSINIF, ogrenciDTARİH, ogrenciCİNSİYET,ogrenciVELIID, ogrenciTC, ogrenciIL, ogrenciILCE, ogrenciADRES,ogrenciFOTO) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9,@p10,@p11,@p12)";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", txt_ad.Text);
                                komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
                                komut.Parameters.AddWithValue("@p3", txt_ogrno.Text);
                                komut.Parameters.AddWithValue("@p4", cmbx_sinif.Text);
                                komut.Parameters.AddWithValue("@p5", dtp_dt.Text);
                                if (rb_erkek.Checked == true)
                                {
                                    komut.Parameters.AddWithValue("@p6", cinsiyet = "E");
                                }
                                else
                                {
                                    komut.Parameters.AddWithValue("@p6", cinsiyet = "K");
                                }
                                komut.Parameters.AddWithValue("@p7", cmbx_veli.Text);
                                komut.Parameters.AddWithValue("@p8", txt_tc.Text);
                                komut.Parameters.AddWithValue("@p9", cmbx_il.Text);
                                komut.Parameters.AddWithValue("@p10", cmbx_ilce.Text);
                                komut.Parameters.AddWithValue("@p11", rxhtxt_adres.Text);
                                komut.Parameters.AddWithValue("@p12", dosyayolu);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
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

        private void btn_resimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            dosyayolu = dosya.FileName;
            pctrbx_ogretmenresim.ImageLocation = dosyayolu;
        }

        private void dgv_9sinif_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_9sinif.CurrentRow != null)
            {
                txt_ıd.Text = dgv_9sinif.CurrentRow.Cells[0].Value.ToString();
                txt_ad.Text = dgv_9sinif.CurrentRow.Cells[1].Value.ToString();
                txt_soyad.Text = dgv_9sinif.CurrentRow.Cells[2].Value.ToString();
                txt_ogrno.Text = dgv_9sinif.CurrentRow.Cells[3].Value.ToString();
                cmbx_sinif.Text = dgv_9sinif.CurrentRow.Cells[4].Value.ToString();
                dtp_dt.Text = dgv_9sinif.CurrentRow.Cells[5].Value.ToString();
                string cinsiyet = dgv_9sinif.CurrentRow.Cells[6].Value.ToString();
                rb_erkek.Checked = (cinsiyet == "E");
                rb_kiz.Checked = (cinsiyet == "K");
                cmbx_veli.Text = dgv_9sinif.CurrentRow.Cells[7].Value.ToString();
                txt_tc.Text = dgv_9sinif.CurrentRow.Cells[8].Value.ToString();
                cmbx_il.Text = dgv_9sinif.CurrentRow.Cells[9].Value.ToString();
                cmbx_ilce.Text = dgv_9sinif.CurrentRow.Cells[10].Value.ToString();
                rxhtxt_adres.Text = dgv_9sinif.CurrentRow.Cells[11].Value.ToString();
                pctrbx_ogretmenresim.ImageLocation = dgv_9sinif.CurrentRow.Cells[12].Value.ToString();
            }

        }

        private void dgv_10sinif_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_10sinif.CurrentRow != null)
            {
                txt_ıd.Text = dgv_10sinif.CurrentRow.Cells[0].Value.ToString();
                txt_ad.Text = dgv_10sinif.CurrentRow.Cells[1].Value.ToString();
                txt_soyad.Text = dgv_10sinif.CurrentRow.Cells[2].Value.ToString();
                txt_ogrno.Text = dgv_10sinif.CurrentRow.Cells[3].Value.ToString();
                cmbx_sinif.Text = dgv_10sinif.CurrentRow.Cells[4].Value.ToString();
                dtp_dt.Text = dgv_10sinif.CurrentRow.Cells[5].Value.ToString();
                string cinsiyet = dgv_10sinif.CurrentRow.Cells[6].Value.ToString();
                rb_erkek.Checked = (cinsiyet == "E");
                rb_kiz.Checked = (cinsiyet == "K");
                cmbx_veli.Text = dgv_10sinif.CurrentRow.Cells[7].Value.ToString();
                txt_tc.Text = dgv_10sinif.CurrentRow.Cells[8].Value.ToString();
                cmbx_il.Text = dgv_10sinif.CurrentRow.Cells[9].Value.ToString();
                cmbx_ilce.Text = dgv_10sinif.CurrentRow.Cells[10].Value.ToString();
                rxhtxt_adres.Text = dgv_10sinif.CurrentRow.Cells[11].Value.ToString();
                pctrbx_ogretmenresim.ImageLocation = dgv_10sinif.CurrentRow.Cells[12].Value.ToString();
            }



        }

        private void dgv_11sinif_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_11sinif.CurrentRow != null)
            {
                txt_ıd.Text = dgv_11sinif.CurrentRow.Cells[0].Value.ToString();
                txt_ad.Text = dgv_11sinif.CurrentRow.Cells[1].Value.ToString();
                txt_soyad.Text = dgv_11sinif.CurrentRow.Cells[2].Value.ToString();
                txt_ogrno.Text = dgv_11sinif.CurrentRow.Cells[3].Value.ToString();
                cmbx_sinif.Text = dgv_11sinif.CurrentRow.Cells[4].Value.ToString();
                dtp_dt.Text = dgv_11sinif.CurrentRow.Cells[5].Value.ToString();
                string cinsiyet = dgv_11sinif.CurrentRow.Cells[6].Value.ToString();
                rb_erkek.Checked = (cinsiyet == "E");
                rb_kiz.Checked = (cinsiyet == "K");
                cmbx_veli.Text = dgv_11sinif.CurrentRow.Cells[7].Value.ToString();
                txt_tc.Text = dgv_11sinif.CurrentRow.Cells[8].Value.ToString();
                cmbx_il.Text = dgv_11sinif.CurrentRow.Cells[9].Value.ToString();
                cmbx_ilce.Text = dgv_11sinif.CurrentRow.Cells[10].Value.ToString();
                rxhtxt_adres.Text = dgv_11sinif.CurrentRow.Cells[11].Value.ToString();
                pctrbx_ogretmenresim.ImageLocation = dgv_11sinif.CurrentRow.Cells[12].Value.ToString();
            }



        }

        private void dgv_12sinif_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_12sinif.CurrentRow != null)
            {
                txt_ıd.Text = dgv_12sinif.CurrentRow.Cells[0].Value.ToString();
                txt_ad.Text = dgv_12sinif.CurrentRow.Cells[1].Value.ToString();
                txt_soyad.Text = dgv_12sinif.CurrentRow.Cells[2].Value.ToString();
                txt_ogrno.Text = dgv_12sinif.CurrentRow.Cells[3].Value.ToString();
                cmbx_sinif.Text = dgv_12sinif.CurrentRow.Cells[4].Value.ToString();
                dtp_dt.Text = dgv_12sinif.CurrentRow.Cells[5].Value.ToString();
                string cinsiyet = dgv_12sinif.CurrentRow.Cells[6].Value.ToString();
                rb_erkek.Checked = (cinsiyet == "E");
                rb_kiz.Checked = (cinsiyet == "K");
                cmbx_veli.Text = dgv_12sinif.CurrentRow.Cells[7].Value.ToString();
                txt_tc.Text = dgv_12sinif.CurrentRow.Cells[8].Value.ToString();
                cmbx_il.Text = dgv_12sinif.CurrentRow.Cells[9].Value.ToString();
                cmbx_ilce.Text = dgv_12sinif.CurrentRow.Cells[10].Value.ToString();
                rxhtxt_adres.Text = dgv_12sinif.CurrentRow.Cells[11].Value.ToString();
                pctrbx_ogretmenresim.ImageLocation = dgv_12sinif.CurrentRow.Cells[12].Value.ToString();
            }

        }

        private void Ogrenciler_Shown(object sender, EventArgs e)
        {
            ogrid.Text = "0";
            temizle();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_9sinif.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_9sinif.SelectedRows[0].Cells["ogrenciID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM ogrenciler WHERE ogrenciID = @ogrenciID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@ogrenciID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_9sinif.Rows.RemoveAt(dgv_9sinif.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
            
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgv_10sinif.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_10sinif.SelectedRows[0].Cells["ogrenciID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM ogrenciler WHERE ogrenciID = @ogrenciID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@ogrenciID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_10sinif.Rows.RemoveAt(dgv_10sinif.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (dgv_11sinif.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_11sinif.SelectedRows[0].Cells["ogrenciID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM ogrenciler WHERE ogrenciID = @ogrenciID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@ogrenciID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_11sinif.Rows.RemoveAt(dgv_11sinif.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (dgv_12sinif.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_12sinif.SelectedRows[0].Cells["ogrenciID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM ogrenciler WHERE ogrenciID = @ogrenciID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@ogrenciID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_12sinif.Rows.RemoveAt(dgv_12sinif.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void btn_yenikayit_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
    

             
        



           
      