namespace Presentacion
{
    partial class AltaPaciente
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNacimento = new System.Windows.Forms.Label();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.lblNumeroOS = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNumeroOS = new System.Windows.Forms.TextBox();
            this.dtpPaciente = new System.Windows.Forms.DateTimePicker();
            this.cboOS = new System.Windows.Forms.ComboBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccionPaciente = new System.Windows.Forms.TextBox();
            this.gbxAltaPaciente = new System.Windows.Forms.GroupBox();
            this.gbxAltaPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(10, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblApellido.Location = new System.Drawing.Point(7, 70);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(72, 18);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(342, 43);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(40, 18);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI:";
            // 
            // lblNacimento
            // 
            this.lblNacimento.AutoSize = true;
            this.lblNacimento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNacimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNacimento.Location = new System.Drawing.Point(7, 127);
            this.lblNacimento.Name = "lblNacimento";
            this.lblNacimento.Size = new System.Drawing.Size(161, 18);
            this.lblNacimento.TabIndex = 4;
            this.lblNacimento.Text = "Fecha de Nacimiento:";
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObraSocial.Location = new System.Drawing.Point(9, 188);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(96, 18);
            this.lblObraSocial.TabIndex = 5;
            this.lblObraSocial.Text = "Obra Social:";
            // 
            // lblNumeroOS
            // 
            this.lblNumeroOS.AutoSize = true;
            this.lblNumeroOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumeroOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOS.Location = new System.Drawing.Point(329, 190);
            this.lblNumeroOS.Name = "lblNumeroOS";
            this.lblNumeroOS.Size = new System.Drawing.Size(87, 18);
            this.lblNumeroOS.TabIndex = 6;
            this.lblNumeroOS.Text = "N° Afiliado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(83, 69);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(167, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(388, 41);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(186, 20);
            this.txtDNI.TabIndex = 13;
            // 
            // txtNumeroOS
            // 
            this.txtNumeroOS.Location = new System.Drawing.Point(436, 189);
            this.txtNumeroOS.Name = "txtNumeroOS";
            this.txtNumeroOS.Size = new System.Drawing.Size(138, 20);
            this.txtNumeroOS.TabIndex = 16;
            // 
            // dtpPaciente
            // 
            this.dtpPaciente.Location = new System.Drawing.Point(172, 127);
            this.dtpPaciente.Name = "dtpPaciente";
            this.dtpPaciente.Size = new System.Drawing.Size(200, 20);
            this.dtpPaciente.TabIndex = 17;
            // 
            // cboOS
            // 
            this.cboOS.FormattingEnabled = true;
            this.cboOS.Location = new System.Drawing.Point(109, 187);
            this.cboOS.Name = "cboOS";
            this.cboOS.Size = new System.Drawing.Size(141, 21);
            this.cboOS.TabIndex = 18;
            // 
            // btnAlta
            // 
            this.btnAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlta.Location = new System.Drawing.Point(445, 263);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(90, 44);
            this.btnAlta.TabIndex = 19;
            this.btnAlta.Text = "Dar de Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(605, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 44);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(393, 128);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(80, 18);
            this.lblDireccion.TabIndex = 22;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtDireccionPaciente
            // 
            this.txtDireccionPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccionPaciente.Location = new System.Drawing.Point(479, 126);
            this.txtDireccionPaciente.Name = "txtDireccionPaciente";
            this.txtDireccionPaciente.Size = new System.Drawing.Size(227, 20);
            this.txtDireccionPaciente.TabIndex = 23;
            this.txtDireccionPaciente.Enter += new System.EventHandler(this.txtDireccion_Enter);
            // 
            // gbxAltaPaciente
            // 
            this.gbxAltaPaciente.Controls.Add(this.txtDNI);
            this.gbxAltaPaciente.Controls.Add(this.txtDireccionPaciente);
            this.gbxAltaPaciente.Controls.Add(this.lblNombre);
            this.gbxAltaPaciente.Controls.Add(this.lblDireccion);
            this.gbxAltaPaciente.Controls.Add(this.lblApellido);
            this.gbxAltaPaciente.Controls.Add(this.lblDNI);
            this.gbxAltaPaciente.Controls.Add(this.lblNacimento);
            this.gbxAltaPaciente.Controls.Add(this.cboOS);
            this.gbxAltaPaciente.Controls.Add(this.lblObraSocial);
            this.gbxAltaPaciente.Controls.Add(this.dtpPaciente);
            this.gbxAltaPaciente.Controls.Add(this.lblNumeroOS);
            this.gbxAltaPaciente.Controls.Add(this.txtNumeroOS);
            this.gbxAltaPaciente.Controls.Add(this.txtNombre);
            this.gbxAltaPaciente.Controls.Add(this.txtApellido);
            this.gbxAltaPaciente.Location = new System.Drawing.Point(12, 12);
            this.gbxAltaPaciente.Name = "gbxAltaPaciente";
            this.gbxAltaPaciente.Size = new System.Drawing.Size(727, 238);
            this.gbxAltaPaciente.TabIndex = 24;
            this.gbxAltaPaciente.TabStop = false;
            this.gbxAltaPaciente.Text = "Datos Paciente";
            // 
            // AltaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 319);
            this.Controls.Add(this.gbxAltaPaciente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlta);
            this.MinimumSize = new System.Drawing.Size(581, 319);
            this.Name = "AltaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaPaciente";
            this.Load += new System.EventHandler(this.AltaPaciente_Load);
            this.gbxAltaPaciente.ResumeLayout(false);
            this.gbxAltaPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNacimento;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.Label lblNumeroOS;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNumeroOS;
        private System.Windows.Forms.DateTimePicker dtpPaciente;
        private System.Windows.Forms.ComboBox cboOS;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccionPaciente;
        private System.Windows.Forms.GroupBox gbxAltaPaciente;
    }
}