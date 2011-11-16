using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace frmContratos
{
    public class ContratoActual
    {
        public static string CODIGO_CONTRATO;
        public static string ID_AUTOR;
        public static string NOMBRE_AUTOR;
        public static string TITULO_OBRA;
        public static int ID_PRODUCTO;
        public static int NRO_EJEMPLARES_CONT;
        public static int NRO_IMPRESIONES;
        public static float VALOR_CONTRATO;
        public static string ID_MONEDA;
        public static DateTime FECHA_ENTREGA_TEXTOS;
        public static string OBSERVACION;
        public static string FIRMA_TEXTOS;
        public static string PAGO_ADELANTADO;
        public static DateTime FECHA_PAGO;
        public static float VALOR_PAGO;
        public static string ACTION;
        public static string ID_CLIENTE;
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmContratos());
        }
    }
}
