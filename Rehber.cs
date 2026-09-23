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

namespace OgrenciBilgiSistemi.cs
{

    public partial class Rehber : Form
    {
        string conneciton = "Server= localhost;Uid= root;Pwd= 123Hilal123.;Database= ogrencibilgisistemi";
        MySqlConnection baglanti = new MySqlConnection();


        public Rehber()
        {
            InitializeComponent();
            baglanti.ConnectionString = conneciton;

        }

        private void Rehber_Load(object sender, EventArgs e)
        {
            listele();
            dgv_okullar.Columns[0].Visible = false;

        }
        void listele()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                //veliler
                string query = "SELECT CONCAT(ot.ogrenciAD, ' ', ot.ogrenciSOYAD) AS OgrenciADSOYAD, ot.ogrenciSINIF,CONCAT(vt.velilerANNE, ' ', vt.velilerBABA) AS veliADSOYAD, vt.veliTEL1, vt.veliTEL2 FROM ogrenciler ot INNER JOIN veliler vt ON ot.ogrenciID = vt.velilerID";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_veliler.DataSource = dataTable;
                //ogretmenler
                string query1 = "SELECT CONCAT(ogretmenAD, ' ', ogretmenSOYAD) AS ogretmenAdSoyad, ogretmenBRANS,ogretmenTEL FROM ogretmenler";
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(query1, baglanti);
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                dgv_ogretmenler.DataSource = dataTable1;
                //okullar
                string query2 = "SELECT * FROM rehberokul";
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, baglanti);
                DataTable datatable2 = new DataTable();
                adapter2.Fill(datatable2);
                dgv_okullar.DataSource = datatable2;

                baglanti.Close();
            }
        }
        void temizle()
        {
            txt_id.Text = null;
            txt_okulad.Text = null;
            txt_mudurad.Text = null;
            txt_muduryrdad.Text = null;
            txt_mudurtel.Text = null;
            txt_muduryrdtel.Text = null;
        }

        private void dgv_okullar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_okullar.CurrentRow != null)
            {
                txt_id.Text = dgv_okullar.CurrentRow.Cells[0].Value.ToString();
                txt_okulad.Text = dgv_okullar.CurrentRow.Cells[1].Value.ToString();
                txt_mudurad.Text = dgv_okullar.CurrentRow.Cells[2].Value.ToString();
                txt_muduryrdad.Text = dgv_okullar.CurrentRow.Cells[3].Value.ToString();
                txt_mudurtel.Text = dgv_okullar.CurrentRow.Cells[4].Value.ToString();
                txt_muduryrdtel.Text = dgv_okullar.CurrentRow.Cells[5].Value.ToString();

                dgv_okullar.Columns[0].HeaderText = "ID";
                dgv_okullar.Columns[1].HeaderText = "Okul Ad";
                dgv_okullar.Columns[2].HeaderText = "Müdür Ad";
                dgv_okullar.Columns[3].HeaderText = "Müdür Yardımcısı Ad";
                dgv_okullar.Columns[4].HeaderText = "Müdür Telefon Numarası";
                dgv_okullar.Columns[5].HeaderText = "Müdür Yardımcısı Telefon Numarası";
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    if (ogrid.Text == "0")
                    {
                        if (!String.IsNullOrEmpty(txt_id.Text))
                        {
                            DialogResult result = MessageBox.Show("Yeni bir güncelleme yapılacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "UPDATE rehberokul SET rehberokulAD=@p1, mudurAD=@p2, muduryrdAD=@p3, mudurTEL=@p4, muduryrdTEL=@p5  WHERE rehberokulID=@p6";

                                MySqlCommand komut = new MySqlCommand(query, baglanti);

                                komut.Parameters.AddWithValue("@p1", txt_okulad.Text);
                                komut.Parameters.AddWithValue("@p2", txt_mudurad.Text);
                                komut.Parameters.AddWithValue("@p3", txt_muduryrdad.Text);
                                komut.Parameters.AddWithValue("@p4", txt_mudurtel.Text);
                                komut.Parameters.AddWithValue("@p5", txt_muduryrdtel.Text);
                                komut.Parameters.AddWithValue("@p6", txt_id.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Rehber Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                                temizle();
                            }
                        }
                        else
                        {

                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string query = "INSERT INTO rehberokul (rehberokulAD, mudurAD, muduryrdAD, mudurTEL, muduryrdTEL ) VALUES (@p1, @p2, @p3, @p4, @p5)";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", txt_okulad.Text);
                                komut.Parameters.AddWithValue("@p2", txt_mudurad.Text);
                                komut.Parameters.AddWithValue("@p3", txt_muduryrdad.Text);
                                komut.Parameters.AddWithValue("@p4", txt_mudurtel.Text);
                                komut.Parameters.AddWithValue("@p5", txt_muduryrdtel.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Rehbere Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgv_veliler_SelectionChanged(object sender, EventArgs e)
        {
            dgv_veliler.Columns[0].HeaderText = "Öğrenci Ad Soyad";
            dgv_veliler.Columns[1].HeaderText = "Anne-Baba Ad Soyad";
            dgv_veliler.Columns[2].HeaderText = "Anne Telefon Numara";
            dgv_veliler.Columns[3].HeaderText = "Baba Telefon Numara";
            dgv_veliler.Columns[4].HeaderText = "E-Mail";

        }

        private void tabPage_veliler_Enter(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
        }

        private void tabPage_ogretmenler_Enter(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
        }

        private void Rehber_Shown(object sender, EventArgs e)
        {

            ogrid.Text = "0";
            temizle();
        }

        private void tabPage_okullar_Enter(object sender, EventArgs e)
        {

            tabControl2.Visible = true;

        }

        private void dgv_ogretmenler_SelectionChanged(object sender, EventArgs e)
        {
            dgv_ogretmenler.Columns[0].HeaderText = "Ad Soyad";
            dgv_ogretmenler.Columns[1].HeaderText = "Branş";
            dgv_ogretmenler.Columns[2].HeaderText = "Telefon Numarası";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_okullar.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_okullar.SelectedRows[0].Cells["rehberokulID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM rehberokul WHERE rehberokulID = @rehberokulID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@rehberokulID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_okullar.Rows.RemoveAt(dgv_okullar.SelectedRows[0].Index);
                    baglanti.Close();
                    temizle();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
