namespace Reflection___SL_Ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void KlasorleriVeClasslariListele(string klasorYolu, int girintiSeviyesi = 0)
        {
            // Klasör ismini girintiyle ekle
            string girinti = new string(' ', girintiSeviyesi * 3);
            string klasorAdi = girinti + "📁 " + Path.GetFileName(klasorYolu);
            listBox1.Items.Add(klasorAdi);

            // .cs dosyalarını al
            string[] csDosyalari = Directory.GetFiles(klasorYolu, "*.cs");
            foreach (string dosya in csDosyalari)
            {
                string[] satirlar = File.ReadAllLines(dosya);
                foreach (string satir in satirlar)
                {
                    if (satir.Trim().StartsWith("class ") || satir.Trim().Contains(" class "))
                    {
                        string classAdi = satir.Trim().Split(' ')[^1];
                        listBox1.Items.Add(girinti + "   📄 " + classAdi);
                        break;
                    }
                }
            }

            // Alt klasörleri al ve metodu tekrar çağır
            string[] altKlasorler = Directory.GetDirectories(klasorYolu);
            foreach (string altKlasor in altKlasorler)
            {
                KlasorleriVeClasslariListele(altKlasor, girintiSeviyesi + 1);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear(); // Öncekileri temizle
                    string secilenKlasor = dialog.SelectedPath;

                    // Şimdi bu klasörü işlemeye başlayacağız
                    KlasorleriVeClasslariListele(secilenKlasor);
                }
            }
        }
    }
}
