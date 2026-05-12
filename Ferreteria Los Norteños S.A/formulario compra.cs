using System;
using System.Windows.Forms;

namespace Ferreteria_Los_Norteños_S.A
{
    public partial class formulario_compra : Form
    {
        public formulario_compra()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cboTipoDocumento.SelectedIndex = 0;
        }
    }
}

            lblTipoDocumento = new Label { Text = "Tipo Documento:", Location = new Point(160, 25), AutoSize = true };
            cboTipoDocumento = new ComboBox { Location = new Point(160, 45), Size = new Size(170, 23), DropDownStyle = ComboBoxStyle.DropDownList };
            cboTipoDocumento.Items.AddRange(new object[] { "Boleta", "Factura" });

            gbInfoCompra.Controls.AddRange(new Control[] { lblFecha, txtFecha, lblTipoDocumento, cboTipoDocumento });
            this.Controls.Add(gbInfoCompra);

            // --- GroupBox: Información Proveedor ---
            gbInfoProveedor = new GroupBox { Text = "Información Proveedor", Location = new Point(390, 60), Size = new Size(350, 80) };

            lblProveedor = new Label { Text = "Proveedor:", Location = new Point(15, 25), AutoSize = true };
            txtProveedor = new TextBox { Location = new Point(15, 45), Size = new Size(270, 23) };

            btnBuscarProveedor = new Button { Text = "🔍", Location = new Point(295, 44), Size = new Size(40, 25), Cursor = Cursors.Hand };

            gbInfoProveedor.Controls.AddRange(new Control[] { lblProveedor, txtProveedor, btnBuscarProveedor });
            this.Controls.Add(gbInfoProveedor);

            // --- GroupBox: Información de Producto ---
            gbInfoProducto = new GroupBox { Text = "Información de Producto", Location = new Point(25, 150), Size = new Size(760, 80) };

            lblCodProducto = new Label { Text = "Cod. Producto:", Location = new Point(15, 25), AutoSize = true };
            txtCodProducto = new TextBox { Location = new Point(15, 45), Size = new Size(120, 23) };
            btnBuscarProducto = new Button { Text = "🔍", Location = new Point(145, 44), Size = new Size(35, 25), Cursor = Cursors.Hand };

            lblProducto = new Label { Text = "Producto:", Location = new Point(195, 25), AutoSize = true };
            txtProducto = new TextBox { Location = new Point(195, 45), Size = new Size(200, 23) };

            lblPrecioCompra = new Label { Text = "Precio Compra:", Location = new Point(410, 25), AutoSize = true };
            txtPrecioCompra = new TextBox { Location = new Point(410, 45), Size = new Size(100, 23) };

            lblPrecioVenta = new Label { Text = "Precio Venta:", Location = new Point(525, 25), AutoSize = true };
            txtPrecioVenta = new TextBox { Location = new Point(525, 45), Size = new Size(100, 23) };

            lblCantidad = new Label { Text = "Cantidad:", Location = new Point(640, 25), AutoSize = true };
            nudCantidad = new NumericUpDown { Location = new Point(640, 45), Size = new Size(100, 23), Minimum = 1, Value = 1 };

            gbInfoProducto.Controls.AddRange(new Control[] {
                lblCodProducto, txtCodProducto, btnBuscarProducto,
                lblProducto, txtProducto,
                lblPrecioCompra, txtPrecioCompra,
                lblPrecioVenta, txtPrecioVenta,
                lblCantidad, nudCantidad
            });
            this.Controls.Add(gbInfoProducto);

            // --- Botón Agregar ---
            btnAgregar = new Button();
            btnAgregar.Text = "➕\nAgregar";
            btnAgregar.Location = new Point(800, 155);
            btnAgregar.Size = new Size(100, 75);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.BackColor = Color.White;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.FlatAppearance.BorderColor = Color.LightGray;
            btnAgregar.ForeColor = Color.Green;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(btnAgregar);

            // --- DataGridView ---
            dgvDetalle = new DataGridView();
            dgvDetalle.Location = new Point(25, 245);
            dgvDetalle.Size = new Size(760, 200);
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.BackgroundColor = Color.White;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDetalle.Columns.Add("Producto", "Producto");
            dgvDetalle.Columns.Add("PrecioCompra", "Precio Compra");
            dgvDetalle.Columns.Add("Cantidad", "Cantidad");
            dgvDetalle.Columns.Add("SubTotal", "Sub Total");

            this.Controls.Add(dgvDetalle);

            // --- Total y Registrar ---
            lblTotalPagar = new Label { Text = "Total a Pagar:", Location = new Point(800, 360), AutoSize = true };
            this.Controls.Add(lblTotalPagar);

            txtTotalPagar = new TextBox { Location = new Point(800, 380), Size = new Size(100, 23), ReadOnly = true, Text = "0.00" };
            this.Controls.Add(txtTotalPagar);

            btnRegistrar = new Button();
            btnRegistrar.Text = "🏷️ Registrar";
            btnRegistrar.Location = new Point(800, 410);
            btnRegistrar.Size = new Size(100, 35);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.BackColor = Color.White;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.FlatAppearance.BorderColor = Color.LightGray;
            btnRegistrar.ForeColor = Color.DodgerBlue;
            this.Controls.Add(btnRegistrar);
        }
    }
}
