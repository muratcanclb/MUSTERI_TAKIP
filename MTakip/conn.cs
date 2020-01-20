using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MTakip
{
    class conn
    {
        public SqlConnection connect()
   
        {
           SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R5EUA3L;Initial Catalog=Firma;Integrated Security=True");
           con.Open();
           return con;
        }

    }
}

