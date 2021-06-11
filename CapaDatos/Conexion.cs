using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        private const string CN = "Data Source=.;Initial Catalog=DBPRUEBAS;Persist Security Info=True;User ID=sa;Password=AsdFdel1-4";

        public static string ConexionDatos
        {
            get { return CN; }
        }
    }


    
}
