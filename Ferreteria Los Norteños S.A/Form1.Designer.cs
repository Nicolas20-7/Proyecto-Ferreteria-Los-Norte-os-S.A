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
            this.btnProveedores = new System.Windows.Forms.Button();
            this.tbtnInicio = new System.Windows.Forms.ToolStripDropDownButton();
            this.tbtnHerramientas = new System.Windows.Forms.ToolStripDropDownButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ts.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
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
            this.btnNuevaventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(132)))), ((int)(((byte)(164)))));
            this.btnNuevaventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaventa.ForeColor = System.Drawing.Color.Transparent;
            this.btnNuevaventa.Name = "btnNuevaventa";
            this.btnNuevaventa.UseVisualStyleBackColor = false;
            this.btnNuevaventa.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            resources.ApplyResources(this.btnClientes, "btnClientes");
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(132)))), ((int)(((byte)(164)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCaja
            // 
            resources.ApplyResources(this.btnCaja, "btnCaja");
            this.btnCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(132)))), ((int)(((byte)(164)))));
            this.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaja.ForeColor = System.Drawing.Color.Transparent;
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnProductos
            // 
            resources.ApplyResources(this.btnProductos, "btnProductos");
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(132)))), ((int)(((byte)(164)))));
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.ForeColor = System.Drawing.Color.Transparent;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnNuevacompra
            // 
            resources.ApplyResources(this.btnNuevacompra, "btnNuevacompra");
            this.btnNuevacompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(132)))), ((int)(((byte)(164)))));
            this.btnNuevacompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevacompra.ForeColor = System.Drawing.Color.Transparent;
            this.btnNuevacompra.Name = "btnNuevacompra";
            this.btnNuevacompra.UseVisualStyleBackColor = false;
            this.btnNuevacompra.Click += new System.EventHandler(this.button2_Click);
            // 
            // ts
            // 
            this.ts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(108)))), ((int)(((byte)(164)))));
            resources.ApplyResources(this.ts, "ts");
            this.ts.GripMargin = new System.Windows.Forms.Padding(3);
            this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnInicio,
            this.tbtnHerramientas});
            this.ts.Name = "ts";
            this.ts.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // btnProveedores
            // 
            resources.ApplyResources(this.btnProveedores, "btnProveedores");
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(132)))), ((int)(((byte)(164)))));
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.ForeColor = System.Drawing.Color.Transparent;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click_1);
            // 
            // tbtnInicio
            // 
            this.tbtnInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.tbtnInicio, "tbtnInicio");
            this.tbtnInicio.Name = "tbtnInicio";
            // 
            // tbtnHerramientas
            // 
            this.tbtnHerramientas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.tbtnHerramientas, "tbtnHerramientas");
            this.tbtnHerramientas.Name = "tbtnHerramientas";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnClientes);
            this.flowLayoutPanel1.Controls.Add(this.btnProductos);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.btnNuevacompra);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.btnNuevaventa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.ToolStripDropDownButton tbtnInicio;
        private System.Windows.Forms.ToolStripDropDownButton tbtnHerramientas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

