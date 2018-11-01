namespace Presentacion
{
    partial class frmPlanillaPaciente
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
            this.dgvPlanillaPacientes = new System.Windows.Forms.DataGridView();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanillaPacientes
            // 
            this.dgvPlanillaPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlanillaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanillaPacientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPlanillaPacientes.Location = new System.Drawing.Point(12, 10);
            this.dgvPlanillaPacientes.MultiSelect = false;
            this.dgvPlanillaPacientes.Name = "dgvPlanillaPacientes";
            this.dgvPlanillaPacientes.Size = new System.Drawing.Size(1257, 381);
            this.dgvPlanillaPacientes.TabIndex = 0;
            // 
            // btnModificarPaciente
            // 
            this.btnModificarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarPaciente.Location = new System.Drawing.Point(1053, 397);
            this.btnModificarPaciente.Name = "btnModificarPaciente";
            this.btnModificarPaciente.Size = new System.Drawing.Size(105, 48);
            this.btnModificarPaciente.TabIndex = 4;
            this.btnModificarPaciente.Text = "Modificar";
            this.btnModificarPaciente.UseVisualStyleBackColor = false;
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarPaciente.Location = new System.Drawing.Point(1164, 397);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(105, 48);
            this.btnEliminarPaciente.TabIndex = 3;
            this.btnEliminarPaciente.Text = "Eliminar";
            this.btnEliminarPaciente.UseVisualStyleBackColor = false;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // PlanillaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 448);
            this.Controls.Add(this.btnModificarPaciente);
            this.Controls.Add(this.btnEliminarPaciente);
            this.Controls.Add(this.dgvPlanillaPacientes);
            this.Name = "PlanillaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanillaPaciente";
            this.Load += new System.EventHandler(this.PlanillaPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanillaPacientes;
        private System.Windows.Forms.Button btnModificarPaciente;
        private System.Windows.Forms.Button btnEliminarPaciente;
    }
}