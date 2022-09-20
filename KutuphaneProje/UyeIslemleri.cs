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
    public partial class UyeIslemleri : Form
    {
        static string constring = ("Data Source=.\\SQLEXPRESS;Initial Catalog=KutuphaneVeriTabani;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable tablo;

        KutuphaneVeriTabaniEntities db = new KutuphaneVeriTabaniEntities();

        public int kutuphaneId;
        public int personelId;

        int i;

        public UyeIslemleri()
        {
            InitializeComponent();
        }
        public void listele()
        {
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            komut = new SqlCommand("SELECT u.Uye_id, u.Uye_ad, u.Uye_soyad, u.Uye_eposta, u.Uye_telefon, u.Ceza, u.Max_kitap_sayisi, u.Alınan_kitap_sayisi" +
                " FROM Kutuphane_Uye k1 inner join Kutuphane k2 on k1.Kutuphane_id=k2.Kutuphane_id right join Uyeler u on k1.Uye_id=u.Uye_id where k1.Kutuphane_Id = @kid", baglan);
            komut.Parameters.AddWithValue("@kid", kutuphaneId);
            da = new SqlDataAdapter(komut);
            tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }

        private void uyeListeleBtn_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            ekleKaydetBtn.Show();
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string sorgu = " insert into Uyeler(Uye_ad, Uye_soyad, Uye_telefon, Uye_eposta) values(@ad, @soyad, @telefon, @eposta) ";
                    komut = new SqlCommand(sorgu, baglan);
                    komut.Parameters.AddWithValue("@ad", adTxt.Text);
                    komut.Parameters.AddWithValue("@soyad", soyadTxt.Text);
                    komut.Parameters.AddWithValue("@telefon", telefonTxt.Text);
                    komut.Parameters.AddWithValue("@eposta", epostaTxt.Text);

                    


                    komut.ExecuteNonQuery();
                    

                    baglan.Close();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata var" + hata.Message);
            }

            

        }
        private void ekleKaydetBtn_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            var uye = db.Uyeler.Where(u => u.Uye_eposta.Contains(epostaTxt.Text)).FirstOrDefault();
            string sorgu2 = "insert into Kutuphane_Uye(Kutuphane_id, Uye_id)values(@k_id, @u_id)";
            komut = new SqlCommand(sorgu2, baglan);
            komut.Parameters.AddWithValue("@k_id", kutuphaneId);
            komut.Parameters.AddWithValue("@u_id", uye.Uye_id);
            komut.ExecuteNonQuery();

            MessageBox.Show("Üye kaydı yapıldı");
            listele();

            baglan.Close();
        }

        public void Sil(int id)
        {
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();

            komut = new SqlCommand("DELETE FROM Kutuphane_Uye where Uye_id=@u_id and Kutuphane_id = @k_id", baglan);
            komut.Parameters.AddWithValue("@u_id", id);
            komut.Parameters.AddWithValue("@k_id", kutuphaneId);
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Sil(id);
        }
   
        public void uye_guncelleme()
        {
            var uye = db.Uyeler.Where(u => u.Uye_eposta.Contains(epostaTxt.Text)).FirstOrDefault();
            komut = new SqlCommand("update Uyeler Set Uye_ad=@ad,Uye_soyad=@soyad,Uye_telefon=@telefon,Uye_eposta=@eposta where uye_id=@id", baglan);

            komut.Parameters.AddWithValue("@ad", adTxt.Text);
            komut.Parameters.AddWithValue("@soyad", soyadTxt.Text);
            komut.Parameters.AddWithValue("@telefon", telefonTxt.Text);
            komut.Parameters.AddWithValue("@eposta", epostaTxt.Text);
          
            komut.Parameters.AddWithValue("id", uye.Uye_id);
            komut.ExecuteNonQuery();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            uye_guncelleme();
            baglan.Close();
            listele();

            adTxt.Clear();
            soyadTxt.Clear();
            telefonTxt.Clear();
            epostaTxt.Clear();
            
        }

        private void kayitAraBtn_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("SELECT * FROM Uyeler Where Uye_id=@id", baglan);
            komut.Parameters.AddWithValue("@id", uyeIdAraTxt.Text);
            da = new SqlDataAdapter(komut);
            tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }

        private void uyeEkleBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Show();
            ekleBtn.Show();
            silBtn.Hide();
            guncelleBtn.Hide();
            ekleKaydetBtn.Hide();
        }

        private void uyeGuncelleBtn_Click(object sender, EventArgs e)
        {
            silBtn.Hide();
            ekleBtn.Hide();
            guncelleBtn.Show();
            eklePnl.Show();
            ekleKaydetBtn.Hide();
        }

        private void uyeSilBtn_Click(object sender, EventArgs e)
        {
            silBtn.Show();
            eklePnl.Hide();
            ekleKaydetBtn.Hide();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            adTxt.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            soyadTxt.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            epostaTxt.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            telefonTxt.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
    }
}
