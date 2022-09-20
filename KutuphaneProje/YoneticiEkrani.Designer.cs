
namespace KutuphaneProje
{
    partial class YoneticiEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiEkrani));
            this.personelSayfasiBtn = new System.Windows.Forms.Button();
            this.personelIslemleriBtn = new System.Windows.Forms.Button();
            this.adSoyadLbl = new System.Windows.Forms.Label();
            this.kutuphaneAdLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // personelSayfasiBtn
            // 
            this.personelSayfasiBtn.BackColor = System.Drawing.Color.Coral;
            this.personelSayfasiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personelSayfasiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelSayfasiBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.personelSayfasiBtn.Location = new System.Drawing.Point(84, 283);
            this.personelSayfasiBtn.Name = "personelSayfasiBtn";
            this.personelSayfasiBtn.Size = new System.Drawing.Size(268, 109);
            this.personelSayfasiBtn.TabIndex = 17;
            this.personelSayfasiBtn.Text = "Personel sayfasına geçmek için tıklayınız";
            this.personelSayfasiBtn.UseVisualStyleBackColor = false;
            this.personelSayfasiBtn.Click += new System.EventHandler(this.personelSayfasiBtn_Click);
            // 
            // personelIslemleriBtn
            // 
            this.personelIslemleriBtn.BackColor = System.Drawing.Color.Coral;
            this.personelIslemleriBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personelIslemleriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelIslemleriBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.personelIslemleriBtn.Location = new System.Drawing.Point(84, 111);
            this.personelIslemleriBtn.Name = "personelIslemleriBtn";
            this.personelIslemleriBtn.Size = new System.Drawing.Size(268, 106);
            this.personelIslemleriBtn.TabIndex = 16;
            this.personelIslemleriBtn.Text = "Personel işlemleri için tıklayınız";
            this.personelIslemleriBtn.UseVisualStyleBackColor = false;
            this.personelIslemleriBtn.Click += new System.EventHandler(this.personelIslemleriBtn_Click);
            // 
            // adSoyadLbl
            // 
            this.adSoyadLbl.AutoSize = true;
            this.adSoyadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adSoyadLbl.Location = new System.Drawing.Point(301, 24);
            this.adSoyadLbl.Name = "adSoyadLbl";
            this.adSoyadLbl.Size = new System.Drawing.Size(64, 13);
            this.adSoyadLbl.TabIndex = 18;
            this.adSoyadLbl.Text = "Ad_Soyad";
            // 
            // kutuphaneAdLbl
            // 
            this.kutuphaneAdLbl.AutoSize = true;
            this.kutuphaneAdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kutuphaneAdLbl.Location = new System.Drawing.Point(161, 485);
            this.kutuphaneAdLbl.Name = "kutuphaneAdLbl";
            this.kutuphaneAdLbl.Size = new System.Drawing.Size(93, 13);
            this.kutuphaneAdLbl.TabIndex = 26;
            this.kutuphaneAdLbl.Text = "... Kütüphanesi";
            // 
            // YoneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(428, 552);
            this.Controls.Add(this.kutuphaneAdLbl);
            this.Controls.Add(this.adSoyadLbl);
            this.Controls.Add(this.personelSayfasiBtn);
            this.Controls.Add(this.personelIslemleriBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YoneticiEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button personelSayfasiBtn;
        private System.Windows.Forms.Button personelIslemleriBtn;
        public System.Windows.Forms.Label adSoyadLbl;
        public System.Windows.Forms.Label kutuphaneAdLbl;
    }
}