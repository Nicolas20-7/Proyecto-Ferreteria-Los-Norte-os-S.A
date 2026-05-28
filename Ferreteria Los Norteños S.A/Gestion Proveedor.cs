using GestionProveedoresApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria_Los_Norteños_S.A
{
    public partial class Gestion_Proveedor : Form
    {
        
        private List<Proveedor> listaProveedores = new List<Proveedor>();

        public Gestion_Proveedor()
        {
            InitializeComponent();
            ConfigurarTabla();

            RedondearBoton(btnBuscar, 20);
            RedondearBoton(btnNuevo, 20);
            RedondearBoton(btnEditar, 20);
            RedondearBoton(btnEliminar, 20);



            btnNuevo.Click += btnNuevo_Click;
            btnBuscar.Click += btnBuscar_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click; 
           
            dgvProveedores.CellDoubleClick += dgvProveedores_CellDoubleClick;

         
            listaProveedores.Add(new Proveedor { Id = 1, Nombre = "Proveedor A", Codigo = "A001", Correo = "a@example.com", Telefono = "555-0100", Cedula = "12345678", Direccion = "Calle 1" });
            listaProveedores.Add(new Proveedor { Id = 2, Nombre = "Proveedor B", Codigo = "B002", Correo = "b@example.com", Telefono = "555-0200", Cedula = "87654321", Direccion = "Calle 2" });

            CargarDatos();
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

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}

