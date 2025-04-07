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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AracEkleme aracEklemeForm = new AracEkleme();
            if (aracEklemeForm.ShowDialog() == DialogResult.OK)
            {
                // Kullanıcının girdiği bilgileri al
                string marka = aracEklemeForm.AracMarkasi;
                string model = aracEklemeForm.AracModeli;
                string kapi = aracEklemeForm.KapiSayisi;

                // ListBox'a biçimlendirilmiş şekilde ekle
                string aracBilgisi = $"{marka} - {model} ({kapi} Kapı)";
                listBox1.Items.Add(aracBilgisi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                DialogResult sonuc = MessageBox.Show(
                    "Seçili aracı silmek istediğinizden emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (sonuc == DialogResult.Yes)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir araç seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string secilenArac = listBox1.SelectedItem.ToString();
                MessageBox.Show($"Seçilen Araç Bilgisi:\n\n{secilenArac}", "Araç Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir araç seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
