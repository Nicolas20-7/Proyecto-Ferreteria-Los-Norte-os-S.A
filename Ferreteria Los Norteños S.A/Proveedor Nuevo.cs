using GestionProveedoresApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria_Los_Norteños_S.A
{
    public partial class Proveedor_Nuevo : Form
    {
        public Proveedor CreatedProveedor { get; private set; }

        public Proveedor_Nuevo()
        {
            InitializeComponent();

            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += BtnCancelar_Click;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Crear nuevo proveedor desde los campos
            CreatedProveedor = new Proveedor
            {
                Id = new Random().Next(1000, 9999),
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                Telefono = txtNumero.Text,
                Cedula = txtCedula.Text,
                Direccion = txtDireccion.Text,
                Codigo = "" // Se generará en Gestion_Proveedor
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
