using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void BtnLoginCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAccesar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = NUsuario.Login(TxtEmail.Text.Trim(), TxtClave.Text.Trim());
                if (Tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El email o la clave es incorrecta","Acceso al sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToBoolean(Tabla.Rows[0][4])==false)
                    {
                        MessageBox.Show("Este usuario no está activo", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FMRPrincipal frm = new FMRPrincipal();
                        Variables.IdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);  //Se pasa la variable del usuario logueado
                        frm.IdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);
                        frm.IdRol = Convert.ToInt32(Tabla.Rows[0][1]);
                        frm.Rol = Convert.ToString(Tabla.Rows[0][2]);
                        frm.Nombre = Convert.ToString(Tabla.Rows[0][3]);
                        frm.Estado = Convert.ToBoolean(Tabla.Rows[0][4]);
                        frm.Show();
                        this.Hide();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
