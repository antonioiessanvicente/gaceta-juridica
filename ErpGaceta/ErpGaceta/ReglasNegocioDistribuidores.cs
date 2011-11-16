using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using AccesoDatos;

namespace ErpGaceta
{
    class ReglasNegocioDistribuidores
    {
        public class MaestroDistribuidores
        {
            #region Atributos
            public double NUMERO { get; set; }
            public DateTime FECHA { get; set; }
            public string DESCRIPCION { get; set; }
            public string SITUACION { get; set; }
            public string ERRORES { get; set; }
            public string FECHA_INI { get; set; }
            public string FECHA_FIN { get; set; }
            public string TIPO_DIST { get; set; }
            public string COD_EMPRESA { get; set; }
            public string ID_CLIENTE { get; set; }
            public DateTime FECHA_ENVIO { get; set; }
            public DateTime HORA_ENVIO { get; set; }
            public string DESTINO { get; set; }
            public string NRO_DOC { get; set; }
            public string OTRO_DATO { get; set; }
            public int NRO_CAJAS { get; set; }
            public int NRO_SOBRES { get; set; }
            public byte[] NOMBRE_ARCHIVO { get; set; }
            public string TIPO_ARCHIVO { get; set; }
            public string TIPO_ACCION { get; set; }
            public string TIPO_PROCESO { get; set; }
            public string STR_FECHA_INI { get; set; }
            public string STR_FECHA_FIN { get; set; }
            public string CLAVE { get; set; }
            public string COD_DOC { get; set; }
            public string NRO_SERIE { get; set; }
            public string NUMERO_DOC { get; set; }
            public string OBSERVACION_OK { get; set; }
            public string AGENCIA { get; set; }
            public double IMPORTE { get; set; }
            #endregion
            #region Metodos


            public void CrearRegDistribuidores(MaestroDistribuidores maestro)
            {
                Conexion.GDatos.Ejecutar("paInsRegDist", maestro.NUMERO, maestro.DESCRIPCION, maestro.FECHA_INI, maestro.FECHA_FIN, maestro.COD_EMPRESA, maestro.ERRORES);
            }
            public void CrearRegDistribImagenes(MaestroDistribuidores maestro)
            {
                Conexion.GDatos.Ejecutar("saveImgenFile", maestro.NUMERO, maestro.ID_CLIENTE, maestro.FECHA_ENVIO, maestro.HORA_ENVIO,
                    maestro.DESTINO, maestro.NRO_DOC, maestro.OTRO_DATO, maestro.NRO_CAJAS, maestro.NRO_SOBRES, maestro.NOMBRE_ARCHIVO,
                    maestro.TIPO_ARCHIVO, maestro.TIPO_ACCION, maestro.ERRORES, maestro.AGENCIA, maestro.IMPORTE);
            }
            public void SaveObservacionOK(MaestroDistribuidores maestro)
            {
                Conexion.GDatos.Ejecutar("saveObservacionOK", maestro.NUMERO, maestro.ID_CLIENTE, maestro.OBSERVACION_OK, maestro.TIPO_ACCION, maestro.ERRORES);
            }
            public IDataReader OpenDistribImagenes(MaestroDistribuidores maestro)
            {
                return Conexion.GDatos.TraerDataReader("OpenDataImgenFile", maestro.NUMERO, maestro.ID_CLIENTE, maestro.ERRORES);
            }
            public void BorrarRegDistribuidores(MaestroDistribuidores maestro)
            {
                Conexion.GDatos.Ejecutar("paDelRegDist", maestro.NUMERO, maestro.ERRORES);
            }
            public void ActualizarRegDistribuidores(MaestroDistribuidores maestro)
            {
                Conexion.GDatos.Ejecutar("paUpdRegDist", maestro.NUMERO, maestro.DESCRIPCION, maestro.ERRORES);
            }
            public void LeerRegDistribuidores(ref MaestroDistribuidores maestro)
            {
                Conexion.GDatos.Ejecutar("paGetRegDist", maestro.NUMERO, maestro.FECHA, maestro.DESCRIPCION, maestro.SITUACION, maestro.ERRORES);
            }
            public DataTable LeedatosRegDistribuidoresCab(MaestroDistribuidores maestro)
            {
                return Conexion.GDatos.TraerDataTable("paLeeRegDistCab", maestro.COD_EMPRESA, maestro.TIPO_PROCESO);
            }
            public DataTable LeedatosRegDistribuidoresDet(MaestroDistribuidores maestro)
            {
                return Conexion.GDatos.TraerDataTable("paLeeRegDistDist", maestro.NUMERO, maestro.ERRORES);
            }

