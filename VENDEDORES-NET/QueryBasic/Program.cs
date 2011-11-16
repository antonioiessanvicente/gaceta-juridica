using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QueryBasic
{
    public class Conection
    {
        public static string conectionstring;
        public static string error_coneccion = "NO SE HA PODIDO CONECTAR CON EL SERVIDOR DE BASE DA DATOS, VERIFIQUE O SOLICITE AYUDA AL AREA DE INFORMATICA";
    }
    public class Tiempo
    {
        public static Timer tiempo;
    }
    public class ActualUser
    {
        public static string usuario;
        public static string id_vendedor;
        public static string email;
        public static string cod_empresa;
        public static string tipo_kardex;
        public static string Supervisor;
        public static string tipo_usuario;
    }
    public class ClienteActual
    {
        public static string Id_cliente;
        public static string Nombre_cliente;
        public static int Id_Suscripcion;
        public static string nro_contrato;
        public static int cantidad;
        public static float valor_suscripcion;
        public static int ID_PRODUCTO;
        public static string clave_doc;
        public static string Nombre_Suscripcion;
        public static string Direccion_Cliente;
        public static string Email_Cliente;
        public static string Vendedor_Supervisor;
    }
    public class EjecutivoActual
    {
        public static string nombre;
        public static string email;
        public static string clave;
        public static string id_vendedor;
    }
    public class formsactivos
    {
        public static Boolean clientes = false;
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// ///Provider=SQLNCLI10;Server=myServerAddress;Database=myDataBase;Uid=myUsername; Pwd=myPassword;
        /// 
        [STAThread]
        static void Main()
        {
            try
            {
                Conection.conectionstring = "Data Source=192.168.0.6;Initial Catalog=comercial;Integrated Security=False;User Id=acceso_vendedores;Password=navidad-2010;Connect Timeout=100";
//                Conection.conectionstring = "Data Source=192.168.1.33;Initial Catalog=juliaca;Integrated Security=true;";
//                Conection.conectionstring = "Data Source=192.168.1.33;Initial Catalog=juliaca;Integrated Security=true;";
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " ::: " + Conection.conectionstring);
            }
        }
    }
}
