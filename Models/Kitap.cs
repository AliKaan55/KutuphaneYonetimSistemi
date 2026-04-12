using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.Models
{
    public class Kitap
    {
        public int KitapId { get; set; }
        public string ISBN { get; set; }
        public string KitapAdi{ get; set; }
        public string Yazar{ get;set; }
        public string Yayinevi {  get; set; }
        public int SayfaSayisi { get; set; }
        public string Kategori {  get; set; }
        public string Durum{ get; set; }


    }
}
