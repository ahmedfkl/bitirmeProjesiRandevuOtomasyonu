namespace WindowsFormsApp2
{
    partial class frm_doktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_doktorBilgiDuzenle));
            this.btnDoktorDuzenlendi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.updDoktorKlinik = new System.Windows.Forms.ComboBox();
            this.updDoktorAd = new System.Windows.Forms.TextBox();
            this.updDoktorTCKNO = new System.Windows.Forms.TextBox();
            this.updDoktorSifre = new System.Windows.Forms.TextBox();
            this.updDoktorSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoktorDuzenlendi
            // 
            this.btnDoktorDuzenlendi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDoktorDuzenlendi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDoktorDuzenlendi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorDuzenlendi.BorderRadius = 0;
            this.btnDoktorDuzenlendi.ButtonText = "Güncelle";
            this.btnDoktorDuzenlendi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoktorDuzenlendi.DisabledColor = System.Drawing.Color.Gray;
            this.btnDoktorDuzenlendi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDoktorDuzenlendi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDoktorDuzenlendi.Iconimage")));
            this.btnDoktorDuzenlendi.Iconimage_right = null;
            this.btnDoktorDuzenlendi.Iconimage_right_Selected = null;
            this.btnDoktorDuzenlendi.Iconimage_Selected = null;
            this.btnDoktorDuzenlendi.IconMarginLeft = 0;
            this.btnDoktorDuzenlendi.IconMarginRight = 0;
            this.btnDoktorDuzenlendi.IconRightVisible = true;
            this.btnDoktorDuzenlendi.IconRightZoom = 0D;
            this.btnDoktorDuzenlendi.IconVisible = true;
            this.btnDoktorDuzenlendi.IconZoom = 90D;
            this.btnDoktorDuzenlendi.IsTab = false;
            this.btnDoktorDuzenlendi.Location = new System.Drawing.Point(155, 238);
            this.btnDoktorDuzenlendi.Name = "btnDoktorDuzenlendi";
            this.btnDoktorDuzenlendi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDoktorDuzenlendi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDoktorDuzenlendi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDoktorDuzenlendi.selected = false;
            this.btnDoktorDuzenlendi.Size = new System.Drawing.Size(110, 46);
            this.btnDoktorDuzenlendi.TabIndex = 51;
            this.btnDoktorDuzenlendi.Text = "Güncelle";
            this.btnDoktorDuzenlendi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoktorDuzenlendi.Textcolor = System.Drawing.Color.White;
            this.btnDoktorDuzenlendi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoktorDuzenlendi.Click += new System.EventHandler(this.btnDoktorDuzenlendi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(109, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ad";
            // 
            // updDoktorKlinik
            // 
            this.updDoktorKlinik.FormattingEnabled = true;
            this.updDoktorKlinik.Location = new System.Drawing.Point(146, 163);
            this.updDoktorKlinik.Name = "updDoktorKlinik";
            this.updDoktorKlinik.Size = new System.Drawing.Size(142, 21);
            this.updDoktorKlinik.TabIndex = 52;
            // 
            // updDoktorAd
            // 
            this.updDoktorAd.Location = new System.Drawing.Point(146, 55);
            this.updDoktorAd.Name = "updDoktorAd";
            this.updDoktorAd.Size = new System.Drawing.Size(142, 20);
            this.updDoktorAd.TabIndex = 53;
            // 
            // updDoktorTCKNO
            // 
            this.updDoktorTCKNO.Location = new System.Drawing.Point(146, 137);
            this.updDoktorTCKNO.MaxLength = 11;
            this.updDoktorTCKNO.Name = "updDoktorTCKNO";
            this.updDoktorTCKNO.Size = new System.Drawing.Size(142, 20);
            this.updDoktorTCKNO.TabIndex = 54;
            // 
            // updDoktorSifre
            // 
            this.updDoktorSifre.Location = new System.Drawing.Point(146, 107);
            this.updDoktorSifre.Name = "updDoktorSifre";
            this.updDoktorSifre.Size = new System.Drawing.Size(142, 20);
            this.updDoktorSifre.TabIndex = 55;
            // 
            // updDoktorSoyad
            // 
            this.updDoktorSoyad.Location = new System.Drawing.Point(146, 81);
            this.updDoktorSoyad.Name = "updDoktorSoyad";
            this.updDoktorSoyad.Size = new System.Drawing.Size(142, 20);
            this.updDoktorSoyad.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(95, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Sifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(76, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "TCKNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(95, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Klinik";
            // 
            // frm_doktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updDoktorSoyad);
            this.Controls.Add(this.updDoktorSifre);
            this.Controls.Add(this.updDoktorTCKNO);
            this.Controls.Add(this.updDoktorAd);
            this.Controls.Add(this.updDoktorKlinik);
            this.Controls.Add(this.btnDoktorDuzenlendi);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_doktorBilgiDuzenle";
            this.Text = "Doktor Bilgi Düzenle";
            this.Load += new System.EventHandler(this.frm_doktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnDoktorDuzenlendi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox updDoktorKlinik;
        private System.Windows.Forms.TextBox updDoktorAd;
        private System.Windows.Forms.TextBox updDoktorTCKNO;
        private System.Windows.Forms.TextBox updDoktorSifre;
        private System.Windows.Forms.TextBox updDoktorSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}