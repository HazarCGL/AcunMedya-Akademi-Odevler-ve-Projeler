using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaBilgiFormu
{

    public partial class AracEkleme : Form
    {
        public string AracMarkasi { get; private set; }
        public string AracModeli { get; private set; }
        public string KapiSayisi { get; private set; }

        public AracEkleme()
        {
            InitializeComponent();

            comboBox1.Items.Add("2");
            comboBox1.Items.Add("4");
            comboBox1.SelectedIndex = 0; // varsayılan seçim
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AracMarkasi = textBox1.Text.Trim();
            AracModeli = textBox2.Text.Trim();
            KapiSayisi = comboBox1.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
