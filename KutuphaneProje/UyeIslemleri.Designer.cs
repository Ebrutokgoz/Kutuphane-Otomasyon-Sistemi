
namespace KutuphaneProje
{
    partial class UyeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeIslemleri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kayitAraBtn = new System.Windows.Forms.Button();
            this.arananKayitIdLbl = new System.Windows.Forms.Label();
            this.eklePnl = new System.Windows.Forms.Panel();
            this.adLbl = new System.Windows.Forms.Label();
            this.soyadLbl = new System.Windows.Forms.Label();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.telefonLbl = new System.Windows.Forms.Label();
            this.epostaLbl = new System.Windows.Forms.Label();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.epostaTxt = new System.Windows.Forms.TextBox();
            this.telefonTxt = new System.Windows.Forms.TextBox();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.uyeIdAraTxt = new System.Windows.Forms.TextBox();
            this.uyeListeleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.personelAdLbl = new System.Windows.Forms.Label();
            this.kutuphaneAdLbl = new System.Windows.Forms.Label();
            this.uyeEkleBtn = new System.Windows.Forms.Button();
            this.uyeGuncelleBtn = new System.Windows.Forms.Button();
            this.uyeSilBtn = new System.Windows.Forms.Button();
            this.ekleKaydetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.eklePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1147, 407);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kayitAraBtn
            // 
            this.kayitAraBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayitAraBtn.Location = new System.Drawing.Point(368, 316);
            this.kayitAraBtn.Name = "kayitAraBtn";
            this.kayitAraBtn.Size = new System.Drawing.Size(75, 36);
            this.kayitAraBtn.TabIndex = 38;
            this.kayitAraBtn.Text = "Ara";
            this.kayitAraBtn.UseVisualStyleBackColor = true;
            this.kayitAraBtn.Click += new System.EventHandler(this.kayitAraBtn_Click);
            // 
            // arananKayitIdLbl
            // 
            this.arananKayitIdLbl.AutoSize = true;
            this.arananKayitIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arananKayitIdLbl.Location = new System.Drawing.Point(107, 325);
            this.arananKayitIdLbl.Name = "arananKayitIdLbl";
            this.arananKayitIdLbl.Size = new System.Drawing.Size(61, 18);
            this.arananKayitIdLbl.TabIndex = 39;
            this.arananKayitIdLbl.Text = "Üye  id :";
            // 
            // eklePnl
            // 
            this.eklePnl.Controls.Add(this.adLbl);
            this.eklePnl.Controls.Add(this.soyadLbl);
            this.eklePnl.Controls.Add(this.guncelleBtn);
            this.eklePnl.Controls.Add(this.telefonLbl);
            this.eklePnl.Controls.Add(this.epostaLbl);
            this.eklePnl.Controls.Add(this.ekleBtn);
            this.eklePnl.Controls.Add(this.soyadTxt);
            this.eklePnl.Controls.Add(this.epostaTxt);
            this.eklePnl.Controls.Add(this.telefonTxt);
            this.eklePnl.Controls.Add(this.adTxt);
            this.eklePnl.Location = new System.Drawing.Point(621, 12);
            this.eklePnl.Name = "eklePnl";
            this.eklePnl.Size = new System.Drawing.Size(718, 340);
            this.eklePnl.TabIndex = 40;
            this.eklePnl.Visible = false;
            // 
            // adLbl
            // 
            this.adLbl.AutoSize = true;
            this.adLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adLbl.Location = new System.Drawing.Point(83, 41);
            this.adLbl.Name = "adLbl";
            this.adLbl.Size = new System.Drawing.Size(33, 18);
            this.adLbl.TabIndex = 47;
            this.adLbl.Text = "Ad :";
            // 
            // soyadLbl
            // 
            this.soyadLbl.AutoSize = true;
            this.soyadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyadLbl.Location = new System.Drawing.Point(58, 120);
            this.soyadLbl.Name = "soyadLbl";
            this.soyadLbl.Size = new System.Drawing.Size(58, 18);
            this.soyadLbl.TabIndex = 46;
            this.soyadLbl.Text = "Soyad :";
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelleBtn.Location = new System.Drawing.Point(298, 242);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(181, 57);
            this.guncelleBtn.TabIndex = 47;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Visible = false;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // telefonLbl
            // 
            this.telefonLbl.AutoSize = true;
            this.telefonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonLbl.Location = new System.Drawing.Point(388, 119);
            this.telefonLbl.Name = "telefonLbl";
            this.telefonLbl.Size = new System.Drawing.Size(65, 18);
            this.telefonLbl.TabIndex = 45;
            this.telefonLbl.Text = "Telefon :";
            // 
            // epostaLbl
            // 
            this.epostaLbl.AutoSize = true;
            this.epostaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epostaLbl.Location = new System.Drawing.Point(385, 37);
            this.epostaLbl.Name = "epostaLbl";
            this.epostaLbl.Size = new System.Drawing.Size(68, 18);
            this.epostaLbl.TabIndex = 44;
            this.epostaLbl.Text = "E-posta :";
            // 
            // ekleBtn
            // 
            this.ekleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleBtn.Location = new System.Drawing.Point(308, 232);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(155, 57);
            this.ekleBtn.TabIndex = 45;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Visible = false;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // soyadTxt
            // 
            this.soyadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyadTxt.Location = new System.Drawing.Point(147, 119);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(164, 22);
            this.soyadTxt.TabIndex = 42;
            // 
            // epostaTxt
            // 
            this.epostaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epostaTxt.Location = new System.Drawing.Point(487, 33);
            this.epostaTxt.Name = "epostaTxt";
            this.epostaTxt.Size = new System.Drawing.Size(164, 22);
            this.epostaTxt.TabIndex = 40;
            // 
            // telefonTxt
            // 
            this.telefonTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonTxt.Location = new System.Drawing.Point(487, 116);
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(164, 22);
            this.telefonTxt.TabIndex = 38;
            // 
            // adTxt
            // 
            this.adTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adTxt.Location = new System.Drawing.Point(147, 37);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(164, 22);
            this.adTxt.TabIndex = 36;
            // 
            // uyeIdAraTxt
            // 
            this.uyeIdAraTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeIdAraTxt.Location = new System.Drawing.Point(174, 325);
            this.uyeIdAraTxt.Name = "uyeIdAraTxt";
            this.uyeIdAraTxt.Size = new System.Drawing.Size(164, 22);
            this.uyeIdAraTxt.TabIndex = 43;
            // 
            // uyeListeleBtn
            // 
            this.uyeListeleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeListeleBtn.Location = new System.Drawing.Point(94, 69);
            this.uyeListeleBtn.Name = "uyeListeleBtn";
            this.uyeListeleBtn.Size = new System.Drawing.Size(133, 61);
            this.uyeListeleBtn.TabIndex = 44;
            this.uyeListeleBtn.Text = "Üyeleri Listele";
            this.uyeListeleBtn.UseVisualStyleBackColor = true;
            this.uyeListeleBtn.Click += new System.EventHandler(this.uyeListeleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silBtn.Location = new System.Drawing.Point(1263, 537);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(129, 53);
            this.silBtn.TabIndex = 46;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Visible = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // personelAdLbl
            // 
            this.personelAdLbl.AutoSize = true;
            this.personelAdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelAdLbl.Location = new System.Drawing.Point(71, 785);
            this.personelAdLbl.Name = "personelAdLbl";
            this.personelAdLbl.Size = new System.Drawing.Size(64, 13);
            this.personelAdLbl.TabIndex = 48;
            this.personelAdLbl.Text = "Ad_Soyad";
            // 
            // kutuphaneAdLbl
            // 
            this.kutuphaneAdLbl.AutoSize = true;
            this.kutuphaneAdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kutuphaneAdLbl.Location = new System.Drawing.Point(1289, 785);
            this.kutuphaneAdLbl.Name = "kutuphaneAdLbl";
            this.kutuphaneAdLbl.Size = new System.Drawing.Size(93, 13);
            this.kutuphaneAdLbl.TabIndex = 49;
            this.kutuphaneAdLbl.Text = "... Kütüphanesi";
            // 
            // uyeEkleBtn
            // 
            this.uyeEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeEkleBtn.Location = new System.Drawing.Point(293, 69);
            this.uyeEkleBtn.Name = "uyeEkleBtn";
            this.uyeEkleBtn.Size = new System.Drawing.Size(133, 61);
            this.uyeEkleBtn.TabIndex = 50;
            this.uyeEkleBtn.Text = "Üye Ekle";
            this.uyeEkleBtn.UseVisualStyleBackColor = true;
            this.uyeEkleBtn.Click += new System.EventHandler(this.uyeEkleBtn_Click);
            // 
            // uyeGuncelleBtn
            // 
            this.uyeGuncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeGuncelleBtn.Location = new System.Drawing.Point(94, 161);
            this.uyeGuncelleBtn.Name = "uyeGuncelleBtn";
            this.uyeGuncelleBtn.Size = new System.Drawing.Size(133, 61);
            this.uyeGuncelleBtn.TabIndex = 51;
            this.uyeGuncelleBtn.Text = "Üye Güncelle";
            this.uyeGuncelleBtn.UseVisualStyleBackColor = true;
            this.uyeGuncelleBtn.Click += new System.EventHandler(this.uyeGuncelleBtn_Click);
            // 
            // uyeSilBtn
            // 
            this.uyeSilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeSilBtn.Location = new System.Drawing.Point(293, 161);
            this.uyeSilBtn.Name = "uyeSilBtn";
            this.uyeSilBtn.Size = new System.Drawing.Size(133, 61);
            this.uyeSilBtn.TabIndex = 52;
            this.uyeSilBtn.Text = "Üye Sil";
            this.uyeSilBtn.UseVisualStyleBackColor = true;
            this.uyeSilBtn.Click += new System.EventHandler(this.uyeSilBtn_Click);
            // 
            // ekleKaydetBtn
            // 
            this.ekleKaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleKaydetBtn.Location = new System.Drawing.Point(1263, 512);
            this.ekleKaydetBtn.Name = "ekleKaydetBtn";
            this.ekleKaydetBtn.Size = new System.Drawing.Size(129, 57);
            this.ekleKaydetBtn.TabIndex = 48;
            this.ekleKaydetBtn.Text = "Kaydet";
            this.ekleKaydetBtn.UseVisualStyleBackColor = true;
            this.ekleKaydetBtn.Visible = false;
            this.ekleKaydetBtn.Click += new System.EventHandler(this.ekleKaydetBtn_Click);
            // 
            // UyeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1435, 825);
            this.Controls.Add(this.ekleKaydetBtn);
            this.Controls.Add(this.uyeSilBtn);
            this.Controls.Add(this.uyeGuncelleBtn);
            this.Controls.Add(this.uyeEkleBtn);
            this.Controls.Add(this.kutuphaneAdLbl);
            this.Controls.Add(this.personelAdLbl);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.uyeListeleBtn);
            this.Controls.Add(this.uyeIdAraTxt);
            this.Controls.Add(this.eklePnl);
            this.Controls.Add(this.arananKayitIdLbl);
            this.Controls.Add(this.kayitAraBtn);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UyeIslemleri";
            this.Text = "Üye İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.eklePnl.ResumeLayout(false);
            this.eklePnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kayitAraBtn;
        private System.Windows.Forms.Label arananKayitIdLbl;
        private System.Windows.Forms.Panel eklePnl;
        private System.Windows.Forms.Label adLbl;
        private System.Windows.Forms.Label soyadLbl;
        private System.Windows.Forms.Label telefonLbl;
        private System.Windows.Forms.Label epostaLbl;
        private System.Windows.Forms.TextBox soyadTxt;
        private System.Windows.Forms.TextBox epostaTxt;
        private System.Windows.Forms.TextBox telefonTxt;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.TextBox uyeIdAraTxt;
        private System.Windows.Forms.Button uyeListeleBtn;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button guncelleBtn;
        public System.Windows.Forms.Label personelAdLbl;
        public System.Windows.Forms.Label kutuphaneAdLbl;
        private System.Windows.Forms.Button uyeEkleBtn;
        private System.Windows.Forms.Button uyeGuncelleBtn;
        private System.Windows.Forms.Button uyeSilBtn;
        private System.Windows.Forms.Button ekleKaydetBtn;
    }
}