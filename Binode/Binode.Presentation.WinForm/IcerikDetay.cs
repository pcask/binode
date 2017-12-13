using Binode.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binode.Presentation.WinForm
{
    public partial class IcerikDetay : Form
    {
        public Icerik TiklananIcerik { get; set; }
        public IcerikDetay()
        {
            InitializeComponent();
        }

        private void IcerikDetay_Load(object sender, EventArgs e)
        {
            List<Kategori> kategoriler = DemoData.DemoKategoriGetir();

            KategorileriDoldur(kategoriler, comboBox1);

            textBox1.Text = TiklananIcerik.Isim;

            comboBox1.SelectedItem = comboBox1.Items[comboBox1.Items.IndexOf(TiklananIcerik.Kategori)];
            richTextBox1.Rtf = TiklananIcerik.Content;
            lblTarih.Text = TiklananIcerik.EklenmeTarihi.ToString();
        }

        private void KategorileriDoldur(List<Kategori> kategoriler, ComboBox cmb)
        {
            foreach (var kategori in kategoriler)
            {
                cmb.Items.Add(kategori);
                if (kategori.AltKategori.Count > 0)
                    KategorileriDoldur(kategori.AltKategori, cmb);
            }
        }
    }
}
