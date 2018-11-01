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
            this.tsbNuevoTurno = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminarDatos = new System.Windows.Forms.ToolStripButton();
            this.tsbModificarTurnos = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsddbAltas = new System.Windows.Forms.ToolStripDropDownButton();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbNuevoTurno
            // 
            this.tsbNuevoTurno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevoTurno.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevoTurno.Image")));
            this.tsbNuevoTurno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoTurno.Name = "tsbNuevoTurno";
            this.tsbNuevoTurno.Size = new System.Drawing.Size(27, 20);
            this.tsbNuevoTurno.Text = "Nuevo turno";
            this.tsbNuevoTurno.Click += new System.EventHandler(this.tsbNuevoTurno_Click);
            // 
            // tsbEliminarDatos
            // 
            this.tsbEliminarDatos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminarDatos.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminarDatos.Image")));
            this.tsbEliminarDatos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarDatos.Name = "tsbEliminarDatos";
            this.tsbEliminarDatos.Size = new System.Drawing.Size(27, 20);
            this.tsbEliminarDatos.Text = "Borrar turno";
            this.tsbEliminarDatos.Click += new System.EventHandler(this.tsbEliminarDatos_Click);
            // 
            // tsbModificarTurnos
            // 
            this.tsbModificarTurnos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificarTurnos.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificarTurnos.Image")));
            this.tsbModificarTurnos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarTurnos.Name = "tsbModificarTurnos";
            this.tsbModificarTurnos.Size = new System.Drawing.Size(27, 20);
            this.tsbModificarTurnos.Text = "Modificar turno";
            this.tsbModificarTurnos.Click += new System.EventHandler(this.tsbModificarTurnos_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(27, 20);
            this.tsbBuscar.Text = "Buscar..";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscarTurno_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoTurno,
            this.tsbEliminarDatos,
            this.tsbModificarTurnos,
            this.tsbBuscar,
            this.tsddbAltas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(30, 450);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsddbAltas
            // 
            this.tsddbAltas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbAltas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.zToolStripMenuItem,
            this.bToolStripMenuItem});
            this.tsddbAltas.Image = ((System.Drawing.Image)(resources.GetObject("tsddbAltas.Image")));
            this.tsddbAltas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbAltas.Name = "tsddbAltas";
            this.tsddbAltas.Size = new System.Drawing.Size(27, 20);
            this.tsddbAltas.Text = "toolStripDropDownButton1";
            this.tsddbAltas.ToolTipText = "Dar de Alta...";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.aToolStripMenuItem.Text = "Paciente";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // zToolStripMenuItem
            // 
            this.zToolStripMenuItem.Name = "zToolStripMenuItem";
            this.zToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.zToolStripMenuItem.Text = "Medico";
            this.zToolStripMenuItem.Click += new System.EventHandler(this.zToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.bToolStripMenuItem.Text = "Obra Social";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton tsbNuevoTurno;
        private System.Windows.Forms.ToolStripButton tsbEliminarDatos;
        private System.Windows.Forms.ToolStripButton tsbModificarTurnos;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsddbAltas;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
    }
}

