using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace JSON_Ödevi
{
    public partial class Form1 : Form
    {
        public class Urun
        {
            public string UrunAdi { get; set; }
            public int Fiyat { get; set; }
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonYolu = "urunler.json"; // Çalışma dizinindeki json dosyası
                string jsonVeri = File.ReadAllText(jsonYolu);

                var urunler = JsonSerializer.Deserialize<List<Urun>>(jsonVeri);

                listBox1.Items.Clear();

                foreach (var urun in urunler)
                {
                    listBox1.Items.Add($"{urun.UrunAdi} - {urun.Fiyat} TL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
