namespace Presentacion
{
    partial class AltaMedico
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
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblMarticula = new System.Windows.Forms.Label();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.txtApelidoMedico = new System.Windows.Forms.TextBox();
            this.txtEdadMedico = new System.Windows.Forms.TextBox();
            this.txtMatriculaMedico = new System.Windows.Forms.TextBox();
            this.dtpNacimientoMedico = new System.Windows.Forms.DateTimePicker();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboObraSocial = new System.Windows.Forms.Label();
            this.lstbxEspecialidades = new System.Windows.Forms.ListBox();
            this.lstbxOS = new System.Windows.Forms.ListBox();
            this.lstbCargaEspecialidades = new System.Windows.Forms.ListBox();
            this.lstbCargaOS = new System.Windows.Forms.ListBox();
            this.btnPasarEspecialidades = new System.Windows.Forms.Button();
            this.btnPasarOS = new System.Windows.Forms.Button();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lstbxDias = new System.Windows.Forms.ListBox();
            this.lstbxHoraEnntrada = new System.Windows.Forms.ListBox();
            this.lstbCargaHorasDias = new System.Windows.Forms.ListBox();
            this.btnCargarHorariosDias = new System.Windows.Forms.Button();
            this.lstbxHoraSalida = new System.Windows.Forms.ListBox();
            this.lblHorarioSalida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.Control;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(15, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(178, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Profesional:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.SystemColors.Control;
            this.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(12, 81);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(181, 18);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido del Profesional:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.SystemColors.Control;
            this.lblEdad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(140, 105);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(51, 18);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.SystemColors.Control;
            this.lblFechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(101, 130);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(92, 18);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Nacimiento:";
            // 
            // lblMarticula
            // 
            this.lblMarticula.AutoSize = true;
            this.lblMarticula.BackColor = System.Drawing.SystemColors.Control;
            this.lblMarticula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMarticula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarticula.Location = new System.Drawing.Point(94, 159);
            this.lblMarticula.Name = "lblMarticula";
            this.lblMarticula.Size = new System.Drawing.Size(97, 18);
            this.lblMarticula.TabIndex = 4;
            this.lblMarticula.Text = "N° Matricula:";
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(199, 53);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(153, 20);
            this.txtNombreMedico.TabIndex = 5;
            // 
            // txtApelidoMedico
            // 
            this.txtApelidoMedico.Location = new System.Drawing.Point(199, 79);
            this.txtApelidoMedico.Name = "txtApelidoMedico";
            this.txtApelidoMedico.Size = new System.Drawing.Size(153, 20);
            this.txtApelidoMedico.TabIndex = 6;
            // 
            // txtEdadMedico
            // 
            this.txtEdadMedico.Location = new System.Drawing.Point(197, 105);
            this.txtEdadMedico.Name = "txtEdadMedico";
            this.txtEdadMedico.Size = new System.Drawing.Size(90, 20);
            this.txtEdadMedico.TabIndex = 7;
            // 
            // txtMatriculaMedico
            // 
            this.txtMatriculaMedico.Location = new System.Drawing.Point(197, 157);
            this.txtMatriculaMedico.Name = "txtMatriculaMedico";
            this.txtMatriculaMedico.Size = new System.Drawing.Size(100, 20);
            this.txtMatriculaMedico.TabIndex = 9;
            // 
            // dtpNacimientoMedico
            // 
            this.dtpNacimientoMedico.Location = new System.Drawing.Point(197, 131);
            this.dtpNacimientoMedico.Name = "dtpNacimientoMedico";
            this.dtpNacimientoMedico.Size = new System.Drawing.Size(200, 20);
            this.dtpNacimientoMedico.TabIndex = 10;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.BackColor = System.Drawing.SystemColors.Control;
            this.lblEspecialidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(2, 258);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(106, 18);
            this.lblEspecialidad.TabIndex = 12;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(522, 390);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(111, 37);
            this.btnAlta.TabIndex = 13;
            this.btnAlta.Text = "Dar de Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(639, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 37);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboObraSocial
            // 
            this.cboObraSocial.AutoSize = true;
            this.cboObraSocial.BackColor = System.Drawing.SystemColors.Control;
            this.cboObraSocial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cboObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboObraSocial.Location = new System.Drawing.Point(12, 319);
            this.cboObraSocial.Name = "cboObraSocial";
            this.cboObraSocial.Size = new System.Drawing.Size(96, 18);
            this.cboObraSocial.TabIndex = 18;
            this.cboObraSocial.Text = "Obra Social:";
            // 
            // lstbxEspecialidades
            // 
            this.lstbxEspecialidades.FormattingEnabled = true;
            this.lstbxEspecialidades.Location = new System.Drawing.Point(114, 238);
            this.lstbxEspecialidades.Name = "lstbxEspecialidades";
            this.lstbxEspecialidades.Size = new System.Drawing.Size(202, 56);
            this.lstbxEspecialidades.TabIndex = 19;
            // 
            // lstbxOS
            // 
            this.lstbxOS.FormattingEnabled = true;
            this.lstbxOS.Location = new System.Drawing.Point(114, 300);
            this.lstbxOS.Name = "lstbxOS";
            this.lstbxOS.Size = new System.Drawing.Size(202, 56);
            this.lstbxOS.TabIndex = 20;
            // 
            // lstbCargaEspecialidades
            // 
            this.lstbCargaEspecialidades.FormattingEnabled = true;
            this.lstbCargaEspecialidades.Location = new System.Drawing.Point(439, 238);
            this.lstbCargaEspecialidades.Name = "lstbCargaEspecialidades";
            this.lstbCargaEspecialidades.Size = new System.Drawing.Size(200, 56);
            this.lstbCargaEspecialidades.TabIndex = 21;
            // 
            // lstbCargaOS
            // 
            this.lstbCargaOS.FormattingEnabled = true;
            this.lstbCargaOS.Location = new System.Drawing.Point(439, 300);
            this.lstbCargaOS.Name = "lstbCargaOS";
            this.lstbCargaOS.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbCargaOS.Size = new System.Drawing.Size(200, 56);
            this.lstbCargaOS.TabIndex = 22;
            // 
            // btnPasarEspecialidades
            // 
            this.btnPasarEspecialidades.Location = new System.Drawing.Point(322, 248);
            this.btnPasarEspecialidades.Name = "btnPasarEspecialidades";
            this.btnPasarEspecialidades.Size = new System.Drawing.Size(111, 37);
            this.btnPasarEspecialidades.TabIndex = 23;
            this.btnPasarEspecialidades.Text = "Cargar Especialidades";
            this.btnPasarEspecialidades.UseVisualStyleBackColor = true;
            this.btnPasarEspecialidades.Click += new System.EventHandler(this.btnPasarEspecialidades_Click);
            // 
            // btnPasarOS
            // 
            this.btnPasarOS.Location = new System.Drawing.Point(322, 309);
            this.btnPasarOS.Name = "btnPasarOS";
            this.btnPasarOS.Size = new System.Drawing.Size(111, 37);
            this.btnPasarOS.TabIndex = 24;
            this.btnPasarOS.Text = "Cargar Obras Sociales";
            this.btnPasarOS.UseVisualStyleBackColor = true;
            this.btnPasarOS.Click += new System.EventHandler(this.btnPasarOS_Click);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.BackColor = System.Drawing.SystemColors.Control;
            this.lblDias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(429, 54);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(51, 18);
            this.lblDias.TabIndex = 32;
            this.lblDias.Text = "Dia/s:";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.BackColor = System.Drawing.SystemColors.Control;
            this.lblHoraEntrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraEntrada.Location = new System.Drawing.Point(639, 55);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(154, 18);
            this.lblHoraEntrada.TabIndex = 35;
            this.lblHoraEntrada.Text = "Horarios de Entrada:";
            // 
            // lstbxDias
            // 
            this.lstbxDias.FormattingEnabled = true;
            this.lstbxDias.Location = new System.Drawing.Point(429, 79);
            this.lstbxDias.Name = "lstbxDias";
            this.lstbxDias.Size = new System.Drawing.Size(202, 56);
            this.lstbxDias.TabIndex = 47;
            // 
            // lstbxHoraEnntrada
            // 
            this.lstbxHoraEnntrada.FormattingEnabled = true;
            this.lstbxHoraEnntrada.Location = new System.Drawing.Point(639, 75);
            this.lstbxHoraEnntrada.Name = "lstbxHoraEnntrada";
            this.lstbxHoraEnntrada.Size = new System.Drawing.Size(53, 108);
            this.lstbxHoraEnntrada.TabIndex = 50;
            // 
            // lstbCargaHorasDias
            // 
            this.lstbCargaHorasDias.FormattingEnabled = true;
            this.lstbCargaHorasDias.Location = new System.Drawing.Point(682, 238);
            this.lstbCargaHorasDias.Name = "lstbCargaHorasDias";
            this.lstbCargaHorasDias.Size = new System.Drawing.Size(122, 108);
            this.lstbCargaHorasDias.TabIndex = 51;
            // 
            // btnCargarHorariosDias
            // 
            this.btnCargarHorariosDias.Location = new System.Drawing.Point(682, 189);
            this.btnCargarHorariosDias.Name = "btnCargarHorariosDias";
            this.btnCargarHorariosDias.Size = new System.Drawing.Size(111, 37);
            this.btnCargarHorariosDias.TabIndex = 52;
            this.btnCargarHorariosDias.Text = "Cargar Horarios y Dias";
            this.btnCargarHorariosDias.UseVisualStyleBackColor = true;
            this.btnCargarHorariosDias.Click += new System.EventHandler(this.btnCargarHorariosDias_Click);
            // 
            // lstbxHoraSalida
            // 
            this.lstbxHoraSalida.FormattingEnabled = true;
            this.lstbxHoraSalida.Location = new System.Drawing.Point(799, 75);
            this.lstbxHoraSalida.Name = "lstbxHoraSalida";
            this.lstbxHoraSalida.Size = new System.Drawing.Size(52, 108);
            this.lstbxHoraSalida.TabIndex = 53;
            // 
            // lblHorarioSalida
            // 
            this.lblHorarioSalida.AutoSize = true;
            this.lblHorarioSalida.BackColor = System.Drawing.SystemColors.Control;
            this.lblHorarioSalida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHorarioSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioSalida.Location = new System.Drawing.Point(799, 54);
            this.lblHorarioSalida.Name = "lblHorarioSalida";
            this.lblHorarioSalida.Size = new System.Drawing.Size(145, 18);
            this.lblHorarioSalida.TabIndex = 56;
            this.lblHorarioSalida.Text = "Horarios de Salida:";
            // 
            // AltaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 440);
            this.Controls.Add(this.lblHorarioSalida);
            this.Controls.Add(this.lstbxHoraSalida);
            this.Controls.Add(this.btnCargarHorariosDias);
            this.Controls.Add(this.lstbCargaHorasDias);
            this.Controls.Add(this.lstbxHoraEnntrada);
            this.Controls.Add(this.lstbxDias);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.btnPasarOS);
            this.Controls.Add(this.btnPasarEspecialidades);
            this.Controls.Add(this.lstbCargaOS);
            this.Controls.Add(this.lstbCargaEspecialidades);
            this.Controls.Add(this.lstbxOS);
            this.Controls.Add(this.lstbxEspecialidades);
            this.Controls.Add(this.cboObraSocial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.dtpNacimientoMedico);
            this.Controls.Add(this.txtMatriculaMedico);
            this.Controls.Add(this.txtEdadMedico);
            this.Controls.Add(this.txtApelidoMedico);
            this.Controls.Add(this.txtNombreMedico);
            this.Controls.Add(this.lblMarticula);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "AltaMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaMedico";
            this.Load += new System.EventHandler(this.AltaMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblMarticula;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.TextBox txtApelidoMedico;
        private System.Windows.Forms.TextBox txtEdadMedico;
        private System.Windows.Forms.TextBox txtMatriculaMedico;
        private System.Windows.Forms.DateTimePicker dtpNacimientoMedico;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label cboObraSocial;
        private System.Windows.Forms.ListBox lstbxEspecialidades;
        private System.Windows.Forms.ListBox lstbxOS;
        private System.Windows.Forms.ListBox lstbCargaEspecialidades;
        private System.Windows.Forms.ListBox lstbCargaOS;
        private System.Windows.Forms.Button btnPasarEspecialidades;
        private System.Windows.Forms.Button btnPasarOS;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.ListBox lstbxDias;
        private System.Windows.Forms.ListBox lstbxHoraEnntrada;
        private System.Windows.Forms.ListBox lstbCargaHorasDias;
        private System.Windows.Forms.Button btnCargarHorariosDias;
        private System.Windows.Forms.ListBox lstbxHoraSalida;
        private System.Windows.Forms.Label lblHorarioSalida;
    }
}