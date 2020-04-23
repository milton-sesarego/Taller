using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class BDComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-RVDRODE\\SQLEXPRESS;Initial Catalog=Taller;Integrated Security=true;");

            conectar.Open();
            return conectar;
        }

    }
}