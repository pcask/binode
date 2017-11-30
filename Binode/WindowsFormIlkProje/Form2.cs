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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for (int j = 0; j < listBox2.Items.Count; j++)
                {
                    if (listBox1.Items[i].ToString() == listBox2.Items[j].ToString())
                    {
                        if (listBox3.Items.Count < 0)
                            listBox3.Items.Add(listBox1.Items[i]);
                        else
                        {
                            bool varMi = false;
                            for (int k = 0; k < listBox3.Items.Count; k++)
                            {
                                if (listBox1.Items[i].ToString() == listBox3.Items[k].ToString())
                                    varMi = true;
                            }

                            if (!varMi)
                                listBox3.Items.Add(listBox1.Items[i]);
                        }
                    }
                }
            }
        }   
    }
}
