namespace WindowsFormsApp2
{
    partial class frm_HastaBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HastaBilgiDuzenle));
            this.btnHastaDuzenlendi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updHastaUyeAd = new System.Windows.Forms.TextBox();
            this.updHastaUyeSoyad = new System.Windows.Forms.TextBox();
            this.updHastaUyeSifre = new System.Windows.Forms.TextBox();
            this.updHastaUyeTckno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHastaDuzenlendi
            // 
            this.btnHastaDuzenlendi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHastaDuzenlendi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHastaDuzenlendi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaDuzenlendi.BorderRadius = 0;
            this.btnHastaDuzenlendi.ButtonText = "Güncelle";
            this.btnHastaDuzenlendi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHastaDuzenlendi.DisabledColor = System.Drawing.Color.Gray;
            this.btnHastaDuzenlendi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHastaDuzenlendi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHastaDuzenlendi.Iconimage")));
            this.btnHastaDuzenlendi.Iconimage_right = null;
            this.btnHastaDuzenlendi.Iconimage_right_Selected = null;
            this.btnHastaDuzenlendi.Iconimage_Selected = null;
            this.btnHastaDuzenlendi.IconMarginLeft = 0;
            this.btnHastaDuzenlendi.IconMarginRight = 0;
            this.btnHastaDuzenlendi.IconRightVisible = true;
            this.btnHastaDuzenlendi.IconRightZoom = 0D;
            this.btnHastaDuzenlendi.IconVisible = true;
            this.btnHastaDuzenlendi.IconZoom = 90D;
            this.btnHastaDuzenlendi.IsTab = false;
            this.btnHastaDuzenlendi.Location = new System.Drawing.Point(406, 252);
            this.btnHastaDuzenlendi.Name = "btnHastaDuzenlendi";
            this.btnHastaDuzenlendi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHastaDuzenlendi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHastaDuzenlendi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHastaDuzenlendi.selected = false;
            this.btnHastaDuzenlendi.Size = new System.Drawing.Size(110, 46);
            this.btnHastaDuzenlendi.TabIndex = 42;
            this.btnHastaDuzenlendi.Text = "Güncelle";
            this.btnHastaDuzenlendi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHastaDuzenlendi.Textcolor = System.Drawing.Color.White;
            this.btnHastaDuzenlendi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHastaDuzenlendi.Click += new System.EventHandler(this.btnHastaDuzenlendi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(226, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(191, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(208, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "TC Kimlik Numarası";
            // 
            // updHastaUyeAd
            // 
            this.updHastaUyeAd.Location = new System.Drawing.Point(270, 113);
            this.updHastaUyeAd.Name = "updHastaUyeAd";
            this.updHastaUyeAd.Size = new System.Drawing.Size(246, 20);
            this.updHastaUyeAd.TabIndex = 43;
            // 
            // updHastaUyeSoyad
            // 
            this.updHastaUyeSoyad.Location = new System.Drawing.Point(270, 164);
            this.updHastaUyeSoyad.Name = "updHastaUyeSoyad";
            this.updHastaUyeSoyad.Size = new System.Drawing.Size(246, 20);
            this.updHastaUyeSoyad.TabIndex = 44;
            // 
            // updHastaUyeSifre
            // 
            this.updHastaUyeSifre.Location = new System.Drawing.Point(270, 221);
            this.updHastaUyeSifre.Name = "updHastaUyeSifre";
            this.updHastaUyeSifre.Size = new System.Drawing.Size(246, 20);
            this.updHastaUyeSifre.TabIndex = 45;
            // 
            // updHastaUyeTckno
            // 
            this.updHastaUyeTckno.Location = new System.Drawing.Point(273, 278);
            this.updHastaUyeTckno.Name = "updHastaUyeTckno";
            this.updHastaUyeTckno.Size = new System.Drawing.Size(127, 20);
            this.updHastaUyeTckno.TabIndex = 46;
            // 
            // frm_HastaBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updHastaUyeTckno);
            this.Controls.Add(this.updHastaUyeSifre);
            this.Controls.Add(this.updHastaUyeSoyad);
            this.Controls.Add(this.updHastaUyeAd);
            this.Controls.Add(this.btnHastaDuzenlendi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HastaBilgiDuzenle";
            this.Text = "Hasta Bilgi Düzenleme";
            this.Load += new System.EventHandler(this.frm_HastaBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnHastaDuzenlendi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox updHastaUyeAd;
        private System.Windows.Forms.TextBox updHastaUyeSoyad;
        private System.Windows.Forms.TextBox updHastaUyeSifre;
        private System.Windows.Forms.TextBox updHastaUyeTckno;
    }
}