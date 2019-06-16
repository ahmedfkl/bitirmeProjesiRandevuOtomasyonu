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
    public partial class frm_DoktrorGiris : Form
    {
        public frm_DoktrorGiris()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_DoktrorGiris_Load(object sender, EventArgs e)
        {

        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        //Doktor Giriş Yap
        //Kontroller
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_doktor where TCKNO=@p1 and sifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",drGirisTC.Text);
            komut.Parameters.AddWithValue("@p2",drGirisSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frm_DoktorDetayGiris fr = new frm_DoktorDetayGiris();
                fr.TC = drGirisTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TCKNO veya Şifre");
            }
            bgl.baglanti().Close();
        }

        //Doğru girildiği zaman doktor detay sayfasına giden yol
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_DoktrorGiris fr = new frm_DoktrorGiris();
            fr.Close();
            frm_girisEkranı frm = new frm_girisEkranı();
            frm.Show();
            this.Hide();
        }
    }
}
