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
    public partial class frm_doktorBilgiDuzenle : Form
    {
        public frm_doktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public String TCNO;
        private void frm_doktorBilgiDuzenle_Load(object sender, EventArgs e)
        {

            //Klinik Çekme****
            SqlCommand komut3 = new SqlCommand("select klinikAdi from tbl_klinik", bgl.baglanti());
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                updDoktorKlinik.Items.Add(dr2[0]);
            }


            updDoktorTCKNO.Text = TCNO;

            //Text Boxlara o anki doktorun verilerini getirme
            SqlCommand komut = new SqlCommand("Select * from tbl_doktor where TCKNO=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",updDoktorTCKNO.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read()){
                updDoktorAd.Text = dr[1].ToString();
                updDoktorSoyad.Text = dr[2].ToString();
                updDoktorSifre.Text = dr[3].ToString();
                updDoktorKlinik.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();

        }

        //Doktroun kendisi kendi bilgileri üzerinde değişiklik yaptığı yer
        private void btnDoktorDuzenlendi_Click(object sender, EventArgs e)
        {
          

            SqlCommand komut2 = new SqlCommand("update tbl_doktor set adi=@p1, soyadi=@p2,sifre=@p3,doktorKlinikAdi=@p4 where TCKNO=@p5",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",updDoktorAd.Text);
            komut2.Parameters.AddWithValue("@p2", updDoktorSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", updDoktorSifre.Text);
            komut2.Parameters.AddWithValue("@p4", updDoktorKlinik.Text);
            komut2.Parameters.AddWithValue("@p5", updDoktorTCKNO.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
