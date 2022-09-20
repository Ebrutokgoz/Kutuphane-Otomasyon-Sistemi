
namespace KutuphaneProje
{
    partial class KitapIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapIslemleri));
            this.silBtn = new System.Windows.Forms.Button();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.kategoriLbl = new System.Windows.Forms.Label();
            this.yayineviLbl = new System.Windows.Forms.Label();
            this.basimTarihiLbl = new System.Windows.Forms.Label();
            this.kitapAdLbl = new System.Windows.Forms.Label();
            this.sayfaSayisiLbl = new System.Windows.Forms.Label();
            this.adetLbl = new System.Windows.Forms.Label();
            this.isbnLbl = new System.Windows.Forms.Label();
            this.yazarSoyadLbl = new System.Windows.Forms.Label();
            this.yazarAdLbl = new System.Windows.Forms.Label();
            this.arananKitapIdLbl = new System.Windows.Forms.Label();
            this.kategoriAdTxt = new System.Windows.Forms.TextBox();
            this.yayineviAdTxt = new System.Windows.Forms.TextBox();
            this.basimTarihiTxt = new System.Windows.Forms.TextBox();
            this.kitapAdTxt = new System.Windows.Forms.TextBox();
            this.sayfaSayisiTxt = new System.Windows.Forms.TextBox();
            this.adetTxt = new System.Windows.Forms.TextBox();
            this.isbnTxt = new System.Windows.Forms.TextBox();
            this.yazarAdTxt = new System.Windows.Forms.TextBox();
            this.yazarSoyadTxt = new System.Windows.Forms.TextBox();
            this.arananKitapTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.kitapAraBtn = new System.Windows.Forms.Button();
            this.personelAdLbl = new System.Windows.Forms.Label();
            this.kutuphaneAdLbl = new System.Windows.Forms.Label();
            this.eklePnl = new System.Windows.Forms.Panel();
            this.kitapEkleBtn = new System.Windows.Forms.Button();
            this.kitapGuncelleBtn = new System.Windows.Forms.Button();
            this.kitapSilBtn = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.silBilgiLbl = new System.Windows.Forms.Label();
            this.silPnl = new System.Windows.Forms.Panel();
            this.listeleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.eklePnl.SuspendLayout();
            this.panel.SuspendLayout();
            this.silPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // silBtn
            // 
            this.silBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silBtn.Location = new System.Drawing.Point(65, 179);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(156, 56);
            this.silBtn.TabIndex = 1;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.sil_Click);
            // 
            // ekleBtn
            // 
            this.ekleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleBtn.Location = new System.Drawing.Point(396, 262);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(103, 55);
            this.ekleBtn.TabIndex = 2;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Visible = false;
            this.ekleBtn.Click += new System.EventHandler(this.ekle_Click);
            // 
            // kategoriLbl
            // 
            this.kategoriLbl.AutoSize = true;
            this.kategoriLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriLbl.Location = new System.Drawing.Point(47, 213);
            this.kategoriLbl.Name = "kategoriLbl";
            this.kategoriLbl.Size = new System.Drawing.Size(59, 15);
            this.kategoriLbl.TabIndex = 6;
            this.kategoriLbl.Text = "Kategori :";
            // 
            // yayineviLbl
            // 
            this.yayineviLbl.AutoSize = true;
            this.yayineviLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yayineviLbl.Location = new System.Drawing.Point(448, 44);
            this.yayineviLbl.Name = "yayineviLbl";
            this.yayineviLbl.Size = new System.Drawing.Size(57, 15);
            this.yayineviLbl.TabIndex = 8;
            this.yayineviLbl.Text = "Yayınevi :";
            // 
            // basimTarihiLbl
            // 
            this.basimTarihiLbl.AutoSize = true;
            this.basimTarihiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basimTarihiLbl.Location = new System.Drawing.Point(427, 87);
            this.basimTarihiLbl.Name = "basimTarihiLbl";
            this.basimTarihiLbl.Size = new System.Drawing.Size(78, 15);
            this.basimTarihiLbl.TabIndex = 9;
            this.basimTarihiLbl.Text = "Basım tarihi :";
            // 
            // kitapAdLbl
            // 
            this.kitapAdLbl.AutoSize = true;
            this.kitapAdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapAdLbl.Location = new System.Drawing.Point(41, 20);
            this.kitapAdLbl.Name = "kitapAdLbl";
            this.kitapAdLbl.Size = new System.Drawing.Size(58, 15);
            this.kitapAdLbl.TabIndex = 11;
            this.kitapAdLbl.Text = "Kitap ad :";
            // 
            // sayfaSayisiLbl
            // 
            this.sayfaSayisiLbl.AutoSize = true;
            this.sayfaSayisiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sayfaSayisiLbl.Location = new System.Drawing.Point(23, 72);
            this.sayfaSayisiLbl.Name = "sayfaSayisiLbl";
            this.sayfaSayisiLbl.Size = new System.Drawing.Size(76, 15);
            this.sayfaSayisiLbl.TabIndex = 12;
            this.sayfaSayisiLbl.Text = "Sayfa sayısı :";
            // 
            // adetLbl
            // 
            this.adetLbl.AutoSize = true;
            this.adetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adetLbl.Location = new System.Drawing.Point(62, 119);
            this.adetLbl.Name = "adetLbl";
            this.adetLbl.Size = new System.Drawing.Size(37, 15);
            this.adetLbl.TabIndex = 13;
            this.adetLbl.Text = "Adet :";
            // 
            // isbnLbl
            // 
            this.isbnLbl.AutoSize = true;
            this.isbnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLbl.Location = new System.Drawing.Point(62, 164);
            this.isbnLbl.Name = "isbnLbl";
            this.isbnLbl.Size = new System.Drawing.Size(44, 15);
            this.isbnLbl.TabIndex = 14;
            this.isbnLbl.Text = " ISBN :";
            // 
            // yazarSoyadLbl
            // 
            this.yazarSoyadLbl.AutoSize = true;
            this.yazarSoyadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yazarSoyadLbl.Location = new System.Drawing.Point(426, 186);
            this.yazarSoyadLbl.Name = "yazarSoyadLbl";
            this.yazarSoyadLbl.Size = new System.Drawing.Size(79, 15);
            this.yazarSoyadLbl.TabIndex = 17;
            this.yazarSoyadLbl.Text = "Yazar soyad :";
            // 
            // yazarAdLbl
            // 
            this.yazarAdLbl.AutoSize = true;
            this.yazarAdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yazarAdLbl.Location = new System.Drawing.Point(444, 139);
            this.yazarAdLbl.Name = "yazarAdLbl";
            this.yazarAdLbl.Size = new System.Drawing.Size(61, 15);
            this.yazarAdLbl.TabIndex = 18;
            this.yazarAdLbl.Text = "Yazar ad :";
            // 
            // arananKitapIdLbl
            // 
            this.arananKitapIdLbl.AutoSize = true;
            this.arananKitapIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arananKitapIdLbl.Location = new System.Drawing.Point(31, 369);
            this.arananKitapIdLbl.Name = "arananKitapIdLbl";
            this.arananKitapIdLbl.Size = new System.Drawing.Size(64, 18);
            this.arananKitapIdLbl.TabIndex = 19;
            this.arananKitapIdLbl.Text = "Kitap Id :";
            // 
            // kategoriAdTxt
            // 
            this.kategoriAdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriAdTxt.Location = new System.Drawing.Point(125, 210);
            this.kategoriAdTxt.Name = "kategoriAdTxt";
            this.kategoriAdTxt.Size = new System.Drawing.Size(164, 21);
            this.kategoriAdTxt.TabIndex = 21;
            // 
            // yayineviAdTxt
            // 
            this.yayineviAdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yayineviAdTxt.Location = new System.Drawing.Point(551, 38);
            this.yayineviAdTxt.Name = "yayineviAdTxt";
            this.yayineviAdTxt.Size = new System.Drawing.Size(164, 21);
            this.yayineviAdTxt.TabIndex = 23;
            // 
            // basimTarihiTxt
            // 
            this.basimTarihiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basimTarihiTxt.Location = new System.Drawing.Point(551, 84);
            this.basimTarihiTxt.Name = "basimTarihiTxt";
            this.basimTarihiTxt.Size = new System.Drawing.Size(164, 21);
            this.basimTarihiTxt.TabIndex = 24;
            // 
            // kitapAdTxt
            // 
            this.kitapAdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapAdTxt.Location = new System.Drawing.Point(125, 20);
            this.kitapAdTxt.Name = "kitapAdTxt";
            this.kitapAdTxt.Size = new System.Drawing.Size(164, 21);
            this.kitapAdTxt.TabIndex = 26;
            // 
            // sayfaSayisiTxt
            // 
            this.sayfaSayisiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sayfaSayisiTxt.Location = new System.Drawing.Point(125, 66);
            this.sayfaSayisiTxt.Name = "sayfaSayisiTxt";
            this.sayfaSayisiTxt.Size = new System.Drawing.Size(164, 21);
            this.sayfaSayisiTxt.TabIndex = 27;
            // 
            // adetTxt
            // 
            this.adetTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adetTxt.Location = new System.Drawing.Point(125, 113);
            this.adetTxt.Name = "adetTxt";
            this.adetTxt.Size = new System.Drawing.Size(164, 21);
            this.adetTxt.TabIndex = 28;
            // 
            // isbnTxt
            // 
            this.isbnTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnTxt.Location = new System.Drawing.Point(125, 161);
            this.isbnTxt.Name = "isbnTxt";
            this.isbnTxt.Size = new System.Drawing.Size(164, 21);
            this.isbnTxt.TabIndex = 29;
            // 
            // yazarAdTxt
            // 
            this.yazarAdTxt.Location = new System.Drawing.Point(551, 138);
            this.yazarAdTxt.Name = "yazarAdTxt";
            this.yazarAdTxt.Size = new System.Drawing.Size(164, 20);
            this.yazarAdTxt.TabIndex = 30;
            // 
            // yazarSoyadTxt
            // 
            this.yazarSoyadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yazarSoyadTxt.Location = new System.Drawing.Point(551, 183);
            this.yazarSoyadTxt.Name = "yazarSoyadTxt";
            this.yazarSoyadTxt.Size = new System.Drawing.Size(164, 21);
            this.yazarSoyadTxt.TabIndex = 31;
            // 
            // arananKitapTxt
            // 
            this.arananKitapTxt.Location = new System.Drawing.Point(120, 367);
            this.arananKitapTxt.Name = "arananKitapTxt";
            this.arananKitapTxt.Size = new System.Drawing.Size(164, 20);
            this.arananKitapTxt.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(834, 350);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelleBtn.Location = new System.Drawing.Point(494, 262);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(120, 55);
            this.guncelleBtn.TabIndex = 36;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Visible = false;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // kitapAraBtn
            // 
            this.kitapAraBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapAraBtn.Location = new System.Drawing.Point(306, 357);
            this.kitapAraBtn.Name = "kitapAraBtn";
            this.kitapAraBtn.Size = new System.Drawing.Size(75, 36);
            this.kitapAraBtn.TabIndex = 37;
            this.kitapAraBtn.Text = "Ara";
            this.kitapAraBtn.UseVisualStyleBackColor = true;
            this.kitapAraBtn.Click += new System.EventHandler(this.kitapAraBtn_Click);
            // 
            // personelAdLbl
            // 
            this.personelAdLbl.AutoSize = true;
            this.personelAdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelAdLbl.Location = new System.Drawing.Point(71, 785);
            this.personelAdLbl.Name = "personelAdLbl";
            this.personelAdLbl.Size = new System.Drawing.Size(64, 13);
            this.personelAdLbl.TabIndex = 38;
            this.personelAdLbl.Text = "Ad_Soyad";
            // 
            // kutuphaneAdLbl
            // 
            this.kutuphaneAdLbl.AutoSize = true;
            this.kutuphaneAdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kutuphaneAdLbl.Location = new System.Drawing.Point(1289, 785);
            this.kutuphaneAdLbl.Name = "kutuphaneAdLbl";
            this.kutuphaneAdLbl.Size = new System.Drawing.Size(93, 13);
            this.kutuphaneAdLbl.TabIndex = 39;
            this.kutuphaneAdLbl.Text = "... Kütüphanesi";
            // 
            // eklePnl
            // 
            this.eklePnl.Controls.Add(this.kitapAdLbl);
            this.eklePnl.Controls.Add(this.kitapAdTxt);
            this.eklePnl.Controls.Add(this.sayfaSayisiLbl);
            this.eklePnl.Controls.Add(this.sayfaSayisiTxt);
            this.eklePnl.Controls.Add(this.adetTxt);
            this.eklePnl.Controls.Add(this.adetLbl);
            this.eklePnl.Controls.Add(this.isbnTxt);
            this.eklePnl.Controls.Add(this.yazarSoyadTxt);
            this.eklePnl.Controls.Add(this.basimTarihiLbl);
            this.eklePnl.Controls.Add(this.yazarAdLbl);
            this.eklePnl.Controls.Add(this.isbnLbl);
            this.eklePnl.Controls.Add(this.yazarSoyadLbl);
            this.eklePnl.Controls.Add(this.yazarAdTxt);
            this.eklePnl.Controls.Add(this.kategoriLbl);
            this.eklePnl.Controls.Add(this.basimTarihiTxt);
            this.eklePnl.Controls.Add(this.kategoriAdTxt);
            this.eklePnl.Controls.Add(this.yayineviAdTxt);
            this.eklePnl.Controls.Add(this.yayineviLbl);
            this.eklePnl.Location = new System.Drawing.Point(76, 3);
            this.eklePnl.Name = "eklePnl";
            this.eklePnl.Size = new System.Drawing.Size(843, 253);
            this.eklePnl.TabIndex = 40;
            this.eklePnl.Visible = false;
            // 
            // kitapEkleBtn
            // 
            this.kitapEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapEkleBtn.Location = new System.Drawing.Point(229, 45);
            this.kitapEkleBtn.Name = "kitapEkleBtn";
            this.kitapEkleBtn.Size = new System.Drawing.Size(162, 68);
            this.kitapEkleBtn.TabIndex = 41;
            this.kitapEkleBtn.Text = "Kitap Ekle";
            this.kitapEkleBtn.UseVisualStyleBackColor = true;
            this.kitapEkleBtn.Click += new System.EventHandler(this.kitapEkleBtn_Click);
            // 
            // kitapGuncelleBtn
            // 
            this.kitapGuncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapGuncelleBtn.Location = new System.Drawing.Point(40, 159);
            this.kitapGuncelleBtn.Name = "kitapGuncelleBtn";
            this.kitapGuncelleBtn.Size = new System.Drawing.Size(162, 68);
            this.kitapGuncelleBtn.TabIndex = 42;
            this.kitapGuncelleBtn.Text = "Kitap Güncelle";
            this.kitapGuncelleBtn.UseVisualStyleBackColor = true;
            this.kitapGuncelleBtn.Click += new System.EventHandler(this.kitapGuncelleBtn_Click);
            // 
            // kitapSilBtn
            // 
            this.kitapSilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapSilBtn.Location = new System.Drawing.Point(229, 159);
            this.kitapSilBtn.Name = "kitapSilBtn";
            this.kitapSilBtn.Size = new System.Drawing.Size(162, 68);
            this.kitapSilBtn.TabIndex = 43;
            this.kitapSilBtn.Text = "Kitap Sil";
            this.kitapSilBtn.UseVisualStyleBackColor = true;
            this.kitapSilBtn.Click += new System.EventHandler(this.kitapSilBtn_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dataGridView1);
            this.panel.Controls.Add(this.arananKitapIdLbl);
            this.panel.Controls.Add(this.arananKitapTxt);
            this.panel.Controls.Add(this.kitapAraBtn);
            this.panel.Controls.Add(this.eklePnl);
            this.panel.Controls.Add(this.guncelleBtn);
            this.panel.Controls.Add(this.ekleBtn);
            this.panel.Location = new System.Drawing.Point(397, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(994, 778);
            this.panel.TabIndex = 44;
            // 
            // silBilgiLbl
            // 
            this.silBilgiLbl.AutoSize = true;
            this.silBilgiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silBilgiLbl.Location = new System.Drawing.Point(31, 21);
            this.silBilgiLbl.Name = "silBilgiLbl";
            this.silBilgiLbl.Size = new System.Drawing.Size(263, 100);
            this.silBilgiLbl.TabIndex = 45;
            this.silBilgiLbl.Text = "\'Kitap Listele\'ye tıklayarak veya \r\narama yaparak kitapları listeledikten \r\nsonra" +
    " tablodan silmek istediğiniz \r\nkitabı seçiniz. Silme işlemini\r\ntamamlamak için \'" +
    "Sil\'e tıklayınız.\r\n";
            // 
            // silPnl
            // 
            this.silPnl.Controls.Add(this.silBilgiLbl);
            this.silPnl.Controls.Add(this.silBtn);
            this.silPnl.Location = new System.Drawing.Point(40, 355);
            this.silPnl.Name = "silPnl";
            this.silPnl.Size = new System.Drawing.Size(316, 328);
            this.silPnl.TabIndex = 46;
            this.silPnl.Visible = false;
            // 
            // listeleBtn
            // 
            this.listeleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeleBtn.Location = new System.Drawing.Point(40, 49);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(162, 68);
            this.listeleBtn.TabIndex = 47;
            this.listeleBtn.Text = "Kitapları Listele";
            this.listeleBtn.UseVisualStyleBackColor = true;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click_1);
            // 
            // KitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1435, 825);
            this.Controls.Add(this.listeleBtn);
            this.Controls.Add(this.silPnl);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.kitapSilBtn);
            this.Controls.Add(this.kitapGuncelleBtn);
            this.Controls.Add(this.kitapEkleBtn);
            this.Controls.Add(this.kutuphaneAdLbl);
            this.Controls.Add(this.personelAdLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapIslemleri";
            this.Text = "KitapIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.eklePnl.ResumeLayout(false);
            this.eklePnl.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.silPnl.ResumeLayout(false);
            this.silPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Label kategoriLbl;
        private System.Windows.Forms.Label yayineviLbl;
        private System.Windows.Forms.Label basimTarihiLbl;
        private System.Windows.Forms.Label kitapAdLbl;
        private System.Windows.Forms.Label sayfaSayisiLbl;
        private System.Windows.Forms.Label adetLbl;
        private System.Windows.Forms.Label isbnLbl;
        private System.Windows.Forms.Label yazarSoyadLbl;
        private System.Windows.Forms.Label yazarAdLbl;
        private System.Windows.Forms.Label arananKitapIdLbl;
        private System.Windows.Forms.TextBox kategoriAdTxt;
        private System.Windows.Forms.TextBox yayineviAdTxt;
        private System.Windows.Forms.TextBox basimTarihiTxt;
        private System.Windows.Forms.TextBox kitapAdTxt;
        private System.Windows.Forms.TextBox sayfaSayisiTxt;
        private System.Windows.Forms.TextBox adetTxt;
        private System.Windows.Forms.TextBox isbnTxt;
        private System.Windows.Forms.TextBox yazarAdTxt;
        private System.Windows.Forms.TextBox yazarSoyadTxt;
        private System.Windows.Forms.TextBox arananKitapTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Button kitapAraBtn;
        public System.Windows.Forms.Label personelAdLbl;
        public System.Windows.Forms.Label kutuphaneAdLbl;
        private System.Windows.Forms.Panel eklePnl;
        private System.Windows.Forms.Button kitapEkleBtn;
        private System.Windows.Forms.Button kitapGuncelleBtn;
        private System.Windows.Forms.Button kitapSilBtn;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label silBilgiLbl;
        private System.Windows.Forms.Panel silPnl;
        private System.Windows.Forms.Button listeleBtn;
    }
}