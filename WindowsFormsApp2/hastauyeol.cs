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
    public partial class hastauyeol : Form
    {
        Sqlbaglantisi bgl = new Sqlbaglantisi();


        public hastauyeol()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            hastauyeol hiptal = new hastauyeol();
           

        }
        //Yeni Hasta Üye Ol
        private void btnHastaUyuOldu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into tbl_hasta(Adi,Soyadi,Sifre,TCKNO) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtHastaUyeAd.Text);
                komut.Parameters.AddWithValue("@p2", txtHastaUyeSoyad.Text);
                komut.Parameters.AddWithValue("@p3", txtHastaUyeSifre.Text);
                komut.Parameters.AddWithValue("@p4", txtHastaUyeTckno.Text);    
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kaydınız gerçekleşmiştir");
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }

        private void hastauyeol_Load(object sender, EventArgs e)
        {

        }
    }
}
