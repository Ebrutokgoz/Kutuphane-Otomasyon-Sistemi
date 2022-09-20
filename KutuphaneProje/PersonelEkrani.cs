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
    public partial class PersonelEkrani : Form
    {
      KutuphaneVeriTabaniEntities db = new KutuphaneVeriTabaniEntities();

        public int kutuphaneId;
        public int personelId;

        private string kutuphaneAd()
        {
            var kutuphane = db.Kutuphane.Where(k => k.Kutuphane_id.Equals(kutuphaneId)).FirstOrDefault();
            return kutuphane.Kutuphane_ad;
        }
        private string  personelAd()
        {
            var personel = db.Calisanlar.Where(c => c.Calisan_id.Equals(personelId)).FirstOrDefault();
            return personel.Calisan_ad + " " + personel.Calisan_soyad;
        }

        public PersonelEkrani()
        {
            InitializeComponent();
        }

        private void kitapIslemleriBtn_Click(object sender, EventArgs e)
        {
            KitapIslemleri kitapIslemleri = new KitapIslemleri();
            kitapIslemleri.Show();
            kitapIslemleri.kutuphaneAdLbl.Text = kutuphaneAd();
            kitapIslemleri.personelAdLbl.Text = personelAd();
            kitapIslemleri.personelId = this.personelId;
            kitapIslemleri.kutuphaneId = this.kutuphaneId;
        }

        private void uyeIslemleriBtn_Click(object sender, EventArgs e)
        {
            UyeIslemleri uyeIslemleri = new UyeIslemleri();
            uyeIslemleri.Show();
            uyeIslemleri.kutuphaneId = this.kutuphaneId;
            uyeIslemleri.personelId = this.personelId;
            uyeIslemleri.kutuphaneAdLbl.Text = kutuphaneAd();
            uyeIslemleri.personelAdLbl.Text = personelAd();
        }

        private void emanetIslemleriBtn_Click(object sender, EventArgs e)
        {
            EmanetIslemleri emanetIslemleri1 = new EmanetIslemleri();
            emanetIslemleri1.Show();
            emanetIslemleri1.kutuphaneAdLbl.Text = kutuphaneAd();
            emanetIslemleri1.personelAdLbl.Text = personelAd();
            emanetIslemleri1.personelId = this.personelId;
            emanetIslemleri1.kutuphaneId = this.kutuphaneId;
        }

        private void PersonelEkrani_Load(object sender, EventArgs e)
        {
        }
    }
}
