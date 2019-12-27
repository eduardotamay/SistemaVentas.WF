using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Datos;
using System.Data.SqlClient;
using System.Data;
using Sistema.Entidades;


namespace Sistema.Negocio
{
    public class NPersona
    {
        public static DataTable Listar()
        {
            DPersona Datos = new DPersona();
            return Datos.Listar();
        }
        public static DataTable ListarProveedor()
        {
            DPersona Datos = new DPersona();
            return Datos.ListarProveedor();
        }
        public static DataTable ListarCliente()
        {
            DPersona Datos = new DPersona();
            return Datos.ListarCliente();
        }
        public static DataTable Buscar(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.Buscar(Valor);
        }
        public static DataTable BuscarProveedor(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarProveedor(Valor);
        }
        public static DataTable BuscarCliente(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarCliente(Valor);
        }

        public static string Insertar(string Tipo_Persona, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string Email)
        {
            DPersona Datos = new DPersona();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "El usuario con ese nombre ya existe";
            }
            else
            {
                Persona Obj = new Persona();
                Obj.TipoPersona = Tipo_Persona;
                Obj.Nombre = Nombre;
                Obj.TipoDocumento = TipoDocumento;
                Obj.NumeroDocumento = NumDocumento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int ID, string Tipo_Persona, string NombreAnte, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string Email)
        {
            DPersona Datos = new DPersona();
            Persona Obj = new Persona();
            if (NombreAnte.Equals(Nombre))
            {
                Obj.IdPersona = ID;
                Obj.TipoPersona = Tipo_Persona;
                Obj.Nombre = Nombre;
                Obj.TipoDocumento = TipoDocumento;
                Obj.NumeroDocumento = NumDocumento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Email);
                if (Existe.Equals("1"))
                {
                    return "El usuario con ese nombre ya existe";
                }
                else
                {
                    Obj.IdPersona = ID;
                    Obj.TipoPersona = Tipo_Persona;
                    Obj.Nombre = Nombre;
                    Obj.TipoDocumento = TipoDocumento;
                    Obj.NumeroDocumento = NumDocumento;
                    Obj.Direccion = Direccion;
                    Obj.Telefono = Telefono;
                    Obj.Email = Email;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Eliminar(int Id)
        {
            DPersona Datos = new DPersona();
            return Datos.Eliminar(Id);
        }
    }
}
