namespace WindowsFormsApp2
{
    partial class frm_girisEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_girisEkranı));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSekreteGiris = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDoktorGiris = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnHastaGiris = new Bunifu.Framework.UI.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSekreteGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoktorGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHastaGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta Giriş";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(352, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor Giriş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(604, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter Giriş";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.heartLogo;
            this.pictureBox1.Location = new System.Drawing.Point(81, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSekreteGiris
            // 
            this.btnSekreteGiris.BackColor = System.Drawing.Color.White;
            this.btnSekreteGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnSekreteGiris.Image")));
            this.btnSekreteGiris.ImageActive = null;
            this.btnSekreteGiris.Location = new System.Drawing.Point(533, 194);
            this.btnSekreteGiris.Name = "btnSekreteGiris";
            this.btnSekreteGiris.Size = new System.Drawing.Size(258, 180);
            this.btnSekreteGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSekreteGiris.TabIndex = 2;
            this.btnSekreteGiris.TabStop = false;
            this.btnSekreteGiris.Zoom = 10;
            this.btnSekreteGiris.Click += new System.EventHandler(this.btnSekreteGiris_Click);
            // 
            // btnDoktorGiris
            // 
            this.btnDoktorGiris.BackColor = System.Drawing.Color.White;
            this.btnDoktorGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnDoktorGiris.Image")));
            this.btnDoktorGiris.ImageActive = null;
            this.btnDoktorGiris.Location = new System.Drawing.Point(279, 194);
            this.btnDoktorGiris.Name = "btnDoktorGiris";
            this.btnDoktorGiris.Size = new System.Drawing.Size(248, 180);
            this.btnDoktorGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDoktorGiris.TabIndex = 1;
            this.btnDoktorGiris.TabStop = false;
            this.btnDoktorGiris.Zoom = 10;
            this.btnDoktorGiris.Click += new System.EventHandler(this.btnDoktorGiris_Click);
            // 
            // btnHastaGiris
            // 
            this.btnHastaGiris.BackColor = System.Drawing.Color.White;
            this.btnHastaGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnHastaGiris.Image")));
            this.btnHastaGiris.ImageActive = null;
            this.btnHastaGiris.Location = new System.Drawing.Point(15, 194);
            this.btnHastaGiris.Name = "btnHastaGiris";
            this.btnHastaGiris.Size = new System.Drawing.Size(258, 180);
            this.btnHastaGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHastaGiris.TabIndex = 0;
            this.btnHastaGiris.TabStop = false;
            this.btnHastaGiris.Zoom = 10;
            this.btnHastaGiris.Click += new System.EventHandler(this.btnHastaGiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RomanT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(345, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 68);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rukwa Life";
            // 
            // frm_girisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSekreteGiris);
            this.Controls.Add(this.btnDoktorGiris);
            this.Controls.Add(this.btnHastaGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_girisEkranı";
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.frm_girisEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSekreteGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoktorGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHastaGiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnHastaGiris;
        private Bunifu.Framework.UI.BunifuImageButton btnDoktorGiris;
        private Bunifu.Framework.UI.BunifuImageButton btnSekreteGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}