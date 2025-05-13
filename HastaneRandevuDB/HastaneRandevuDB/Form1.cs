using System.Data.SqlClient;
using System.Data;

namespace HastaneRandevuDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BranslariYukle();
            SaatleriYukle();
        }

        private void BranslariYukle()
        {
            cbBrans.Items.Clear();
            try
            {
                SqlConnection baglanti = new SqlConnection("Server=.;Database=HastaRandevuDB;Trusted_Connection=True;");
                baglanti.Open();

                SqlCommand komut = new SqlCommand("SELECT Id, BransAdi FROM Branslar", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbBrans.DisplayMember = "BransAdi";
                cbBrans.ValueMember = "Id";
                cbBrans.DataSource = dt;

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Branþlar yüklenemedi: " + ex.Message);
            }
        }

        private void SaatleriYukle()
        {
            cbSaat.Items.Clear();
            cbSaat.Items.AddRange(new string[] { "09:00", "10:00", "11:00", "13:00", "14:00", "15:00" });
        }



        private void cbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrans.SelectedValue == null) return;

            try
            {
                SqlConnection baglanti = new SqlConnection("Server=.;Database=HastaRandevuDB;Trusted_Connection=True;");
                baglanti.Open();

                SqlCommand komut = new SqlCommand("SELECT Id, DoktorAdi, DoktorSoyadi FROM Doktorlar WHERE BransID = @id", baglanti);
                komut.Parameters.AddWithValue("@id", cbBrans.SelectedValue);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Ad ve Soyadý birleþtirerek yeni sütun oluþtur
                dt.Columns.Add("TamAd", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    row["TamAd"] = row["DoktorAdi"] + " " + row["DoktorSoyadi"];
                }

                cbDoktor.DisplayMember = "TamAd";
                cbDoktor.ValueMember = "Id";
                cbDoktor.DataSource = dt;

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktorlar yüklenemedi: " + ex.Message);
            }
        }

        private void cbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen hasta ad ve soyadýný giriniz.");
                return;
            }

            if (cbBrans.SelectedValue == null || cbDoktor.SelectedValue == null || cbSaat.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm seçimleri yapýnýz.");
                return;
            }

            DateTime tarihSaat = dtTarih.Value.Date + TimeSpan.Parse(cbSaat.SelectedItem.ToString());

            try
            {
                using (SqlConnection baglanti = new SqlConnection("Server=.;Database=HastaRandevuDB;Trusted_Connection=True;"))
                {
                    baglanti.Open();

                    // Ayný tarih, saat ve doktora ait randevu var mý kontrol et
                    SqlCommand kontrolCmd = new SqlCommand(@"
                SELECT COUNT(*) FROM Randevular 
                WHERE DoktorID = @doktorID AND Tarih = @tarih", baglanti);
                    kontrolCmd.Parameters.AddWithValue("@doktorID", cbDoktor.SelectedValue);
                    kontrolCmd.Parameters.AddWithValue("@tarih", tarihSaat);

                    int kontrol = (int)kontrolCmd.ExecuteScalar();
                    if (kontrol > 0)
                    {
                        MessageBox.Show("Bu saatte bu doktora zaten randevu alýnmýþ.");
                        return;
                    }

                    // Yeni randevu ekle
                    SqlCommand ekleCmd = new SqlCommand(@"
                INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih)
                VALUES (@ad, @soyad, @bransID, @doktorID, @tarih)", baglanti);
                    ekleCmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                    ekleCmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                    ekleCmd.Parameters.AddWithValue("@bransID", cbBrans.SelectedValue);
                    ekleCmd.Parameters.AddWithValue("@doktorID", cbDoktor.SelectedValue);
                    ekleCmd.Parameters.AddWithValue("@tarih", tarihSaat);

                    ekleCmd.ExecuteNonQuery();

                    MessageBox.Show("Randevu baþarýyla alýndý.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
