using System;
using System.Data;

namespace AccesoDatos.Orm
{
    public class Maestro
    {
        #region Atributos

        public string   CODIGO_CONTRATO { get; set; }
        public string   ID_AUTOR            { get; set; }
        public string   TITULO_OBRA         { get; set; }
        public int      ID_PRODUCTO         { get; set; }
        public int      NRO_EJEMPLARES_CONT { get; set; }
        public int      NRO_IMPRESIONES     { get; set; }
        public float    VALOR_CONTRATO      { get; set; }
        public string   ID_MONEDA           { get; set; }
        public DateTime FECHA_ENTREGA_TEXTOS    { get; set; }
        public string   OBSERVACION             { get; set; }
        public string   FIRMA_TEXTOS            { get; set; }
        public string   PAGO_ADELANTADO         { get; set; }
        public DateTime FECHA_PAGO              { get; set; }
        public float    VALOR_PAGO              { get; set; }
        public string   ERRORES                 { get; set; }
        public int      ID_NUMERO               { get; set; }
        public string   ID_CLIENTE              { get; set; }
        #endregion

        #region Metodos

        public DataTable Buscar(string IdVendedor, string Codempresa,int cantidad)
        { return Conexion.GDatos.TraerDataTable("paKardexVendedores", 267, '0',1); }

        public void CrearContratos(Maestro maestro)
        { Conexion.GDatos.Ejecutar("paInsContratoAutores", 
            maestro.CODIGO_CONTRATO, maestro.TITULO_OBRA,
            maestro.ID_PRODUCTO, maestro.NRO_EJEMPLARES_CONT, maestro.NRO_IMPRESIONES,
            maestro.VALOR_CONTRATO, maestro.ID_MONEDA, maestro.FECHA_ENTREGA_TEXTOS,
            maestro.OBSERVACION, maestro.FIRMA_TEXTOS, maestro.PAGO_ADELANTADO, maestro.FECHA_PAGO, 
            maestro.VALOR_PAGO, maestro.ERRORES);
        }

        public void DeleteContratos(Maestro maestro)
        {
            Conexion.GDatos.Ejecutar("paDelContratoAutores",
              maestro.CODIGO_CONTRATO, maestro.ERRORES);
        }
        public void UpdateContratos(Maestro maestro)
        {
            Conexion.GDatos.Ejecutar("paUpdContratoAutores",
              maestro.CODIGO_CONTRATO, maestro.TITULO_OBRA,
              maestro.ID_PRODUCTO, maestro.NRO_EJEMPLARES_CONT, maestro.NRO_IMPRESIONES,
              maestro.VALOR_CONTRATO, maestro.ID_MONEDA, maestro.FECHA_ENTREGA_TEXTOS,
              maestro.OBSERVACION, maestro.FIRMA_TEXTOS, maestro.PAGO_ADELANTADO, maestro.FECHA_PAGO, maestro.VALOR_PAGO, maestro.ERRORES);
        }


        public void LeerDatoContrato(Maestro maestro)
        {
            Conexion.GDatos.Ejecutar("paGetContratoAutores",
            maestro.CODIGO_CONTRATO, maestro.TITULO_OBRA,
            maestro.ID_PRODUCTO, maestro.NRO_EJEMPLARES_CONT, maestro.NRO_IMPRESIONES,
            maestro.VALOR_CONTRATO, maestro.ID_MONEDA, maestro.FECHA_ENTREGA_TEXTOS,
            maestro.OBSERVACION, maestro.FIRMA_TEXTOS, maestro.PAGO_ADELANTADO, maestro.FECHA_PAGO, maestro.VALOR_PAGO, maestro.ERRORES); 
        }

        public DataTable LeerContratos()
        {
            return Conexion.GDatos.TraerDataTable("paContratoAutores");
        }
        public DataTable LeeAutores(Maestro maestro)
        {
            return Conexion.GDatos.TraerDataTable("pagetAutores", maestro.CODIGO_CONTRATO);
        }
        public DataTable LeeProductos(Maestro maestro)
        {
            return Conexion.GDatos.TraerDataTable("paGetProdContratos", maestro.CODIGO_CONTRATO);
        }
        public DataTable LeeIngresos(Maestro maestro)
        {
            return Conexion.GDatos.TraerDataTable("paGetIngresos", maestro.CODIGO_CONTRATO, maestro.ERRORES);
        }
        public DataTable LeeIngresosTotales(Maestro maestro)
        {
            return Conexion.GDatos.TraerDataTable("paGetIngresosTotales", maestro.ID_PRODUCTO, maestro.ERRORES);
        }

        public DataTable LeeProductosPorContrato(Maestro maestro)
        {
            return Conexion.GDatos.TraerDataTable("paGetProductosPorContrato", maestro.CODIGO_CONTRATO, maestro.ERRORES);
        }

        public DataTable LeeProductosContrato()
        {
            return Conexion.GDatos.TraerDataTable("paGetProductosContrato");
        }

        public void InsProductosPorContrato(Maestro maestro)
        {
            Conexion.GDatos.Ejecutar("paInsProductosPorContrato", maestro.CODIGO_CONTRATO, maestro.ID_PRODUCTO, maestro.ID_NUMERO, maestro.ERRORES);
        }

        public DataTable LeeAutoresPorContrato(Maestro maestro)
        {
            return Conexion.GDatos.TraerDataTable("paGetAutoresPorContrato", maestro.CODIGO_CONTRATO, maestro.ERRORES);
        }
        public void InsAutoresPorContrato(Maestro maestro)
        {
            Conexion.GDatos.Ejecutar("paInsAutoresPorContrato", maestro.CODIGO_CONTRATO, maestro.ID_AUTOR, maestro.ID_NUMERO, maestro.ERRORES);
        }
        public void ExisteCheckProd(ref Maestro maestro)
        {
            Conexion.GDatos.TraerValorOutput("paExisteCheckProd", maestro.CODIGO_CONTRATO, maestro.ID_PRODUCTO, maestro.ID_NUMERO, maestro.ERRORES);
        }

        public DataTable LeeAutoresClientes(Maestro maestro)
        {
            return Conexion.GDatos.TraerDataTable("paAutoresClientes", maestro.CODIGO_CONTRATO, maestro.ERRORES);
        }

        public DataTable LeeClientesAutores(Maestro maestro)
        {
            return Conexion.GDatos.TraerDataTable("paGetClientesAutores", maestro.ERRORES);
        }

        public void UpdateClientesAutores(Maestro maestro)
        {
            Conexion.GDatos.Ejecutar("paUpdateAutoresClientes", maestro.CODIGO_CONTRATO, maestro.ID_AUTOR, maestro.ID_CLIENTE, maestro.ERRORES);
        }

        public DataTable getSalidasResumen(Maestro maestro)
        {
            return Conexion.GDatos.TraerDataTable("paResEntregadoAutores", maestro.CODIGO_CONTRATO, maestro.ERRORES);
        }

        public DataTable getSalidasDetalle(Maestro maestro)
        {
            return Conexion.GDatos.TraerDataTable("paDetEntregadoAutores", maestro.CODIGO_CONTRATO, maestro.ID_PRODUCTO, maestro.ID_CLIENTE, maestro.ERRORES);
        }
        
        #endregion

    }
}
