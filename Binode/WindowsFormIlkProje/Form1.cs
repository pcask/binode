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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstSehirler.Items.Add(txtSehir.Text);
        }

        private void lstSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSehirler.SelectedItem != null)
            {
                lblSeciliItem.Visible = true;
                lblSeciliItem.Text = ((ListBox)sender).SelectedItem.ToString();

            }
            else
                lblSeciliItem.Visible = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstSehirler.Items.Remove(lstSehirler.SelectedItem);

        }
    }
}
