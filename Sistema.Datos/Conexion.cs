using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        public Conexion()
        {
            this.Base = "dbsistema";
            this.Servidor = "CPU256";
            this.Usuario = "tamaycj";
            this.Clave = "";
            this.Seguridad = true;
        }
        public SqlConnection CrearConnexion()
        {
            SqlConnection cadena = new SqlConnection();

            try
            {
                cadena.ConnectionString = "Server= " + this.Servidor + "; Database= " + this.Base + ";";
                if (this.Seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Trusted_Connection=SSPI";
                }
                else{
                    cadena.ConnectionString = cadena.ConnectionString + "User Id =" + this.Usuario + "Password = " + this.Clave;
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    } 
}
