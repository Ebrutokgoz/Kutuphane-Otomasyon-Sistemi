using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace KutuphaneProje
{
    public partial class GirisEkrani : Form
    {
        KutuphaneVeriTabaniEntities db = new KutuphaneVeriTabaniEntities();

        public GirisEkrani()
        {
            InitializeComponent();
        }


        private void girisBtn_Click(object sender, EventArgs e)
        {
            string girilenEposta = epostaTxt.Text;
            string girilenSifre = sifreTxt.Text;

            var calisan = db.Calisanlar.Where(c => c.Calisan_eposta.Equals(girilenEposta) && c.Calisan_sifre.Equals(girilenSifre)).FirstOrDefault();

        

            if (calisan == null)
            {
                MessageBox.Show(text: "Personel adı veya şifer hatalı");
            }
            else
            {
                if (calisan.Unvan == "Yönetici")
                {
                    YoneticiEkrani yoneticiEkrani = new YoneticiEkrani();
                    yoneticiEkrani.Show();
                    yoneticiEkrani.adSoyadLbl.Text = calisan.Calisan_ad + " " + calisan.Calisan_soyad;
                    yoneticiEkrani.kutuphaneAdLbl.Text = calisan.Kutuphane.Kutuphane_ad;
                    yoneticiEkrani.kutuphaneId = calisan.Kutuphane.Kutuphane_id;
                    yoneticiEkrani.personelId = calisan.Calisan_id;
                    //this.Hide();
                }
                else
                {
                    PersonelEkrani personelEkrani = new PersonelEkrani();
                    personelEkrani.Show();
                    personelEkrani.adSoyadLbl.Text = calisan.Calisan_ad + " " + calisan.Calisan_soyad;
                    personelEkrani.kutuphaneAdLbl.Text = calisan.Kutuphane.Kutuphane_ad;
                    personelEkrani.kutuphaneId = calisan.Kutuphane.Kutuphane_id;
                    personelEkrani.personelId = calisan.Calisan_id;
                    //this.Hide();
                }
            }

        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            sifreTxt.PasswordChar = '*';
        }
    }
}
