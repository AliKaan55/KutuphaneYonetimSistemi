using System;

namespace KutuphaneYonetimSistemi.Models
{
    public class Uye
    {
        public int UyeID { get; set; }
        public string TCNo { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
}