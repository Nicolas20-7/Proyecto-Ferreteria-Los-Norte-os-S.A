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
            // Conectar el evento al botón creado por el diseñador (button1)
            this.button1.Click += BtnGuardar_Click;
  
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Crear nuevo proveedor desde los campos del diseñador (textBox1..)
            CreatedProveedor = new Proveedor
            {
                Id = new Random().Next(1000, 9999),
                Nombre = textBox1.Text,
                Correo = textBox3.Text,
                Telefono = textBox6.Text,
                Direccion = textBox4.Text,
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
