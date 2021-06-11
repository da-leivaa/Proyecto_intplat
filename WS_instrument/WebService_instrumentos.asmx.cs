using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using CapaDatos;

namespace WS_instrument
{
    /// <summary>
    /// Descripción breve de WebService_instrumentos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService_instrumentos : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataSet TotalProductos()
        {
            var comando = CapaDatos.ConfiguracionDatos.CrearComando();
            comando.CommandText = "SELECT * FROM PRODUCTO";
            DataSet dt = CapaDatos.ConfiguracionDatos.CrearDataSet(comando);
            return dt;
        }

        public DataSet ListarVentas()
        {
            var comando = CapaDatos.ConfiguracionDatos.CrearComando();
            comando.CommandText = "SELECT * FROM VENTA";
            DataSet dt = CapaDatos.ConfiguracionDatos.CrearDataSet(comando);
            return dt;
        }

        [WebMethod]
        public DataSet ProductoXtienda(int idTienda)
        {
            var comando = ConfiguracionDatos.CrearComando();
            comando.CommandText = "SELECT * FROM PRODUCTO_TIENDA WHERE IdTienda = '" + idTienda + "'";
            DataSet dt = ConfiguracionDatos.CrearDataSet(comando);
            return dt;
        }
    }
}
