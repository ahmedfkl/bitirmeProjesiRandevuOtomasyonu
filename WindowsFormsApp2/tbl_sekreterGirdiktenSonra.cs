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
    public partial class tbl_sekreterGirdiktenSonra : Form
    {
        public tbl_sekreterGirdiktenSonra()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public String TCNumara;
       

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void tbl_sekreterGirdiktenSonra_Load(object sender, EventArgs e)
        {
            //TCKNO çekme
            skTCKNO.Text = TCNumara;
            
            //Ad Soyad Çekme
            SqlCommand komut1 = new SqlCommand("Select Ad,Soyad from tbl_sekreter where TC=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", skTCKNO.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                skAdSoyad.Text = dr1[0] + " " + dr1[1];
            }
            bgl.baglanti().Close();

            // Data grid view'e klinik çekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID, klinikAdi as Klinik from tbl_klinik",bgl.baglanti());
            da.Fill(dt1);
            skKlinikler.DataSource = dt1;

            // Data grid view'e Doktor çekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (adi+' '+soyadi) as Doktor,doktorKlinikAdi as Klinik from tbl_doktor",bgl.baglanti());
            da2.Fill(dt2);
            skDoktorlar.DataSource = dt2;


            //Randevu Oluşturmaya Klinik Çekmek
            SqlCommand Komut2 = new SqlCommand("select klinikAdi from tbl_klinik",bgl.baglanti());
            SqlDataReader dr2 = Komut2.ExecuteReader();
            while (dr2.Read())
            {
                skRandevuPaneliKlinik.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


            
        }

        //Çıkış Yap
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            tbl_sekreterGirdiktenSonra skcikisEkrani = new tbl_sekreterGirdiktenSonra();
            skcikisEkrani.Close();
            frm_girisEkranı Hcikis = new frm_girisEkranı();
            Hcikis.Show();
            this.Hide();
        }

        //Yeni Randevu Oluşturma
        private void skRandevuPaneliKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("insert into tbl_randevu (tarih,saat,RandevuKlinik,RandevuDoktor,RandevuDurum) values (@r1,@r2,@r3,@r4,0)",bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@r1",skRandevuPaneliTarih.Text);
            komutKaydet.Parameters.AddWithValue("@r2", skRandevuPaneliSaat.Text);
            komutKaydet.Parameters.AddWithValue("@r3", skRandevuPaneliKlinik.Text);
            komutKaydet.Parameters.AddWithValue("@r4", skRandevuPaneliDoktor.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturldu!");
        }


        //Randevu Oluşturmaya Doktor Çekmek
        private void skRandevuPaneliKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            skRandevuPaneliDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select adi,soyadi from tbl_doktor where doktorKlinikAdi=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",skRandevuPaneliKlinik.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                skRandevuPaneliDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }


        //Doktor Ekle
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frm_DoktorEkle drp = new frm_DoktorEkle();
            drp.Show();
        }

        //Klinik Ekle
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            frm_KlinikEkle frk = new frm_KlinikEkle();
            frk.Show();
        }

        //Bütün Randevuların Listesi
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frm_randevuListesi frl = new frm_randevuListesi();
            frl.Show(); 
        }

        private void skRandevuPaneliGüncelle_Click(object sender, EventArgs e)
        {
           
        }

        private void skKlinikler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
