namespace KullaniciGiris
{
    partial class SiparisTürüEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisTürüEkrani));
            this.btn_onlineSiparis = new System.Windows.Forms.Button();
            this.btn_masadaSiparis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_onlineSiparis
            // 
            this.btn_onlineSiparis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_onlineSiparis.BackColor = System.Drawing.Color.Lime;
            this.btn_onlineSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_onlineSiparis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_onlineSiparis.Location = new System.Drawing.Point(74, 87);
            this.btn_onlineSiparis.Name = "btn_onlineSiparis";
            this.btn_onlineSiparis.Size = new System.Drawing.Size(395, 199);
            this.btn_onlineSiparis.TabIndex = 0;
            this.btn_onlineSiparis.Text = "ONLİNE SİPARİŞ";
            this.btn_onlineSiparis.UseVisualStyleBackColor = false;
            this.btn_onlineSiparis.Click += new System.EventHandler(this.btn_onlineSiparis_Click);
            // 
            // btn_masadaSiparis
            // 
            this.btn_masadaSiparis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_masadaSiparis.BackColor = System.Drawing.Color.Lime;
            this.btn_masadaSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_masadaSiparis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_masadaSiparis.Location = new System.Drawing.Point(598, 87);
            this.btn_masadaSiparis.Name = "btn_masadaSiparis";
            this.btn_masadaSiparis.Size = new System.Drawing.Size(363, 199);
            this.btn_masadaSiparis.TabIndex = 1;
            this.btn_masadaSiparis.Text = "MASADA SİPARİŞ";
            this.btn_masadaSiparis.UseVisualStyleBackColor = false;
            this.btn_masadaSiparis.Click += new System.EventHandler(this.btn_masadaSiparis_Click);
            // 
            // SiparisTürüEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1014, 325);
            this.Controls.Add(this.btn_masadaSiparis);
            this.Controls.Add(this.btn_onlineSiparis);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SiparisTürüEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SİPARİŞ TÜRÜ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_onlineSiparis;
        private System.Windows.Forms.Button btn_masadaSiparis;
    }
}