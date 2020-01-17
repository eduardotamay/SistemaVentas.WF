using System;
using System.Data;

namespace Sistema.Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public string Tipo_Comprobante { get; set; }
        public string Serie_Comprobante { get; set; }
        public string Num_Comprobante { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
        public DataTable Detalles {get; set;}
    }
}
