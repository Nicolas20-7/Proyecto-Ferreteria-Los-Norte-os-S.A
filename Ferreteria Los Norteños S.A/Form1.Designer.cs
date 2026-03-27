namespace Ferreteria_Los_Norteños_S.A
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevaventa = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnNuevacompra = new System.Windows.Forms.Button();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tsbEntrada = new System.Windows.Forms.ToolStripButton();
            this.tsbProcesos = new System.Windows.Forms.ToolStripButton();
            this.tsbReportes = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnNuevaventa
            // 
            resources.ApplyResources(this.btnNuevaventa, "btnNuevaventa");
            this.btnNuevaventa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNuevaventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaventa.Name = "btnNuevaventa";
            this.btnNuevaventa.UseVisualStyleBackColor = false;
            this.btnNuevaventa.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            resources.ApplyResources(this.btnClientes, "btnClientes");
            this.btnClientes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCaja
            // 
            resources.ApplyResources(this.btnCaja, "btnCaja");
            this.btnCaja.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnProductos
            // 
            resources.ApplyResources(this.btnProductos, "btnProductos");
            this.btnProductos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnNuevacompra
            // 
            resources.ApplyResources(this.btnNuevacompra, "btnNuevacompra");
            this.btnNuevacompra.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNuevacompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevacompra.Name = "btnNuevacompra";
            this.btnNuevacompra.UseVisualStyleBackColor = false;
            this.btnNuevacompra.Click += new System.EventHandler(this.button2_Click);
            // 
            // ts
            // 
            this.ts.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ts.GripMargin = new System.Windows.Forms.Padding(3);
            this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEntrada,
            this.tsbProcesos,
            this.tsbReportes,
            this.tsbSalir});
            resources.ApplyResources(this.ts, "ts");
            this.ts.Name = "ts";
            this.ts.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // tsbEntrada
            // 
            this.tsbEntrada.BackColor = System.Drawing.Color.Transparent;
            this.tsbEntrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEntrada.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.tsbEntrada, "tsbEntrada");
            this.tsbEntrada.Name = "tsbEntrada";
            // 
            // tsbProcesos
            // 
            this.tsbProcesos.BackColor = System.Drawing.Color.Transparent;
            this.tsbProcesos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbProcesos.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.tsbProcesos, "tsbProcesos");
            this.tsbProcesos.Name = "tsbProcesos";
            // 
            // tsbReportes
            // 
            this.tsbReportes.BackColor = System.Drawing.Color.Transparent;
            this.tsbReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReportes.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.tsbReportes, "tsbReportes");
            this.tsbReportes.Name = "tsbReportes";
            // 
            // tsbSalir
            // 
            this.tsbSalir.BackColor = System.Drawing.Color.Transparent;
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSalir.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.tsbSalir, "tsbSalir");
            this.tsbSalir.Name = "tsbSalir";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.ts);
            this.Controls.Add(this.btnNuevacompra);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnNuevaventa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevaventa;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnNuevacompra;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton tsbEntrada;
        private System.Windows.Forms.ToolStripButton tsbProcesos;
        private System.Windows.Forms.ToolStripButton tsbReportes;
        private System.Windows.Forms.ToolStripButton tsbSalir;
    }
}

