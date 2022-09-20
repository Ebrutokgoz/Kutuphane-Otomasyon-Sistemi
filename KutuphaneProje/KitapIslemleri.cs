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
    public partial class KitapIslemleri : Form
    {
        static string constring = ("Data Source=.\\SQLEXPRESS;Initial Catalog=KutuphaneVeriTabani;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable tablo;

        public int kutuphaneId;
        public int personelId;

        int i = 0;

        public KitapIslemleri()
        {
            InitializeComponent();
        }

        private void kitapSilBtn_Click(object sender, EventArgs e)
        {
            ekleBtn.Hide();
            guncelleBtn.Hide();
            eklePnl.Hide();

            silPnl.Show();
        }

        private void kitapGuncelleBtn_Click(object sender, EventArgs e)
        {
            silPnl.Hide();
            ekleBtn.Hide();

            guncelleBtn.Show();
            eklePnl.Show();
        }

        private void kitapEkleBtn_Click(object sender, EventArgs e)
        {
            silPnl.Hide();
            guncelleBtn.Hide();

            ekleBtn.Show();
            eklePnl.Show();
        }

        public void listele()
        {
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();

            komut = new SqlCommand("SELECT Kitap.Kitap_id, Kitap.Kitap_ad, Kitap.Sayfa_sayisi, Kitap.ISBN, " +
                "Kitap.Adet, Yazarlar.Yazar_id, Yazarlar.Yazar_ad, Yazarlar.Yazar_soyad, Kategori.Kategori_id, " +
                "Kategori.Kategori_ad, Kitap_Yayinevi.Basim_tarihi " +
                "FROM Kitap inner join Kutuphane on Kitap.Kütüphane_id=Kutuphane.Kutuphane_id " +
                "inner join Yazarlar on Kitap.Yazar_id=Yazarlar.Yazar_id " +
                "inner join Kategori on Kitap.Kategori_id=Kategori.Kategori_id " +
                "inner join Kitap_Yayinevi on Kitap.Kitap_id=Kitap_Yayinevi.Kitap_id " +
                "where Kitap.Kütüphane_id = @kid", baglan);
            komut.Parameters.AddWithValue("@kid", kutuphaneId);

            da = new SqlDataAdapter(komut);
            tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }



        public void Sil(int id)
        {
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();

            komut = new SqlCommand("DELETE FROM Kitap_Yayinevi where Kitap_id=@id", baglan);
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Sil(id);
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            komut = new SqlCommand("Delete from Kitap where Kitap_id = @id", baglan);
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglan.Close();
        }


        private void ekle_Click(object sender, EventArgs e)
        {
            int yazarId;
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    komut = new SqlCommand("Select * from Yazarlar where (Yazar_ad like '%' + @yazar_ad +'%' and Yazar_soyad like '%' +@yazar_soyad+'%')", baglan);
                    komut.Parameters.AddWithValue("@yazar_ad", yazarAdTxt.Text);
                    komut.Parameters.AddWithValue("@yazar_soyad", yazarSoyadTxt.Text);
                    var dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.IsDBNull(dr.GetOrdinal("Yazar_id")))
                        {
                            komut = new SqlCommand("insert into Yazarlar(Yazar_ad,Yazar_soyad) values (@y_ad,@y_soyad)", baglan);
                            komut.Parameters.AddWithValue("@y_ad", yazarAdTxt.Text);
                            komut.Parameters.AddWithValue("@y_soyad", yazarSoyadTxt.Text);
                        }
                        else
                        {
                            komut = new SqlCommand("insert into Kitap(Kitap_ad,Sayfa_sayisi,Adet,ISBN,Yazar_id,Kütüphane_id) values (@ad,@sayfa,@adet,@ısbn,@y_id,@kt_id)", baglan);
                            komut.Parameters.AddWithValue("@ad", kitapAdTxt.Text);
                            komut.Parameters.AddWithValue("@sayfa", sayfaSayisiTxt.Text);
                            komut.Parameters.AddWithValue("@adet", adetTxt.Text);
                            komut.Parameters.AddWithValue("@ısbn", isbnTxt.Text);
                            komut.Parameters.AddWithValue("@y_id", dr.GetInt32(0));
                            komut.Parameters.AddWithValue("@kt_id", kutuphaneId);
                        }
                        yazarId = dr.GetInt32(0);
                    }
                    dr.Close();

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kitap kaydı yapıldı.");
                    baglan.Close();
                    listele();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata var" + hata.Message);
            }
        }

        private void kitapAraBtn_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("SELECT * FROM Kitap Where Kitap_id=@id", baglan);
            komut.Parameters.AddWithValue("@id", arananKitapTxt.Text);
            da = new SqlDataAdapter(komut);
            tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }


        public void kitap_güncelle()
        {
            komut = new SqlCommand("update Kitap Set Kitap_ad=@ad,Sayfa_sayisi=@sayfa,Adet=@adet,ISBN=@ısbn Where Kitap_id=@id", baglan);

            komut.Parameters.AddWithValue("@ad", kitapAdTxt.Text);
            komut.Parameters.AddWithValue("@sayfa", sayfaSayisiTxt.Text);
            komut.Parameters.AddWithValue("@adet", adetTxt.Text);
            komut.Parameters.AddWithValue("@ısbn", isbnTxt.Text);

            komut.Parameters.AddWithValue("id", dataGridView1.Rows[i].Cells[0].Value);
            komut.ExecuteNonQuery();
        }
        public void yazar_güncelle()
        {
            komut = new SqlCommand("update Yazarlar Set Yazar_ad=@ad, Yazar_soyad = @soyad where Yazar_id=@id", baglan);
            komut.Parameters.AddWithValue("@ad", yazarAdTxt.Text);
            komut.Parameters.AddWithValue("@soyad", yazarSoyadTxt.Text);
            komut.Parameters.AddWithValue("id", dataGridView1.Rows[i].Cells[5].Value);

            komut.ExecuteNonQuery();
        }

        public void katagori_guncelle()
        {
            komut = new SqlCommand("update Kategori Set Kategori_ad=@ad  where Kategori_id=@id ", baglan);
            komut.Parameters.AddWithValue("@ad", kategoriAdTxt.Text);
            komut.Parameters.AddWithValue("id", dataGridView1.Rows[i].Cells[7].Value);
            komut.ExecuteNonQuery();
        }
        public void kitap_yayınevi_güncelle()
        {
            komut = new SqlCommand("update Kitap_Yayinevi Set Basim_tarihi=@bt where Kitap_id=@id  ", baglan);
            komut.Parameters.AddWithValue("@bt", basimTarihiTxt.Text);
            komut.Parameters.AddWithValue("id", dataGridView1.Rows[i].Cells[0].Value);
            komut.ExecuteNonQuery();

        }
        public void yayınevi_guncelle()
        {
            komut = new SqlCommand("update Yayinevi Set Yayinevi_ad=@ad  where Yayinevi_id=@id ", baglan);
            komut.Parameters.AddWithValue("@ad", yayineviAdTxt.Text);
            komut.Parameters.AddWithValue("id", dataGridView1.Rows[i].Cells[15].Value);
            komut.ExecuteNonQuery();
        }

        
        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();

            kitap_güncelle();
            yazar_güncelle();
            katagori_guncelle();
            kitap_yayınevi_güncelle();
            yayınevi_guncelle();


            baglan.Close();
            listele();

        }

        private void listeleBtn_Click_1(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            kitapAdTxt.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            sayfaSayisiTxt.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            adetTxt.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            isbnTxt.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            yazarAdTxt.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            yazarSoyadTxt.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            kategoriAdTxt.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
            basimTarihiTxt.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
        }
    }

}
