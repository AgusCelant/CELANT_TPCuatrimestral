namespace Presentacion
{
    partial class Buscar_Turno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar_Turno));
            this.dgvBuscarTurno = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBuscarDatosPaciente = new System.Windows.Forms.ToolStripButton();
            this.tsbBusquedaTurno = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarTurno)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscarTurno
            // 
            this.dgvBuscarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscarTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarTurno.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBuscarTurno.Location = new System.Drawing.Point(12, 51);
            this.dgvBuscarTurno.MultiSelect = false;
            this.dgvBuscarTurno.Name = "dgvBuscarTurno";
            this.dgvBuscarTurno.Size = new System.Drawing.Size(541, 217);
            this.dgvBuscarTurno.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBuscarDatosPaciente,
            this.tsbBusquedaTurno});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(565, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbBuscarDatosPaciente
            // 
            this.tsbBuscarDatosPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscarDatosPaciente.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscarDatosPaciente.Image")));
            this.tsbBuscarDatosPaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarDatosPaciente.Name = "tsbBuscarDatosPaciente";
            this.tsbBuscarDatosPaciente.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscarDatosPaciente.Text = "Datos del Paciente";
            // 
            // tsbBusquedaTurno
            // 
            this.tsbBusquedaTurno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBusquedaTurno.Image = ((System.Drawing.Image)(resources.GetObject("tsbBusquedaTurno.Image")));
            this.tsbBusquedaTurno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBusquedaTurno.Name = "tsbBusquedaTurno";
            this.tsbBusquedaTurno.Size = new System.Drawing.Size(23, 22);
            this.tsbBusquedaTurno.Text = "Buscar turno";
            // 
            // Buscar_Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 280);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvBuscarTurno);
            this.MinimumSize = new System.Drawing.Size(581, 319);
            this.Name = "Buscar_Turno";
            this.Text = "Buscar_Turno";
            this.Load += new System.EventHandler(this.Buscar_Turno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarTurno)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarTurno;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbBuscarDatosPaciente;
        private System.Windows.Forms.ToolStripButton tsbBusquedaTurno;
    }
}