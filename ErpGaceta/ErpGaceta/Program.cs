using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ErpGaceta
{
    public class Principal
    {
        public static string Server;
        public static string DataBase;
        public static string Descripcion;
        public static DateTime fechaIni;
        public static DateTime fechaFin;
        public static Double Numero;
        public static string strCodEmpresa;
        public static string strTipoDist;
        public static string IdCliente;
        public static string Action;
        public static string TipoProceso;
        public static string CLAVE;
        public static string TIPO_DOCUMENTO;
        public static int intVentanas;
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }

    }
}