            public DataTable ObtieneDataDistribuidores(MaestroDistribuidores maestro)
            {
                return Conexion.GDatos.TraerDataTable("paObtieneDataDistribuidores", maestro.FECHA_INI, maestro.FECHA_FIN, maestro.TIPO_DIST, maestro.COD_EMPRESA);
            }
            public DataTable ObtieneDataDistribuidores_01(MaestroDistribuidores maestro)
            {
                return Conexion.GDatos.TraerDataTable("paObtieneDataDistribuidores_01", maestro.NUMERO);
            }
            public DataTable ObtieneDataDistribuidores_02(MaestroDistribuidores maestro)
            {
                return Conexion.GDatos.TraerDataTable("paObtieneDataDistribuidores_02", maestro.COD_EMPRESA, maestro.STR_FECHA_INI, maestro.STR_FECHA_FIN, maestro.TIPO_DIST); 
            }
            public DataTable ObtieneMuestraDataImgenFile(MaestroDistribuidores maestro)
            {
                return Conexion.GDatos.TraerDataTable("MuestraDataImgenFile", maestro.NUMERO);
            }
            public IDataReader OpenDataDocumentos_Cab(MaestroDistribuidores maestro)
            {
                return Conexion.GDatos.TraerDataReader("paOpenDataDocumentos_Cab", maestro.CLAVE);
            }
            public DataTable OpenDataDocumentos_Det(MaestroDistribuidores maestro)
            {
                return Conexion.GDatos.TraerDataTable("paOpenDataDocumentos_Det", maestro.CLAVE);
            }
            public DataTable OpenDetallePagos(MaestroDistribuidores maestro)
            {
                return Conexion.GDatos.TraerDataTable("paDetallePagos", maestro.CLAVE);
            }
            public DataTable OpenDataSeries(MaestroDistribuidores maestro)
            {
                return Conexion.GDatos.TraerDataTable("paNroSeries", maestro.COD_DOC, maestro.COD_EMPRESA);
            }
            public DataTable GetNroDocumentos(MaestroDistribuidores maestro)
            {
                return Conexion.GDatos.TraerDataTable("paNroDocs", maestro.COD_DOC, maestro.NRO_SERIE);
            }
            public IDataReader OpenGetdataCabecera(MaestroDistribuidores maestro)
            {
                return Conexion.GDatos.TraerDataReader("paGetdataCabecera", maestro.COD_DOC, maestro.NRO_SERIE, maestro.NUMERO_DOC);
            }
            ///<summary>
            ///FechaToSql
            ///</summary>
            ///<remarks>
            ///Funcion que recibe convierte la fecha en formato de texto 'YYYYMMDD'
            ///Fecha      : 17-Jun-2011
            ///Autor(es)  : Grupo de desarrollo de Gaceta Jurídica (Marco Mendoza)
            ///Copyright (c) Gaceta Jurídica S.A.
            ///</remarks>
            public string FechaToSql(DateTime valor)
            {
                int longitud_00;
                int longitud_01;
                int longitud_02;
                string _day = "00" + valor.Day.ToString();
                string _month = "00" + valor.Month.ToString();
                string _year = "0000" + valor.Year.ToString();
                longitud_00 = _year.Length;
                longitud_01 = _month.Length;
                longitud_02 = _day.Length;
                return (_year.Substring(longitud_00 - 4, 4) + _month.Substring(longitud_01 - 2, 2) + _day.Substring(longitud_02 - 2, 2));
            }
            public string Left(string text, int length)
            {
                return text.Substring(0, length);
            }

            public string Right(string text, int length)
            {
                return text.Substring(text.Length - length, length);
            }

            public string Mid(string text, int start, int end)
            {
                return text.Substring(start, end);
            }

            public string Mid(string text, int start)
            {
                return text.Substring(start, text.Length - start);
            }

            #endregion
        }
        public class ClassCobranzas
        {
            #region Atributos
            public DateTime FECHA_INI { get; set; }
            public DateTime FECHA_FIN { get; set; }
            public string COD_EMPRESA { get; set; }
            public int TIPO { get; set; }
            public string PARAMETRO { get; set; }
            public string ID_FAMILIA { get; set; }
            #endregion
            #region Medodos
            public DataTable ObtieneDataCobranzas(ClassCobranzas MaestroCobranzas)
            {
                return Conexion.GDatos.TraerDataTable("paAnalisCobranzas", MaestroCobranzas.FECHA_INI, MaestroCobranzas.FECHA_FIN, 
                    MaestroCobranzas.COD_EMPRESA, MaestroCobranzas.TIPO, MaestroCobranzas.PARAMETRO, MaestroCobranzas.ID_FAMILIA);
            }
            
            #endregion
        }
        public class LeftRightMid
        {
            public static string Left(string param, int length)
            {
                string result = param.Substring(0, length);
                return result;
            }
            public static string Right(string param, int length)
            {
                int value = param.Length - length;
                string result = param.Substring(value, length);
                return result;
            }
            public String FechaToTextSQL(DateTime Fecha)
            {
                String strD = LeftRightMid.Right("0" + Fecha.Day.ToString(), 2);
                String strM = LeftRightMid.Right("0" + Fecha.Month.ToString(), 2);
                String strY = Fecha.Year.ToString();
                return (strY + strM + strD);
            }
            public static bool IsNumeric(object Expression)
            {
                bool isNum;
                double retNum;

                isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
                return isNum;
            }
        }
        public class ClassGenericos
        {
            #region Atributos
            public string COD_EMPRESA { get; set; }
            #endregion
            #region Medodos
            public DataTable ObtieneFamilias(ClassGenericos MaestroGenerico)
            {
                return Conexion.GDatos.TraerDataTable("paFamilias", MaestroGenerico.COD_EMPRESA);
            }
            #endregion

        }
    }
}

