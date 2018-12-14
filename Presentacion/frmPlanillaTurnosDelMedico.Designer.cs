namespace Presentacion
{
    partial class frmPlanillaTurnosDelMedico
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.lblNombreMedico = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(13, 59);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(524, 379);
            this.dgvListado.TabIndex = 0;
            // 
            // lblNombreMedico
            // 
            this.lblNombreMedico.AutoSize = true;
            this.lblNombreMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMedico.Location = new System.Drawing.Point(24, 13);
            this.lblNombreMedico.Name = "lblNombreMedico";
            this.lblNombreMedico.Size = new System.Drawing.Size(66, 24);
            this.lblNombreMedico.TabIndex = 1;
            this.lblNombreMedico.Text = "label1";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFiltrar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFiltrar.Location = new System.Drawing.Point(609, 95);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(119, 20);
            this.txtFiltrar.TabIndex = 33;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnFiltrar.Location = new System.Drawing.Point(552, 121);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(230, 57);
            this.btnFiltrar.TabIndex = 31;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(552, 74);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(227, 18);
            this.lblFiltrar.TabIndex = 32;
            this.lblFiltrar.Text = "Buscar por el DNI del Paciente:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(552, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 57);
            this.button1.TabIndex = 34;
            this.button1.Text = "Salir.";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPlanillaTurnosDelMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.lblNombreMedico);
            this.Controls.Add(this.dgvListado);
            this.Name = "frmPlanillaTurnosDelMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlanillaTurnosDelMedico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPlanillaTurnosDelMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        public System.Windows.Forms.Label lblNombreMedico;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Button button1;
    }
}