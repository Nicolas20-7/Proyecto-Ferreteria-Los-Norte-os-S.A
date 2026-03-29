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
            this.BackColor = Color.Gray; 
        }

        private void CargarDatos()
        {
            
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = listaProveedores;
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Abriendo formulario de Nuevo Proveedor...");
       
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

   
}

