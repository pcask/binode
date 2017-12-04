using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormIlkProje
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private bool isUpdate;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kisi kisi = (isUpdate) ? (Kisi)lstKisiler.SelectedItem : new Kisi();

            kisi.Ad = txtAd.Text;
            kisi.Soyad = txtSoyad.Text;
            kisi.TcKimlikNo = txtTcKimlikNo.Text;
            kisi.Uzmanlik = txtUzmanlik.Text;

            if (isUpdate)
            {
                lstKisiler.Items[lstKisiler.SelectedIndex] = kisi;
                btnEkle.Text = "Ekle";
            }
            else
                lstKisiler.Items.Add(kisi);

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTcKimlikNo.Text = "";
            txtUzmanlik.Text = "";

            isUpdate = false;
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kisi gelenKisi = lstKisiler.SelectedItem as Kisi;

            if (gelenKisi != null)
            {
                isUpdate = true;
                btnEkle.Text = "Güncelle";
                txtAd.Text = gelenKisi.Ad;
                txtSoyad.Text = gelenKisi.Soyad;
                txtTcKimlikNo.Text = gelenKisi.TcKimlikNo;
                txtUzmanlik.Text = gelenKisi.Uzmanlik;
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var seciliItem = lstKisiler.SelectedItem;
            if (seciliItem != null)
            {
                Kisi gelenKisi = seciliItem as Kisi;

                int seciliIndex = lstKisiler.SelectedIndex;

                lstKisiler.Items.RemoveAt(seciliIndex);

                gelenKisi.Ad = txtAd.Text;
                gelenKisi.Soyad = txtSoyad.Text;
                gelenKisi.TcKimlikNo = txtTcKimlikNo.Text;
                gelenKisi.Uzmanlik = txtUzmanlik.Text;

                lstKisiler.Items.Insert(seciliIndex, gelenKisi);
            }
            else
                MessageBox.Show("Lütfen Güncellenecek Kişiyi Seçiniz!!");
        }
    }
}
