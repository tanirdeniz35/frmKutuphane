using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmKutuphane.Entities
{
    public class KullaniciKitap
    {
        public int Id { get; set; }
        public Kullanici Kullanici { get; set; }
        public int KullaniciId { get; set; }

        public Kitap Kitap { get; set; }
        public int KitapId { get;set; }

        public DateTime AlisTarihi { get; set; }

        public DateTime VerilisTarihi { get; set; }
    }
}
