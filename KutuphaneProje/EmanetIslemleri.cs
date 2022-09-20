using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProje
{
    public partial class EmanetIslemleri : Form
    {
        KutuphaneVeriTabaniEntities db = new KutuphaneVeriTabaniEntities();

        public int kutuphaneId;
        public int personelId;


        public EmanetIslemleri()
        {
            InitializeComponent();
        }

        private void cleanTables()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
        }
        private void tümEmanetleriListele()
        {
            var emanetListesi = from emanet in db.Emanet
                                join kitap in db.Kitap
                                on emanet.Kitap_id equals kitap.Kitap_id
                                select new
                                {

                                    Uye_id = emanet.Uye_id,
                                    Kitap_Id = kitap.Kitap_id,
                                    Kitap_Ad = kitap.Kitap_ad,
                                    Alıs_tarihi = emanet.Alis_tarihi,
                                    Teslim_tarihi = emanet.Teslim_tarihi,
                                };
        }
        private void emanetListele(int uyeId)
        {

            var emanetListesi = from emanet in db.Emanet
                                join kitap in db.Kitap
                                on emanet.Kitap_id equals kitap.Kitap_id
                                where emanet.Uye_id == uyeId
                                select new
                                {
                                    Uye_Id = emanet.Uye_id,
                                    Uye_Ad = emanet.Uyeler.Uye_ad,
                                    Uye_Soyad = emanet.Uyeler.Uye_soyad,
                                    Kitap_Id = kitap.Kitap_id,
                                    Kitap_Ad = kitap.Kitap_ad,
                                    Alıs_tarihi = emanet.Alis_tarihi,
                                    Teslim_tarihi = emanet.Teslim_tarihi,
                                };

            try
            {
                dataGridView3.DataSource = emanetListesi.ToList();

            }
            catch
            {
                MessageBox.Show("Üyeye ait emanet bilgisi bulunmamaktadır.");
            }

        }

        private void emanetVerBtn_Click(object sender, EventArgs e)
        {
            kaydetBtn2.Hide();
            teslimAlBilgi.Hide();
            sorgulaBilgi.Hide();
            goruntuleBtn.Hide();
            cleanTables();

            panel.Show();
            kitapAdPnl.Show();
            kaydetBtn.Show();
            emanetVerBilgi.Show();
            dataGridView1.Show();
        }

        private void teslimAlBtn_Click(object sender, EventArgs e)
        {
            kitapAdPnl.Hide();
            kaydetBtn.Hide();
            emanetVerBilgi.Hide();
            sorgulaBilgi.Hide();
            cleanTables();

            panel.Show();
            kaydetBtn2.Show();
            teslimAlBilgi.Show();
            goruntuleBtn.Show();
            dataGridView1.Show();

        }

        private void sorgulaBtn_Click(object sender, EventArgs e)
        {
            kitapAdPnl.Hide();
            dataGridView1.Hide();
            teslimAlBilgi.Hide();
            emanetVerBilgi.Hide();
            kaydetBtn.Hide();
            kaydetBtn2.Hide();
            cleanTables();
            

            panel.Show();
            sorgulaBilgi.Show();
            goruntuleBtn.Show();
            
        }

        private void araBtn1_Click(object sender, EventArgs e)
        {
     
            var uyeler = from uye in db.Uyeler
                         join kutuphane in db.Kutuphane_Uye
                         on uye.Uye_id equals kutuphane.Uye_id
                         where uye.Uye_ad.Contains(uyeAdTxt.Text) && uye.Uye_soyad.Contains(uyeSoyadTxt.Text) && kutuphane.Kutuphane_id.Equals(kutuphaneId)
                         select new
                         {
                             Uye_Id = uye.Uye_id,
                             Uye_Ad = uye.Uye_ad,
                             Uye_Soyad = uye.Uye_soyad,
                             Alinan_Kitap_Sayisi = uye.Alınan_kitap_sayisi,
                             Max_Kitap_Sayisi = uye.Max_kitap_sayisi,
                             Ceza = uye.Ceza,
                         };

                dataGridView2.DataSource = uyeler.ToList();
        }

        private void araBtn2_Click(object sender, EventArgs e)
        {
            var kitaplar = from kitap in db.Kitap
                           join yazar in db.Yazarlar
                           on kitap.Yazar_id equals yazar.Yazar_id
                           join kyayinevi in db.Kitap_Yayinevi
                           on kitap.Kitap_id equals kyayinevi.Kitap_id
                           join kategori in db.Kategori
                           on kitap.Kategori_id equals kategori.Kategori_id
                           where kitap.Kitap_ad.Contains(kitapAdTxt.Text) && kitap.Kütüphane_id.Equals(kutuphaneId) && kitap.Adet != 0
                           select new
                           {
                               Kitap_Id = kitap.Kitap_id,
                               Kitap_Ad = kitap.Kitap_ad,
                               Yazar_Ad = yazar.Yazar_ad,
                               Yazar_Soyad = yazar.Yazar_soyad,
                               Yayinevi = kyayinevi.Yayinevi.Yayinevi_ad,
                               Kategori = kategori.Kategori_ad,
                           };
            dataGridView1.DataSource = kitaplar.ToList();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            int uyeId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenUye = db.Uyeler.Where(u => u.Uye_id == uyeId).FirstOrDefault();

            if (secilenUye.Alınan_kitap_sayisi <= secilenUye.Max_kitap_sayisi)
            {
                int kitapId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                var secilenKitap = db.Kitap.Where(kitap => kitap.Kitap_id.Equals(kitapId)).FirstOrDefault();

                Emanet yeniEmanet = new Emanet();
                yeniEmanet.Uye_id = uyeId;
                yeniEmanet.Kitap_id = kitapId;
                yeniEmanet.Alis_tarihi = DateTime.Today;
                yeniEmanet.Teslim_tarihi = DateTime.Today.AddDays(15);

                db.Emanet.Add(yeniEmanet);

                secilenKitap.Adet -= 1;

                secilenUye.Alınan_kitap_sayisi += 1;

                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Üye alabileceği maksimum kitap sayısını aşmaktadır." +
                    "Yeni bir kitap alabilmek için elindekilerinin birini ya da daha fazlasını teslim etmesi gerekmektedir.");
            }

            
            emanetListele(secilenUye.Uye_id);

        }

      

      

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void goruntuleBtn_Click(object sender, EventArgs e)
        {
            int uyeId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenUye = db.Emanet.Where(u => u.Uye_id == uyeId).FirstOrDefault();


            var emanetListesi = from emanet in db.Emanet
                                join kitap in db.Kitap
                                on emanet.Kitap_id equals kitap.Kitap_id
                                where emanet.Uye_id == secilenUye.Uye_id
                                select new
                                {
                                    Kitap_Id = kitap.Kitap_id,
                                    Kitap_Ad = kitap.Kitap_ad,
                                    Alıs_tarihi = emanet.Alis_tarihi,
                                    Teslim_tarihi = emanet.Teslim_tarihi,
                                };
            try
            {
                dataGridView1.DataSource = emanetListesi.ToList();

            }
            catch
            {
                MessageBox.Show("Üyeye ait emanet bilgisi bulunmamaktadır.");
            }
        }

        private void kaydetBtn2_Click(object sender, EventArgs e)
        {
            int uyeId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            int kitapId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var secilenKayit = db.Emanet.Where(u => u.Uye_id == uyeId && u.Kitap_id == kitapId).FirstOrDefault();
            

            if (DateTime.Compare(secilenKayit.Teslim_tarihi, DateTime.Today) < 0)
            {
                MessageBox.Show("Üye teslim süresini aşmıştır!!");
                secilenKayit.Uyeler.Ceza += 1;
                secilenKayit.Uyeler.Max_kitap_sayisi -= 1;
            }

            secilenKayit.Uyeler.Alınan_kitap_sayisi -= 1;

            

            var silinecekKitap = db.Emanet.Where(k => k.Kitap_id.Equals(kitapId)).FirstOrDefault();

            secilenKayit.Kitap.Adet += 1;
            

            db.Emanet.Remove(secilenKayit);


            db.SaveChanges();
            emanetListele(secilenKayit.Uye_id);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
