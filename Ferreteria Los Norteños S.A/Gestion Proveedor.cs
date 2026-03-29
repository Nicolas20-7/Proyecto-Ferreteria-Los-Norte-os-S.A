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
    public partial class Gestion_Proveedor : Form
    {
        private static List<Proveedor> listaProveedores = new List<Proveedor>()
        {
            new Proveedor{ Id = 1 , Nombre = " ladriyeria la paz centro", Correo = "enmanuel@gmail.com" , Telefono = "5861-2360" , Cedula = "020205-012p" , Direccion = "carretera a managua"},
            new Proveedor{ Id = 1 , Nombre = " ferromac", Correo = "bernaldo@gmail.com" , Telefono = "8888-5698" , Cedula = "0002-50k" , Direccion = "carretera a jinotega"}
        };

        public Gestion_Proveedor()
        {
            InitializeComponent();
            ConfigurarTabla();
            CargarDatos();
        }

        private void ConfigurarTabla()
        {
            dgvProveedores.ReadOnly = true;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.BackColor = Color.Gray; // Color de fondo como tu imagen
        }

        private void CargarDatos()
        {
            // Forzamos la actualización de la tabla
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = listaProveedores;
        }

        // --- EVENTOS DE LOS BOTONES ---

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Aquí llamarías a tu segundo formulario
            MessageBox.Show("Abriendo formulario de Nuevo Proveedor...");
            // Ejemplo:
            // var frm = new Proveedor_Nuevo();
            // if(frm.ShowDialog() == DialogResult.OK) CargarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();
            var filtrados = listaProveedores.Where(p => p.Nombre.ToLower().Contains(filtro)).ToList();
            dgvProveedores.DataSource = filtrados;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                var id = (int)dgvProveedores.SelectedRows[0].Cells["Id"].Value;
                listaProveedores.RemoveAll(p => p.Id == id);
                CargarDatos();
                MessageBox.Show("Proveedor eliminado con éxito.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila en la tabla.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // --- CLASE MODELO ---
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
    }
}

