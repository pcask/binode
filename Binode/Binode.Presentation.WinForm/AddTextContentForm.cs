using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Binode.Data.Model;

namespace Binode.Presentation.WinForm
{
    public partial class AddTextContentForm : Form
    {
        public AddTextContentForm()
        {
            InitializeComponent();
        }

        public string title { get; set; }
        public string content { get; set; }

        //Add Text Content = Metin içerik ekle
        private void AddTextContent_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //BinodeMainForm anaForm = this.Owner as BinodeMainForm;

            //Kategori seciliKategori = anaForm._rightClicknode.Tag as Kategori;

            //seciliKategori.Icerik.Add(new Icerik
            //{
            //    Isim = txtTitle.Text,
            //    Tip = IcerikTipi.Metin,
            //    Content = txtContent.Text,
            //    EklenmeTarihi = DateTime.Now
            //});

            //anaForm.listView1.Items.Clear();
            //anaForm.ListViewDoldur(anaForm._rightClicknode);

            title = txtTitle.Text;
            content = txtContent.Text;

            this.Close();
        }
    }
}
