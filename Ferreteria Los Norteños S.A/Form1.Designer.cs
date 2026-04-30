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
            this.ts = new System.Windows.Forms.ToolStrip();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.PnlBotones = new System.Windows.Forms.Panel();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnNuevaventa = new System.Windows.Forms.Button();
            this.btnNuevacompra = new System.Windows.Forms.Button();
            this.tbtnInicio = new System.Windows.Forms.ToolStripDropDownButton();
            this.tbtnHerramientas = new System.Windows.Forms.ToolStripDropDownButton();
            this.ts.SuspendLayout();
            this.PnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            // pnlContenedor
            // 
            resources.ApplyResources(this.pnlContenedor, "pnlContenedor");
            this.pnlContenedor.Name = "pnlContenedor";
            // 
            // PnlBotones
            // 
            resources.ApplyResources(this.PnlBotones, "PnlBotones");
            this.PnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            this.PnlBotones.Controls.Add(this.btnProveedores);
            this.PnlBotones.Controls.Add(this.btnClientes);
            this.PnlBotones.Controls.Add(this.btnProductos);
            this.PnlBotones.Controls.Add(this.btnCaja);
            this.PnlBotones.Controls.Add(this.btnNuevaventa);
            this.PnlBotones.Controls.Add(this.btnNuevacompra);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnProveedores, "btnProveedores");
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(109)))));
            this.btnProveedores.ForeColor = System.Drawing.Color.Black;
            this.btnProveedores.Image = global::Ferreteria_Los_Norteños_S.A.Properties.Resources._664468__1_;
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnClientes, "btnClientes");
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(109)))));
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.Image = global::Ferreteria_Los_Norteños_S.A.Properties.Resources._6522581__1_;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnProductos, "btnProductos");
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(109)))));
            this.btnProductos.ForeColor = System.Drawing.Color.Black;
            this.btnProductos.Image = global::Ferreteria_Los_Norteños_S.A.Properties.Resources._2630085__1_;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnCaja
            // 
            this.btnCaja.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnCaja, "btnCaja");
            this.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaja.FlatAppearance.BorderSize = 0;
            this.btnCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            this.btnCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(109)))));
            this.btnCaja.ForeColor = System.Drawing.Color.Black;
            this.btnCaja.Image = global::Ferreteria_Los_Norteños_S.A.Properties.Resources._335829__1_;
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.UseVisualStyleBackColor = false;
            // 
            // btnNuevaventa
            // 
            this.btnNuevaventa.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnNuevaventa, "btnNuevaventa");
            this.btnNuevaventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaventa.FlatAppearance.BorderSize = 0;
            this.btnNuevaventa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            this.btnNuevaventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(109)))));
            this.btnNuevaventa.ForeColor = System.Drawing.Color.Black;
            this.btnNuevaventa.Image = global::Ferreteria_Los_Norteños_S.A.Properties.Resources.ticket_tag_icon_142958__1_;
            this.btnNuevaventa.Name = "btnNuevaventa";
            this.btnNuevaventa.UseVisualStyleBackColor = false;
            // 
            // btnNuevacompra
            // 
            this.btnNuevacompra.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnNuevacompra, "btnNuevacompra");
            this.btnNuevacompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevacompra.FlatAppearance.BorderSize = 0;
            this.btnNuevacompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            this.btnNuevacompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(109)))));
            this.btnNuevacompra.ForeColor = System.Drawing.Color.Black;
            this.btnNuevacompra.Image = global::Ferreteria_Los_Norteños_S.A.Properties.Resources._3144456__5_;
            this.btnNuevacompra.Name = "btnNuevacompra";
            this.btnNuevacompra.UseVisualStyleBackColor = false;
            this.btnNuevacompra.Click += new System.EventHandler(this.button2_Click);
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
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.PnlBotones);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.PnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevacompra;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripDropDownButton tbtnInicio;
        private System.Windows.Forms.ToolStripDropDownButton tbtnHerramientas;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnNuevaventa;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Panel PnlBotones;
    }
}

