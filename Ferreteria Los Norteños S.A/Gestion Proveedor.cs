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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ferreteria_Los_Norteños_S.A
{
    public partial class Gestion_Proveedor : Form 
    {
        private List<Proveedor> listaProveedores = new List<Proveedor>();
        private int? _editingId = null;
       
        public Gestion_Proveedor()
        {
            InitializeComponent();
            ConfigurarTabla();

            RedondearBoton(btnBuscar, 20);
            RedondearBoton(btnGuardar, 20);
            
            RedondearBoton(btnLimpiar, 20);
            




            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;

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
            this.BackColor = Color.White;
            dgvProveedores.AutoGenerateColumns = false; 
        }

        private void CargarDatos()
        {
            
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = listaProveedores.ToList();
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


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor selecciona un proveedor para editar.");
                return;
            }

            var fila = dgvProveedores.SelectedRows[0];
            if (fila.DataBoundItem is Proveedor proveedor)
            {
                
                _editingId = proveedor.Id;
                textBox7.Text = proveedor.Nombre;
                textBox3.Text = proveedor.Codigo; 
                textBox4.Text = proveedor.Telefono;
                textBox5.Text = proveedor.Direccion;
                textBox6.Text = proveedor.Correo;
            }
            else
            {
                MessageBox.Show("No se pudo cargar el proveedor seleccionado.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                var fila = dgvProveedores.SelectedRows[0];
                if (fila.DataBoundItem is Proveedor proveedor)
                {
                    var confirm = MessageBox.Show($"Eliminar proveedor '{proveedor.Nombre}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        listaProveedores.RemoveAll(p => p.Id == proveedor.Id);
                        CargarDatos();
                        MessageBox.Show("Proveedor eliminado con éxito.");
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo determinar el proveedor seleccionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila en la tabla.");
            }
        }

   

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
      
            textBox3.Clear(); // correo/ruc según diseño
            textBox4.Clear(); // telefono
            textBox5.Clear(); // direccion
            textBox6.Clear(); // otro campo
            textBox7.Clear(); // nombre
            _editingId = null;
            CargarDatos();
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvProveedores.Rows[e.RowIndex];
                if (fila.DataBoundItem is Proveedor proveedor)
                {
                    _editingId = proveedor.Id;
                    textBox7.Text = proveedor.Nombre;
                    textBox3.Text = proveedor.Codigo;
                    textBox4.Text = proveedor.Telefono;
                    textBox5.Text = proveedor.Direccion;
                    textBox6.Text = proveedor.Correo;
                }
            }
        }

  
        public Proveedor GetProveedorById(int id)
        {
            return GetById(id);
        }

        public List<Proveedor> GetAll()
        {
            return listaProveedores;
        }

        public Proveedor GetById(int id)
        {
            return listaProveedores.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Proveedor proveedor)
        {
            if (proveedor != null)
            {
                listaProveedores.Add(proveedor);
                CargarDatos();
            }
        }

        public void Update(Proveedor proveedor)
        {
            if (proveedor == null) return;
            int idx = listaProveedores.FindIndex(p => p.Id == proveedor.Id);
            if (idx >= 0)
            {
                listaProveedores[idx] = proveedor;
                CargarDatos();
            }
        }

        public void Remove(int id)
        {
            listaProveedores.RemoveAll(p => p.Id == id);
            CargarDatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gestion_Proveedor_Load(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            var filtro = txtBuscar.Text?.Trim();
            if (string.IsNullOrEmpty(filtro))
            {
                CargarDatos();
                return;
            }
            filtro = filtro.ToLower();
            var filtrados = listaProveedores.Where(p => (!string.IsNullOrEmpty(p.Nombre) && p.Nombre.ToLower().Contains(filtro)) ||
                                                       (!string.IsNullOrEmpty(p.Codigo) && p.Codigo.ToLower().Contains(filtro))).ToList();
            dgvProveedores.DataSource = filtrados;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Validaciones básicas
            var nombre = textBox7.Text?.Trim();
            var ruc = textBox3.Text?.Trim();
            var telefono = textBox4.Text?.Trim();
            var direccion = textBox5.Text?.Trim();
            var correo = textBox6.Text?.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre del proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox7.Focus();
                return;
            }
            if (string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Ingrese el teléfono del proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(correo))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(correo);
                    // opcion: verificar que la dirección contenga nombre y dominio
                    if (string.IsNullOrWhiteSpace(addr.Address) || !addr.Address.Contains("@"))
                    {
                        throw new FormatException();
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese un correo electrónico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox6.Focus();
                    return;
                }
            }

            if (_editingId.HasValue)
            {
              
                var existing = listaProveedores.FirstOrDefault(p => p.Id == _editingId.Value);
                if (existing != null)
                {
                    existing.Nombre = nombre;
                    existing.Codigo = string.IsNullOrEmpty(ruc) ? existing.Codigo : ruc;
                    existing.Telefono = telefono;
                    existing.Direccion = direccion;
                    existing.Correo = correo;
                    Update(existing);
                    MessageBox.Show("Proveedor actualizado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                _editingId = null;
            }
            else
            {
         
                var nuevoId = listaProveedores.Any() ? listaProveedores.Max(p => p.Id) + 1 : 1;
                var codigoFinal = string.IsNullOrEmpty(ruc) ? GenerarRUCUnico() : ruc;
                var nuevo = new Proveedor
                {
                    Id = nuevoId,
                    Nombre = nombre,
                    Codigo = codigoFinal,
                    Telefono = telefono,
                    Direccion = direccion,
                    Correo = correo
                };
                listaProveedores.Add(nuevo);
                CargarDatos();
                MessageBox.Show("Proveedor agregado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

    
            btnLimpiar_Click(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
               e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            formulario_ayuda ayuda = new formulario_ayuda();
            ayuda.Show();
        }   
    }
}

