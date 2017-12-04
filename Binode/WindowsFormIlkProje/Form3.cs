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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TreeNode aktifNode = tvKategoriler.SelectedNode;

            if (rdBtnAnaKategori.Checked)
                tvKategoriler.Nodes.Add(txtKategoriGiris.Text);
            else if (rdBtnAltKategori.Checked)
            {
                if (aktifNode == null)
                    MessageBox.Show("Lütfen Ana Kategori Seçiniz!");
                else
                    aktifNode.Nodes.Add(txtKategoriGiris.Text);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            TreeNode aktifNode = tvKategoriler.SelectedNode;

            tvKategoriler.Nodes.Remove(aktifNode);
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            tvKategoriler.ExpandAll();
        }

        private void btnGizle_Click(object sender, EventArgs e)
        {
            tvKategoriler.CollapseAll();
        }
    }
}
