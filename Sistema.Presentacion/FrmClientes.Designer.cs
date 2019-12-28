namespace Sistema.Presentacion
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CboTipoDoc = new System.Windows.Forms.ComboBox();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtNumDoc = new System.Windows.Forms.TextBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.TabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboTipoDoc
            // 
            this.CboTipoDoc.FormattingEnabled = true;
            this.CboTipoDoc.Items.AddRange(new object[] {
            "CURP",
            "CEDULA",
            "PASAPORTE",
            "INE"});
            this.CboTipoDoc.Location = new System.Drawing.Point(150, 126);
            this.CboTipoDoc.Name = "CboTipoDoc";
            this.CboTipoDoc.Size = new System.Drawing.Size(192, 21);
            this.CboTipoDoc.TabIndex = 12;
            this.CboTipoDoc.Text = "CURP";
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // TxtNumDoc
            // 
            this.TxtNumDoc.Location = new System.Drawing.Point(150, 166);
            this.TxtNumDoc.Name = "TxtNumDoc";
            this.TxtNumDoc.Size = new System.Drawing.Size(191, 20);
            this.TxtNumDoc.TabIndex = 13;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(47, 361);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(90, 23);
            this.BtnActualizar.TabIndex = 7;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(263, 361);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 23);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(157, 361);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(90, 23);
            this.BtnInsertar.TabIndex = 5;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(241, 34);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 4;
            this.TxtId.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(150, 81);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(192, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Doc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre (*)";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnEliminar);
            this.tabPage1.Controls.Add(this.ChkSeleccionar);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.TxtBuscar);
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(889, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(285, 361);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(145, 30);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(9, 369);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.ChkSeleccionar.TabIndex = 4;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            this.ChkSeleccionar.CheckedChanged += new System.EventHandler(this.ChkSeleccionar_CheckedChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(424, 17);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(89, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(9, 20);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(399, 20);
            this.TxtBuscar.TabIndex = 2;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(645, 373);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(34, 13);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "Total:";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(8, 51);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(849, 299);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(150, 267);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(191, 20);
            this.TxtTelefono.TabIndex = 15;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(150, 214);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(191, 20);
            this.TxtDireccion.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TxtEmail);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Direccion);
            this.tabPage2.Controls.Add(this.TxtTelefono);
            this.tabPage2.Controls.Add(this.TxtDireccion);
            this.tabPage2.Controls.Add(this.TxtNumDoc);
            this.tabPage2.Controls.Add(this.CboTipoDoc);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.BtnActualizar);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnInsertar);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.TxtNombre);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(889, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefono";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(149, 304);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(192, 20);
            this.TxtEmail.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email(*)";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(61, 221);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(52, 13);
            this.Direccion.TabIndex = 17;
            this.Direccion.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo Doc";
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Location = new System.Drawing.Point(0, 0);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(897, 453);
            this.TabGeneral.TabIndex = 3;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 465);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.TabGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboTipoDoc;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtNumDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}