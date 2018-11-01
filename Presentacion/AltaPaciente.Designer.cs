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
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(15, 28);
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
            this.lblApellido.Location = new System.Drawing.Point(12, 59);
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
            this.lblDNI.Location = new System.Drawing.Point(347, 32);
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
            this.lblNacimento.Location = new System.Drawing.Point(12, 116);
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
            this.lblObraSocial.Location = new System.Drawing.Point(14, 177);
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
            this.lblNumeroOS.Location = new System.Drawing.Point(334, 179);
            this.lblNumeroOS.Name = "lblNumeroOS";
            this.lblNumeroOS.Size = new System.Drawing.Size(87, 18);
            this.lblNumeroOS.TabIndex = 6;
            this.lblNumeroOS.Text = "N° Afiliado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(88, 58);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(167, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(393, 30);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(186, 20);
            this.txtDNI.TabIndex = 13;
            // 
            // txtNumeroOS
            // 
            this.txtNumeroOS.Location = new System.Drawing.Point(441, 178);
            this.txtNumeroOS.Name = "txtNumeroOS";
            this.txtNumeroOS.Size = new System.Drawing.Size(138, 20);
            this.txtNumeroOS.TabIndex = 16;
            // 
            // dtpPaciente
            // 
            this.dtpPaciente.Location = new System.Drawing.Point(177, 116);
            this.dtpPaciente.Name = "dtpPaciente";
            this.dtpPaciente.Size = new System.Drawing.Size(200, 20);
            this.dtpPaciente.TabIndex = 17;
            // 
            // cboOS
            // 
            this.cboOS.FormattingEnabled = true;
            this.cboOS.Location = new System.Drawing.Point(114, 176);
            this.cboOS.Name = "cboOS";
            this.cboOS.Size = new System.Drawing.Size(141, 21);
            this.cboOS.TabIndex = 18;
            // 
            // btnAlta
            // 
            this.btnAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlta.Location = new System.Drawing.Point(512, 245);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 19;
            this.btnAlta.Text = "Dar de Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(672, 245);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
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
            this.lblDireccion.Location = new System.Drawing.Point(398, 117);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(80, 18);
            this.lblDireccion.TabIndex = 22;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtDireccionPaciente
            // 
            this.txtDireccionPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccionPaciente.Location = new System.Drawing.Point(484, 115);
            this.txtDireccionPaciente.Name = "txtDireccionPaciente";
            this.txtDireccionPaciente.Size = new System.Drawing.Size(227, 20);
            this.txtDireccionPaciente.TabIndex = 23;
            this.txtDireccionPaciente.Enter += new System.EventHandler(this.txtDireccion_Enter);
            // 
            // AltaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 280);
            this.Controls.Add(this.txtDireccionPaciente);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.cboOS);
            this.Controls.Add(this.dtpPaciente);
            this.Controls.Add(this.txtNumeroOS);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNumeroOS);
            this.Controls.Add(this.lblObraSocial);
            this.Controls.Add(this.lblNacimento);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.MinimumSize = new System.Drawing.Size(581, 319);
            this.Name = "AltaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaPaciente";
            this.Load += new System.EventHandler(this.AltaPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}