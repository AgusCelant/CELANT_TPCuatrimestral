namespace Presentacion
{
    partial class frmPlanillaMedicos
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
            this.dgvPlanillaMedicos = new System.Windows.Forms.DataGridView();
            this.btnEliminarMedico = new System.Windows.Forms.Button();
            this.btnModificarMedico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanillaMedicos
            // 
            this.dgvPlanillaMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlanillaMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanillaMedicos.Location = new System.Drawing.Point(12, 12);
            this.dgvPlanillaMedicos.Name = "dgvPlanillaMedicos";
            this.dgvPlanillaMedicos.Size = new System.Drawing.Size(848, 372);
            this.dgvPlanillaMedicos.TabIndex = 0;
            // 
            // btnEliminarMedico
            // 
            this.btnEliminarMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarMedico.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarMedico.Location = new System.Drawing.Point(755, 390);
            this.btnEliminarMedico.Name = "btnEliminarMedico";
            this.btnEliminarMedico.Size = new System.Drawing.Size(105, 48);
            this.btnEliminarMedico.TabIndex = 1;
            this.btnEliminarMedico.Text = "Eliminar";
            this.btnEliminarMedico.UseVisualStyleBackColor = false;
            this.btnEliminarMedico.Click += new System.EventHandler(this.btnEliminarMedico_Click);
            // 
            // btnModificarMedico
            // 
            this.btnModificarMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarMedico.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarMedico.Location = new System.Drawing.Point(644, 390);
            this.btnModificarMedico.Name = "btnModificarMedico";
            this.btnModificarMedico.Size = new System.Drawing.Size(105, 48);
            this.btnModificarMedico.TabIndex = 2;
            this.btnModificarMedico.Text = "Modificar";
            this.btnModificarMedico.UseVisualStyleBackColor = false;
            this.btnModificarMedico.Click += new System.EventHandler(this.btnModificarMedico_Click);
            // 
            // PlanillaMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.btnModificarMedico);
            this.Controls.Add(this.btnEliminarMedico);
            this.Controls.Add(this.dgvPlanillaMedicos);
            this.Name = "PlanillaMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanillaMedicos";
            this.Load += new System.EventHandler(this.PlanillaMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanillaMedicos;
        private System.Windows.Forms.Button btnEliminarMedico;
        private System.Windows.Forms.Button btnModificarMedico;
    }
}