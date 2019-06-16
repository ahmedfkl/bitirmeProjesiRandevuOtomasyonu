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
    public partial class frm_HastaBilgiDuzenle : Form
    {
        public frm_HastaBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TCno;

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void frm_HastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            //Hastanın Bilgilerinin text box a çekilmesini sağlar
            updHastaUyeTckno.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * from tbl_hasta where TCKNO=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",updHastaUyeTckno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                updHastaUyeAd.Text = dr[1].ToString();
                updHastaUyeSoyad.Text = dr[2].ToString();
                updHastaUyeSifre.Text = dr[3].ToString();
            }
            bgl.baglanti().Close();
        }


        //Güncelleme kısmı
        private void btnHastaDuzenlendi_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update tbl_hasta set Adi=@p1,Soyadi=@p2,Sifre=@p3 where TCKNO=@p4",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",updHastaUyeAd.Text);
            komut2.Parameters.AddWithValue("@p2", updHastaUyeSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", updHastaUyeSifre.Text);
            komut2.Parameters.AddWithValue("@p4", updHastaUyeTckno.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellenmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
