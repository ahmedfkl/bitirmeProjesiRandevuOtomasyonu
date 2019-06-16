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
    public partial class frm_DoktorEkle : Form
    {
        public frm_DoktorEkle()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void frm_DoktorEkle_Load(object sender, EventArgs e)
        {
            //Klinik Çekme Dropdown Liste
            SqlCommand Komut2 = new SqlCommand("select klinikAdi from tbl_klinik", bgl.baglanti());
            SqlDataReader dr2 = Komut2.ExecuteReader();
            while (dr2.Read())
            {
                dreKlinik.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


            //Data table daki Mevcutda Olan Doktorlar ve görünümleri
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select ID as [Doktor Numarası],adi as Adı,soyadi as Soyadı,sifre as Şifre,TCKNO,doktorKlinikAdi as Klinik from tbl_doktor", bgl.baglanti());
            da1.Fill(dt1);
            dreDoktorList.DataSource = dt1;
        }


        //Yeni Doktor Kaydetme
        private void dreKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_doktor(adi,soyadi,sifre,TCKNO,doktorKlinikAdi) values (@d1,@d2,@d3,@d4,@d5)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",dreAd.Text);
            komut.Parameters.AddWithValue("@d2", dreSoyad.Text);
            komut.Parameters.AddWithValue("@d3", dreSifre.Text);
            komut.Parameters.AddWithValue("@d4", dreTCKNO.Text);
            komut.Parameters.AddWithValue("@d5", dreKlinik.Text);
            komut.ExecuteNonQuery();


            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select ID as [Doktor Numarası],adi as Adı,soyadi as Soyadı,sifre as Şifre,TCKNO,doktorKlinikAdi as Klinik from tbl_doktor", bgl.baglanti());
            da1.Fill(dt1);
            dreDoktorList.DataSource = dt1;



            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Data Table a tıklandığında(Doktorların olduğu)
        private void dreDoktorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dreDoktorList.SelectedCells[0].RowIndex;
            dreAd.Text = dreDoktorList.Rows[secilen].Cells[1].Value.ToString();
            dreSoyad.Text = dreDoktorList.Rows[secilen].Cells[2].Value.ToString();
            dreSifre.Text = dreDoktorList.Rows[secilen].Cells[3].Value.ToString();
            dreTCKNO.Text = dreDoktorList.Rows[secilen].Cells[4].Value.ToString();
            dreKlinik.Text = dreDoktorList.Rows[secilen].Cells[5].Value.ToString();
        }

        //Doktor Silme
        private void dreSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_doktor where TCKNO=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",dreTCKNO.Text);
            komut.ExecuteNonQuery();


            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select ID as [Doktor Numarası],adi as Adı,soyadi as Soyadı,sifre as Şifre,TCKNO,doktorKlinikAdi as Klinik from tbl_doktor", bgl.baglanti());
            da1.Fill(dt1);
            dreDoktorList.DataSource = dt1;


            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        //Doktorun bilgilerini güncelle
        private void dreGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update tbl_doktor set adi=@d1,soyadi=@d2,doktorKlinikAdi=@d3,sifre=@d5 where TCKNO=@d4",bgl.baglanti());
            komut2.Parameters.AddWithValue("@d1", dreAd.Text);
            komut2.Parameters.AddWithValue("@d2", dreSoyad.Text);
            komut2.Parameters.AddWithValue("@d3", dreKlinik.Text);
            komut2.Parameters.AddWithValue("@d4", dreTCKNO.Text);
            komut2.Parameters.AddWithValue("@d5", dreSifre.Text);
            komut2.ExecuteNonQuery();


            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select ID as [Doktor Numarası],adi as Adı,soyadi as Soyadı,sifre as Şifre,TCKNO,doktorKlinikAdi as Klinik from tbl_doktor", bgl.baglanti());
            da1.Fill(dt1);
            dreDoktorList.DataSource = dt1;


            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
