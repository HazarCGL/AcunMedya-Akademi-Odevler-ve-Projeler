using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödeme_Sistemi_Ödevi
{
    public class KrediKarti : IOdemeYontemi
    {
        public string KartNo { get; set; }
        public string Tarih { get; set; }
        public string CVV { get; set; }

        public string Ode(decimal tutar)
        {
            // Basit kontrol ve sahte işlem simülasyonu
            if (string.IsNullOrWhiteSpace(KartNo) || string.IsNullOrWhiteSpace(Tarih) || string.IsNullOrWhiteSpace(CVV))
            {
                return "Kart bilgileri eksik!";
            }

            return $"Kredi kartı ile {tutar:C} tutarında ödeme başarılı.";
        }
    }
}
