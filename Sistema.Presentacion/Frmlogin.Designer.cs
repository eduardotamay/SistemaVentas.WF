namespace Sistema.Presentacion
{
    partial class Frmlogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAccesar = new System.Windows.Forms.Button();
            this.BtnLoginCancelar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(86, 70);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(184, 20);
            this.TxtEmail.TabIndex = 2;
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(85, 114);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(184, 20);
            this.TxtClave.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema.Presentacion.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(288, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAccesar
            // 
            this.BtnAccesar.Location = new System.Drawing.Point(85, 166);
            this.BtnAccesar.Name = "BtnAccesar";
            this.BtnAccesar.Size = new System.Drawing.Size(125, 23);
            this.BtnAccesar.TabIndex = 5;
            this.BtnAccesar.Text = "Acceder";
            this.BtnAccesar.UseVisualStyleBackColor = true;
            this.BtnAccesar.Click += new System.EventHandler(this.BtnAccesar_Click);
            // 
            // BtnLoginCancelar
            // 
            this.BtnLoginCancelar.Location = new System.Drawing.Point(226, 166);
            this.BtnLoginCancelar.Name = "BtnLoginCancelar";
            this.BtnLoginCancelar.Size = new System.Drawing.Size(120, 23);
            this.BtnLoginCancelar.TabIndex = 6;
            this.BtnLoginCancelar.Text = "Cancelar";
            this.BtnLoginCancelar.UseVisualStyleBackColor = true;
            this.BtnLoginCancelar.Click += new System.EventHandler(this.BtnLoginCancelar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(420, 39);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(128, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Iniciar Sesión";
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 208);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnLoginCancelar);
            this.Controls.Add(this.BtnAccesar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnAccesar;
        private System.Windows.Forms.Button BtnLoginCancelar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}