using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KutuphaneProje
{
    

    public partial class PersonelIslemleri : Form
    {
        KutuphaneVeriTabaniEntities db = new KutuphaneVeriTabaniEntities();

        public int kutuphaneId;
        public int personelId;
        public PersonelIslemleri()
        {
            InitializeComponent();
        }

        static string constring = ("Data Source=.\\SQLEXPRESS;Initial Catalog=KutuphaneVeriTabani;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);

        private void calisanListele()
        {
            var calisanlar = from c in db.Calisanlar
                             where c.Kutuphane_id == kutuphaneId
                             select new
                             {
                                 Id = c.Calisan_id,
                                 Ad = c.Calisan_ad,
                                 Soyad = c.Calisan_soyad,
                                 Sifre = c.Calisan_sifre,
                                 Telefon = c.Calisan_telefon,
                                 Adres = c.Calisan_adres,
                                 Eposta = c.Calisan_eposta,
                                 Unvan = c.Unvan,
                                 Nobet_gunleri = c.Nobet_gunleri,
                             };

            dataGridView1.DataSource = calisanlar.ToList();
        }

        private void ekleBtn_Click_1(object sender, EventArgs e)
        {
            eklePnl.Show();
            kaydetBtn.Show();
            silPnl.Hide();
            guncellePanelBtn.Hide();
            calisanListele();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Show();
            guncellePanelBtn.Show();
            silPnl.Hide();
            kaydetBtn.Hide();
            calisanListele();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Hide();
            silPnl.Show();
            calisanListele();
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        { 
            eklePnl.Hide();
            silPnl.Hide();
            calisanListele();
        }


        int i = 0;

        public void veriSil(int id)
        {
            string sil = " Delete From Calisanlar Where Calisan_id = @id ";
            SqlCommand komut = new SqlCommand(sil, baglan);
            baglan.Open();

            komut.Parameters.AddWithValue("@id", id);

            komut.ExecuteNonQuery();
            baglan.Close();

        }


        private void guncellePanelBtn_Click(object sender, EventArgs e)
        {

            baglan.Open();

            string kayitGuncelle = ("Update Calisanlar Set Calisan_ad = @ad, Calisan_soyad = @soyad, Calisan_sifre = @sifre, Nobet_gunleri = @nobetGunleri, Calisan_telefon = @tel, " +
                " Unvan = @unvan, Calisan_eposta = @eposta, Calisan_adres = @adres Where Calisan_id = @id ");

            SqlCommand komut = new SqlCommand(kayitGuncelle, baglan);

            komut.Parameters.AddWithValue("@ad", adTxt.Text);
            komut.Parameters.AddWithValue("@soyad", soyadTxt.Text);
            komut.Parameters.AddWithValue("@sifre", sifreTxt.Text);
            komut.Parameters.AddWithValue("@nobetGunleri", nobetGunleriTxt.Text);
            komut.Parameters.AddWithValue("@tel", telefonTxt.Text);
            komut.Parameters.AddWithValue("@unvan", unvanTxt.Text);
            komut.Parameters.AddWithValue("@eposta", epostaTxt.Text);
            komut.Parameters.AddWithValue("@adres", adresTxt.Text);
            komut.Parameters.AddWithValue("id", dataGridView1.Rows[i].Cells[0].Value);

            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıtlar Başarıyla Güncellendi.");
            baglan.Close();
            calisanListele();
        }

        private void silPanelBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                veriSil(id);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;

            adTxt.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            soyadTxt.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            sifreTxt.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            telefonTxt.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            epostaTxt.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            unvanTxt.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            if (dataGridView1.Rows[i].Cells[5].Value == null)
            {
                adresTxt.Text = "-";
            }
            else
            {
                adresTxt.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            }


            if (dataGridView1.Rows[i].Cells[8].Value == null)
            {
                nobetGunleriTxt.Text = "-";
            }
            else
            {
                nobetGunleriTxt.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            }

        }

        private void kaydetBtn_Click_1(object sender, EventArgs e)
        {
            Calisanlar calisanlar = new Calisanlar();
            calisanlar.Calisan_ad = adTxt.Text;
            calisanlar.Calisan_sifre = sifreTxt.Text;
            calisanlar.Nobet_gunleri = nobetGunleriTxt.Text;
            calisanlar.Calisan_telefon = telefonTxt.Text;
            calisanlar.Unvan = unvanTxt.Text;
            calisanlar.Calisan_eposta = epostaTxt.Text;
            calisanlar.Calisan_adres = adresTxt.Text;
           // calisanlar.Kutuphane_id = kutuphane.Kutuphane_id;

            db.Calisanlar.Add(calisanlar);
            db.SaveChanges();
        }
    }
}
