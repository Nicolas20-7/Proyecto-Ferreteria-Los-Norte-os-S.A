using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Ferreteria_Los_Norteños_S.A
{
    public partial class formulario_compra : Form
    {
        // In-memory stores for demo purposes (no DB). Keys: product code / provider id
        private readonly Dictionary<string, (string Nombre, decimal PrecioCompra, decimal PrecioVenta)> _productos;
        private readonly Dictionary<string, string> _proveedores;
        private string _currentProveedorId;


        public formulario_compra()
        {
            InitializeComponent();
            ConfigurarFormulario();

            // inicializar almacenes en memoria con algunos datos de ejemplo
            _productos = new Dictionary<string, (string, decimal, decimal)>(StringComparer.OrdinalIgnoreCase)
            {
                { "1001", ("Martillo", 10.50m, 15.00m) },
                { "1002", ("Destornillador", 5.75m, 9.50m) }
            };

            _proveedores = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "P001", "Proveedor Demo" }
            };

            // Asignar manejadores básicos
            btnBuscarProducto.Click += BtnBuscarProducto_Click;
            btnNuevoproducto.Click += BtnNuevoProducto_Click;
            btnAgregar.Click += BtnAgregar_Click;
            btnBuscarProveedor.Click += BtnBuscarProveedor_Click;
            btnAgregarProveedor.Click += BtnAgregarProveedor_Click;
            btnRegistrar.Click += BtnRegistrar_Click;
            btnCancelar.Click += BtnCancelar_Click;

            RedondearBoton(btnBuscarProducto, 20);
            RedondearBoton(btnNuevoproducto, 20);
            RedondearBoton(btnAgregar, 20);
            RedondearBoton(btnAgregarProveedor, 20);
            RedondearBoton(btnBuscarProveedor, 20);
            RedondearBoton(btnRegistrar, 20);
            RedondearBoton(btnCancelar, 20);
        }

        private void RedondearBoton(Button btn, int radio)
        {
            GraphicsPath ruta = new GraphicsPath();


            ruta.AddArc(0, 0, radio, radio, 180, 90);
            ruta.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
            ruta.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
            ruta.AddArc(0, btn.Height - radio, radio, radio, 90, 90);

            ruta.CloseAllFigures();


            btn.Region = new Region(ruta);
        }

        private void ConfigurarFormulario()
        {

            if (this.dateTimePicker1 != null)
            {
                this.dateTimePicker1.Value = DateTime.Now;
            }


            if (this.cboTipoDocumento != null && this.cboTipoDocumento.Items.Count > 0)
            {
                this.cboTipoDocumento.SelectedIndex = 0;
            }
        }

        private void gbInfoProveedor_Enter(object sender, EventArgs e)
        {

        }

        private void formulario_compra_Load(object sender, EventArgs e)
        {

        }

        // Eventos implementados
        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            var codigo = txtCodProducto.Text?.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese el código del producto para buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodProducto.Focus();
                return;
            }

            if (_productos.TryGetValue(codigo, out var info))
            {
                txtProducto.Text = info.Nombre;
                txtPrecioCompra.Text = info.PrecioCompra.ToString("F2", CultureInfo.InvariantCulture);
                txtPrecioVenta.Text = info.PrecioVenta.ToString("F2", CultureInfo.InvariantCulture);
                nudCantidad.Value = 1;
            }
            else
            {
                MessageBox.Show("Producto no encontrado. Puede crearlo con 'Nuevo Producto'.", "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnNuevoProducto_Click(object sender, EventArgs e)
        {
            var codigo = txtCodProducto.Text?.Trim();
            var nombre = txtProducto.Text?.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese un código para el nuevo producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodProducto.Focus();
                return;
            }
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre del producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var pc) || pc <= 0)
            {
                MessageBox.Show("Precio compra inválido. Ingrese un número mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCompra.Focus();
                return;
            }
            if (!decimal.TryParse(txtPrecioVenta.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var pv) || pv <= 0)
            {
                MessageBox.Show("Precio venta inválido. Ingrese un número mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioVenta.Focus();
                return;
            }

            _productos[codigo] = (nombre, pc, pv);
            MessageBox.Show("Producto agregado correctamente.", "Nuevo Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrEmpty(_currentProveedorId))
            {
                MessageBox.Show("Seleccione o agregue un proveedor antes de agregar productos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var codigo = txtCodProducto.Text?.Trim();
            var nombre = txtProducto.Text?.Trim();
            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Complete código y nombre del producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var pc) || pc < 0)
            {
                MessageBox.Show("Precio compra inválido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCompra.Focus();
                return;
            }
            if (!decimal.TryParse(txtPrecioVenta.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var pv) || pv < 0)
            {
                MessageBox.Show("Precio venta inválido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioVenta.Focus();
                return;
            }

            var cantidad = (int)nudCantidad.Value;
            var subtotal = pc * cantidad;

            dgvDetalle.Rows.Add(nombre, pc.ToString("F2", CultureInfo.InvariantCulture), pv.ToString("F2", CultureInfo.InvariantCulture), cantidad.ToString(), subtotal.ToString("F2", CultureInfo.InvariantCulture));

            UpdateTotal();

            // Limpiar campos de producto para nueva entrada
            txtCodProducto.Clear();
            txtProducto.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            nudCantidad.Value = 1;
        }

        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            var texto = txtProveedor.Text?.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Ingrese el ID o nombre del proveedor para buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProveedor.Focus();
                return;
            }

            // Si coincide con un id
            if (_proveedores.TryGetValue(texto, out var nombre))
            {
                txtProveedor.Text = nombre;
                _currentProveedorId = texto;
                MessageBox.Show("Proveedor seleccionado: " + nombre, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Buscar por nombre
            foreach (var kv in _proveedores)
            {
                if (string.Equals(kv.Value, texto, StringComparison.OrdinalIgnoreCase))
                {
                    _currentProveedorId = kv.Key;
                    MessageBox.Show("Proveedor seleccionado: " + kv.Value, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Proveedor no encontrado.", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            var nombre = txtProveedor.Text?.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre del proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProveedor.Focus();
                return;
            }

            // Crear id sencillo
            var nextId = "P" + (_proveedores.Count + 1).ToString("D3");
            _proveedores[nextId] = nombre;
            _currentProveedorId = nextId;
            MessageBox.Show($"Proveedor agregado. ID: {nextId}", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto a la compra antes de registrar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(_currentProveedorId))
            {
                MessageBox.Show("Seleccione un proveedor antes de registrar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // En una app real aquí se guardaría en BD. Para demo solo limpiar y confirmar.
            MessageBox.Show("Compra registrada correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("¿Desea cancelar la operación y limpiar el formulario?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                LimpiarFormulario();
            }
        }

        private void UpdateTotal()
        {
            decimal total = 0m;
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells.Count >= 5 && decimal.TryParse(Convert.ToString(row.Cells[4].Value), NumberStyles.Number, CultureInfo.InvariantCulture, out var sub))
                {
                    total += sub;
                }
            }
            txtTotalPagar.Text = total.ToString("F2", CultureInfo.InvariantCulture);
        }

        private void LimpiarFormulario()
        {
            txtProveedor.Clear();
            _currentProveedorId = null;
            txtCodProducto.Clear();
            txtProducto.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            nudCantidad.Value = 1;
            dgvDetalle.Rows.Clear();
            txtTotalPagar.Text = "0.00";
            cboTipoDocumento.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ayuda ayuda = new ayuda();
            ayuda.Show();

        }
    }
}
