namespace Presentacion
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.dgvMenuPrincipal = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevoTurno = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminarDatos = new System.Windows.Forms.ToolStripButton();
            this.tsbModificarTurnos = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarTurno = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuPrincipal)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMenuPrincipal
            // 
            this.dgvMenuPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMenuPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuPrincipal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMenuPrincipal.Location = new System.Drawing.Point(12, 43);
            this.dgvMenuPrincipal.MultiSelect = false;
            this.dgvMenuPrincipal.Name = "dgvMenuPrincipal";
            this.dgvMenuPrincipal.Size = new System.Drawing.Size(776, 395);
            this.dgvMenuPrincipal.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoTurno,
            this.tsbEliminarDatos,
            this.tsbModificarTurnos,
            this.tsbBuscarTurno});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevoTurno
            // 
            this.tsbNuevoTurno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevoTurno.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevoTurno.Image")));
            this.tsbNuevoTurno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoTurno.Name = "tsbNuevoTurno";
            this.tsbNuevoTurno.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevoTurno.Text = "Nuevo turno";
            this.tsbNuevoTurno.Click += new System.EventHandler(this.tsbNuevoTurno_Click);
            // 
            // tsbEliminarDatos
            // 
            this.tsbEliminarDatos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminarDatos.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminarDatos.Image")));
            this.tsbEliminarDatos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarDatos.Name = "tsbEliminarDatos";
            this.tsbEliminarDatos.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminarDatos.Text = "Borrar turno";
            this.tsbEliminarDatos.Click += new System.EventHandler(this.tsbEliminarDatos_Click);
            // 
            // tsbModificarTurnos
            // 
            this.tsbModificarTurnos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificarTurnos.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificarTurnos.Image")));
            this.tsbModificarTurnos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarTurnos.Name = "tsbModificarTurnos";
            this.tsbModificarTurnos.Size = new System.Drawing.Size(23, 22);
            this.tsbModificarTurnos.Text = "Modificar turno";
            this.tsbModificarTurnos.Click += new System.EventHandler(this.tsbModificarTurnos_Click);
            // 
            // tsbBuscarTurno
            // 
            this.tsbBuscarTurno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscarTurno.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscarTurno.Image")));
            this.tsbBuscarTurno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarTurno.Name = "tsbBuscarTurno";
            this.tsbBuscarTurno.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscarTurno.Text = "Buscar turnos";
            this.tsbBuscarTurno.Click += new System.EventHandler(this.tsbBuscarTurno_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvMenuPrincipal);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuPrincipal)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenuPrincipal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevoTurno;
        private System.Windows.Forms.ToolStripButton tsbEliminarDatos;
        private System.Windows.Forms.ToolStripButton tsbModificarTurnos;
        private System.Windows.Forms.ToolStripButton tsbBuscarTurno;
    }
}

