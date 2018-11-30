namespace Presentacion
{
    partial class AltaObSocial
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
            this.lblNombreOS = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreoOS = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtTelefonoOS = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.gbxAltaObraSocial = new System.Windows.Forms.GroupBox();
            this.gbxAltaObraSocial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreOS
            // 
            this.lblNombreOS.AutoSize = true;
            this.lblNombreOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreOS.Location = new System.Drawing.Point(28, 21);
            this.lblNombreOS.Name = "lblNombreOS";
            this.lblNombreOS.Size = new System.Drawing.Size(96, 18);
            this.lblNombreOS.TabIndex = 0;
            this.lblNombreOS.Text = "Obra Social:";
            // 
            // btnAlta
            // 
            this.btnAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlta.Location = new System.Drawing.Point(404, 138);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 4;
            this.btnAlta.Text = "Dar de Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(534, 138);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCorreoOS
            // 
            this.txtCorreoOS.Location = new System.Drawing.Point(147, 69);
            this.txtCorreoOS.Name = "txtCorreoOS";
            this.txtCorreoOS.Size = new System.Drawing.Size(170, 20);
            this.txtCorreoOS.TabIndex = 10;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(80, 71);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(61, 18);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Correo:";
            // 
            // txtTelefonoOS
            // 
            this.txtTelefonoOS.Location = new System.Drawing.Point(427, 44);
            this.txtTelefonoOS.Name = "txtTelefonoOS";
            this.txtTelefonoOS.Size = new System.Drawing.Size(170, 20);
            this.txtTelefonoOS.TabIndex = 12;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(345, 44);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(76, 18);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Telefono:";
            // 
            // gbxAltaObraSocial
            // 
            this.gbxAltaObraSocial.Controls.Add(this.txtNombre);
            this.gbxAltaObraSocial.Controls.Add(this.txtTelefonoOS);
            this.gbxAltaObraSocial.Controls.Add(this.lblNombreOS);
            this.gbxAltaObraSocial.Controls.Add(this.lblTelefono);
            this.gbxAltaObraSocial.Controls.Add(this.lblMail);
            this.gbxAltaObraSocial.Controls.Add(this.txtCorreoOS);
            this.gbxAltaObraSocial.Location = new System.Drawing.Point(12, 12);
            this.gbxAltaObraSocial.Name = "gbxAltaObraSocial";
            this.gbxAltaObraSocial.Size = new System.Drawing.Size(603, 121);
            this.gbxAltaObraSocial.TabIndex = 13;
            this.gbxAltaObraSocial.TabStop = false;
            this.gbxAltaObraSocial.Text = "Datos Obra Social";
            // 
            // AltaObSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 173);
            this.Controls.Add(this.gbxAltaObraSocial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlta);
            this.Name = "AltaObSocial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaObSocial";
            this.gbxAltaObraSocial.ResumeLayout(false);
            this.gbxAltaObraSocial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreOS;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreoOS;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtTelefonoOS;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.GroupBox gbxAltaObraSocial;
    }
}