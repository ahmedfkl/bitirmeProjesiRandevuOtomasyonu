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
    public partial class frm_HastaDetayGirisEkrani : Form
    {
        public frm_HastaDetayGirisEkrani()
        {
            InitializeComponent();
        }
        public void verileriGoster(String veriler)
        {

        }


        public string tc;

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void randevu (){
            
        }

        private void frm_HastaDetayGirisEkrani_Load(object sender, EventArgs e)
        {
            lblTCKNO.Text = tc;
            HGSadSoyad.Text = tc;

            //Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("select Adi,Soyadi from tbl_hasta where TCKNO=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", HGSadSoyad.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                HGSadSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();


            //Randevu Geçmişi

            DataTable rndGeçmişi = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter("Select ID as [Randevu Numarası], RandevuDoktor as Doktor, tarih as Tarih, saat as Saat, RandevuKlinik as Klinik from tbl_randevu where hastaTC='"+lblTCKNO.Text+"'",bgl.baglanti());
            dta.Fill(rndGeçmişi);
            dataGridView2.DataSource = rndGeçmişi;

            //Dropdown List Klinik Çekme

            SqlCommand komut2 = new SqlCommand("select klinikAdi from tbl_klinik", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                rndKlinik.Items.Add(dr2[0]);
            }
        }


        //Aktif Randevular
        public void rndDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID as [Randevu Numarası],RandevuDoktor as Doktor,tarih as Tarih,saat as Saat from tbl_randevu where RandevuKlinik='"+rndKlinik.Text+"'" + "and RandevuDoktor='" + rndDoktor.Text + "'and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        

        //Klinik seçtikten sonra Kliniğin Doktrolarını listeleme
        private void rndKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            rndDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select adi,soyadi from tbl_doktor where doktorKlinikAdi=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", rndKlinik.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                rndDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }


        //Çıkış Yap Butonu
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frm_HastaDetayGirisEkrani HcikisEkrani = new frm_HastaDetayGirisEkrani();
            HcikisEkrani.Close();
            frm_girisEkranı Hcikis = new frm_girisEkranı();
            Hcikis.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //Hasta Bilgilerini Düzenle Sayfası Yolu
        private void HastaBilgilerimiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_HastaBilgiDuzenle duzenle = new frm_HastaBilgiDuzenle();
            duzenle.TCno = lblTCKNO.Text;
            duzenle.Show();
            
        }

        private void lblTCKNO_Click(object sender, EventArgs e)
        {

        }


        //Data Grid View2 Yani Geçmiş Randevuya tıkladnığı zaman
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            iptTCKNO.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            iptKlinik.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            iptDoktor.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            iptTarih.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            iptSaat.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            
            

        }




        //Data Grid View1 Yani Aktif Randevuya tıkladnığı zaman
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rndID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();


        }


        //Randevu Al
        private void rndRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevu set RandevuDurum=1,hastaTC=@p1 where ID=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTCKNO.Text);
            komut.Parameters.AddWithValue("@p2",rndID.Text);
            komut.ExecuteNonQuery();

            //***********
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter("Select ID as [Randevu Numarası],RandevuDoktor as Doktor,tarih as Tarih,saat as Saat from tbl_randevu where RandevuKlinik='" + rndKlinik.Text + "'" + "and RandevuDoktor='" + rndDoktor.Text + "'and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;





            DataTable rndGeçmişi = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter("Select ID as [Randevu Numarası], RandevuDoktor as Doktor, tarih as Tarih, saat as Saat, RandevuKlinik as Klinik from tbl_randevu where hastaTC='" + lblTCKNO.Text + "'", bgl.baglanti());
            dta.Fill(rndGeçmişi);
            dataGridView2.DataSource = rndGeçmişi;
            //***************


            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "DİKKAT", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
        }

        //Randevu İptal
        private void rndRandevuIptal_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevu set RandevuDurum=0,hastaTC=0 where ID=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", iptKlinik.Text);
            komut.ExecuteNonQuery();


            //************
            DataTable rndGeçmişi = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter("Select ID as [Randevu Numarası], RandevuDoktor as Doktor, tarih as Tarih, saat as Saat, RandevuKlinik as Klinik from tbl_randevu where hastaTC='" + lblTCKNO.Text + "'", bgl.baglanti());
            dta.Fill(rndGeçmişi);
            dataGridView2.DataSource = rndGeçmişi;




            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID as [Randevu Numarası],RandevuDoktor as Doktor,tarih as Tarih,saat as Saat from tbl_randevu where RandevuKlinik='" + rndKlinik.Text + "'" + "and RandevuDoktor='" + rndDoktor.Text + "'and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //************


            bgl.baglanti().Close();
            MessageBox.Show("Randevu İptal Edildi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }



        //***********************



        private void iptKlinik_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}