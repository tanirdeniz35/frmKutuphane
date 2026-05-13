using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmKutuphane.Entities
{
    public class Kitap
    {
        public int Id { get; set; }

        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string ISSN { get; set; }

        public Durum Durum { get; set; }
        public int DurumId { get; set; }

        public override string ToString()
        {
            return KitapAdi;
        }
    }
}
