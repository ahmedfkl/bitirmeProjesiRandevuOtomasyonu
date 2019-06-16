namespace WindowsFormsApp2
{
    partial class frm_DoktrorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoktrorGiris));
            this.label3 = new System.Windows.Forms.Label();
            this.drGirisSifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.drGirisTC = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGeri = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Doktor Giriş";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // drGirisSifre
            // 
            this.drGirisSifre.BorderColorFocused = System.Drawing.Color.Blue;
            this.drGirisSifre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drGirisSifre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.drGirisSifre.BorderThickness = 3;
            this.drGirisSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drGirisSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.drGirisSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drGirisSifre.isPassword = true;
            this.drGirisSifre.Location = new System.Drawing.Point(244, 203);
            this.drGirisSifre.Margin = new System.Windows.Forms.Padding(4);
            this.drGirisSifre.Name = "drGirisSifre";
            this.drGirisSifre.Size = new System.Drawing.Size(370, 44);
            this.drGirisSifre.TabIndex = 18;
            this.drGirisSifre.Text = "Şifre";
            this.drGirisSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // drGirisTC
            // 
            this.drGirisTC.BorderColorFocused = System.Drawing.Color.Blue;
            this.drGirisTC.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drGirisTC.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.drGirisTC.BorderThickness = 3;
            this.drGirisTC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drGirisTC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.drGirisTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drGirisTC.isPassword = false;
            this.drGirisTC.Location = new System.Drawing.Point(244, 151);
            this.drGirisTC.Margin = new System.Windows.Forms.Padding(4);
            this.drGirisTC.Name = "drGirisTC";
            this.drGirisTC.Size = new System.Drawing.Size(370, 44);
            this.drGirisTC.TabIndex = 17;
            this.drGirisTC.Text = "TCKNO";
            this.drGirisTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(167, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(138, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "TCKNO";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Giriş Yap";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(492, 254);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(122, 40);
            this.bunifuFlatButton1.TabIndex = 19;
            this.bunifuFlatButton1.Text = "Giriş Yap";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
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
            // frm_DoktrorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.drGirisSifre);
            this.Controls.Add(this.drGirisTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DoktrorGiris";
            this.Text = "Doktor Giriş";
            this.Load += new System.EventHandler(this.frm_DoktrorGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMetroTextbox drGirisSifre;
        private Bunifu.Framework.UI.BunifuMetroTextbox drGirisTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnGeri;
    }
}