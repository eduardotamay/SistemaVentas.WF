using System;
using Sistema.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class DVenta
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConnexion();
                SqlCommand comando = new SqlCommand("venta_listar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

        }
        public DataTable Buscar(String Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConnexion();
                SqlCommand comando = new SqlCommand("venta_buscar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                sqlCon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        public DataTable ListarDetalle(int Id)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConnexion();
                SqlCommand comando = new SqlCommand("venta_listar_detalle", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Id;
                sqlCon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }
        public string Insertar(Venta Obj)
        {
            string Rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConnexion();
                SqlCommand comando = new SqlCommand("venta_insertar", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idcliente", SqlDbType.Int).Value = Obj.IdCliente;
                //comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Obj.IdVenta;
                comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Obj.IdUsuario;
                comando.Parameters.Add("@tipo_comprobante",SqlDbType.VarChar).Value = Obj.Tipo_Comprobante;
                comando.Parameters.Add("@serie_comprobante",SqlDbType.VarChar).Value = Obj.Serie_Comprobante;
                comando.Parameters.Add("@num_comprobante", SqlDbType.VarChar).Value = Obj.Num_Comprobante;
                comando.Parameters.Add("@impuesto", SqlDbType.Decimal).Value = Obj.Impuesto;
                comando.Parameters.Add("@total", SqlDbType.Decimal).Value = Obj.Total;
                comando.Parameters.Add("@detalle", SqlDbType.Structured).Value = Obj.Detalles;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                Rpta =  "OK" ;
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return Rpta;
        }
        public string Anular(int Id)
        {
            string Rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConnexion();
                SqlCommand comando = new SqlCommand("venta_anular", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Id;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                Rpta =  "OK";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return Rpta;
        }
    }
}
//capa 3 datos