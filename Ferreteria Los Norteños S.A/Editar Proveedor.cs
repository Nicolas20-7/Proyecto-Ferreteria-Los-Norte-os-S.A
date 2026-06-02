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
    public partial class Editar_Proveedor : Form
    {
        private int proveedorId;

        public Editar_Proveedor(int id)
        {
            InitializeComponent();
            proveedorId = id;

            // Asociar eventos de botones
            button1.Click += Button1_Click; // Guardar

            // Cargar datos si se encuentra (en este ejemplo buscamos en el propietario si es Gestion_Proveedor)
            LoadProveedorData();
        }

        private void LoadProveedorData()
        {
            if (this.Owner is Gestion_Proveedor parent)
            {
                var proveedor = parent.GetProveedorById(proveedorId);
                if (proveedor != null)
                {
                    textBox1.Text = proveedor.Nombre;
                    textBox3.Text = proveedor.Correo;
                    textBox4.Text = proveedor.Telefono;
                    textBox5.Text = proveedor.Direccion;
                   
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Guardar cambios en el proveedor en el formulario padre
            if (this.Owner is Gestion_Proveedor parent)
            {
                var proveedor = parent.GetProveedorById(proveedorId);
                if (proveedor != null)
                {
                    proveedor.Nombre = textBox1.Text;
                    proveedor.Correo = textBox3.Text;
                    proveedor.Telefono = textBox4.Text;
                    proveedor.Direccion = textBox5.Text;
                 
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
