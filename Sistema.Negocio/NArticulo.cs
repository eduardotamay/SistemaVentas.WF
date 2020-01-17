using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Entidades;
using Sistema.Datos;

namespace Sistema.Negocio
{
    public class NArticulo
    {
        
        public static DataTable Listar()
        {
            DArticulo Datos = new DArticulo();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Buscar(Valor);
        }
        public static DataTable BuscarVenta(string Valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.BuscarVenta(Valor);
        }
        public static DataTable BuscarCodigo(string Valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.BuscarCodigo(Valor);
        }
        public static DataTable BuscarCodigoVenta(string Valor)
        {
            DArticulo Datos = new DArticulo();
            return Datos.BuscarCodigoVenta(Valor);
        }
        public static string Insertar(int IdCategoria, string Codigo, string Nombre, decimal PrecioVenta, int Stock, string Descripcion, string Imagen)
        {
            DArticulo Datos = new DArticulo();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "El articulo ya existe";
            }
            else
            {
                Articulo Obj = new Articulo();
                Obj.IdCategoria = IdCategoria;
                Obj.Codigo = Codigo;
                Obj.Nombre = Nombre;
                Obj.PrecioVenta = PrecioVenta;
                Obj.Stock = Stock;
                Obj.Descripcion = Descripcion;
                Obj.Imagen = Imagen;
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int Id, int IdCategoria, string Codigo, string NombreAnt, string Nombre, decimal PrecioVenta, int Stock, string Descripcion, string Imagen)
        {
            DArticulo Datos = new DArticulo();
            Articulo Obj = new Articulo();
            if (NombreAnt.Equals(Nombre))
            {
                Obj.IdArticulo = Id;
                Obj.IdCategoria = IdCategoria;
                Obj.Codigo = Codigo;
                Obj.Nombre = Nombre;
                Obj.PrecioVenta = PrecioVenta;
                Obj.Stock = Stock;
                Obj.Descripcion = Descripcion;
                Obj.Imagen = Imagen;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return "La categoria ya existe";
                }
                else
                {
                    Obj.IdArticulo = Id;
                    Obj.IdCategoria = IdCategoria;
                    Obj.Codigo = Codigo;
                    Obj.Nombre = Nombre;
                    Obj.PrecioVenta = PrecioVenta;
                    Obj.Stock = Stock;
                    Obj.Descripcion = Descripcion;
                    Obj.Imagen = Imagen;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Eliminar(int Id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Eliminar(Id);
        }
        public static string Activar(int Id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Activar(Id);
        }
        public static string Desactivar(int Id)
        {
            DArticulo Datos = new DArticulo();
            return Datos.Desactivar(Id);
        }
    }
}
