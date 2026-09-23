using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace OgrenciBilgiSistemi.cs
{
    public partial class İstatistikler : Form
    {

        string connection = "Server=localhost;database=ogrencibilgisistemi;Uid=root;password=123Hilal123.;";
        MySqlConnection baglanti = new MySqlConnection();
        public İstatistikler()
        {
            InitializeComponent();
            baglanti.ConnectionString = connection;
        }

        private void İstatistikler_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            string query = "SELECT notBRANS, AVG(ortalama) as ortalama FROM notlar GROUP BY notBRANS";

            MySqlCommand cmd = new MySqlCommand(query, baglanti);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            chart1.Series.Clear();
            chart1.Series.Add("Öğrenci Ders Başarı Ortalamaları");
            chart1.Series["Öğrenci Ders Başarı Ortalamaları"].Points.DataBind(dataTable.AsEnumerable(), "notBRANS", "ortalama", "");

            string query1 = "SELECT basaridurum, COUNT(*) as sayi FROM notlar GROUP BY basaridurum";

            MySqlCommand komut = new MySqlCommand(query1, baglanti);
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(komut);

            DataTable dataTable1 = new DataTable();

            adapter1.Fill(dataTable1);

            // Toplam sayıyı hesaplayın
            int toplamSayi = Convert.ToInt32(dataTable1.Compute("SUM(sayi)", ""));

            // Grafik nesnesini temizleyin (varsa)
            chart2.Series.Clear();
            chart2.Titles.Clear();

            // Yeni bir seri oluşturun
            Series seri = new Series();
            seri.ChartType = SeriesChartType.Pie;
            seri.IsValueShownAsLabel = true;
            seri.LabelFormat = "#0.00%";

            // Her bir veri noktasını ekleyin
            foreach (DataRow row in dataTable1.Rows)
            {
                string basaridurum = row["basaridurum"].ToString();
                int sayi = Convert.ToInt32(row["sayi"]);
                double yuzde = (double)sayi / toplamSayi;

                // Veri noktasını ekle
                seri.Points.AddXY(basaridurum, yuzde);
                seri.Points.Last().Label = basaridurum + " (" + (yuzde * 100).ToString("0.00") + "%)";
            }

            // Seriyi grafiğe ekleyin
            chart2.Series.Add(seri);
            chart2.Titles.Add("Başarı Durumu Dağılımı");

            // Grafiği güncelleyin
            chart2.Invalidate();


            string query2 = "SELECT notADSOYAD, AVG(ortalama) as ortalama FROM notlar GROUP BY notADSOYAD ORDER BY ortalama DESC";

            MySqlCommand komut2 = new MySqlCommand(query2, baglanti);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(komut2);

            DataTable dataTable2 = new DataTable();

            adapter2.Fill(dataTable2);

            dataTable2.Columns.Add("Başarı Sıralaması"); // Yeni bir sütun oluşturun

            for (int i = 0; i < dataTable2.Rows.Count; i++)
            {
                dataTable2.Rows[i]["Başarı Sıralaması"] = i + 1;
            }

            dataGridView1.DataSource = dataTable2;
            dataGridView1.Columns["notADSOYAD"].HeaderText = "Öğrenci Adı Soyadı";
            dataGridView1.Columns["ortalama"].HeaderText = "Ortalama";
            dataGridView1.Columns["Başarı Sıralaması"].HeaderText = "Sıralama";

        }

    }
}
    

