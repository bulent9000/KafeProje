namespace KullaniciGiris
{
    partial class OdemeOnay
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
            this.label1 = new System.Windows.Forms.Label();
            this.msk_kod = new System.Windows.Forms.MaskedTextBox();
            this.btn_koduGönder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Onay Kodunu giriniz";
            // 
            // msk_kod
            // 
            this.msk_kod.Location = new System.Drawing.Point(70, 77);
            this.msk_kod.Mask = "000000";
            this.msk_kod.Name = "msk_kod";
            this.msk_kod.Size = new System.Drawing.Size(46, 20);
            this.msk_kod.TabIndex = 1;
            // 
            // btn_koduGönder
            // 
            this.btn_koduGönder.Location = new System.Drawing.Point(46, 125);
            this.btn_koduGönder.Name = "btn_koduGönder";
            this.btn_koduGönder.Size = new System.Drawing.Size(86, 23);
            this.btn_koduGönder.TabIndex = 2;
            this.btn_koduGönder.Text = "Kodu Gönder";
            this.btn_koduGönder.UseVisualStyleBackColor = true;
            this.btn_koduGönder.Click += new System.EventHandler(this.btn_koduGönder_Click);
            // 
            // OdemeOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(194, 189);
            this.Controls.Add(this.btn_koduGönder);
            this.Controls.Add(this.msk_kod);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OdemeOnay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Onay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_kod;
        private System.Windows.Forms.Button btn_koduGönder;
    }
}