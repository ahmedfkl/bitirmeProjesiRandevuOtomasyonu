using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class frm_DoktorDetayGiris : Form
    {
        public frm_DoktorDetayGiris()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public String TC;

        private void frm_DoktorDetayGiris_Load(object sender, EventArgs e)
        {
            lblTCKNO.Text = TC;

            
            
            //Doktor Ad Soyad

            SqlCommand komut = new SqlCommand("select adi,soyadi from tbl_doktor where TCKNO=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTCKNO.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                drGadSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();




            //Doktor ait randevuları listeleme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ID,hastaTC as [Hasta TCKNO],tarih as Tarih,saat as Saat,RandevuDurum as [Randevu Durum] from tbl_randevu where RandevuDoktor='"+drGadSoyad.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //Doktor TCKNO
        private void doktorBilgilerimiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_doktorBilgiDuzenle fr = new frm_doktorBilgiDuzenle();
            fr.TCNO = lblTCKNO.Text;
            fr.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //Doktor Çıkış Yap

            frm_DoktorDetayGiris frmDr = new frm_DoktorDetayGiris();
            frmDr.Close();
            frm_girisEkranı Hcikis = new frm_girisEkranı();
            Hcikis.Show();
            this.Hide();
        }
    }
}
