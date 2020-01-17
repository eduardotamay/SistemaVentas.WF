using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NVenta
    {
        public static DataTable Listar()
        {
            DVenta Datos = new DVenta();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DVenta Datos = new DVenta();
            return Datos.Buscar(Valor);
        }
        public static DataTable ListarDetalle(int Id)
        {
            DVenta Datos = new DVenta();
            return Datos.ListarDetalle(Id);
        }
        public static string Insertar(int IdCliente, int IdUsuario, string TipoComprobante, string SerieComprobante, string NumComprobante, decimal Impuesto, decimal Total, DataTable Detalles)
        {
                DVenta Datos = new DVenta();
                Venta  Obj = new Venta();
                Obj.IdCliente = IdCliente;
                Obj.IdUsuario = IdUsuario;
                Obj.Tipo_Comprobante = TipoComprobante;
                Obj.Serie_Comprobante = SerieComprobante;
                Obj.Num_Comprobante = NumComprobante;
                Obj.Impuesto = Impuesto;
                Obj.Total = Total;
                Obj.Detalles = Detalles;
                return Datos.Insertar(Obj);
            
        }
        public static string Anular(int Id)
        {
            DVenta Datos = new DVenta();
            return Datos.Anular(Id);
        }
    }
}
