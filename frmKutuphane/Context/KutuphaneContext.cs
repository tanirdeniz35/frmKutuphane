using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frmKutuphane.Entities;
using Microsoft.EntityFrameworkCore;

namespace frmKutuphane.Context
{
    public class KutuphaneContext:DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<KullaniciKitap> KullaniciKitaplar { get; set; }

        public DbSet<Durum> Durumlar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FVLJCOB\\SQLEXPRESS;Trusted_Connection=True;Database=KUTUPHANE;TrustServerCertificate=True");
        }
    }
}
