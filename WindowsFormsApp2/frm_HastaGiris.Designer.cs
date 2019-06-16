namespace WindowsFormsApp2
{
    partial class frm_HastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HastaGiris));
            this.txtBoxHastaGirisSifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtBoxHastaGirisTCKNO = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHastaUyeOlcak = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnHastaGirisYap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGeri = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // txtBoxHastaGirisSifre
            // 
            this.txtBoxHastaGirisSifre.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBoxHastaGirisSifre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxHastaGirisSifre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtBoxHastaGirisSifre.BorderThickness = 3;
            this.txtBoxHastaGirisSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxHastaGirisSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxHastaGirisSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxHastaGirisSifre.isPassword = true;
            this.txtBoxHastaGirisSifre.Location = new System.Drawing.Point(218, 216);
            this.txtBoxHastaGirisSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxHastaGirisSifre.Name = "txtBoxHastaGirisSifre";
            this.txtBoxHastaGirisSifre.Size = new System.Drawing.Size(370, 44);
            this.txtBoxHastaGirisSifre.TabIndex = 11;
            this.txtBoxHastaGirisSifre.Text = "Şifre";
            this.txtBoxHastaGirisSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxHastaGirisSifre.OnValueChanged += new System.EventHandler(this.txtBoxHastaGirisSifre_OnValueChanged);
            // 
            // txtBoxHastaGirisTCKNO
            // 
            this.txtBoxHastaGirisTCKNO.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBoxHastaGirisTCKNO.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxHastaGirisTCKNO.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtBoxHastaGirisTCKNO.BorderThickness = 3;
            this.txtBoxHastaGirisTCKNO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxHastaGirisTCKNO.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxHastaGirisTCKNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxHastaGirisTCKNO.isPassword = false;
            this.txtBoxHastaGirisTCKNO.Location = new System.Drawing.Point(218, 164);
            this.txtBoxHastaGirisTCKNO.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxHastaGirisTCKNO.Name = "txtBoxHastaGirisTCKNO";
            this.txtBoxHastaGirisTCKNO.Size = new System.Drawing.Size(370, 44);
            this.txtBoxHastaGirisTCKNO.TabIndex = 10;
            this.txtBoxHastaGirisTCKNO.Text = "TCKNO";
            this.txtBoxHastaGirisTCKNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxHastaGirisTCKNO.OnValueChanged += new System.EventHandler(this.txtBoxHastaGirisTCKNO_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(141, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(112, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "TCKNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hasta Giriş";
            // 
            // btnHastaUyeOlcak
            // 
            this.btnHastaUyeOlcak.ActiveBorderThickness = 1;
            this.btnHastaUyeOlcak.ActiveCornerRadius = 20;
            this.btnHastaUyeOlcak.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnHastaUyeOlcak.ActiveForecolor = System.Drawing.Color.White;
            this.btnHastaUyeOlcak.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnHastaUyeOlcak.BackColor = System.Drawing.SystemColors.Control;
            this.btnHastaUyeOlcak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHastaUyeOlcak.BackgroundImage")));
            this.btnHastaUyeOlcak.ButtonText = "Üye Ol";
            this.btnHastaUyeOlcak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHastaUyeOlcak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHastaUyeOlcak.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnHastaUyeOlcak.IdleBorderThickness = 1;
            this.btnHastaUyeOlcak.IdleCornerRadius = 20;
            this.btnHastaUyeOlcak.IdleFillColor = System.Drawing.Color.White;
            this.btnHastaUyeOlcak.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnHastaUyeOlcak.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnHastaUyeOlcak.Location = new System.Drawing.Point(528, 269);
            this.btnHastaUyeOlcak.Margin = new System.Windows.Forms.Padding(5);
            this.btnHastaUyeOlcak.Name = "btnHastaUyeOlcak";
            this.btnHastaUyeOlcak.Size = new System.Drawing.Size(60, 36);
            this.btnHastaUyeOlcak.TabIndex = 13;
            this.btnHastaUyeOlcak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHastaUyeOlcak.Click += new System.EventHandler(this.btnHastaUyeOlcak_Click);
            // 
            // btnHastaGirisYap
            // 
            this.btnHastaGirisYap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHastaGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHastaGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaGirisYap.BorderRadius = 0;
            this.btnHastaGirisYap.ButtonText = "Giriş Yap";
            this.btnHastaGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHastaGirisYap.DisabledColor = System.Drawing.Color.Gray;
            this.btnHastaGirisYap.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHastaGirisYap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHastaGirisYap.Iconimage")));
            this.btnHastaGirisYap.Iconimage_right = null;
            this.btnHastaGirisYap.Iconimage_right_Selected = null;
            this.btnHastaGirisYap.Iconimage_Selected = null;
            this.btnHastaGirisYap.IconMarginLeft = 0;
            this.btnHastaGirisYap.IconMarginRight = 0;
            this.btnHastaGirisYap.IconRightVisible = true;
            this.btnHastaGirisYap.IconRightZoom = 0D;
            this.btnHastaGirisYap.IconVisible = true;
            this.btnHastaGirisYap.IconZoom = 90D;
            this.btnHastaGirisYap.IsTab = false;
            this.btnHastaGirisYap.Location = new System.Drawing.Point(398, 267);
            this.btnHastaGirisYap.Name = "btnHastaGirisYap";
            this.btnHastaGirisYap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHastaGirisYap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHastaGirisYap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHastaGirisYap.selected = false;
            this.btnHastaGirisYap.Size = new System.Drawing.Size(122, 40);
            this.btnHastaGirisYap.TabIndex = 12;
            this.btnHastaGirisYap.Text = "Giriş Yap";
            this.btnHastaGirisYap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHastaGirisYap.Textcolor = System.Drawing.Color.White;
            this.btnHastaGirisYap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHastaGirisYap.Click += new System.EventHandler(this.btnHastaGirisYap_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.BorderRadius = 0;
            this.btnGeri.ButtonText = "Geri Gel";
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.DisabledColor = System.Drawing.Color.Gray;
            this.btnGeri.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGeri.Iconimage = null;
            this.btnGeri.Iconimage_right = null;
            this.btnGeri.Iconimage_right_Selected = null;
            this.btnGeri.Iconimage_Selected = null;
            this.btnGeri.IconMarginLeft = 0;
            this.btnGeri.IconMarginRight = 0;
            this.btnGeri.IconRightVisible = true;
            this.btnGeri.IconRightZoom = 0D;
            this.btnGeri.IconVisible = true;
            this.btnGeri.IconZoom = 90D;
            this.btnGeri.IsTab = false;
            this.btnGeri.Location = new System.Drawing.Point(666, 398);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGeri.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGeri.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGeri.selected = false;
            this.btnGeri.Size = new System.Drawing.Size(122, 40);
            this.btnGeri.TabIndex = 24;
            this.btnGeri.Text = "Geri Gel";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeri.Textcolor = System.Drawing.Color.White;
            this.btnGeri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frm_HastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHastaUyeOlcak);
            this.Controls.Add(this.btnHastaGirisYap);
            this.Controls.Add(this.txtBoxHastaGirisSifre);
            this.Controls.Add(this.txtBoxHastaGirisTCKNO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HastaGiris";
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.frm_HastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnHastaUyeOlcak;
        private Bunifu.Framework.UI.BunifuFlatButton btnHastaGirisYap;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBoxHastaGirisSifre;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBoxHastaGirisTCKNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnGeri;
    }
}