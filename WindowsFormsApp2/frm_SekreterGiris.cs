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
    public partial class frm_SekreterGiris : Form
    {
        public frm_SekreterGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        

        //Sekreter Giriş Kontrol
        private void skrtrGirisBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_sekreter where TC=@p1 and Sifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",skrtrGirisTCKNO.Text);
            komut.Parameters.AddWithValue("@p2", skrtrGirisSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                tbl_sekreterGirdiktenSonra frs = new tbl_sekreterGirdiktenSonra();
                frs.TCNumara = skrtrGirisTCKNO.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC yada Şifre");
            }
            bgl.baglanti().Close();

        }
        //Giriş Butonu
        private void btnGeri_Click(object sender, EventArgs e)
        {
            frm_SekreterGiris fr = new frm_SekreterGiris();
            fr.Close();
            frm_girisEkranı frm = new frm_girisEkranı();
            frm.Show();
            this.Hide();
        }

        private void frm_SekreterGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
