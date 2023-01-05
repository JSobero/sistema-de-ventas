namespace SistemaVentas_V01
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletaDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesoToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(128, 25);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // procesoToolStripMenuItem
            // 
            this.procesoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletaDeVentaToolStripMenuItem});
            this.procesoToolStripMenuItem.Name = "procesoToolStripMenuItem";
            this.procesoToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.procesoToolStripMenuItem.Text = "Proceso";
            // 
            // boletaDeVentaToolStripMenuItem
            // 
            this.boletaDeVentaToolStripMenuItem.Name = "boletaDeVentaToolStripMenuItem";
            this.boletaDeVentaToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.boletaDeVentaToolStripMenuItem.Text = "Boleta de Venta";
            this.boletaDeVentaToolStripMenuItem.Click += new System.EventHandler(this.boletaDeVentaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorFechaToolStripMenuItem,
            this.detalleVentaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // ventasPorFechaToolStripMenuItem
            // 
            this.ventasPorFechaToolStripMenuItem.Name = "ventasPorFechaToolStripMenuItem";
            this.ventasPorFechaToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.ventasPorFechaToolStripMenuItem.Text = "Ventas por Fecha";
            this.ventasPorFechaToolStripMenuItem.Click += new System.EventHandler(this.ventasPorFechaToolStripMenuItem_Click);
            // 
            // detalleVentaToolStripMenuItem
            // 
            this.detalleVentaToolStripMenuItem.Name = "detalleVentaToolStripMenuItem";
            this.detalleVentaToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.detalleVentaToolStripMenuItem.Text = "Detalle Venta";
            this.detalleVentaToolStripMenuItem.Click += new System.EventHandler(this.detalleVentaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 360);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE VENTAS 2022";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletaDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleVentaToolStripMenuItem;
    }
}