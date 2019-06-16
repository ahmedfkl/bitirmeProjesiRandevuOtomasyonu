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
    public partial class frm_randevuListesi : Form
    {
        public frm_randevuListesi()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();


        //Bütün Randevuların Listelendiği Kısım
        private void frm_randevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ID as [Randevu Numarası],hastaTC as [Hasta TCKNO],RandevuDoktor as Doktor,tarih as Tarih,saat as Saat,RandevuDurum as Durum,RandevuKlinik as Klinik from tbl_randevu",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
