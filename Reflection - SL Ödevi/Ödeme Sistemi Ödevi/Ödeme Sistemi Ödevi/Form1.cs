namespace Ödeme_Sistemi_Ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kredi/Banka Kartı");
            comboBox1.Items.Add("Alışveriş Kredisi");
            comboBox1.SelectedIndex = 0;

            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBox1.Text, out decimal tutar))
            {
                label4.Text = "Geçerli bir tutar giriniz.";
                return;
            }

            string secilenYontem = comboBox1.SelectedItem.ToString();

            if (secilenYontem == "Kredi/Banka Kartı")
            {
                KrediKarti kart = new KrediKarti
                {
                    KartNo = textBox2.Text,
                    Tarih = textBox3.Text,
                    CVV = textBox5.Text
                };

                string sonuc = kart.Ode(tutar);
                label4.Text = sonuc;
            }
            else if (secilenYontem == "Alışveriş Kredisi")
            {
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    label4.Text = "Lütfen bir banka seçiniz.";
                    return;
                }

                string bankaSecimi = radioButton1.Checked ? "A Bankası" : "B Bankası";
                label4.Text = $"Alışveriş Kredisi ile {bankaSecimi} seçildi, işlem başarılı.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Text = "A Bankası'na başvuru gönderildi.";
            // Teklif durumu simülasyonu
            bool kabulEdildi = (new Random().Next(0, 2) == 0); // %50 şansla kabul veya reddedilir
            label11.Text = kabulEdildi ? "Teklif kabul edildi!" : "Teklif reddedildi.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label11.Text = "B Bankası'na başvuru gönderildi.";
            // Teklif durumu simülasyonu
            bool kabulEdildi = (new Random().Next(0, 2) == 0); // %50 şansla kabul veya reddedilir
            label11.Text = kabulEdildi ? "Teklif kabul edildi!" : "Teklif reddedildi.";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Kredi/Banka Kartı")
            {
                groupBox1.Visible = true;  // Kredi kartı paneli görünür
                groupBox2.Visible = false;   // Alışveriş kredisi paneli gizli
            }
            else if (comboBox1.SelectedItem.ToString() == "Alışveriş Kredisi")
            {
                groupBox1.Visible = false; // Kredi kartı paneli gizli
                groupBox2.Visible = true;    // Alışveriş kredisi paneli görünür
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
