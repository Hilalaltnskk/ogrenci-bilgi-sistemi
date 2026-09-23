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
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace OgrenciBilgiSistemi.cs
{
    public partial class Duyurular : Form
    {
        string conneciton = "Server= localhost;Uid= root;Pwd= 123Hilal123.;Database= ogrencibilgisistemi";
        MySqlConnection baglanti = new MySqlConnection();
        public Duyurular()
        {
            InitializeComponent();
            baglanti.ConnectionString = conneciton;
        }

        private void Duyurular_Load(object sender, EventArgs e)
        {
            bransgetir();
           
            
            Yemeklistele();
            SinavTarihlistele();
            EtkinlikListele();
           
            duyurugetir();
            dgv_yemeklistesi.Columns[0].Visible = false;
            dgv_sinavtarih.Columns[0].Visible = false;
            dgv_etkinlikler.Columns[0].Visible = false;
            dgv_duyurular.Columns[0].Visible = false;

            dgv_sinavtarih.Columns["sinavtarihleriID"].HeaderText = "ID";
            dgv_sinavtarih.Columns["sinavSINIF"].HeaderText = "Sınıf";
            dgv_sinavtarih.Columns["sinavDERS"].HeaderText = "Ders";
            dgv_sinavtarih.Columns["sinavTARİH"].HeaderText = "Tarih";
            dgv_sinavtarih.Columns["sinavSAAT"].HeaderText = "Saat";
        }
        void Yemeklistele()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                string query = "SELECT * FROM yemeklistesi";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_yemeklistesi.DataSource = dataTable;
                baglanti.Close();
            }
        }
        void SinavTarihlistele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    string query = "SELECT sinavtarihleri.sinavtarihleriID, sinavtarihleri.sinavSINIF,sinavtarihleri.sinavDERS, sinavtarihleri.sinavTARİH, sinavtarihleri.sinavSAAT FROM sinavtarihleri INNER JOIN brans ON sinavtarihleri.sinavDERS = brans.branscAD;";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_sinavtarih.DataSource = dataTable;
                    baglanti.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            
        }
        void EtkinlikListele()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                string query = "SELECT * FROM etkinlikler";
                MySqlDataAdapter adapter=new MySqlDataAdapter(query,baglanti);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_etkinlikler.DataSource = dataTable;
                baglanti .Close();
            }
        }
        void bransgetir()
        {

            baglanti.Open();
            string query = "SELECT DISTINCT branscAD FROM brans";

            MySqlCommand cmd = new MySqlCommand(query, baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();

            cmb_sinavders.Items.Clear(); 

            while (reader.Read())
            {
                cmb_sinavders.Items.Add(reader.GetString(0));
            }

            baglanti.Close();


        }
        
        void temizle()
        {
            txt_yemekıd.Clear();
            dtp_yemektarih.Value = DateTime.Now;
            rtbx_yemekmenu.Clear();
           
      
        }
        void temizle2()
        {
            txt_sinavid.Clear();
            dtp_sinavtarih.Value = DateTime.Now;
            cmb_sinavsinif.Text="";
            cmb_sinavders.Text="";
            txt_sinavsaat.Clear();
            
            
        }
        void temizle3()
        {
           
            txt_etkinlikid.Clear();
            dtp_etkinliktarih.Value = DateTime.Now;
            txt_etkinlikad.Clear();
            txt_etkinlikmekan.Clear();
            txt_etkinliksaat.Clear();
            rtbx_etkinlikaciklama.Clear();

        }
        void temizle4()
        {
            txt_duyuruid.Clear();
            rtbx_duyuru.Clear();
        }
        void duyurugetir()
        {
            baglanti.Open();
            string query = "SELECT * FROM duyurular";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_duyurular.DataSource = dataTable;

            baglanti.Close();
        }
        private void dgv_yemeklistesi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_yemekıd.Text = dgv_yemeklistesi.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_yemeklistesi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_yemeklistesi.CurrentRow != null)
            {
                txt_yemekıd.Text = dgv_yemeklistesi.CurrentRow.Cells["yemekID"].Value.ToString();
                dtp_yemektarih.Text = dgv_yemeklistesi.CurrentRow.Cells["yemekTARİH"].Value.ToString();
                rtbx_yemekmenu.Text = dgv_yemeklistesi.CurrentRow.Cells["yemekMENU"].Value.ToString();
            }

          
            dgv_yemeklistesi.Columns["yemekID"].HeaderText = "ID";
            dgv_yemeklistesi.Columns["yemekTARİH"].HeaderText = "Tarih";
            dgv_yemeklistesi.Columns["yemekMENU"].HeaderText = "Menü";
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
                        if (!String.IsNullOrEmpty(txt_yemekıd.Text))
                        {
                            DialogResult result = MessageBox.Show("Yeni bir güncelleme yapılacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "UPDATE yemeklistesi SET yemekTARİH=@p1, yemekMENU=@p2  WHERE yemekID=@p3";

                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", dtp_yemektarih.Text);
                                komut.Parameters.AddWithValue("@p2", rtbx_yemekmenu.Text);
                                komut.Parameters.AddWithValue("@p3", txt_yemekıd.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();

                                MessageBox.Show("Liste Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Yemeklistele();
                                temizle();

                            }

                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "INSERT INTO yemeklistesi (yemekTARİH,yemekMENU) VALUES (@p1,@p2)";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", dtp_yemektarih.Text);
                                komut.Parameters.AddWithValue("@p2", rtbx_yemekmenu.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Listeye Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Yemeklistele();
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

        private void dgv_sinavtarih_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_sinavid.Text = dgv_sinavtarih.CurrentRow.Cells[0].Value.ToString();
        }

       
        private void btn_sinavkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    if (ogrid1.Text == "0")
                    {
                        if (!String.IsNullOrEmpty(txt_sinavid.Text))
                        {
                            DialogResult result = MessageBox.Show("Yeni bir güncelleme yapılacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "UPDATE sinavtarihleri SET sinavSINIF=@p1, sinavDERS=@p2,sinavTARİH=@p3,sinavSAAT=@p4  WHERE sinavtarihleriID=@p5";

                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", cmb_sinavsinif.Text);
                                komut.Parameters.AddWithValue("@p2", cmb_sinavders.Text);
                                komut.Parameters.AddWithValue("@p3", dtp_sinavtarih.Text);
                                komut.Parameters.AddWithValue("@p4", txt_sinavsaat.Text);
                                komut.Parameters.AddWithValue("@p5", txt_sinavid.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();

                                MessageBox.Show("Liste Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SinavTarihlistele();
                                temizle2();

                            }

                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "INSERT INTO sinavtarihleri (sinavSINIF, sinavDERS, sinavTARİH, sinavSAAT) VALUES (@sinavSINIF, @sinavDERS, @sinavTARİH, @sinavSAAT);";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);

                                komut.Parameters.AddWithValue("@sinavSINIF", cmb_sinavsinif.Text);
                                komut.Parameters.AddWithValue("@sinavDERS", cmb_sinavders.Text);
                                komut.Parameters.AddWithValue("@sinavTARİH", dtp_sinavtarih.Text);
                                komut.Parameters.AddWithValue("@sinavSAAT", txt_sinavsaat.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();
                                MessageBox.Show("Listeye Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SinavTarihlistele();
                                temizle2();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_sinavtarih.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_sinavtarih.SelectedRows[0].Cells["sinavtarihleriID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM sinavtarihleri WHERE sinavtarihleriID = @sinavtarihleriID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@sinavtarihleriID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_sinavtarih.Rows.RemoveAt(dgv_sinavtarih.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void Duyurular_Shown(object sender, EventArgs e)
        {
            ogrid.Text = "0";
            ogrid1.Text = "0";
            ogrid2.Text = "0";
            ogrid3.Text = "0";
            temizle();
            temizle2();
            temizle3();
            temizle4();
        }

        private void dgv_etkinlikler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_etkinlikid.Text = dgv_etkinlikler.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_etkinlikler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_etkinlikler.CurrentRow != null)
            {
                txt_etkinlikid.Text = dgv_etkinlikler.CurrentRow.Cells["etkinliklerID"].Value.ToString();
                txt_etkinlikad.Text = dgv_etkinlikler.CurrentRow.Cells["etkinlikAD"].Value.ToString();
                dtp_etkinliktarih.Text = dgv_etkinlikler.CurrentRow.Cells["etkinlikTARİH"].Value.ToString();
                txt_etkinliksaat.Text = dgv_etkinlikler.CurrentRow.Cells["etkinlikSAAT"].Value.ToString();
                txt_etkinlikmekan.Text = dgv_etkinlikler.CurrentRow.Cells["etkinlikMEKAN"].Value.ToString();
                rtbx_etkinlikaciklama.Text = dgv_etkinlikler.CurrentRow.Cells["etkinlikACİKLAMA"].Value.ToString();
            }

            // Sütun başlıklarını güncellemek için bu kodu kullanabilirsiniz
            dgv_etkinlikler.Columns["etkinliklerID"].HeaderText = "ID";
            dgv_etkinlikler.Columns["etkinlikAD"].HeaderText = "Etkinlik Ad";
            dgv_etkinlikler.Columns["etkinlikTARİH"].HeaderText = "Tarih";
            dgv_etkinlikler.Columns["etkinlikSAAT"].HeaderText = "Saat";
            dgv_etkinlikler.Columns["etkinlikMEKAN"].HeaderText = "Mekan";
            dgv_etkinlikler.Columns["etkinlikACİKLAMA"].HeaderText = "Açıklama";

        }

        private void btn_etkinlikkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    if (ogrid2.Text == "0")
                    {
                        if (!String.IsNullOrEmpty(txt_etkinlikid.Text))
                        {
                            DialogResult result = MessageBox.Show("Yeni bir güncelleme yapılacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "UPDATE etkinlikler SET etkinlikAD=@p1, etkinlikTARİH=@p2,etkinlikSAAT=@p3,etkinlikMEKAN=@p4,etkinlikACİKLAMA=@p5 WHERE etkinliklerID=@p6";

                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", txt_etkinlikad.Text);
                                komut.Parameters.AddWithValue("@p2", dtp_etkinliktarih.Text);
                                komut.Parameters.AddWithValue("@p3", txt_etkinliksaat.Text);
                                komut.Parameters.AddWithValue("@p4", txt_etkinlikmekan.Text);
                                komut.Parameters.AddWithValue("@p5", rtbx_etkinlikaciklama.Text);
                                komut.Parameters.AddWithValue("@p6",txt_etkinlikid.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();

                                MessageBox.Show("Liste Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                EtkinlikListele();
                                temizle3();

                            }

                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "INSERT INTO etkinlikler (etkinlikAD,etkinlikTARİH,etkinlikSAAT,etkinlikMEKAN,etkinlikACİKLAMA) VALUES (@p1,@p2,@p3,@p4,@p5)";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", txt_etkinlikad.Text);
                                komut.Parameters.AddWithValue("@p2", dtp_etkinliktarih.Text);
                                komut.Parameters.AddWithValue("@p3", txt_etkinliksaat.Text);
                                komut.Parameters.AddWithValue("@p4", txt_etkinlikmekan.Text);
                                komut.Parameters.AddWithValue("@p5", rtbx_etkinlikaciklama.Text);
                                komut.ExecuteNonQuery();

                                baglanti.Close();
                                MessageBox.Show("Listeye Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                EtkinlikListele();
                                temizle3();
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

        private void contextMenuStrip2_Click(object sender, EventArgs e)
        {
            if (dgv_yemeklistesi.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_yemeklistesi.SelectedRows[0].Cells["yemekID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM yemeklistesi WHERE yemekID = @yemekID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@yemekID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_yemeklistesi.Rows.RemoveAt(dgv_yemeklistesi.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void contextMenuStrip3_Click(object sender, EventArgs e)
        {
            if (dgv_etkinlikler.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_etkinlikler.SelectedRows[0].Cells["etkinliklerID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM etkinlikler WHERE etkinliklerID = @etkinliklerID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@etkinliklerID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_etkinlikler.Rows.RemoveAt(dgv_etkinlikler.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void dgv_duyurular_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_duyuruid.Text = dgv_duyurular.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_duyurular_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_duyurular.CurrentRow != null)
            {
                txt_duyuruid.Text = dgv_duyurular.CurrentRow.Cells["duyurularID"].Value.ToString();
                rtbx_duyuru.Text = dgv_duyurular.CurrentRow.Cells["duyurularAD"].Value.ToString();
            }
            dgv_duyurular.Columns["duyurularID"].HeaderText = "ID";
            dgv_duyurular.Columns["duyurularAD"].HeaderText = "Duyuru";
        }

        private void btn_duyurukaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    if (ogrid3.Text == "0")
                    {
                        if (!String.IsNullOrEmpty(txt_duyuruid.Text))
                        {
                            DialogResult result = MessageBox.Show("Yeni bir güncelleme yapılacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "UPDATE duyurular SET duyurularAD=@p1 WHERE duyurularID=@p2";

                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", rtbx_duyuru.Text);
                                komut.Parameters.AddWithValue("@p2", txt_duyuruid.Text);
                                komut.ExecuteNonQuery();
                                baglanti.Close();

                                MessageBox.Show("Liste Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                duyurugetir();
                                temizle4();

                            }

                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Yeni bir kayıt oluşturulacaktır. Kaydetmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                string query = "INSERT INTO duyurular (duyurularAD) VALUES (@p1)";
                                MySqlCommand komut = new MySqlCommand(query, baglanti);
                                komut.Parameters.AddWithValue("@p1", rtbx_duyuru.Text);
                                komut.ExecuteNonQuery();

                                baglanti.Close();
                                MessageBox.Show("Listeye Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                duyurugetir();
                                temizle4();
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

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (dgv_duyurular.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    baglanti.Open();

                    // Seçilen satırın benzersiz kimliğini alın
                    int selectedRowID = (int)dgv_duyurular.SelectedRows[0].Cells["duyurularID"].Value; // ID, silinecek verinin benzersiz kimliğini temsil ediyor

                    // Silme sorgusunu oluşturun ve çalıştırın
                    string deleteQuery = "DELETE FROM duyurular WHERE duyurularID = @duyurularID";
                    MySqlCommand command = new MySqlCommand(deleteQuery, baglanti);
                    command.Parameters.AddWithValue("@duyurularID", selectedRowID);
                    command.ExecuteNonQuery();

                    // DataGridView'den satırı kaldırın
                    dgv_duyurular.Rows.RemoveAt(dgv_duyurular.SelectedRows[0].Index);
                    baglanti.Close();
                }
            }
        }

        private void dgv_sinavtarih_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_sinavtarih.CurrentCell != null)
            {
                txt_sinavid.Text = dgv_sinavtarih.CurrentRow.Cells[0].Value.ToString();
                cmb_sinavsinif.Text = dgv_sinavtarih.CurrentRow.Cells[1].Value.ToString();
                cmb_sinavders.Text = dgv_sinavtarih.CurrentRow.Cells[2].Value.ToString();
                dtp_sinavtarih.Text = dgv_sinavtarih.CurrentRow.Cells[3].Value.ToString();
                txt_sinavsaat.Text = dgv_sinavtarih.CurrentRow.Cells[4].Value.ToString();
            }
           
        }

        private void btn_yenikayit_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle3();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temizle4();
        }
    }
}
