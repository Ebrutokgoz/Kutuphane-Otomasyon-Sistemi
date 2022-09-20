
namespace KutuphaneProje
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.girisPnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.epostaLbl = new System.Windows.Forms.Label();
            this.girisBtn = new System.Windows.Forms.Button();
            this.epostaTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.sifreLbl = new System.Windows.Forms.Label();
            this.girisPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // girisPnl
            // 
            this.girisPnl.BackColor = System.Drawing.Color.Silver;
            this.girisPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.girisPnl.Controls.Add(this.pictureBox1);
            this.girisPnl.Controls.Add(this.epostaLbl);
            this.girisPnl.Controls.Add(this.girisBtn);
            this.girisPnl.Controls.Add(this.epostaTxt);
            this.girisPnl.Controls.Add(this.sifreTxt);
            this.girisPnl.Controls.Add(this.sifreLbl);
            this.girisPnl.Location = new System.Drawing.Point(58, 92);
            this.girisPnl.Name = "girisPnl";
            this.girisPnl.Size = new System.Drawing.Size(332, 352);
            this.girisPnl.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(100, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // epostaLbl
            // 
            this.epostaLbl.AutoSize = true;
            this.epostaLbl.BackColor = System.Drawing.Color.Transparent;
            this.epostaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epostaLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.epostaLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.epostaLbl.Location = new System.Drawing.Point(21, 180);
            this.epostaLbl.Name = "epostaLbl";
            this.epostaLbl.Size = new System.Drawing.Size(68, 18);
            this.epostaLbl.TabIndex = 1;
            this.epostaLbl.Text = "E-posta :";
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.girisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.girisBtn.Location = new System.Drawing.Point(71, 290);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(183, 37);
            this.girisBtn.TabIndex = 4;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.UseVisualStyleBackColor = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // epostaTxt
            // 
            this.epostaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epostaTxt.Location = new System.Drawing.Point(100, 180);
            this.epostaTxt.Name = "epostaTxt";
            this.epostaTxt.Size = new System.Drawing.Size(201, 22);
            this.epostaTxt.TabIndex = 0;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifreTxt.Location = new System.Drawing.Point(100, 238);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(201, 22);
            this.sifreTxt.TabIndex = 3;
            // 
            // sifreLbl
            // 
            this.sifreLbl.AutoSize = true;
            this.sifreLbl.BackColor = System.Drawing.Color.Transparent;
            this.sifreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifreLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.sifreLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sifreLbl.Location = new System.Drawing.Point(43, 237);
            this.sifreLbl.Name = "sifreLbl";
            this.sifreLbl.Size = new System.Drawing.Size(46, 18);
            this.sifreLbl.TabIndex = 2;
            this.sifreLbl.Text = "Şifre :";
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 559);
            this.Controls.Add(this.girisPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.girisPnl.ResumeLayout(false);
            this.girisPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel girisPnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label epostaLbl;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Label sifreLbl;
        public System.Windows.Forms.TextBox epostaTxt;
    }
}

