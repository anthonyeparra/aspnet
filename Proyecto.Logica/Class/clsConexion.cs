using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.Class
{
    class clsConexion
    {
        // Me va retornar la conexion a la base de  
        public string stGetConexion() 
        {
            return ConfigurationManager.ConnectionStrings["Cnx"].ToString();
        }
    }
}
