namespace WindowsFormsApp2
{
    partial class tbl_sekreterGirdiktenSonra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tbl_sekreterGirdiktenSonra));
            this.skAdSoyad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.skRandevuPaneliSaat = new System.Windows.Forms.MaskedTextBox();
            this.skRandevuPaneliTarih = new System.Windows.Forms.MaskedTextBox();
            this.skRandevuPaneliKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.skRandevuPaneliDoktor = new System.Windows.Forms.ComboBox();
            this.skRandevuPaneliKlinik = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.skKlinikler = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.skDoktorlar = new System.Windows.Forms.DataGridView();
            this.skTCKNO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skKlinikler)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skDoktorlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // skAdSoyad
            // 
            this.skAdSoyad.AutoSize = true;
            this.skAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skAdSoyad.Location = new System.Drawing.Point(63, 12);
            this.skAdSoyad.Name = "skAdSoyad";
            this.skAdSoyad.Size = new System.Drawing.Size(197, 25);
            this.skAdSoyad.TabIndex = 9;
            this.skAdSoyad.Text = "Sekreter adı soyadı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.skRandevuPaneliSaat);
            this.groupBox1.Controls.Add(this.skRandevuPaneliTarih);
            this.groupBox1.Controls.Add(this.skRandevuPaneliKaydet);
            this.groupBox1.Controls.Add(this.skRandevuPaneliDoktor);
            this.groupBox1.Controls.Add(this.skRandevuPaneliKlinik);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 190);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Paneli";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // skRandevuPaneliSaat
            // 
            this.skRandevuPaneliSaat.Location = new System.Drawing.Point(84, 53);
            this.skRandevuPaneliSaat.Mask = "00:00";
            this.skRandevuPaneliSaat.Name = "skRandevuPaneliSaat";
            this.skRandevuPaneliSaat.Size = new System.Drawing.Size(127, 20);
            this.skRandevuPaneliSaat.TabIndex = 16;
            this.skRandevuPaneliSaat.ValidatingType = typeof(System.DateTime);
            // 
            // skRandevuPaneliTarih
            // 
            this.skRandevuPaneliTarih.Location = new System.Drawing.Point(84, 25);
            this.skRandevuPaneliTarih.Mask = "00/00/0000";
            this.skRandevuPaneliTarih.Name = "skRandevuPaneliTarih";
            this.skRandevuPaneliTarih.Size = new System.Drawing.Size(127, 20);
            this.skRandevuPaneliTarih.TabIndex = 16;
            this.skRandevuPaneliTarih.ValidatingType = typeof(System.DateTime);
            // 
            // skRandevuPaneliKaydet
            // 
            this.skRandevuPaneliKaydet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.skRandevuPaneliKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.skRandevuPaneliKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skRandevuPaneliKaydet.BorderRadius = 0;
            this.skRandevuPaneliKaydet.ButtonText = "Kaydet";
            this.skRandevuPaneliKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skRandevuPaneliKaydet.DisabledColor = System.Drawing.Color.Gray;
            this.skRandevuPaneliKaydet.Iconcolor = System.Drawing.Color.Transparent;
            this.skRandevuPaneliKaydet.Iconimage = null;
            this.skRandevuPaneliKaydet.Iconimage_right = null;
            this.skRandevuPaneliKaydet.Iconimage_right_Selected = null;
            this.skRandevuPaneliKaydet.Iconimage_Selected = null;
            this.skRandevuPaneliKaydet.IconMarginLeft = 0;
            this.skRandevuPaneliKaydet.IconMarginRight = 0;
            this.skRandevuPaneliKaydet.IconRightVisible = true;
            this.skRandevuPaneliKaydet.IconRightZoom = 0D;
            this.skRandevuPaneliKaydet.IconVisible = true;
            this.skRandevuPaneliKaydet.IconZoom = 90D;
            this.skRandevuPaneliKaydet.IsTab = false;
            this.skRandevuPaneliKaydet.Location = new System.Drawing.Point(84, 148);
            this.skRandevuPaneliKaydet.Name = "skRandevuPaneliKaydet";
            this.skRandevuPaneliKaydet.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.skRandevuPaneliKaydet.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.skRandevuPaneliKaydet.OnHoverTextColor = System.Drawing.Color.White;
            this.skRandevuPaneliKaydet.selected = false;
            this.skRandevuPaneliKaydet.Size = new System.Drawing.Size(117, 31);
            this.skRandevuPaneliKaydet.TabIndex = 16;
            this.skRandevuPaneliKaydet.Text = "Kaydet";
            this.skRandevuPaneliKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.skRandevuPaneliKaydet.Textcolor = System.Drawing.Color.White;
            this.skRandevuPaneliKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skRandevuPaneliKaydet.Click += new System.EventHandler(this.skRandevuPaneliKaydet_Click);
            // 
            // skRandevuPaneliDoktor
            // 
            this.skRandevuPaneliDoktor.FormattingEnabled = true;
            this.skRandevuPaneliDoktor.Location = new System.Drawing.Point(84, 119);
            this.skRandevuPaneliDoktor.Name = "skRandevuPaneliDoktor";
            this.skRandevuPaneliDoktor.Size = new System.Drawing.Size(127, 21);
            this.skRandevuPaneliDoktor.TabIndex = 28;
            // 
            // skRandevuPaneliKlinik
            // 
            this.skRandevuPaneliKlinik.FormattingEnabled = true;
            this.skRandevuPaneliKlinik.Location = new System.Drawing.Point(84, 84);
            this.skRandevuPaneliKlinik.Name = "skRandevuPaneliKlinik";
            this.skRandevuPaneliKlinik.Size = new System.Drawing.Size(127, 21);
            this.skRandevuPaneliKlinik.TabIndex = 27;
            this.skRandevuPaneliKlinik.SelectedIndexChanged += new System.EventHandler(this.skRandevuPaneliKlinik_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Doktor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Klinik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Saat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tarih";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuFlatButton3);
            this.groupBox2.Controls.Add(this.bunifuFlatButton2);
            this.groupBox2.Controls.Add(this.bunifuFlatButton1);
            this.groupBox2.Location = new System.Drawing.Point(12, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 134);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hızlı Erişim";
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Klinik Paneli";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(6, 56);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(242, 31);
            this.bunifuFlatButton3.TabIndex = 15;
            this.bunifuFlatButton3.Text = "Klinik Paneli";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Bütün Randevular";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(6, 93);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(242, 35);
            this.bunifuFlatButton2.TabIndex = 14;
            this.bunifuFlatButton2.Text = "Bütün Randevular";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Doktor Paneli";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(6, 19);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(242, 31);
            this.bunifuFlatButton1.TabIndex = 13;
            this.bunifuFlatButton1.Text = "Doktor Paneli";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.skKlinikler);
            this.groupBox3.Location = new System.Drawing.Point(289, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 156);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Klinikler";
            // 
            // skKlinikler
            // 
            this.skKlinikler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skKlinikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skKlinikler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skKlinikler.Location = new System.Drawing.Point(3, 16);
            this.skKlinikler.Name = "skKlinikler";
            this.skKlinikler.Size = new System.Drawing.Size(493, 137);
            this.skKlinikler.TabIndex = 0;
            this.skKlinikler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skKlinikler_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.skDoktorlar);
            this.groupBox4.Location = new System.Drawing.Point(289, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(493, 171);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doktorlar";
            // 
            // skDoktorlar
            // 
            this.skDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skDoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skDoktorlar.Location = new System.Drawing.Point(3, 16);
            this.skDoktorlar.Name = "skDoktorlar";
            this.skDoktorlar.Size = new System.Drawing.Size(487, 152);
            this.skDoktorlar.TabIndex = 0;
            // 
            // skTCKNO
            // 
            this.skTCKNO.AutoSize = true;
            this.skTCKNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skTCKNO.Location = new System.Drawing.Point(63, 40);
            this.skTCKNO.Name = "skTCKNO";
            this.skTCKNO.Size = new System.Drawing.Size(85, 25);
            this.skTCKNO.TabIndex = 15;
            this.skTCKNO.Text = "TCKNO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.bunifuImageButton1.Image = global::WindowsFormsApp2.Properties.Resources.exit;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(732, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(56, 53);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.UseWaitCursor = true;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // tbl_sekreterGirdiktenSonra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.skTCKNO);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.skAdSoyad);
            this.Controls.Add(this.bunifuImageButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tbl_sekreterGirdiktenSonra";
            this.Text = "Sekreter Ana Sayfa";
            this.Load += new System.EventHandler(this.tbl_sekreterGirdiktenSonra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skKlinikler)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skDoktorlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label skAdSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView skKlinikler;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView skDoktorlar;
        private System.Windows.Forms.Label skTCKNO;
        private Bunifu.Framework.UI.BunifuFlatButton skRandevuPaneliKaydet;
        private System.Windows.Forms.ComboBox skRandevuPaneliDoktor;
        private System.Windows.Forms.ComboBox skRandevuPaneliKlinik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox skRandevuPaneliSaat;
        private System.Windows.Forms.MaskedTextBox skRandevuPaneliTarih;
    }
}