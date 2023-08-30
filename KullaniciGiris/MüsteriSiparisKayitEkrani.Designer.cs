namespace KullaniciGiris
{
    partial class MüsteriSiparisKayitEkrani
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
            this.labelmasaNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_masaNumarasi = new System.Windows.Forms.Label();
            this.txt_müsteriAdi = new System.Windows.Forms.TextBox();
            this.btn_müsteriKayitEkrani = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSiparisZamani = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelmasaNo
            // 
            this.labelmasaNo.AutoSize = true;
            this.labelmasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelmasaNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelmasaNo.Location = new System.Drawing.Point(21, 26);
            this.labelmasaNo.Name = "labelmasaNo";
            this.labelmasaNo.Size = new System.Drawing.Size(176, 24);
            this.labelmasaNo.TabIndex = 0;
            this.labelmasaNo.Text = "Masa No             :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(21, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Adı         :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(21, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih-Saat           :";
            // 
            // lbl_masaNumarasi
            // 
            this.lbl_masaNumarasi.AutoSize = true;
            this.lbl_masaNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_masaNumarasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_masaNumarasi.Location = new System.Drawing.Point(205, 26);
            this.lbl_masaNumarasi.Name = "lbl_masaNumarasi";
            this.lbl_masaNumarasi.Size = new System.Drawing.Size(21, 24);
            this.lbl_masaNumarasi.TabIndex = 3;
            this.lbl_masaNumarasi.Text = "1";
            // 
            // txt_müsteriAdi
            // 
            this.txt_müsteriAdi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_müsteriAdi.Location = new System.Drawing.Point(209, 76);
            this.txt_müsteriAdi.Name = "txt_müsteriAdi";
            this.txt_müsteriAdi.Size = new System.Drawing.Size(156, 20);
            this.txt_müsteriAdi.TabIndex = 6;
            // 
            // btn_müsteriKayitEkrani
            // 
            this.btn_müsteriKayitEkrani.Location = new System.Drawing.Point(25, 164);
            this.btn_müsteriKayitEkrani.Name = "btn_müsteriKayitEkrani";
            this.btn_müsteriKayitEkrani.Size = new System.Drawing.Size(340, 23);
            this.btn_müsteriKayitEkrani.TabIndex = 7;
            this.btn_müsteriKayitEkrani.Text = "Sipariş vermek için tıklayınız";
            this.btn_müsteriKayitEkrani.UseVisualStyleBackColor = true;
            this.btn_müsteriKayitEkrani.Click += new System.EventHandler(this.btn_müsteriKayitEkrani_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(294, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "zorunlu alan *";
            // 
            // dtpSiparisZamani
            // 
            this.dtpSiparisZamani.Enabled = false;
            this.dtpSiparisZamani.Location = new System.Drawing.Point(209, 122);
            this.dtpSiparisZamani.Name = "dtpSiparisZamani";
            this.dtpSiparisZamani.Size = new System.Drawing.Size(156, 20);
            this.dtpSiparisZamani.TabIndex = 9;
            // 
            // MüsteriSiparisKayitEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 206);
            this.Controls.Add(this.dtpSiparisZamani);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_müsteriKayitEkrani);
            this.Controls.Add(this.txt_müsteriAdi);
            this.Controls.Add(this.lbl_masaNumarasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelmasaNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MüsteriSiparisKayitEkrani";
            this.Text = "Müsteri Sipariş Kayıt Ekranı";
            this.Load += new System.EventHandler(this.MüsteriSiparisKayitEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmasaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_masaNumarasi;
        private System.Windows.Forms.TextBox txt_müsteriAdi;
        private System.Windows.Forms.Button btn_müsteriKayitEkrani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpSiparisZamani;
    }
}