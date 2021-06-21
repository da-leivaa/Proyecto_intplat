using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SistemaVentas
{
    public partial class rptProductoTienda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ObtenerProductoXTienda();
        }

        protected void ObtenerProductoXTienda()
        {
            var codigoLibro = int.Parse(txt.Text);

            using (ws_instrument.WebService_instrumentosSoapClient instrumentos = new ws_instrument.WebService_instrumentosSoapClient())
            {
                
                DataSet ds = instrumentos.ProductoXtienda(idtienda, codigoproducto);

                tbReporte.DataSource = ds;
                tbReporte.DataBind();

            }


            //DataTable dt = CD_Reportes.Instancia.ReporteProductoTienda(idtienda, codigoproducto);

            //System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            //List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            //Dictionary<string, object> row;
            //foreach (DataRow dr in dt.Rows)
            //{
            //    row = new Dictionary<string, object>();
            //    foreach (DataColumn col in dt.Columns)
            //    {
            //        row.Add(col.ColumnName, dr[col]);
            //    }
            //    rows.Add(row);
            //}
            //return new Respuesta<string>() { estado = true , objeto = serializer.Serialize(rows) };
            
        }
    }
}