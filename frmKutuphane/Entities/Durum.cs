using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmKutuphane.Entities
{
    public class Durum
    {
      
        public int Id { get; set; }
        public string DurumAdi { get; set; }

        public override string ToString()
        {
            return DurumAdi;
        }
    }
}
