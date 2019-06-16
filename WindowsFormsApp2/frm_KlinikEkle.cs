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
    public partial class frm_KlinikEkle : Form
    {
        public frm_KlinikEkle()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void frm_KlinikEkle_Load(object sender, EventArgs e)
        {
            //Grid e Verileri Çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID as [Klinik Numarası], klinikAdi as Klinik from tbl_klinik", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            //Klinik Ekleme
            SqlCommand komut = new SqlCommand("insert into tbl_klinik (klinikAdi) values(@b1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@b1",klnkAdi.Text);
            komut.ExecuteNonQuery();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID as [Klinik Numarası], klinikAdi as Klinik from tbl_klinik", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;



            bgl.baglanti().Close();
            MessageBox.Show("Klinik Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Seçilenin Bilgilerini Getrime
            int secilenDeger = dataGridView1.SelectedCells[0].RowIndex;
            klnkID.Text = dataGridView1.Rows[secilenDeger].Cells[0].Value.ToString();
            klnkAdi.Text = dataGridView1.Rows[secilenDeger].Cells[1].Value.ToString();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //Klinik Sil
            SqlCommand komut2 = new SqlCommand("delete from tbl_klinik where ID=@b1",bgl.baglanti());
            komut2.Parameters.AddWithValue("@b1",klnkID.Text);
            komut2.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID as [Klinik Numarası], klinikAdi as Klinik from tbl_klinik", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            bgl.baglanti().Close();
            MessageBox.Show("Klinik Silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //Klinik Güncelle
            SqlCommand komut3 = new SqlCommand("update tbl_klinik set klinikAdi=@b1 where ID=@b2", bgl.baglanti());
            komut3.Parameters.AddWithValue("@b1",klnkAdi.Text);
            komut3.Parameters.AddWithValue("@b2",klnkID.Text);
            komut3.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID as [Klinik Numarası], klinikAdi as Klinik from tbl_klinik", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            bgl.baglanti().Close();
            MessageBox.Show("Klinik Güncellenmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
