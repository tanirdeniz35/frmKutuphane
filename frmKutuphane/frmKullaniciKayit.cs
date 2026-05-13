using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmKutuphane.Context;
using frmKutuphane.Entities;

namespace frmKutuphane
{
    public partial class frmKullaniciKayit : Form
    {
        public frmKullaniciKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KutuphaneContext kutuphane = new KutuphaneContext();
            Kullanici kullanici = new Kullanici()
            { 
                Ad=txtAd.Text,
               Soyad=txtSoyad.Text,
                KullaniciAdi =txtKullaniciAdi.Text,
                  Sifre =txtSifre.Text
            };
            kutuphane.Kullanicilar.Add(kullanici);
            kutuphane.SaveChanges();

            MessageBox.Show("Kayıt başarılı");
        }
    }
}
