namespace WindowsFormsApp2
{
    partial class frm_SekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SekreterGiris));
            this.label3 = new System.Windows.Forms.Label();
            this.skrtrGirisBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.skrtrGirisSifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.skrtrGirisTCKNO = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Sekreter Giriş";
            // 
            // skrtrGirisBtn
            // 
            this.skrtrGirisBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.skrtrGirisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.skrtrGirisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skrtrGirisBtn.BorderRadius = 0;
            this.skrtrGirisBtn.ButtonText = "Giriş Yap";
            this.skrtrGirisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skrtrGirisBtn.DisabledColor = System.Drawing.Color.Gray;
            this.skrtrGirisBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.skrtrGirisBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("skrtrGirisBtn.Iconimage")));
            this.skrtrGirisBtn.Iconimage_right = null;
            this.skrtrGirisBtn.Iconimage_right_Selected = null;
            this.skrtrGirisBtn.Iconimage_Selected = null;
            this.skrtrGirisBtn.IconMarginLeft = 0;
            this.skrtrGirisBtn.IconMarginRight = 0;
            this.skrtrGirisBtn.IconRightVisible = true;
            this.skrtrGirisBtn.IconRightZoom = 0D;
            this.skrtrGirisBtn.IconVisible = true;
            this.skrtrGirisBtn.IconZoom = 90D;
            this.skrtrGirisBtn.IsTab = false;
            this.skrtrGirisBtn.Location = new System.Drawing.Point(493, 279);
            this.skrtrGirisBtn.Name = "skrtrGirisBtn";
            this.skrtrGirisBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.skrtrGirisBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.skrtrGirisBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.skrtrGirisBtn.selected = false;
            this.skrtrGirisBtn.Size = new System.Drawing.Size(122, 40);
            this.skrtrGirisBtn.TabIndex = 19;
            this.skrtrGirisBtn.Text = "Giriş Yap";
            this.skrtrGirisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skrtrGirisBtn.Textcolor = System.Drawing.Color.White;
            this.skrtrGirisBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skrtrGirisBtn.Click += new System.EventHandler(this.skrtrGirisBtn_Click);
            // 
            // skrtrGirisSifre
            // 
            this.skrtrGirisSifre.BorderColorFocused = System.Drawing.Color.Blue;
            this.skrtrGirisSifre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skrtrGirisSifre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.skrtrGirisSifre.BorderThickness = 3;
            this.skrtrGirisSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.skrtrGirisSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.skrtrGirisSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skrtrGirisSifre.isPassword = true;
            this.skrtrGirisSifre.Location = new System.Drawing.Point(245, 228);
            this.skrtrGirisSifre.Margin = new System.Windows.Forms.Padding(4);
            this.skrtrGirisSifre.Name = "skrtrGirisSifre";
            this.skrtrGirisSifre.Size = new System.Drawing.Size(370, 44);
            this.skrtrGirisSifre.TabIndex = 18;
            this.skrtrGirisSifre.Text = "Şifre";
            this.skrtrGirisSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // skrtrGirisTCKNO
            // 
            this.skrtrGirisTCKNO.BorderColorFocused = System.Drawing.Color.Blue;
            this.skrtrGirisTCKNO.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skrtrGirisTCKNO.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.skrtrGirisTCKNO.BorderThickness = 3;
            this.skrtrGirisTCKNO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.skrtrGirisTCKNO.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.skrtrGirisTCKNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skrtrGirisTCKNO.isPassword = false;
            this.skrtrGirisTCKNO.Location = new System.Drawing.Point(245, 176);
            this.skrtrGirisTCKNO.Margin = new System.Windows.Forms.Padding(4);
            this.skrtrGirisTCKNO.Name = "skrtrGirisTCKNO";
            this.skrtrGirisTCKNO.Size = new System.Drawing.Size(370, 44);
            this.skrtrGirisTCKNO.TabIndex = 17;
            this.skrtrGirisTCKNO.Text = "TCKNO";
            this.skrtrGirisTCKNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(168, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(139, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "TCKNO";
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
            this.btnGeri.TabIndex = 23;
            this.btnGeri.Text = "Geri Gel";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeri.Textcolor = System.Drawing.Color.White;
            this.btnGeri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frm_SekreterGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.skrtrGirisBtn);
            this.Controls.Add(this.skrtrGirisSifre);
            this.Controls.Add(this.skrtrGirisTCKNO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_SekreterGiris";
            this.Text = "Sekreter Giriş";
            this.Load += new System.EventHandler(this.frm_SekreterGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton skrtrGirisBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox skrtrGirisSifre;
        private Bunifu.Framework.UI.BunifuMetroTextbox skrtrGirisTCKNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnGeri;
    }
}