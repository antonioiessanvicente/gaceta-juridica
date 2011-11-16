using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using System.Data;
namespace AccesosCds
{
    class ReglasNegocio
    {

        public class MaestroActivacionCds
        {
            #region Atributos
            public string NRO_PIN { get; set; }
            public int CODIGO_PROD { get; set; }
            public int CANTIDAD { get; set; }
            #endregion
            #region Metodos


            public IDataReader LeerDatos(MaestroActivacionCds maestro)
            {
                return Conexion.GDatos.TraerDataReader("paVerNroActivaciones", maestro.CODIGO_PROD, maestro.NRO_PIN);
            }
            public void Descontar(MaestroActivacionCds maestro)
            {
                Conexion.GDatos.Ejecutar("paDescontarActivaciones", maestro.CODIGO_PROD, maestro.NRO_PIN, maestro.CANTIDAD);
            }
            public DataTable MostrarProductos()
            {
                return Conexion.GDatos.TraerDataTable("OpenProductos");
            }

            #endregion
        }
    }
}
