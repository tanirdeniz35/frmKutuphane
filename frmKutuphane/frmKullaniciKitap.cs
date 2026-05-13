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
using Microsoft.EntityFrameworkCore;

namespace frmKutuphane
{
    public partial class frmKullaniciKitap : Form
    {
        public Kullanici Kullanici { get; }

        public frmKullaniciKitap(Kullanici kullanici)
        {
            InitializeComponent();
            Kullanici = kullanici;
        }


        public frmKullaniciKitap()
        {
            InitializeComponent();
        }

        private void frmKullaniciKitap_Load(object sender, EventArgs e)
        {
            LoadKitaplar();
            LoadKullaniciKitaplar();
       
            dgwKullaniciKitaplar.Columns[2].Visible = false;
            dgwKullaniciKitaplar.Columns[4].Visible = false;
            dgwKullaniciKitaplar.Columns[0].Visible = false;

            dgwKullaniciKitaplar.ClearSelection();
        }


        private void LoadKullaniciKitaplar()
        {
            KutuphaneContext ctx = new KutuphaneContext();
            var kullaniciKitaplar = ctx.KullaniciKitaplar.Include(x => x.Kullanici).Include(x => x.Kitap);
            dgwKullaniciKitaplar.DataSource = kullaniciKitaplar.ToList();
        }

        private void LoadKitaplar()
        {
            KutuphaneContext ctx = new KutuphaneContext();
            var Kitaplar = ctx.Kitaplar.Where(x => x.DurumId == 1).ToList();
            cmbKitaplar.DataSource = Kitaplar;
        }





        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            KutuphaneContext kutuphaneContext = new KutuphaneContext();

            if (btnOduncAl.Text == "Ödünç Al")
            {
                KullaniciKitap kullaniciKitap = new KullaniciKitap()
                {

                    KullaniciId = Kullanici.Id,

                    KitapId = ((Kitap)(cmbKitaplar.SelectedItem)).Id,

                    AlisTarihi = DateTime.Now,
                };
                kutuphaneContext.KullaniciKitaplar.Add(kullaniciKitap);
                kutuphaneContext.SaveChanges();
                MessageBox.Show("Kitap ödünç alındı"); 
            }
            else
            {
                seciliKullaniciKitap.VerilisTarihi= DateTime.Now;
                kutuphaneContext.KullaniciKitaplar.Update(seciliKullaniciKitap);
                kutuphaneContext.SaveChanges();
                MessageBox.Show("Kitap iade edildi");

            }
            LoadKullaniciKitaplar();
        }

        private void btnIade_Click(object sender, EventArgs e)
        {

        }


        KullaniciKitap seciliKullaniciKitap = new KullaniciKitap();
        private void dgwKullaniciKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwKullaniciKitaplar.CurrentRow != null)
            {
                seciliKullaniciKitap = dgwKullaniciKitaplar.CurrentRow?.DataBoundItem as KullaniciKitap;
               
                btnOduncAl.Text = "İade Et";
            }
            else
            {
                seciliKullaniciKitap = new KullaniciKitap();
                btnOduncAl.Text = "Ödünç Al";
            }
        }
    }
}
