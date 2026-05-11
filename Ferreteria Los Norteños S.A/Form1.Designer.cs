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
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.PnlBotones = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnNuevaventa = new System.Windows.Forms.Button();
            this.btnNuevacompra = new System.Windows.Forms.Button();
            this.tsbCerrarsesion = new System.Windows.Forms.ToolStripButton();
            this.tssbHerramientas = new System.Windows.Forms.ToolStripSplitButton();
            this.historialDeCréditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContenedor.SuspendLayout();
            this.PnlBotones.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pnlContenedor
            // 
            resources.ApplyResources(this.pnlContenedor, "pnlContenedor");
            this.pnlContenedor.BackColor = System.Drawing.Color.Silver;
            this.pnlContenedor.Controls.Add(this.panel2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // PnlBotones
            // 
            resources.ApplyResources(this.PnlBotones, "PnlBotones");
            this.PnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(108)))), ((int)(((byte)(134)))));
            this.PnlBotones.Controls.Add(this.btnInicio);
            this.PnlBotones.Controls.Add(this.btnProveedores);
            this.PnlBotones.Controls.Add(this.btnClientes);
            this.PnlBotones.Controls.Add(this.btnProductos);
            this.PnlBotones.Controls.Add(this.btnCaja);
            this.PnlBotones.Controls.Add(this.btnNuevaventa);
            this.PnlBotones.Controls.Add(this.btnNuevacompra);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(109)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrarsesion,
            this.tssbHerramientas});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Ferreteria_Los_Norteños_S.A.Properties.Resources.Screenshot_2026_05_07_092929;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(59)))));
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnInicio, "btnInicio");
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(109)))));
            this.btnInicio.ForeColor = System.Drawing.Color.Black;
            this.btnInicio.Image = global::Ferreteria_Los_Norteños_S.A.Properties.Resources.home_icon_home_house_icon_house_icon_free_115535088579crumwqczi__1_;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnProveedores, "btnProveedores");
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
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
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
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
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(109)))));
            this.btnProductos.ForeColor = System.Drawing.Color.Black;
            this.btnProductos.Image = global::Ferreteria_Los_Norteños_S.A.Properties.Resources._2630085__1_;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click_1);
            // 
            // btnCaja
            // 
            this.btnCaja.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnCaja, "btnCaja");
            this.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaja.FlatAppearance.BorderSize = 0;
            this.btnCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(109)))));
            this.btnCaja.ForeColor = System.Drawing.Color.Black;
            this.btnCaja.Image = global::Ferreteria_Los_Norteños_S.A.Properties.Resources._335829__1_;
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnNuevaventa
            // 
            this.btnNuevaventa.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnNuevaventa, "btnNuevaventa");
            this.btnNuevaventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaventa.FlatAppearance.BorderSize = 0;
            this.btnNuevaventa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnNuevaventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(109)))));
            this.btnNuevaventa.ForeColor = System.Drawing.Color.Black;
            this.btnNuevaventa.Image = global::Ferreteria_Los_Norteños_S.A.Properties.Resources.ticket_tag_icon_142958__1_;
            this.btnNuevaventa.Name = "btnNuevaventa";
            this.btnNuevaventa.UseVisualStyleBackColor = false;
            this.btnNuevaventa.Click += new System.EventHandler(this.btnNuevaventa_Click);
            // 
            // btnNuevacompra
            // 
            this.btnNuevacompra.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnNuevacompra, "btnNuevacompra");
            this.btnNuevacompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevacompra.FlatAppearance.BorderSize = 0;
            this.btnNuevacompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.btnNuevacompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(109)))));
            this.btnNuevacompra.ForeColor = System.Drawing.Color.Black;
            this.btnNuevacompra.Image = global::Ferreteria_Los_Norteños_S.A.Properties.Resources._3144456__5_;
            this.btnNuevacompra.Name = "btnNuevacompra";
            this.btnNuevacompra.UseVisualStyleBackColor = false;
            this.btnNuevacompra.Click += new System.EventHandler(this.button2_Click);
            // 
            // tsbCerrarsesion
            // 
            this.tsbCerrarsesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrarsesion.BackColor = System.Drawing.Color.Red;
            this.tsbCerrarsesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCerrarsesion.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tsbCerrarsesion, "tsbCerrarsesion");
            this.tsbCerrarsesion.Name = "tsbCerrarsesion";
            this.tsbCerrarsesion.Click += new System.EventHandler(this.tsbCerrarsesion_Click);
            // 
            // tssbHerramientas
            // 
            this.tssbHerramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDeCréditoToolStripMenuItem});
            resources.ApplyResources(this.tssbHerramientas, "tssbHerramientas");
            this.tssbHerramientas.Name = "tssbHerramientas";
            // 
            // historialDeCréditoToolStripMenuItem
            // 
            this.historialDeCréditoToolStripMenuItem.Name = "historialDeCréditoToolStripMenuItem";
            resources.ApplyResources(this.historialDeCréditoToolStripMenuItem, "historialDeCréditoToolStripMenuItem");
            this.historialDeCréditoToolStripMenuItem.Click += new System.EventHandler(this.historialDeCréditoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.PnlBotones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.PnlBotones.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevacompra;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnNuevaventa;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Panel PnlBotones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCerrarsesion;
        private System.Windows.Forms.ToolStripSplitButton tssbHerramientas;
        private System.Windows.Forms.ToolStripMenuItem historialDeCréditoToolStripMenuItem;
    }
}

