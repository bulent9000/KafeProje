namespace KullaniciGiris
{
    partial class YetkiliGirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkiliGirisEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.pct_yetkiliLock = new System.Windows.Forms.PictureBox();
            this.btn_yetkiliGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_yetkiliLock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(218, 46);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(191, 20);
            this.txt_kullaniciAdi.TabIndex = 2;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(218, 85);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(191, 20);
            this.txt_sifre.TabIndex = 3;
            // 
            // pct_yetkiliLock
            // 
            this.pct_yetkiliLock.Image = ((System.Drawing.Image)(resources.GetObject("pct_yetkiliLock.Image")));
            this.pct_yetkiliLock.Location = new System.Drawing.Point(12, 46);
            this.pct_yetkiliLock.Name = "pct_yetkiliLock";
            this.pct_yetkiliLock.Size = new System.Drawing.Size(96, 103);
            this.pct_yetkiliLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_yetkiliLock.TabIndex = 4;
            this.pct_yetkiliLock.TabStop = false;
            // 
            // btn_yetkiliGiris
            // 
            this.btn_yetkiliGiris.Location = new System.Drawing.Point(138, 126);
            this.btn_yetkiliGiris.Name = "btn_yetkiliGiris";
            this.btn_yetkiliGiris.Size = new System.Drawing.Size(271, 23);
            this.btn_yetkiliGiris.TabIndex = 5;
            this.btn_yetkiliGiris.Text = "Yetkili Girişi";
            this.btn_yetkiliGiris.UseVisualStyleBackColor = true;
            this.btn_yetkiliGiris.Click += new System.EventHandler(this.btn_yetkiliGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre";
            // 
            // YetkiliGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(431, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_yetkiliGiris);
            this.Controls.Add(this.pct_yetkiliLock);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullaniciAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YetkiliGirisEkrani";
            this.Text = "Yetkili Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pct_yetkiliLock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.PictureBox pct_yetkiliLock;
        private System.Windows.Forms.Button btn_yetkiliGiris;
        private System.Windows.Forms.Label label2;
    }
}