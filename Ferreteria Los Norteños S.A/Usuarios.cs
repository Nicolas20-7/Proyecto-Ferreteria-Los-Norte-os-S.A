using GestionProveedoresApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Ferreteria_Los_Norteños_S.A
{
    public partial class Usuarios : Form
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private int nextUserId = 1;

        public Usuarios()
        {
            InitializeComponent();
            ConfigurarGrid();


            button2.Click += Button2_Click;
            button3.Click += Button3_Click; 
            button4.Click += Button4_Click; 
            button5.Click += Button5_Click;
            button1.Click += Button1_Click; 

 
            if (listaUsuarios.Count == 0)
            {
                listaUsuarios.Add(new Usuario { Id = nextUserId++, Nombre = "admin", Contrasena = "admin", Correo = "admin@empresa.com", Activo = true });
                listaUsuarios.Add(new Usuario { Id = nextUserId++, Nombre = "usuario1", Contrasena = "1234", Correo = "user1@empresa.com", Activo = true });
            }

            CargarDatos();
        }

        private void ConfigurarGrid()
        {
            dataGridView1.AutoGenerateColumns = false; 
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

          
            dataGridView1.Columns[0].DataPropertyName = "Id";
            dataGridView1.Columns[1].DataPropertyName = "Contrasena";
            dataGridView1.Columns[2].DataPropertyName = "Nombre";
            dataGridView1.Columns[3].DataPropertyName = "Correo";
            dataGridView1.Columns[4].DataPropertyName = "Activo";
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaUsuarios.Select(u => new {
                u.Id,
                u.Contrasena,
                u.Nombre,
                u.Correo,
                Activo = u.Activo ? "Activo" : "Inactivo"
            }).ToList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form = new nuevo_usuario();
            form.StartPosition = FormStartPosition.CenterParent;
            var result = form.ShowDialog(this);
            if (result == DialogResult.OK && form.CreatedUsuario != null)
            {
                form.CreatedUsuario.Id = nextUserId++;
                listaUsuarios.Add(form.CreatedUsuario);
                CargarDatos();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario para editar.");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var usuario = listaUsuarios.FirstOrDefault(u => u.Id == id);
            if (usuario == null) return;

            var form = new Editar_Usuario(usuario);
            form.StartPosition = FormStartPosition.CenterParent;
            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            listaUsuarios.RemoveAll(u => u.Id == id);
            CargarDatos();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var filtro = textBox1.Text?.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(filtro))
            {
                CargarDatos();
                return;
            }

            var filtrados = listaUsuarios.Where(u => u.Nombre.ToLower().Contains(filtro) || u.Correo.ToLower().Contains(filtro)).ToList();
            dataGridView1.DataSource = filtrados.Select(u => new {
                u.Id,
                u.Contrasena,
                u.Nombre,
                u.Correo,
                Activo = u.Activo ? "Activo" : "Inactivo"
            }).ToList();
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
