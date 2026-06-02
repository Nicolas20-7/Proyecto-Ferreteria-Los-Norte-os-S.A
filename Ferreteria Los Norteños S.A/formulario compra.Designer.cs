namespace Ferreteria_Los_Norteños_S.A
{
    partial class formulario_compra
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulario_compra));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbInfoCompra = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbInfoProveedor = new System.Windows.Forms.GroupBox();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.gbInfoProducto = new System.Windows.Forms.GroupBox();
            this.btnNuevoproducto = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfoCompra.SuspendLayout();
            this.gbInfoProveedor.SuspendLayout();
            this.gbInfoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(378, 31);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.lblTitulo.Size = new System.Drawing.Size(355, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar Compra 💲";
            // 
            // gbInfoCompra
            // 
            this.gbInfoCompra.Controls.Add(this.dateTimePicker1);
            this.gbInfoCompra.Controls.Add(this.cboTipoDocumento);
            this.gbInfoCompra.Controls.Add(this.lblTipoDocumento);
            this.gbInfoCompra.Controls.Add(this.lblFecha);
            this.gbInfoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoCompra.Location = new System.Drawing.Point(-2, 123);
            this.gbInfoCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInfoCompra.Name = "gbInfoCompra";
            this.gbInfoCompra.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInfoCompra.Size = new System.Drawing.Size(517, 116);
            this.gbInfoCompra.TabIndex = 1;
            this.gbInfoCompra.TabStop = false;
            this.gbInfoCompra.Text = "Información Compra";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 54);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cboTipoDocumento.Location = new System.Drawing.Point(269, 52);
            this.cboTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(230, 24);
            this.cboTipoDocumento.TabIndex = 3;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.Location = new System.Drawing.Point(266, 33);
            this.lblTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(125, 16);
            this.lblTipoDocumento.TabIndex = 2;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(19, 32);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 16);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // gbInfoProveedor
            // 
            this.gbInfoProveedor.Controls.Add(this.btnAgregarProveedor);
            this.gbInfoProveedor.Controls.Add(this.btnBuscarProveedor);
            this.gbInfoProveedor.Controls.Add(this.txtProveedor);
            this.gbInfoProveedor.Controls.Add(this.lblProveedor);
            this.gbInfoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProveedor.Location = new System.Drawing.Point(588, 123);
            this.gbInfoProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInfoProveedor.Name = "gbInfoProveedor";
            this.gbInfoProveedor.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInfoProveedor.Size = new System.Drawing.Size(475, 116);
            this.gbInfoProveedor.TabIndex = 2;
            this.gbInfoProveedor.TabStop = false;
            this.gbInfoProveedor.Text = "Información Proveedor";
            this.gbInfoProveedor.Enter += new System.EventHandler(this.gbInfoProveedor_Enter);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(61)))));
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(355, 61);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(100, 34);
            this.btnAgregarProveedor.TabIndex = 3;
            this.btnAgregarProveedor.Text = "Agregar :";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(61)))));
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(355, 23);
            this.btnBuscarProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(100, 32);
            this.btnBuscarProveedor.TabIndex = 2;
            this.btnBuscarProveedor.Text = "Buscar :";
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(19, 54);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(308, 23);
            this.txtProveedor.TabIndex = 1;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(19, 32);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(101, 16);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "Proveedor 🛠️:";
            // 
            // gbInfoProducto
            // 
            this.gbInfoProducto.BackColor = System.Drawing.Color.Transparent;
            this.gbInfoProducto.Controls.Add(this.btnNuevoproducto);
            this.gbInfoProducto.Controls.Add(this.nudCantidad);
            this.gbInfoProducto.Controls.Add(this.lblCantidad);
            this.gbInfoProducto.Controls.Add(this.txtPrecioVenta);
            this.gbInfoProducto.Controls.Add(this.lblPrecioVenta);
            this.gbInfoProducto.Controls.Add(this.txtPrecioCompra);
            this.gbInfoProducto.Controls.Add(this.lblPrecioCompra);
            this.gbInfoProducto.Controls.Add(this.txtProducto);
            this.gbInfoProducto.Controls.Add(this.lblProducto);
            this.gbInfoProducto.Controls.Add(this.btnAgregar);
            this.gbInfoProducto.Controls.Add(this.btnBuscarProducto);
            this.gbInfoProducto.Controls.Add(this.txtCodProducto);
            this.gbInfoProducto.Controls.Add(this.lblCodProducto);
            this.gbInfoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProducto.Location = new System.Drawing.Point(6, 245);
            this.gbInfoProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInfoProducto.Name = "gbInfoProducto";
            this.gbInfoProducto.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbInfoProducto.Size = new System.Drawing.Size(1057, 123);
            this.gbInfoProducto.TabIndex = 3;
            this.gbInfoProducto.TabStop = false;
            this.gbInfoProducto.Text = "Información de Producto";
            // 
            // btnNuevoproducto
            // 
            this.btnNuevoproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(61)))));
            this.btnNuevoproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoproducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoproducto.Location = new System.Drawing.Point(466, 53);
            this.btnNuevoproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevoproducto.Name = "btnNuevoproducto";
            this.btnNuevoproducto.Size = new System.Drawing.Size(142, 24);
            this.btnNuevoproducto.TabIndex = 12;
            this.btnNuevoproducto.Text = "Nuevo Producto :";
            this.btnNuevoproducto.UseVisualStyleBackColor = false;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(892, 52);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(116, 23);
            this.nudCantidad.TabIndex = 10;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(892, 30);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 16);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(751, 52);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(115, 23);
            this.txtPrecioVenta.TabIndex = 8;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(751, 30);
            this.lblPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(100, 16);
            this.lblPrecioVenta.TabIndex = 7;
            this.lblPrecioVenta.Text = "Precio Venta:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(616, 52);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(115, 23);
            this.txtPrecioCompra.TabIndex = 6;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(616, 30);
            this.lblPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(114, 16);
            this.lblPrecioCompra.TabIndex = 5;
            this.lblPrecioCompra.Text = "Precio Compra:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(241, 54);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(217, 23);
            this.txtProducto.TabIndex = 4;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(238, 32);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(73, 16);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Producto:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(937, 81);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 27);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = " Agregar 🛒";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(61)))));
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarProducto.Location = new System.Drawing.Point(135, 52);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(98, 25);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "Buscar :";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(0, 54);
            this.txtCodProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(127, 23);
            this.txtCodProducto.TabIndex = 1;
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProducto.Location = new System.Drawing.Point(-3, 32);
            this.lblCodProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(109, 16);
            this.lblCodProducto.TabIndex = 0;
            this.lblCodProducto.Text = "Cod. Producto:";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvDetalle.Location = new System.Drawing.Point(30, 373);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.Size = new System.Drawing.Size(812, 252);
            this.dgvDetalle.TabIndex = 12;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPagar.Location = new System.Drawing.Point(868, 421);
            this.lblTotalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(134, 17);
            this.lblTotalPagar.TabIndex = 13;
            this.lblTotalPagar.Text = "Total a Pagar 💲:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(871, 450);
            this.txtTotalPagar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(108, 22);
            this.txtTotalPagar.TabIndex = 14;
            this.txtTotalPagar.Text = "0.00";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(870, 495);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(144, 38);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "✔️Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(871, 539);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 38);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar ✖️";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(108)))), ((int)(((byte)(134)))));
            this.textBox6.Location = new System.Drawing.Point(-2, 73);
            this.textBox6.Margin = new System.Windows.Forms.Padding(1);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(1064, 10);
            this.textBox6.TabIndex = 34;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(108)))), ((int)(((byte)(134)))));
            this.textBox5.Location = new System.Drawing.Point(-2, -4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(1061, 32);
            this.textBox5.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Precio Compra";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Precio Venta";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Sub Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // formulario_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 637);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbInfoProveedor);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.gbInfoProducto);
            this.Controls.Add(this.gbInfoCompra);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "formulario_compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Compra";
            this.Load += new System.EventHandler(this.formulario_compra_Load);
            this.gbInfoCompra.ResumeLayout(false);
            this.gbInfoCompra.PerformLayout();
            this.gbInfoProveedor.ResumeLayout(false);
            this.gbInfoProveedor.PerformLayout();
            this.gbInfoProducto.ResumeLayout(false);
            this.gbInfoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbInfoCompra;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.GroupBox gbInfoProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.GroupBox gbInfoProducto;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnNuevoproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
