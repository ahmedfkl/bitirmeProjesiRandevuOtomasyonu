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
    public partial class frm_HastaGiris : Form
    {
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public frm_HastaGiris()
        {
            InitializeComponent();
        }   

        private void frm_HastaGiris_Load(object sender, EventArgs e)
        {

        }

        //Hasta Üye Giriş Kontrolü
        private void btnHastaGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_hasta where TCKNO=@p1 and Sifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtBoxHastaGirisTCKNO.Text);
            komut.Parameters.AddWithValue("@p2",txtBoxHastaGirisSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frm_HastaDetayGirisEkrani fr = new frm_HastaDetayGirisEkrani();
                fr.tc = txtBoxHastaGirisTCKNO.Text; 
                fr.tc = txtBoxHastaGirisTCKNO.Text;
                fr.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Hatalı Giriş");
            }
            bgl.baglanti().Close();
        }

        //Üye Olmak için yol
        private void btnHastaUyeOlcak_Click(object sender, EventArgs e)
        {
            hastauyeol kayit = new hastauyeol();
            kayit.Show();
        }

        private void txtBoxHastaGirisTCKNO_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxHastaGirisSifre_OnValueChanged(object sender, EventArgs e)
        {

        }


        //Giriş Yap butonu
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_HastaGiris fr = new frm_HastaGiris();
            fr.Close();
            frm_girisEkranı frm = new frm_girisEkranı();
            frm.Show();
            this.Hide();


        }
    }
}
