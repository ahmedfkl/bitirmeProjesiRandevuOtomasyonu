using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frm_girisEkranı : Form
    {
        public frm_girisEkranı()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        //Hasta Giriş Sayfasına Giden Yol
        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            frm_girisEkranı Hgiris = new frm_girisEkranı();
            Hgiris.Close();
            frm_HastaGiris HgirisEkrani = new frm_HastaGiris();
            HgirisEkrani.Show();
            this.Hide();
        }

        //Doktor Giriş Sayfasına Giden Yol
        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            frm_girisEkranı Dgiris = new frm_girisEkranı();
            Dgiris.Close();
            frm_DoktrorGiris DgirisEkrani = new frm_DoktrorGiris();
            DgirisEkrani.Show();
            this.Hide();
        }

        //Sekreter Giriş Sayfasına Giden Yol
        private void btnSekreteGiris_Click(object sender, EventArgs e)
        {
            frm_girisEkranı Sgiris = new frm_girisEkranı();
            Sgiris.Close();
            frm_SekreterGiris SgirisEkrani = new frm_SekreterGiris();
            SgirisEkrani.Show();
            this.Hide();
        }

        private void frm_girisEkranı_Load(object sender, EventArgs e)
        {

        }
    }
}
