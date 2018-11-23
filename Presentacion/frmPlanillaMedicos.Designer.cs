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
            this.btnVerEspecialidades = new System.Windows.Forms.Button();
            this.dgvVerEspecialidades = new System.Windows.Forms.DataGridView();
            this.btnVerOS = new System.Windows.Forms.Button();
            this.dgvVerOS = new System.Windows.Forms.DataGridView();
            this.dgvDias = new System.Windows.Forms.DataGridView();
            this.btnDias = new System.Windows.Forms.Button();
            this.btnHoras = new System.Windows.Forms.Button();
            this.dgvHoras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerEspecialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlanillaMedicos
            // 
            this.dgvPlanillaMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlanillaMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanillaMedicos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPlanillaMedicos.Location = new System.Drawing.Point(12, 12);
            this.dgvPlanillaMedicos.MultiSelect = false;
            this.dgvPlanillaMedicos.Name = "dgvPlanillaMedicos";
            this.dgvPlanillaMedicos.Size = new System.Drawing.Size(649, 420);
            this.dgvPlanillaMedicos.TabIndex = 0;
            // 
            // btnEliminarMedico
            // 
            this.btnEliminarMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarMedico.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarMedico.Location = new System.Drawing.Point(338, 438);
            this.btnEliminarMedico.Name = "btnEliminarMedico";
            this.btnEliminarMedico.Size = new System.Drawing.Size(105, 33);
            this.btnEliminarMedico.TabIndex = 1;
            this.btnEliminarMedico.Text = "Eliminar";
            this.btnEliminarMedico.UseVisualStyleBackColor = false;
            this.btnEliminarMedico.Click += new System.EventHandler(this.btnEliminarMedico_Click);
            // 
            // btnModificarMedico
            // 
            this.btnModificarMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarMedico.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarMedico.Location = new System.Drawing.Point(227, 438);
            this.btnModificarMedico.Name = "btnModificarMedico";
            this.btnModificarMedico.Size = new System.Drawing.Size(105, 33);
            this.btnModificarMedico.TabIndex = 2;
            this.btnModificarMedico.Text = "Modificar";
            this.btnModificarMedico.UseVisualStyleBackColor = false;
            this.btnModificarMedico.Click += new System.EventHandler(this.btnModificarMedico_Click);
            // 
            // btnVerEspecialidades
            // 
            this.btnVerEspecialidades.Location = new System.Drawing.Point(694, 12);
            this.btnVerEspecialidades.Name = "btnVerEspecialidades";
            this.btnVerEspecialidades.Size = new System.Drawing.Size(99, 54);
            this.btnVerEspecialidades.TabIndex = 3;
            this.btnVerEspecialidades.Text = "Ver Especialidades";
            this.btnVerEspecialidades.UseVisualStyleBackColor = true;
            this.btnVerEspecialidades.Click += new System.EventHandler(this.btnVerEspecialidades_Click);
            // 
            // dgvVerEspecialidades
            // 
            this.dgvVerEspecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerEspecialidades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVerEspecialidades.Location = new System.Drawing.Point(667, 72);
            this.dgvVerEspecialidades.MultiSelect = false;
            this.dgvVerEspecialidades.Name = "dgvVerEspecialidades";
            this.dgvVerEspecialidades.Size = new System.Drawing.Size(154, 150);
            this.dgvVerEspecialidades.TabIndex = 4;
            // 
            // btnVerOS
            // 
            this.btnVerOS.Location = new System.Drawing.Point(854, 12);
            this.btnVerOS.Name = "btnVerOS";
            this.btnVerOS.Size = new System.Drawing.Size(98, 53);
            this.btnVerOS.TabIndex = 5;
            this.btnVerOS.Text = "Ver Obras Sociales";
            this.btnVerOS.UseVisualStyleBackColor = true;
            this.btnVerOS.Click += new System.EventHandler(this.btnVerOS_Click);
            // 
            // dgvVerOS
            // 
            this.dgvVerOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerOS.Location = new System.Drawing.Point(836, 71);
            this.dgvVerOS.Name = "dgvVerOS";
            this.dgvVerOS.Size = new System.Drawing.Size(153, 151);
            this.dgvVerOS.TabIndex = 6;
            // 
            // dgvDias
            // 
            this.dgvDias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDias.Location = new System.Drawing.Point(771, 228);
            this.dgvDias.Name = "dgvDias";
            this.dgvDias.Size = new System.Drawing.Size(253, 99);
            this.dgvDias.TabIndex = 7;
            // 
            // btnDias
            // 
            this.btnDias.Location = new System.Drawing.Point(667, 228);
            this.btnDias.Name = "btnDias";
            this.btnDias.Size = new System.Drawing.Size(98, 53);
            this.btnDias.TabIndex = 8;
            this.btnDias.Text = "Ver Dias";
            this.btnDias.UseVisualStyleBackColor = true;
            this.btnDias.Click += new System.EventHandler(this.btnDias_Click);
            // 
            // btnHoras
            // 
            this.btnHoras.Location = new System.Drawing.Point(667, 353);
            this.btnHoras.Name = "btnHoras";
            this.btnHoras.Size = new System.Drawing.Size(98, 53);
            this.btnHoras.TabIndex = 9;
            this.btnHoras.Text = "Ver Horas";
            this.btnHoras.UseVisualStyleBackColor = true;
            this.btnHoras.Click += new System.EventHandler(this.btnHoras_Click);
            // 
            // dgvHoras
            // 
            this.dgvHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoras.Location = new System.Drawing.Point(771, 333);
            this.dgvHoras.Name = "dgvHoras";
            this.dgvHoras.Size = new System.Drawing.Size(253, 99);
            this.dgvHoras.TabIndex = 10;
            // 
            // frmPlanillaMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 483);
            this.Controls.Add(this.dgvHoras);
            this.Controls.Add(this.btnHoras);
            this.Controls.Add(this.btnDias);
            this.Controls.Add(this.dgvDias);
            this.Controls.Add(this.dgvVerOS);
            this.Controls.Add(this.btnVerOS);
            this.Controls.Add(this.dgvVerEspecialidades);
            this.Controls.Add(this.btnVerEspecialidades);
            this.Controls.Add(this.btnModificarMedico);
            this.Controls.Add(this.btnEliminarMedico);
            this.Controls.Add(this.dgvPlanillaMedicos);
            this.Name = "frmPlanillaMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanillaMedicos";
            this.Load += new System.EventHandler(this.PlanillaMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerEspecialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlanillaMedicos;
        private System.Windows.Forms.Button btnEliminarMedico;
        private System.Windows.Forms.Button btnModificarMedico;
        private System.Windows.Forms.Button btnVerEspecialidades;
        private System.Windows.Forms.DataGridView dgvVerEspecialidades;
        private System.Windows.Forms.Button btnVerOS;
        private System.Windows.Forms.DataGridView dgvVerOS;
        private System.Windows.Forms.DataGridView dgvDias;
        private System.Windows.Forms.Button btnDias;
        private System.Windows.Forms.Button btnHoras;
        private System.Windows.Forms.DataGridView dgvHoras;
    }
}