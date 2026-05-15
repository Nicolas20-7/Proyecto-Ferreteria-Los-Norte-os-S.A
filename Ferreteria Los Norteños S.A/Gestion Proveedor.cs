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
        // Lista de proveedores manejada por el formulario
        private List<Proveedor> listaProveedores = new List<Proveedor>();

        public Gestion_Proveedor()
        {
            InitializeComponent();
            ConfigurarTabla();

            // Asociar manejadores de eventos de botones (si no están asignados en el diseñador)
            btnNuevo.Click += btnNuevo_Click;
            btnBuscar.Click += btnBuscar_Click;
            btnEditar.Click += btnEditar_Click;
            button3.Click += btnEliminar_Click; // button3 es Eliminar en el diseñador
           
            dgvProveedores.CellDoubleClick += dgvProveedores_CellDoubleClick;

            // Cargar datos de ejemplo
            listaProveedores.Add(new Proveedor { Id = 1, Nombre = "Proveedor A", Codigo = "A001", Correo = "a@example.com", Telefono = "555-0100", Cedula = "12345678", Direccion = "Calle 1" });
            listaProveedores.Add(new Proveedor { Id = 2, Nombre = "Proveedor B", Codigo = "B002", Correo = "b@example.com", Telefono = "555-0200", Cedula = "87654321", Direccion = "Calle 2" });

            CargarDatos();
        }

        private void ConfigurarTabla()
        {
            dgvProveedores.ReadOnly = true;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.BackColor = Color.Gray;
        }

        private void CargarDatos()
        {
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = listaProveedores.Select(p => new
            {
                p.Id,
                p.Nombre,
                p.Codigo,
                Correo = p.Correo,
                Telefono = p.Telefono,
           
                Direccion = p.Direccion
            }).ToList();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = new Proveedor_Nuevo();
            form.Owner = this;
            if (form.ShowDialog() == DialogResult.OK && form.CreatedProveedor != null)
            {
                // Generar RUC único
                form.CreatedProveedor.Codigo = GenerarRUCUnico();
                listaProveedores.Add(form.CreatedProveedor);
                CargarDatos();
            }
        }

        private string GenerarRUCUnico()
        {
            Random rand = new Random();
            string ruc;
            do
            {
                ruc = rand.Next(100000000, 999999999).ToString();
            } while (listaProveedores.Any(p => p.Codigo == ruc));
            return ruc;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();
            var filtrados = listaProveedores.Where(p => (!string.IsNullOrEmpty(p.Nombre) && p.Nombre.ToLower().Contains(filtro)) ||
                                                       (!string.IsNullOrEmpty(p.Codigo) && p.Codigo.ToLower().Contains(filtro))).ToList();
            dgvProveedores.DataSource = filtrados.Select(p => new
            {
                p.Id,
                p.Nombre,
                p.Codigo,
                Correo = p.Correo,
                Telefono = p.Telefono,
                Direccion = p.Direccion
            }).ToList();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor selecciona un proveedor para editar.");
                return;
            }

            int id = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells["Id"].Value);
            var proveedor = listaProveedores.FirstOrDefault(p => p.Id == id);
            if (proveedor == null)
            {
                MessageBox.Show("Proveedor no encontrado.");
                return;
            }

            var editarForm = new Editar_Proveedor(proveedor.Id);
            editarForm.Owner = this;
            if (editarForm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
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

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abrir edición al hacer doble click en una fila
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvProveedores.Rows[e.RowIndex].Cells["Id"].Value);
                var editarForm = new Editar_Proveedor(id);
                editarForm.Owner = this;
                if (editarForm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
        }

        // Helper para que Editar_Proveedor pueda obtener el proveedor
        public Proveedor GetProveedorById(int id)
        {
            return listaProveedores.FirstOrDefault(p => p.Id == id);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gestion_Proveedor_Load(object sender, EventArgs e)
        {

        }
    }
}

