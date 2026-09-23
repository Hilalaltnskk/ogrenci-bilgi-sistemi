using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace OgrenciBilgiSistemi.cs
{
    public partial class Veliler : Form
    {
        string conneciton = "Server=localhost;uid=root;password=123Hilal123.;database=ogrencibilgisistemi";
        MySqlConnection baglanti = new MySqlConnection();
        public Veliler()
        {
            InitializeComponent();
            baglanti.ConnectionString = conneciton;
            listele();
        }
        void listele()
        {


            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                string query = "Select  * from veliler";

                MySqlCommand cmd = new MySqlCommand(query, baglanti);


                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_veliler.DataSource = dataTable;
                baglanti.Close();
            }
        }
        void temizle()
        {
            txt_ıd.Text = null;
            txt_annead.Text = null;
            txt_babaad.Text = null;
            txt_telno.Text = null;
            txt_telno2.Text = null;
            txt_mail.Text = null;

        }
        private void Veliler_Load(object sender, EventArgs e)
        {
            dgv_veliler.Columns[0].Visible = false;
            dgv_veliler.Columns["velilerID"].HeaderText = "ID";
            dgv_veliler.Columns["velilerANNE"].HeaderText = "Anne Adı";
            dgv_veliler.Columns["velilerBABA"].HeaderText = "Baba Adı";
            dgv_veliler.Columns["veliTEL1"].HeaderText = "Telefon Numarası-1";
            dgv_veliler.Columns["veliTEL2"].HeaderText = "Telefon Numarası-2";
            dgv_veliler.Columns["veliMAIL"].HeaderText = "Veli E-Mail";
        }

        private void dgv_veliler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_veliler.CurrentRow != null)
            {
                txt_ıd.Text = dgv_veliler.CurrentRow.Cells[0].Value.ToString();
                txt_annead.Text = dgv_veliler.CurrentRow.Cells[1].Value.ToString();
                txt_babaad.Text = dgv_veliler.CurrentRow.Cells[2].Value.ToString();
                txt_telno.Text = dgv_veliler.CurrentRow.Cells[3].Value.ToString();
                txt_telno2.Text = dgv_veliler.CurrentRow.Cells[4].Value.ToString();
                txt_mail.Text = dgv_veliler.CurrentRow.Cells[5].Value.ToString();
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
                        if (!String.IsNullOrEmpty(txt_ıd.Text))
                        {
                            DialogResult result = MessageBox.Show("Yeni bir güncelleme yapılacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "UPDATE veliler SET velilerANNE=@p1, velilerBABA=@p2, veliTEL1=@p3, veliTEL2=@p4, veliMAIL=@p5 WHERE velilerID=@p6";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", txt_annead.Text);
                                komut.Parameters.AddWithValue("@p2", txt_babaad.Text);
                                komut.Parameters.AddWithValue("@p3", txt_telno.Text);
                                komut.Parameters.AddWithValue("@p4", txt_telno2.Text);
                                komut.Parameters.AddWithValue("@p5", txt_mail.Text);
                                komut.Parameters.AddWithValue("@p6", txt_ıd.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();

                                MessageBox.Show("Veli Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                listele();
                                temizle();
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                string query = "INSERT INTO veliler (velilerANNE, velilerBABA, veliTEL1, veliTEL2, veliMAIL) VALUES (@p1, @p2, @p3, @p4, @p5)";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", txt_annead.Text);
                                komut.Parameters.AddWithValue("@p2", txt_babaad.Text);
                                komut.Parameters.AddWithValue("@p3", txt_telno.Text);
                                komut.Parameters.AddWithValue("@p4", txt_telno2.Text);
                                komut.Parameters.AddWithValue("@p5", txt_mail.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();

                                MessageBox.Show("Veli Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void Veliler_Shown(object sender, EventArgs e)
        {
            ogrid.Text = "0";
            temizle();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_veliler.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_veliler.SelectedRows[0].Cells["velilerID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM veliler WHERE velilerID = @velilerID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@velilerID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_veliler.Rows.RemoveAt(dgv_veliler.SelectedRows[0].Index);
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

