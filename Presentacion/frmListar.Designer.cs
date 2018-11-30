namespace Presentacion
{
    partial class frmListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListar));
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBuscarDatosPaciente = new System.Windows.Forms.ToolStripButton();
            this.tsbVerEspecialidades = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarMedicos = new System.Windows.Forms.ToolStripButton();
            this.tsbListarOS = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBuscar.Location = new System.Drawing.Point(27, 12);
            this.dgvBuscar.MultiSelect = false;
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(526, 202);
            this.dgvBuscar.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBuscarDatosPaciente,
            this.tsbVerEspecialidades,
            this.tsbBuscarMedicos,
            this.tsbListarOS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(24, 280);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbBuscarDatosPaciente
            // 
            this.tsbBuscarDatosPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscarDatosPaciente.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscarDatosPaciente.Image")));
            this.tsbBuscarDatosPaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarDatosPaciente.Name = "tsbBuscarDatosPaciente";
            this.tsbBuscarDatosPaciente.Size = new System.Drawing.Size(21, 20);
            this.tsbBuscarDatosPaciente.Text = "Datos del Paciente";
            this.tsbBuscarDatosPaciente.Click += new System.EventHandler(this.tsbBuscarDatosPaciente_Click);
            // 
            // tsbVerEspecialidades
            // 
            this.tsbVerEspecialidades.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbVerEspecialidades.Image = ((System.Drawing.Image)(resources.GetObject("tsbVerEspecialidades.Image")));
            this.tsbVerEspecialidades.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVerEspecialidades.Name = "tsbVerEspecialidades";
            this.tsbVerEspecialidades.Size = new System.Drawing.Size(21, 20);
            this.tsbVerEspecialidades.Text = "Ver Especialidades";
            this.tsbVerEspecialidades.Click += new System.EventHandler(this.tsbVerEspecialidades_Click);
            // 
            // tsbBuscarMedicos
            // 
            this.tsbBuscarMedicos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscarMedicos.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscarMedicos.Image")));
            this.tsbBuscarMedicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarMedicos.Name = "tsbBuscarMedicos";
            this.tsbBuscarMedicos.Size = new System.Drawing.Size(21, 20);
            this.tsbBuscarMedicos.Text = "Buscar Medico";
            this.tsbBuscarMedicos.Click += new System.EventHandler(this.tsbBuscarMedicos_Click);
            // 
            // tsbListarOS
            // 
            this.tsbListarOS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbListarOS.Image = ((System.Drawing.Image)(resources.GetObject("tsbListarOS.Image")));
            this.tsbListarOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbListarOS.Name = "tsbListarOS";
            this.tsbListarOS.Size = new System.Drawing.Size(21, 20);
            this.tsbListarOS.Text = "Obras Sociales";
            this.tsbListarOS.Click += new System.EventHandler(this.tsbListarOS_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Location = new System.Drawing.Point(337, 220);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 48);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
           // this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(448, 220);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 48);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 280);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvBuscar);
            this.MinimumSize = new System.Drawing.Size(581, 319);
            this.Name = "frmListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar...";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbBuscarDatosPaciente;
        private System.Windows.Forms.ToolStripButton tsbVerEspecialidades;
        private System.Windows.Forms.ToolStripButton tsbBuscarMedicos;
        private System.Windows.Forms.ToolStripButton tsbListarOS;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}