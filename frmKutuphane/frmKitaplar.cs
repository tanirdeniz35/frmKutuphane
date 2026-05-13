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
    public partial class frmKitaplar : Form
    {
        public Kullanici Kullanici { get; }

        public frmKitaplar()
        {
            InitializeComponent();
        }

        public frmKitaplar(Kullanici kullanici)
        {
            InitializeComponent();
            Kullanici = kullanici;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "Kitap Güncelle")
            {
                KutuphaneContext context = new KutuphaneContext();

                Durum seciliDurum = context.Durumlar.FirstOrDefault(x => x.Id == durum);
                seciliKitap.Yazar = txtYazar.Text;

                seciliKitap.KitapAdi = txtKitapAdi.Text;
                seciliKitap.ISSN = txtISSN.Text;
                seciliKitap.DurumId = durum;
                seciliKitap.Durum = seciliDurum;
                context.Kitaplar.Update(seciliKitap);
                context.SaveChanges();
                MessageBox.Show("Kitap başarıyla güncellendi");
                txtYazar.Text = "";
                txtKitapAdi.Text = "";
                txtISSN.Text = "";

            }
            else
            {
                KutuphaneContext context = new KutuphaneContext();
                Kitap kitap = new Kitap()
                {
                    Yazar = txtYazar.Text,
                    KitapAdi = txtKitapAdi.Text,
                    ISSN = txtISSN.Text,
                    DurumId = durum
                };
                context.Kitaplar.Add(kitap);
                context.SaveChanges();
                MessageBox.Show("Kitap başarıyla kaydedildi");
                Temizle();

            }
            frmKitaplar_Load(null, null);
        }
        void Temizle()
        {
            txtYazar.Text = "";
            txtKitapAdi.Text = "";
            txtISSN.Text = "";
            rdnMevcut.Checked = false;
            rdnMevcutDegil.Checked = false;
            btnEkle.Text = "Kitap Ekle";
            seciliKitap = new Kitap();
            btnSil.Visible = false;
        }
        private void lbtnOduncAl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKullaniciKitap frmKullaniciKitap = new frmKullaniciKitap(Kullanici);
            frmKullaniciKitap.Show();
        }

        private void frmKitaplar_Load(object sender, EventArgs e)
        {
            KutuphaneContext context = new KutuphaneContext();
            dgwKitaplar.DataSource = context.Kitaplar.Include(x => x.Durum).ToList();
            dgwKitaplar.ClearSelection();

            Temizle();
        }

        private void dgwKitaplar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {



        }
        Kitap seciliKitap = new Kitap();
        private void dgwKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwKitaplar.CurrentRow != null)
            {
                seciliKitap = dgwKitaplar.CurrentRow?.DataBoundItem as Kitap;
                txtISSN.Text = seciliKitap.ISSN;
                txtKitapAdi.Text = seciliKitap.KitapAdi;
                txtYazar.Text = seciliKitap.Yazar;
                btnEkle.Text = "Kitap Güncelle";
                btnSil.Visible = true;
                if (seciliKitap.DurumId==1)
                {
                    rdnMevcut.Checked = true;
                }
                else
                {
                    rdnMevcutDegil.Checked = true;
                }
            }
            else
            {
                seciliKitap = new Kitap();
                btnEkle.Text = "Kitap Ekle";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            KutuphaneContext context = new KutuphaneContext();
            context.Kitaplar.Remove(seciliKitap);
            context.SaveChanges();
            MessageBox.Show("Seçili kitap silindi");
            Temizle();
            frmKitaplar_Load(null, null);
        }
        int durum;
        private void rdnMevcutDegil_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnMevcutDegil.Checked)
                durum = 2;
            else

                durum = 1;
        }

        private void rdnMevcut_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnMevcut.Checked)
                durum = 1;
            else

                durum = 2;
        }

        private void dgwKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
