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
    public partial class YoneticiEkrani : Form
    {
        KutuphaneVeriTabaniEntities db = new KutuphaneVeriTabaniEntities();

        public int kutuphaneId;
        public int personelId;

        private string kutuphaneAd()
        {
            var kutuphane = db.Kutuphane.Where(k => k.Kutuphane_id.Equals(kutuphaneId)).FirstOrDefault();
            return kutuphane.Kutuphane_ad;
        }
        private string personelAd()
        {
            var personel = db.Calisanlar.Where(c => c.Calisan_id.Equals(personelId)).FirstOrDefault();
            return personel.Calisan_ad + " " + personel.Calisan_soyad;
        }

        public YoneticiEkrani()
        {
            InitializeComponent();
        }

        private void personelIslemleriBtn_Click(object sender, EventArgs e)
        {
            PersonelIslemleri personelIslemleri = new PersonelIslemleri();
            personelIslemleri.personelId = this.personelId;
            personelIslemleri.kutuphaneId = this.kutuphaneId;
            personelIslemleri.personelAdLbl.Text = personelAd();
            personelIslemleri.kutuphaneAdLbl.Text = kutuphaneAd();
            personelIslemleri.Show();
        }

        private void personelSayfasiBtn_Click(object sender, EventArgs e)
        {
            PersonelEkrani personelEkrani = new PersonelEkrani();
            personelEkrani.personelId = this.personelId;
            personelEkrani.kutuphaneId = this.kutuphaneId;
            personelEkrani.adSoyadLbl.Text = personelAd();
            personelEkrani.kutuphaneAdLbl.Text = kutuphaneAd();
            personelEkrani.Show();
        }

       
    }
}
