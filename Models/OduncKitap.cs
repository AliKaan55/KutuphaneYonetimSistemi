using System;

namespace KutuphaneYonetimSistemi.Models
{
    public class OduncKitap
    {
        public int IslemID { get; set; }
        public int KitapID { get; set; }
        public int UyeID { get; set; }
        public string UyeAdi { get; set; }
        public string KitapAdi { get; set; }
        public DateTime OduncTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public string Durum { get; set; }
    }
}