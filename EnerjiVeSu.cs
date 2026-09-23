using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi.cs
{
    public partial class EnerjiVeSu : Form
    {
        public EnerjiVeSu()
        {
            InitializeComponent();
        }

        private void EnerjiVeSu_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://ebelge.gib.gov.tr/anasayfa.html"); // WebBrowser kontrolüne bir URL yükleyin

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
