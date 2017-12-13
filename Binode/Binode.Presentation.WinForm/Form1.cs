using Binode.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binode.Presentation.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        List<Kategori> kategoriler;
        private void Form1_Load(object sender, EventArgs e)
        {
            kategoriler = DemoData.DemoKategoriGetir();
            KategoriyiTreeviewAEkle(kategoriler, null);
        }

        private void KategoriListViewEkle(TreeNode node)
        {
            Kategori tiklananKategori = node.Tag as Kategori;

            ListViewGroup lvg = new ListViewGroup(tiklananKategori.Isim);

            if (tiklananKategori.Icerik != null)
            {
                foreach (var icerik in tiklananKategori.Icerik)
                {
                    ListViewItem lvItem = new ListViewItem(lvg);

                    lvItem.Text = icerik.Isim;
                    lvItem.SubItems[0].Text = icerik.EklenmeTarihi.ToString();
                }
            }

            if (node.Nodes != null)
            {
                KategoriListViewEkle(node.Nodes[node.Nodes.Count - 1]);
            }
        }

        private void KategoriyiTreeviewAEkle(List<Kategori> kategoriler, TreeNode node)
        {
            foreach (var kategori in kategoriler)
            {
                if (node is null)
                {
                    var nnode = new TreeNode(kategori.Isim);
                    nnode.Tag = kategori;

                    treeKategori.Nodes.Add(nnode);

                    if (kategori.AltKategori != null)
                    {
                        KategoriyiTreeviewAEkle(kategori.AltKategori, nnode);
                    }
                }
                else
                {
                    node.Tag = kategori;
                    node.Nodes.Add(kategori.Isim);

                    if (kategori.AltKategori != null)
                    {
                        KategoriyiTreeviewAEkle(kategori.AltKategori, node.Nodes[node.Nodes.Count - 1]);
                        node.Nodes[node.Nodes.Count - 1].Tag = kategori;
                    }
                }
            }

        }

        private void treeKategori_AfterSelect(object sender, TreeViewEventArgs e)
        {
            KategoriListViewEkle(e.Node);
        }

        private void treeKategori_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
