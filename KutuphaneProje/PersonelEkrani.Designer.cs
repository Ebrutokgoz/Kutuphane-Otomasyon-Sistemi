
namespace KutuphaneProje
{
    partial class PersonelEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkrani));
            this.emanetIslemleriBtn = new System.Windows.Forms.Button();
            this.uyeIslemleriBtn = new System.Windows.Forms.Button();
            this.kitapIslemleriBtn = new System.Windows.Forms.Button();
            this.adSoyadLbl = new System.Windows.Forms.Label();
            this.kutuphaneAdLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emanetIslemleriBtn
            // 
            this.emanetIslemleriBtn.BackColor = System.Drawing.Color.Coral;
            this.emanetIslemleriBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emanetIslemleriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emanetIslemleriBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.emanetIslemleriBtn.Location = new System.Drawing.Point(80, 340);
            this.emanetIslemleriBtn.Name = "emanetIslemleriBtn";
            this.emanetIslemleriBtn.Size = new System.Drawing.Size(268, 90);
            this.emanetIslemleriBtn.TabIndex = 23;
            this.emanetIslemleriBtn.Text = "Emanet işlemleri için tıklayınız";
            this.emanetIslemleriBtn.UseVisualStyleBackColor = false;
            this.emanetIslemleriBtn.Click += new System.EventHandler(this.emanetIslemleriBtn_Click);
            // 
            // uyeIslemleriBtn
            // 
            this.uyeIslemleriBtn.BackColor = System.Drawing.Color.Coral;
            this.uyeIslemleriBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uyeIslemleriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeIslemleriBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uyeIslemleriBtn.Location = new System.Drawing.Point(80, 205);
            this.uyeIslemleriBtn.Name = "uyeIslemleriBtn";
            this.uyeIslemleriBtn.Size = new System.Drawing.Size(268, 90);
            this.uyeIslemleriBtn.TabIndex = 22;
            this.uyeIslemleriBtn.Text = "Üye işlemleri için tıklayınız";
            this.uyeIslemleriBtn.UseVisualStyleBackColor = false;
            this.uyeIslemleriBtn.Click += new System.EventHandler(this.uyeIslemleriBtn_Click);
            // 
            // kitapIslemleriBtn
            // 
            this.kitapIslemleriBtn.BackColor = System.Drawing.Color.Coral;
            this.kitapIslemleriBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapIslemleriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapIslemleriBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kitapIslemleriBtn.Location = new System.Drawing.Point(80, 77);
            this.kitapIslemleriBtn.Name = "kitapIslemleriBtn";
            this.kitapIslemleriBtn.Size = new System.Drawing.Size(268, 90);
            this.kitapIslemleriBtn.TabIndex = 21;
            this.kitapIslemleriBtn.Text = "Kitap işlemleri için tıklayınız";
            this.kitapIslemleriBtn.UseVisualStyleBackColor = false;
            this.kitapIslemleriBtn.Click += new System.EventHandler(this.kitapIslemleriBtn_Click);
            // 
            // adSoyadLbl
            // 
            this.adSoyadLbl.AutoSize = true;
            this.adSoyadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adSoyadLbl.Location = new System.Drawing.Point(301, 24);
            this.adSoyadLbl.Name = "adSoyadLbl";
            this.adSoyadLbl.Size = new System.Drawing.Size(61, 13);
            this.adSoyadLbl.TabIndex = 24;
            this.adSoyadLbl.Text = "Ad Soyad";
            // 
            // kutuphaneAdLbl
            // 
            this.kutuphaneAdLbl.AutoSize = true;
            this.kutuphaneAdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kutuphaneAdLbl.Location = new System.Drawing.Point(161, 485);
            this.kutuphaneAdLbl.Name = "kutuphaneAdLbl";
            this.kutuphaneAdLbl.Size = new System.Drawing.Size(93, 13);
            this.kutuphaneAdLbl.TabIndex = 25;
            this.kutuphaneAdLbl.Text = "... Kütüphanesi";
            // 
            // PersonelEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(428, 552);
            this.Controls.Add(this.kutuphaneAdLbl);
            this.Controls.Add(this.adSoyadLbl);
            this.Controls.Add(this.emanetIslemleriBtn);
            this.Controls.Add(this.uyeIslemleriBtn);
            this.Controls.Add(this.kitapIslemleriBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.PersonelEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button emanetIslemleriBtn;
        private System.Windows.Forms.Button uyeIslemleriBtn;
        private System.Windows.Forms.Button kitapIslemleriBtn;
        public System.Windows.Forms.Label adSoyadLbl;
        public System.Windows.Forms.Label kutuphaneAdLbl;
    }
}