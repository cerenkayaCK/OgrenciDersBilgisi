
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace OgrenciDersBilgisi
{
    public partial class Form1 : Form
    {

        UygulamaDbContext db = new();

        Ders SecilenDers = new();
        public Form1()
        {
            InitializeComponent();
            dgwDersBilgileri.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            Listele();
        }

        private void Listele()
        {
            dgwDersBilgileri.DataSource = db.Dersler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            Ders ders = new();

            DersBilgileriniAl(ders);

            var x = db.Dersler.FirstOrDefault(d => d.Kod == ders.Kod);
            if (x == null)
            {
                db.Dersler.Add(ders);
                int result = db.SaveChanges();
                if (result == 1)
                {
                    TextBoxYazilariSil();
                    Listele();
                    IslemYapilanDersiSeciliHaleGetir(ders);
                }
                else if (result < 0) { MessageBox.Show("Hata. Ders Eklenemedi."); }

            }
            else
            {
                MessageBox.Show("Ayný Koda sahip ders bulunmaktadýr. Eðer bir deðiþiklik yapmak istiyorsanýz ders bilgilerini güncelleyebilirsiniz");
            }
    

        }

        private void TextBoxYazilariSil()
        {
            txtDersAdi.Text = null;
            txtDersHarfNotu.Text = null;
            txtKredi.Text = null;
            txtDersKodu.Text = null;
            txtDersId.Text = null;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int result;
            try
            {
                if (SecilenDers != null)
                {
                    DersBilgileriniAl(SecilenDers);
                    lblGuncellemeBilgi.Text = "Guncelleniyor..";
                    result = db.SaveChanges();    
                    
                    if (result > 0)
                    {                        
                        lblGuncellemeBilgi.Text = "Güncellendi.";
                        Listele();
                        IslemYapilanDersiSeciliHaleGetir(SecilenDers);
                        Task.Delay(4000);
                        lblGuncellemeBilgi.Text = null;
                    }
                    else if (db.Entry(SecilenDers).State == EntityState.Unchanged)
                    {
                        lblGuncellemeBilgi.Text = null;
                        MessageBox.Show("Deðiþiklik Yapýlmadý.");
                    }
                }
                else MessageBox.Show("Güncellenecek dersi Seçiniz");
            }
            catch (Exception)
            {
                lblGuncellemeBilgi.Text = null;
                MessageBox.Show("Hata! ");
            }
        }

        private void IslemYapilanDersiSeciliHaleGetir(Ders ders)
        {
            dgwDersBilgileri.ClearSelection();
            foreach (DataGridViewRow row in dgwDersBilgileri.Rows)
            {
                if (row.Cells["Id"].Value.ToString() == ders.Id.ToString())
                {
                    row.Selected = true;
                    break;
                }
            }
        }
        private void DersBilgileriniAl(Ders d)
        {

            d.Ad = txtDersAdi.Text;
            d.HarfNotu = txtDersHarfNotu.Text[0];
            d.Kod = txtDersKodu.Text;
            d.Kredi = Convert.ToDouble(txtKredi.Text);

        }

        private void dgwDersBilgileri_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (dataGridView != null)
            {
                // DataGridView üzerindeki Ders tipine ait veriyi al
                Ders ders = (Ders)dataGridView.Rows[e.RowIndex].DataBoundItem;
                SecilenDers = ders;
                DersIsimleriniGetir(SecilenDers);

            }

        }

        private void DersIsimleriniGetir(Ders ders)
        {
            txtDersAdi.Text = ders.Ad;
            txtDersId.Text = ders.Id.ToString();
            txtDersKodu.Text = ders.Kod;
            txtDersHarfNotu.Text = ders.HarfNotu.ToString();
            txtKredi.Text = ders.Kredi.ToString();
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {

            int silinecekDersId = Convert.ToInt32(txtDersId.Text);
            var ders = db.Dersler.FirstOrDefault(x => x.Id == silinecekDersId);
            if (ders != null)
            {
                db.Dersler.Remove(ders);
                int result = db.SaveChanges();
                if (result > 0)
                { MessageBox.Show("Ders Silindi"); Listele();  }
                else MessageBox.Show("Ders Silinemedi");
            }
            else MessageBox.Show("Ders bulunamadý.");
            dgwDersBilgileri.ClearSelection();

            TextBoxYazilariSil();
        }

        private void btnOrtalamaHesapla_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            
            foreach (var item in db.Dersler)
            {
                char harfNotu = Char.ToUpper(item.HarfNotu); //küçük harf ile yazýlan harf notu varsa büyük harfe çevir..
                toplam += item.Kredi * (item.HarfNotu == 'A' ? 4 : item.HarfNotu == 'B' ? 3.5 : item.HarfNotu == 'C' ? 2 : item.HarfNotu == 'D' ? 1 : 0);
            }

            double toplamKredi = db.Dersler.Sum(item => item.Kredi);

            double ortalama = toplam / toplamKredi;

            MessageBox.Show("Genel Ortalamanýz: " + ortalama);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgwDersBilgileri.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // sadece satýr seçebilmeyi mümkün hale getir.
            dgwDersBilgileri.ClearSelection();
        }

        private void btnIstatistikleriGoster_Click(object sender, EventArgs e)
        {

            int basariliDersSayisi = db.Dersler.Count(x => x.HarfNotu == 'A' || x.HarfNotu == 'B' || x.HarfNotu == 'C');
            int basarisizDersSayisi = db.Dersler.Count(x => x.HarfNotu == 'F');
            int sinamaliDersSayisi = db.Dersler.Count(x => x.HarfNotu == 'D');
            MessageBox.Show(db.Dersler.Count() + "Dersten:" + Environment.NewLine + basariliDersSayisi + " tanesi baþarýlý" + Environment.NewLine + basarisizDersSayisi + " tanesi baþarýsýz" + Environment.NewLine + sinamaliDersSayisi + " tanesi sýnamalýdýr");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TextBoxYazilariSil();
        }
    }
}
