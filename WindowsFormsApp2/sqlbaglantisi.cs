using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp2
{
    class Sqlbaglantisi
    {
        public SqlConnection baglanti() {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-HPPGFA2\\SQLEXPRESS;Initial " +
                   "Catalog=db_BitirmeProjesi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        
    }
}