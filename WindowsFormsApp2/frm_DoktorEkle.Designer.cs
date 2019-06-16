namespace WindowsFormsApp2
{
    partial class frm_DoktorEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoktorEkle));
            this.dreGuncelle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dreDoktorList = new System.Windows.Forms.DataGridView();
            this.dreSil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dreKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dreKlinik = new System.Windows.Forms.ComboBox();
            this.dreAd = new System.Windows.Forms.TextBox();
            this.dreSifre = new System.Windows.Forms.TextBox();
            this.dreTCKNO = new System.Windows.Forms.TextBox();
            this.dreSoyad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dreDoktorList)).BeginInit();
            this.SuspendLayout();
            // 
            // dreGuncelle
            // 
            this.dreGuncelle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dreGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dreGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dreGuncelle.BorderRadius = 0;
            this.dreGuncelle.ButtonText = "Güncelle";
            this.dreGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dreGuncelle.DisabledColor = System.Drawing.Color.Gray;
            this.dreGuncelle.Iconcolor = System.Drawing.Color.Transparent;
            this.dreGuncelle.Iconimage = ((System.Drawing.Image)(resources.GetObject("dreGuncelle.Iconimage")));
            this.dreGuncelle.Iconimage_right = null;
            this.dreGuncelle.Iconimage_right_Selected = null;
            this.dreGuncelle.Iconimage_Selected = null;
            this.dreGuncelle.IconMarginLeft = 0;
            this.dreGuncelle.IconMarginRight = 0;
            this.dreGuncelle.IconRightVisible = true;
            this.dreGuncelle.IconRightZoom = 0D;
            this.dreGuncelle.IconVisible = true;
            this.dreGuncelle.IconZoom = 90D;
            this.dreGuncelle.IsTab = false;
            this.dreGuncelle.Location = new System.Drawing.Point(99, 226);
            this.dreGuncelle.Name = "dreGuncelle";
            this.dreGuncelle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dreGuncelle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dreGuncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.dreGuncelle.selected = false;
            this.dreGuncelle.Size = new System.Drawing.Size(111, 43);
            this.dreGuncelle.TabIndex = 44;
            this.dreGuncelle.Text = "Güncelle";
            this.dreGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dreGuncelle.Textcolor = System.Drawing.Color.White;
            this.dreGuncelle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dreGuncelle.Click += new System.EventHandler(this.dreGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dreDoktorList);
            this.groupBox1.Location = new System.Drawing.Point(236, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 350);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktorlar";
            // 
            // dreDoktorList
            // 
            this.dreDoktorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dreDoktorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dreDoktorList.Location = new System.Drawing.Point(3, 16);
            this.dreDoktorList.Name = "dreDoktorList";
            this.dreDoktorList.Size = new System.Drawing.Size(546, 331);
            this.dreDoktorList.TabIndex = 0;
            this.dreDoktorList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dreDoktorList_CellClick);
            // 
            // dreSil
            // 
            this.dreSil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dreSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dreSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dreSil.BorderRadius = 0;
            this.dreSil.ButtonText = "Sil";
            this.dreSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dreSil.DisabledColor = System.Drawing.Color.Gray;
            this.dreSil.Iconcolor = System.Drawing.Color.Transparent;
            this.dreSil.Iconimage = ((System.Drawing.Image)(resources.GetObject("dreSil.Iconimage")));
            this.dreSil.Iconimage_right = null;
            this.dreSil.Iconimage_right_Selected = null;
            this.dreSil.Iconimage_Selected = null;
            this.dreSil.IconMarginLeft = 0;
            this.dreSil.IconMarginRight = 0;
            this.dreSil.IconRightVisible = true;
            this.dreSil.IconRightZoom = 0D;
            this.dreSil.IconVisible = true;
            this.dreSil.IconZoom = 90D;
            this.dreSil.IsTab = false;
            this.dreSil.Location = new System.Drawing.Point(99, 275);
            this.dreSil.Name = "dreSil";
            this.dreSil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dreSil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dreSil.OnHoverTextColor = System.Drawing.Color.White;
            this.dreSil.selected = false;
            this.dreSil.Size = new System.Drawing.Size(111, 43);
            this.dreSil.TabIndex = 49;
            this.dreSil.Text = "Sil";
            this.dreSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dreSil.Textcolor = System.Drawing.Color.White;
            this.dreSil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dreSil.Click += new System.EventHandler(this.dreSil_Click);
            // 
            // dreKaydet
            // 
            this.dreKaydet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dreKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dreKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dreKaydet.BorderRadius = 0;
            this.dreKaydet.ButtonText = "Kaydet";
            this.dreKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dreKaydet.DisabledColor = System.Drawing.Color.Gray;
            this.dreKaydet.Iconcolor = System.Drawing.Color.Transparent;
            this.dreKaydet.Iconimage = ((System.Drawing.Image)(resources.GetObject("dreKaydet.Iconimage")));
            this.dreKaydet.Iconimage_right = null;
            this.dreKaydet.Iconimage_right_Selected = null;
            this.dreKaydet.Iconimage_Selected = null;
            this.dreKaydet.IconMarginLeft = 0;
            this.dreKaydet.IconMarginRight = 0;
            this.dreKaydet.IconRightVisible = true;
            this.dreKaydet.IconRightZoom = 0D;
            this.dreKaydet.IconVisible = true;
            this.dreKaydet.IconZoom = 90D;
            this.dreKaydet.IsTab = false;
            this.dreKaydet.Location = new System.Drawing.Point(99, 177);
            this.dreKaydet.Name = "dreKaydet";
            this.dreKaydet.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.dreKaydet.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.dreKaydet.OnHoverTextColor = System.Drawing.Color.White;
            this.dreKaydet.selected = false;
            this.dreKaydet.Size = new System.Drawing.Size(111, 43);
            this.dreKaydet.TabIndex = 50;
            this.dreKaydet.Text = "Kaydet";
            this.dreKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dreKaydet.Textcolor = System.Drawing.Color.White;
            this.dreKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dreKaydet.Click += new System.EventHandler(this.dreKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(0, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "TCKNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "Klinik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Şifre";
            // 
            // dreKlinik
            // 
            this.dreKlinik.FormattingEnabled = true;
            this.dreKlinik.Location = new System.Drawing.Point(99, 98);
            this.dreKlinik.Name = "dreKlinik";
            this.dreKlinik.Size = new System.Drawing.Size(121, 21);
            this.dreKlinik.TabIndex = 3;
            // 
            // dreAd
            // 
            this.dreAd.Location = new System.Drawing.Point(99, 46);
            this.dreAd.Name = "dreAd";
            this.dreAd.Size = new System.Drawing.Size(121, 20);
            this.dreAd.TabIndex = 1;
            // 
            // dreSifre
            // 
            this.dreSifre.Location = new System.Drawing.Point(99, 151);
            this.dreSifre.Name = "dreSifre";
            this.dreSifre.Size = new System.Drawing.Size(121, 20);
            this.dreSifre.TabIndex = 5;
            // 
            // dreTCKNO
            // 
            this.dreTCKNO.Location = new System.Drawing.Point(99, 125);
            this.dreTCKNO.MaxLength = 11;
            this.dreTCKNO.Name = "dreTCKNO";
            this.dreTCKNO.Size = new System.Drawing.Size(121, 20);
            this.dreTCKNO.TabIndex = 4;
            // 
            // dreSoyad
            // 
            this.dreSoyad.Location = new System.Drawing.Point(99, 72);
            this.dreSoyad.Name = "dreSoyad";
            this.dreSoyad.Size = new System.Drawing.Size(121, 20);
            this.dreSoyad.TabIndex = 2;
            // 
            // frm_DoktorEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dreSoyad);
            this.Controls.Add(this.dreTCKNO);
            this.Controls.Add(this.dreSifre);
            this.Controls.Add(this.dreAd);
            this.Controls.Add(this.dreKlinik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dreKaydet);
            this.Controls.Add(this.dreSil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dreGuncelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DoktorEkle";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.frm_DoktorEkle_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dreDoktorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton dreGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dreDoktorList;
        private Bunifu.Framework.UI.BunifuFlatButton dreSil;
        private Bunifu.Framework.UI.BunifuFlatButton dreKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dreKlinik;
        private System.Windows.Forms.TextBox dreAd;
        private System.Windows.Forms.TextBox dreSifre;
        private System.Windows.Forms.TextBox dreTCKNO;
        private System.Windows.Forms.TextBox dreSoyad;
    }
}