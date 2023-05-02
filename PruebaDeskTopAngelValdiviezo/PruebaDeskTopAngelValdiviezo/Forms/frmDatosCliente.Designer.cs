namespace PruebaDeskTopAngelValdiviezo.Forms
{
    partial class frmDatosCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCursos = new System.Windows.Forms.TextBox();
            this.lblValidaCedula = new System.Windows.Forms.Label();
            this.lblValidaCelular = new System.Windows.Forms.Label();
            this.pctBoxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.btnSubirFotoPerfil = new System.Windows.Forms.Button();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.lblMensajeCorreo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Foto de perfil:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cursos:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(48, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(267, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(48, 236);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(267, 22);
            this.txtApellido.TabIndex = 8;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(48, 409);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(168, 22);
            this.txtCedula.TabIndex = 9;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(48, 550);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(168, 22);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(601, 94);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(420, 22);
            this.txtCorreo.TabIndex = 11;
            // 
            // txtCursos
            // 
            this.txtCursos.Location = new System.Drawing.Point(601, 388);
            this.txtCursos.Multiline = true;
            this.txtCursos.Name = "txtCursos";
            this.txtCursos.Size = new System.Drawing.Size(420, 93);
            this.txtCursos.TabIndex = 12;
            // 
            // lblValidaCedula
            // 
            this.lblValidaCedula.AutoSize = true;
            this.lblValidaCedula.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidaCedula.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValidaCedula.Location = new System.Drawing.Point(45, 376);
            this.lblValidaCedula.Name = "lblValidaCedula";
            this.lblValidaCedula.Size = new System.Drawing.Size(0, 16);
            this.lblValidaCedula.TabIndex = 13;
            // 
            // lblValidaCelular
            // 
            this.lblValidaCelular.AutoSize = true;
            this.lblValidaCelular.BackColor = System.Drawing.SystemColors.Control;
            this.lblValidaCelular.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValidaCelular.Location = new System.Drawing.Point(53, 522);
            this.lblValidaCelular.Name = "lblValidaCelular";
            this.lblValidaCelular.Size = new System.Drawing.Size(0, 16);
            this.lblValidaCelular.TabIndex = 14;
            // 
            // pctBoxFotoPerfil
            // 
            this.pctBoxFotoPerfil.Location = new System.Drawing.Point(601, 222);
            this.pctBoxFotoPerfil.Name = "pctBoxFotoPerfil";
            this.pctBoxFotoPerfil.Size = new System.Drawing.Size(396, 107);
            this.pctBoxFotoPerfil.TabIndex = 15;
            this.pctBoxFotoPerfil.TabStop = false;
            // 
            // btnSubirFotoPerfil
            // 
            this.btnSubirFotoPerfil.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubirFotoPerfil.Location = new System.Drawing.Point(703, 168);
            this.btnSubirFotoPerfil.Name = "btnSubirFotoPerfil";
            this.btnSubirFotoPerfil.Size = new System.Drawing.Size(98, 23);
            this.btnSubirFotoPerfil.TabIndex = 16;
            this.btnSubirFotoPerfil.Text = "Subir foto";
            this.btnSubirFotoPerfil.UseVisualStyleBackColor = false;
            this.btnSubirFotoPerfil.Click += new System.EventHandler(this.btnSubirFotoPerfil_Click);
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardarDatos.Location = new System.Drawing.Point(601, 537);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(147, 42);
            this.btnGuardarDatos.TabIndex = 17;
            this.btnGuardarDatos.Text = "Guardar";
            this.btnGuardarDatos.UseVisualStyleBackColor = false;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // lblMensajeCorreo
            // 
            this.lblMensajeCorreo.AutoSize = true;
            this.lblMensajeCorreo.BackColor = System.Drawing.SystemColors.Control;
            this.lblMensajeCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMensajeCorreo.Location = new System.Drawing.Point(606, 71);
            this.lblMensajeCorreo.Name = "lblMensajeCorreo";
            this.lblMensajeCorreo.Size = new System.Drawing.Size(0, 16);
            this.lblMensajeCorreo.TabIndex = 18;
            // 
            // frmDatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 619);
            this.Controls.Add(this.lblMensajeCorreo);
            this.Controls.Add(this.btnGuardarDatos);
            this.Controls.Add(this.btnSubirFotoPerfil);
            this.Controls.Add(this.pctBoxFotoPerfil);
            this.Controls.Add(this.lblValidaCelular);
            this.Controls.Add(this.lblValidaCedula);
            this.Controls.Add(this.txtCursos);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDatosCliente";
            this.Text = "frmDatosCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCursos;
        private System.Windows.Forms.Label lblValidaCedula;
        private System.Windows.Forms.Label lblValidaCelular;
        private System.Windows.Forms.PictureBox pctBoxFotoPerfil;
        private System.Windows.Forms.Button btnSubirFotoPerfil;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.Label lblMensajeCorreo;
    }
}