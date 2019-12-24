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
    public partial class FrmUsuario : Form
    {
        string EmailAnte;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NUsuario.Listar();
                this.Formato();
                this.Limpiar();
                LblTotal.Text = "Total de registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NUsuario.Buscar(TxtBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total de registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[2].Visible = false;
            DgvListado.Columns[1].Width = 50;
            DgvListado.Columns[3].Width = 100;
            DgvListado.Columns[4].Width = 170;
            DgvListado.Columns[5].Width = 100;
            DgvListado.Columns[5].HeaderText = "Documentos";
            DgvListado.Columns[6].Width = 100;
            DgvListado.Columns[6].HeaderText = "Núm Docs";
            DgvListado.Columns[7].Width = 120;
            DgvListado.Columns[7].HeaderText = "Dirección";
            DgvListado.Columns[8].Width = 100;
            DgvListado.Columns[8].HeaderText = "Teléfono";
            DgvListado.Columns[9].Width = 120;
        }

        private void Limpiar()
        {
            TxtNombre.Clear();
            TxtBuscar.Clear();
            TxtId.Clear();
            TxtNombre.Clear();
            TxtNumDoc.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            TxtClave.Clear();
            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false;
            ErrorIcono.Clear();

            DgvListado.Columns[0].Visible = false;
            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
            BtnEliminar.Visible = false;
            ChkSeleccionar.Checked = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarRol()
        {
            try
            {
                CboRol.DataSource = NRol.Listar();
                CboRol.ValueMember = "idrol";
                CboRol.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarRol();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (CboRol.Text == String.Empty || TxtNombre.Text == string.Empty || TxtEmail.Text == string.Empty || TxtClave.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar unos datos");
                    ErrorIcono.SetError(CboRol, "Tienes que elegir un rol");
                    ErrorIcono.SetError(TxtNombre, "Ingresa un nombre");
                    ErrorIcono.SetError(TxtEmail, "Ingresa un email");
                    ErrorIcono.SetError(CboRol, "Ingresa una clave");
                }
                else
                {
                    Rpta = NUsuario.Insertar(Convert.ToInt32(CboRol.SelectedValue), TxtNombre.Text.Trim(),CboTipoDoc.Text,TxtNumDoc.Text.Trim(),TxtDireccion.Text.Trim(), TxtTelefono.Text.Trim(),TxtEmail.Text.Trim(), TxtClave.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se insertaron los datos de manera correcta");
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.Listar();
            TabGeneral.SelectedIndex = 0;
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnActualizar.Visible = true;
                BtnInsertar.Visible = false;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                CboRol.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["idrol"].Value);
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                CboTipoDoc.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Tipo_Documento"].Value);
                TxtNumDoc.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Num_Documento"].Value);
                TxtDireccion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Direccion"].Value);
                TxtTelefono.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Telefono"].Value);
                this.EmailAnte = Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                TxtEmail.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione desde el nombre");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtId.Text ==string.Empty || CboRol.Text == String.Empty || TxtNombre.Text == string.Empty || TxtEmail.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar unos datos");
                    ErrorIcono.SetError(CboRol, "Tienes que elegir un rol");
                    ErrorIcono.SetError(TxtNombre, "Ingresa un nombre");
                    ErrorIcono.SetError(TxtEmail, "Ingresa un email");
                    ErrorIcono.SetError(CboRol, "Ingresa una clave");
                }
                else
                {
                    Rpta = NUsuario.Actualizar(Convert.ToInt32(TxtId.Text),Convert.ToInt32(CboRol.SelectedValue), TxtNombre.Text.Trim(), CboTipoDoc.Text, TxtNumDoc.Text.Trim(), TxtDireccion.Text.Trim(), TxtTelefono.Text.Trim(),this.EmailAnte, TxtEmail.Text.Trim(),TxtClave.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se insertaron los datos de manera correcta");
                        this.Limpiar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                BtnActivar.Visible = true;
                BtnDesactivar.Visible = true;
                BtnEliminar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = false;
                BtnEliminar.Visible = false;
            }
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar el registro", "Sistema de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NUsuario.Eliminar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se eliminó el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }

                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas activar el registro", "Sistema de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NUsuario.Activar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se activó el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }

                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas desactivar el registro", "Sistema de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NUsuario.Desactivar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se desactivó el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }

                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
