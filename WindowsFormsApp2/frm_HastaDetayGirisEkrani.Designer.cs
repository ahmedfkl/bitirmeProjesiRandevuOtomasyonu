namespace WindowsFormsApp2
{
    partial class frm_HastaDetayGirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HastaDetayGirisEkrani));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RandevuAlGrup = new System.Windows.Forms.GroupBox();
            this.rndID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rndDoktor = new System.Windows.Forms.ComboBox();
            this.rndKlinik = new System.Windows.Forms.ComboBox();
            this.rndRandevuAl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.HGSadSoyad = new System.Windows.Forms.Label();
            this.HastaBilgilerimiDuzenle = new System.Windows.Forms.LinkLabel();
            this.lblTCKNO = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rndRandevuIptal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.asd = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.iptTCKNO = new System.Windows.Forms.TextBox();
            this.iptSaat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fgh = new System.Windows.Forms.Label();
            this.iptDoktor = new System.Windows.Forms.TextBox();
            this.dgfs = new System.Windows.Forms.Label();
            this.iptTarih = new System.Windows.Forms.TextBox();
            this.dsffdg = new System.Windows.Forms.Label();
            this.iptKlinik = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.RandevuAlGrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(254, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 173);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktif Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 154);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RandevuAlGrup
            // 
            this.RandevuAlGrup.Controls.Add(this.rndID);
            this.RandevuAlGrup.Controls.Add(this.label2);
            this.RandevuAlGrup.Controls.Add(this.rndDoktor);
            this.RandevuAlGrup.Controls.Add(this.rndKlinik);
            this.RandevuAlGrup.Controls.Add(this.rndRandevuAl);
            this.RandevuAlGrup.Controls.Add(this.label3);
            this.RandevuAlGrup.Controls.Add(this.label1);
            this.RandevuAlGrup.Location = new System.Drawing.Point(12, 91);
            this.RandevuAlGrup.Name = "RandevuAlGrup";
            this.RandevuAlGrup.Size = new System.Drawing.Size(236, 138);
            this.RandevuAlGrup.TabIndex = 13;
            this.RandevuAlGrup.TabStop = false;
            this.RandevuAlGrup.Text = "Randevu Al";
            // 
            // rndID
            // 
            this.rndID.Location = new System.Drawing.Point(79, 19);
            this.rndID.Name = "rndID";
            this.rndID.Size = new System.Drawing.Size(146, 20);
            this.rndID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Id";
            // 
            // rndDoktor
            // 
            this.rndDoktor.FormattingEnabled = true;
            this.rndDoktor.Location = new System.Drawing.Point(79, 67);
            this.rndDoktor.Name = "rndDoktor";
            this.rndDoktor.Size = new System.Drawing.Size(146, 21);
            this.rndDoktor.TabIndex = 17;
            this.rndDoktor.SelectedIndexChanged += new System.EventHandler(this.rndDoktor_SelectedIndexChanged);
            // 
            // rndKlinik
            // 
            this.rndKlinik.FormattingEnabled = true;
            this.rndKlinik.Location = new System.Drawing.Point(79, 43);
            this.rndKlinik.Name = "rndKlinik";
            this.rndKlinik.Size = new System.Drawing.Size(146, 21);
            this.rndKlinik.TabIndex = 16;
            this.rndKlinik.SelectedIndexChanged += new System.EventHandler(this.rndKlinik_SelectedIndexChanged);
            // 
            // rndRandevuAl
            // 
            this.rndRandevuAl.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rndRandevuAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rndRandevuAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rndRandevuAl.BorderRadius = 0;
            this.rndRandevuAl.ButtonText = "Randevu Al";
            this.rndRandevuAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rndRandevuAl.DisabledColor = System.Drawing.Color.Gray;
            this.rndRandevuAl.Iconcolor = System.Drawing.Color.Transparent;
            this.rndRandevuAl.Iconimage = ((System.Drawing.Image)(resources.GetObject("rndRandevuAl.Iconimage")));
            this.rndRandevuAl.Iconimage_right = null;
            this.rndRandevuAl.Iconimage_right_Selected = null;
            this.rndRandevuAl.Iconimage_Selected = null;
            this.rndRandevuAl.IconMarginLeft = 0;
            this.rndRandevuAl.IconMarginRight = 0;
            this.rndRandevuAl.IconRightVisible = true;
            this.rndRandevuAl.IconRightZoom = 0D;
            this.rndRandevuAl.IconVisible = true;
            this.rndRandevuAl.IconZoom = 90D;
            this.rndRandevuAl.IsTab = false;
            this.rndRandevuAl.Location = new System.Drawing.Point(79, 94);
            this.rndRandevuAl.Name = "rndRandevuAl";
            this.rndRandevuAl.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rndRandevuAl.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.rndRandevuAl.OnHoverTextColor = System.Drawing.Color.White;
            this.rndRandevuAl.selected = false;
            this.rndRandevuAl.Size = new System.Drawing.Size(146, 30);
            this.rndRandevuAl.TabIndex = 8;
            this.rndRandevuAl.Text = "Randevu Al";
            this.rndRandevuAl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rndRandevuAl.Textcolor = System.Drawing.Color.White;
            this.rndRandevuAl.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rndRandevuAl.Click += new System.EventHandler(this.rndRandevuAl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doktor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klinik";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.bunifuImageButton1.Image = global::WindowsFormsApp2.Properties.Resources.exit;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(691, 24);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(56, 56);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.UseWaitCursor = true;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // HGSadSoyad
            // 
            this.HGSadSoyad.AutoSize = true;
            this.HGSadSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HGSadSoyad.Location = new System.Drawing.Point(65, 24);
            this.HGSadSoyad.Name = "HGSadSoyad";
            this.HGSadSoyad.Size = new System.Drawing.Size(172, 25);
            this.HGSadSoyad.TabIndex = 10;
            this.HGSadSoyad.Text = "Hasta adı soyadı";
            // 
            // HastaBilgilerimiDuzenle
            // 
            this.HastaBilgilerimiDuzenle.AutoSize = true;
            this.HastaBilgilerimiDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HastaBilgilerimiDuzenle.Location = new System.Drawing.Point(311, 24);
            this.HastaBilgilerimiDuzenle.Name = "HastaBilgilerimiDuzenle";
            this.HastaBilgilerimiDuzenle.Size = new System.Drawing.Size(189, 25);
            this.HastaBilgilerimiDuzenle.TabIndex = 16;
            this.HastaBilgilerimiDuzenle.TabStop = true;
            this.HastaBilgilerimiDuzenle.Text = "Bilgilerimi Düzenle";
            this.HastaBilgilerimiDuzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HastaBilgilerimiDuzenle_LinkClicked);
            // 
            // lblTCKNO
            // 
            this.lblTCKNO.AutoSize = true;
            this.lblTCKNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCKNO.Location = new System.Drawing.Point(65, 49);
            this.lblTCKNO.Name = "lblTCKNO";
            this.lblTCKNO.Size = new System.Drawing.Size(85, 25);
            this.lblTCKNO.TabIndex = 17;
            this.lblTCKNO.Text = "TCKNO";
            this.lblTCKNO.Click += new System.EventHandler(this.lblTCKNO_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(257, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 168);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mevcut Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(493, 149);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // rndRandevuIptal
            // 
            this.rndRandevuIptal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rndRandevuIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rndRandevuIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rndRandevuIptal.BorderRadius = 0;
            this.rndRandevuIptal.ButtonText = "Randevu İptal";
            this.rndRandevuIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rndRandevuIptal.DisabledColor = System.Drawing.Color.Gray;
            this.rndRandevuIptal.Iconcolor = System.Drawing.Color.Transparent;
            this.rndRandevuIptal.Iconimage = ((System.Drawing.Image)(resources.GetObject("rndRandevuIptal.Iconimage")));
            this.rndRandevuIptal.Iconimage_right = null;
            this.rndRandevuIptal.Iconimage_right_Selected = null;
            this.rndRandevuIptal.Iconimage_Selected = null;
            this.rndRandevuIptal.IconMarginLeft = 0;
            this.rndRandevuIptal.IconMarginRight = 0;
            this.rndRandevuIptal.IconRightVisible = true;
            this.rndRandevuIptal.IconRightZoom = 0D;
            this.rndRandevuIptal.IconVisible = true;
            this.rndRandevuIptal.IconZoom = 90D;
            this.rndRandevuIptal.IsTab = false;
            this.rndRandevuIptal.Location = new System.Drawing.Point(69, 167);
            this.rndRandevuIptal.Name = "rndRandevuIptal";
            this.rndRandevuIptal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rndRandevuIptal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.rndRandevuIptal.OnHoverTextColor = System.Drawing.Color.White;
            this.rndRandevuIptal.selected = false;
            this.rndRandevuIptal.Size = new System.Drawing.Size(146, 30);
            this.rndRandevuIptal.TabIndex = 20;
            this.rndRandevuIptal.Text = "Randevu İptal";
            this.rndRandevuIptal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rndRandevuIptal.Textcolor = System.Drawing.Color.White;
            this.rndRandevuIptal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rndRandevuIptal.Click += new System.EventHandler(this.rndRandevuIptal_Click);
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asd.Location = new System.Drawing.Point(35, 51);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(26, 20);
            this.asd.TabIndex = 21;
            this.asd.Text = "ID";
            this.asd.Click += new System.EventHandler(this.iptKlinik_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.iptTCKNO);
            this.groupBox3.Controls.Add(this.iptSaat);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.fgh);
            this.groupBox3.Controls.Add(this.iptDoktor);
            this.groupBox3.Controls.Add(this.dgfs);
            this.groupBox3.Controls.Add(this.iptTarih);
            this.groupBox3.Controls.Add(this.dsffdg);
            this.groupBox3.Controls.Add(this.rndRandevuIptal);
            this.groupBox3.Controls.Add(this.iptKlinik);
            this.groupBox3.Controls.Add(this.asd);
            this.groupBox3.Location = new System.Drawing.Point(13, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 203);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu İptal";
            // 
            // iptTCKNO
            // 
            this.iptTCKNO.Location = new System.Drawing.Point(69, 25);
            this.iptTCKNO.Name = "iptTCKNO";
            this.iptTCKNO.Size = new System.Drawing.Size(146, 20);
            this.iptTCKNO.TabIndex = 29;
            // 
            // iptSaat
            // 
            this.iptSaat.Location = new System.Drawing.Point(69, 129);
            this.iptSaat.Name = "iptSaat";
            this.iptSaat.Size = new System.Drawing.Size(146, 20);
            this.iptSaat.TabIndex = 28;
            this.iptSaat.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Doktor";
            // 
            // fgh
            // 
            this.fgh.AutoSize = true;
            this.fgh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fgh.Location = new System.Drawing.Point(14, 127);
            this.fgh.Name = "fgh";
            this.fgh.Size = new System.Drawing.Size(45, 20);
            this.fgh.TabIndex = 24;
            this.fgh.Text = "Klinik";
            // 
            // iptDoktor
            // 
            this.iptDoktor.Location = new System.Drawing.Point(69, 77);
            this.iptDoktor.Name = "iptDoktor";
            this.iptDoktor.Size = new System.Drawing.Size(146, 20);
            this.iptDoktor.TabIndex = 27;
            this.iptDoktor.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dgfs
            // 
            this.dgfs.AutoSize = true;
            this.dgfs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgfs.Location = new System.Drawing.Point(18, 103);
            this.dgfs.Name = "dgfs";
            this.dgfs.Size = new System.Drawing.Size(43, 20);
            this.dgfs.TabIndex = 23;
            this.dgfs.Text = "Saat";
            // 
            // iptTarih
            // 
            this.iptTarih.Location = new System.Drawing.Point(69, 103);
            this.iptTarih.Name = "iptTarih";
            this.iptTarih.Size = new System.Drawing.Size(146, 20);
            this.iptTarih.TabIndex = 26;
            this.iptTarih.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dsffdg
            // 
            this.dsffdg.AutoSize = true;
            this.dsffdg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dsffdg.Location = new System.Drawing.Point(15, 77);
            this.dsffdg.Name = "dsffdg";
            this.dsffdg.Size = new System.Drawing.Size(44, 20);
            this.dsffdg.TabIndex = 22;
            this.dsffdg.Text = "Tarih";
            // 
            // iptKlinik
            // 
            this.iptKlinik.Location = new System.Drawing.Point(69, 51);
            this.iptKlinik.Name = "iptKlinik";
            this.iptKlinik.Size = new System.Drawing.Size(146, 20);
            this.iptKlinik.TabIndex = 25;
            this.iptKlinik.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frm_HastaDetayGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTCKNO);
            this.Controls.Add(this.HastaBilgilerimiDuzenle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RandevuAlGrup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HGSadSoyad);
            this.Controls.Add(this.bunifuImageButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_HastaDetayGirisEkrani";
            this.Text = "Hasta Ana Sayfa";
            this.Load += new System.EventHandler(this.frm_HastaDetayGirisEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.RandevuAlGrup.ResumeLayout(false);
            this.RandevuAlGrup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox RandevuAlGrup;
        private Bunifu.Framework.UI.BunifuFlatButton rndRandevuAl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label HGSadSoyad;
        private System.Windows.Forms.ComboBox rndKlinik;
        private System.Windows.Forms.ComboBox rndDoktor;
        private System.Windows.Forms.LinkLabel HastaBilgilerimiDuzenle;
        private System.Windows.Forms.Label lblTCKNO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox rndID;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton rndRandevuIptal;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label fgh;
        private System.Windows.Forms.Label dgfs;
        private System.Windows.Forms.Label dsffdg;
        private System.Windows.Forms.TextBox iptTarih;
        private System.Windows.Forms.TextBox iptDoktor;
        private System.Windows.Forms.TextBox iptSaat;
        private System.Windows.Forms.TextBox iptTCKNO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox iptKlinik;
    }
}