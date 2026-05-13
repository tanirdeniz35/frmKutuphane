using frmKutuphane.Context;

namespace frmKutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            KutuphaneContext kutuphane = new KutuphaneContext();

             var kullanici=kutuphane.Kullanicilar.FirstOrDefault(x=>x.KullaniciAdi==txtKullaniciAdi.Text&&x.Sifre==txtSifre.Text);
            if (kullanici != null)
            {
                frmKitaplar frmKitaplar = new frmKitaplar(kullanici);
                frmKitaplar.Show();
            }
            else
            {
                MessageBox.Show("Giriþ baþarýsýz");
            }
        }

        private void lblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKullaniciKayit kayit=new frmKullaniciKayit();
            kayit.ShowDialog();
        }
    }
}
