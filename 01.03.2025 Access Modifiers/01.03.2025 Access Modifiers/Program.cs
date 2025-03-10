internal class Program
{
    private static void Main(string[] args)
    {
        User user = new User();
        user.UserName = "Muhammed Hazar Caglayan";
        user.UserAge = 19;
        user.UserMail = "hazarcglyn@gmail.com";
        user.BilgileriGoster();
    }
    // Public (Genel) Erişim Belirleyicisi
    /*
     * Bir Classdaki veriye Her yerden erişilebilir yapmaktadır.
     */
    // Private (Özel) Erişim Belirleyicisi
    /*
     * Bir Veriye Sadece Tanımlandığı Classdan Erişim izni verir.
     */
    //Protected (Korumalı) Erişim Belirleyicisi
    /*
     * Aynı Classda olan ve o classdan İnheritence alan sınıflar erişim sağlayabilir.
     */
    //internal (Dahili) Erişim Belirleyicisi
    /*
     * Aynı Proje içerisinden erişilebilir.
     */
    class User
    {
        private string adSoyad;
        private int yas;
        public string eMail; 
        public string UserName
        {
            get { return adSoyad; }
            set
            {
                adSoyad = value;
            }
        }
        public int UserAge
        {
            get { return yas; }
            set
            {
                yas = value;
            }
        }
        public string UserMail
        {
            get { return eMail; }
            set
            {
                eMail = value;
            }
        }
        public void BilgileriGoster()
        {
            Console.WriteLine(adSoyad + "\n" + yas + "\n" + eMail);
        }
    }
}