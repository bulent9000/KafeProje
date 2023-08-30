namespace KullaniciGiris
{
    partial class YetkiliAnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkiliAnaForm));
            this.btn_saticiBilgisi = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_müsteriBilgi = new System.Windows.Forms.Button();
            this.btn_siparisler = new System.Windows.Forms.Button();
            this.btn_raporlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_saticiBilgisi
            // 
            this.btn_saticiBilgisi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_saticiBilgisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saticiBilgisi.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_saticiBilgisi.ForeColor = System.Drawing.Color.Black;
            this.btn_saticiBilgisi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_saticiBilgisi.ImageKey = "best-seller.png";
            this.btn_saticiBilgisi.ImageList = this.ımageList1;
            this.btn_saticiBilgisi.Location = new System.Drawing.Point(52, 235);
            this.btn_saticiBilgisi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_saticiBilgisi.Name = "btn_saticiBilgisi";
            this.btn_saticiBilgisi.Size = new System.Drawing.Size(257, 155);
            this.btn_saticiBilgisi.TabIndex = 1;
            this.btn_saticiBilgisi.Text = "SATICI BİLGİSİ";
            this.btn_saticiBilgisi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_saticiBilgisi.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "best-seller.png");
            this.ımageList1.Images.SetKeyName(1, "kafeAnaMenü.png");
            this.ımageList1.Images.SetKeyName(2, "müsteri.png");
            this.ımageList1.Images.SetKeyName(3, "onlineOrder.png");
            this.ımageList1.Images.SetKeyName(4, "rating.png");
            this.ımageList1.Images.SetKeyName(5, "siparissRes.png");
            this.ımageList1.Images.SetKeyName(6, "raporlar.png");
            this.ımageList1.Images.SetKeyName(7, "siparisim.jpg");
            // 
            // btn_müsteriBilgi
            // 
            this.btn_müsteriBilgi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_müsteriBilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_müsteriBilgi.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_müsteriBilgi.ForeColor = System.Drawing.Color.Black;
            this.btn_müsteriBilgi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_müsteriBilgi.ImageKey = "rating.png";
            this.btn_müsteriBilgi.ImageList = this.ımageList1;
            this.btn_müsteriBilgi.Location = new System.Drawing.Point(401, 40);
            this.btn_müsteriBilgi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_müsteriBilgi.Name = "btn_müsteriBilgi";
            this.btn_müsteriBilgi.Size = new System.Drawing.Size(257, 155);
            this.btn_müsteriBilgi.TabIndex = 2;
            this.btn_müsteriBilgi.Text = "MÜŞTERİ BİLGİSİ";
            this.btn_müsteriBilgi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_müsteriBilgi.UseVisualStyleBackColor = false;
            // 
            // btn_siparisler
            // 
            this.btn_siparisler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_siparisler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siparisler.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_siparisler.ForeColor = System.Drawing.Color.Black;
            this.btn_siparisler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_siparisler.ImageKey = "siparisim.jpg";
            this.btn_siparisler.ImageList = this.ımageList1;
            this.btn_siparisler.Location = new System.Drawing.Point(52, 40);
            this.btn_siparisler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_siparisler.Name = "btn_siparisler";
            this.btn_siparisler.Size = new System.Drawing.Size(257, 155);
            this.btn_siparisler.TabIndex = 3;
            this.btn_siparisler.Text = "SİPARİŞ VER";
            this.btn_siparisler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_siparisler.UseVisualStyleBackColor = false;
            this.btn_siparisler.Click += new System.EventHandler(this.btn_siparisler_Click);
            // 
            // btn_raporlar
            // 
            this.btn_raporlar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_raporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_raporlar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_raporlar.ForeColor = System.Drawing.Color.Black;
            this.btn_raporlar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_raporlar.ImageKey = "raporlar.png";
            this.btn_raporlar.ImageList = this.ımageList1;
            this.btn_raporlar.Location = new System.Drawing.Point(401, 235);
            this.btn_raporlar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_raporlar.Name = "btn_raporlar";
            this.btn_raporlar.Size = new System.Drawing.Size(257, 155);
            this.btn_raporlar.TabIndex = 4;
            this.btn_raporlar.Text = "RAPORLAR";
            this.btn_raporlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_raporlar.UseVisualStyleBackColor = false;
            this.btn_raporlar.Click += new System.EventHandler(this.btn_raporlar_Click);
            // 
            // YetkiliAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.btn_raporlar);
            this.Controls.Add(this.btn_siparisler);
            this.Controls.Add(this.btn_müsteriBilgi);
            this.Controls.Add(this.btn_saticiBilgisi);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "YetkiliAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili Ana Menüsü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_saticiBilgisi;
        private System.Windows.Forms.Button btn_müsteriBilgi;
        private System.Windows.Forms.Button btn_siparisler;
        private System.Windows.Forms.Button btn_raporlar;
        private System.Windows.Forms.ImageList ımageList1;
    }
}