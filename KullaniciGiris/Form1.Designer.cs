namespace KullaniciGiris
{
    partial class frm_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_giris));
            this.btn_yetkiliGiris = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_müsteriGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_yetkiliGiris
            // 
            this.btn_yetkiliGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_yetkiliGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yetkiliGiris.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yetkiliGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_yetkiliGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_yetkiliGiris.ImageKey = "admin.png";
            this.btn_yetkiliGiris.ImageList = this.ımageList1;
            this.btn_yetkiliGiris.Location = new System.Drawing.Point(40, 28);
            this.btn_yetkiliGiris.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_yetkiliGiris.Name = "btn_yetkiliGiris";
            this.btn_yetkiliGiris.Size = new System.Drawing.Size(257, 155);
            this.btn_yetkiliGiris.TabIndex = 0;
            this.btn_yetkiliGiris.Text = "YETKİLİ GİRİŞİ";
            this.btn_yetkiliGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_yetkiliGiris.UseVisualStyleBackColor = false;
            this.btn_yetkiliGiris.Click += new System.EventHandler(this.btn_yetkiliGiris_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "admin.png");
            this.ımageList1.Images.SetKeyName(1, "müsteriGiris.jpg");
            // 
            // btn_müsteriGiris
            // 
            this.btn_müsteriGiris.BackColor = System.Drawing.Color.White;
            this.btn_müsteriGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_müsteriGiris.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_müsteriGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_müsteriGiris.ImageKey = "müsteriGiris.jpg";
            this.btn_müsteriGiris.ImageList = this.ımageList1;
            this.btn_müsteriGiris.Location = new System.Drawing.Point(369, 28);
            this.btn_müsteriGiris.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_müsteriGiris.Name = "btn_müsteriGiris";
            this.btn_müsteriGiris.Size = new System.Drawing.Size(257, 155);
            this.btn_müsteriGiris.TabIndex = 1;
            this.btn_müsteriGiris.Text = "MÜŞTERİ GİRİŞİ";
            this.btn_müsteriGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_müsteriGiris.UseVisualStyleBackColor = false;
            this.btn_müsteriGiris.Click += new System.EventHandler(this.btn_müsteriGiris_Click);
            // 
            // frm_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(674, 235);
            this.Controls.Add(this.btn_müsteriGiris);
            this.Controls.Add(this.btn_yetkiliGiris);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frm_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ EKRANI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_yetkiliGiris;
        private System.Windows.Forms.Button btn_müsteriGiris;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

