using GestionProveedoresApp;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ferreteria_Los_Norteños_S.A
{
    public partial class Proveedor_Nuevo : Form
    {
        public Proveedor CreatedProveedor { get; private set; }

        public Proveedor_Nuevo()
        {
            InitializeComponent();
            this.button1.Click += BtnGuardar_Click;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var nombre = textBox1.Text?.Trim();
            var correo = textBox3.Text?.Trim();
            var telefono = textBox6.Text?.Trim();
            var direccion = textBox4.Text?.Trim();

            // Validaciones simples
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre del proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Ingrese el teléfono del proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(correo) && !Regex.IsMatch(correo, "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$"))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            CreatedProveedor = new Proveedor
            {
                Id = new Random().Next(1000, 9999),
                Nombre = nombre,
                Correo = correo,
                Telefono = telefono,
                Direccion = direccion,
                Codigo = "" // Se generará en Gestion_Proveedor si es necesario
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Proveedor_Nuevo_Load(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
    }
}
