using GestionProveedoresApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Ferreteria_Los_Norteños_S.A
{
    public partial class Usuarios : Form
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private int nextUserId = 1;
        private int editingUserId = -1;
       

        public Usuarios()
        {
            InitializeComponent();
            ConfigurarGrid();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (btnGuardar != null) btnGuardar.Click += btnGuardar_Click;
            if (btnEditar != null) btnEditar.Click += btnEditar_Click;
            if (btnEliminar != null) btnEliminar.Click += btnEliminar_Click;
            if (btnLimpiar != null) btnLimpiar.Click += btnLimpiar_Click;
            if (btnBuscar != null) btnBuscar.Click += Button1_Click;
          

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            if (btnLimpiar != null) RedondearBoton(btnLimpiar, 20);
            if (btnGuardar != null) RedondearBoton(btnGuardar, 20);
            if (btnBuscar != null) RedondearBoton(btnBuscar, 20);
            if (btnEditar != null) RedondearBoton(btnEditar, 20);
          

            if (listaUsuarios.Count == 0)
            {
                listaUsuarios.Add(new Usuario { Id = nextUserId++, Nombre = "admin", Username = "admin", Contrasena = "admin", Correo = "admin@empresa.com", Rol = "Gerente", Activo = true });
                listaUsuarios.Add(new Usuario { Id = nextUserId++, Nombre = "usuario1", Username = "usuario1", Contrasena = "1234", Correo = "user1@empresa.com", Rol = "Empleado", Activo = true });
            }

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

        private void ConfigurarGrid()
        {
            dataGridView1.AutoGenerateColumns = false; 
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            
         
            if (dataGridView1.Columns.Count < 6)
            {
                dataGridView1.Columns.Clear();

                var colNombre = new DataGridViewTextBoxColumn { Name = "colNombre", HeaderText = "Nombre", DataPropertyName = "Nombre" };
                var colUsername = new DataGridViewTextBoxColumn { Name = "colUsername", HeaderText = "Usuario", DataPropertyName = "Username" };
                var colCorreo = new DataGridViewTextBoxColumn { Name = "colCorreo", HeaderText = "Correo", DataPropertyName = "Correo" };
                var colRol = new DataGridViewTextBoxColumn { Name = "colRol", HeaderText = "Rol", DataPropertyName = "Rol" };
                var colActivo = new DataGridViewTextBoxColumn { Name = "colActivo", HeaderText = "Estado", DataPropertyName = "Activo" };
                var colId = new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "Id", DataPropertyName = "Id", Visible = false };
                var colEditar = new DataGridViewButtonColumn { Name = "colEditar", HeaderText = "", Text = "Editar", UseColumnTextForButtonValue = true, DataPropertyName = "" };
                var colEliminar = new DataGridViewButtonColumn { Name = "colEliminar", HeaderText = "", Text = "Eliminar", UseColumnTextForButtonValue = true, DataPropertyName = "" };

                dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNombre, colUsername, colCorreo, colRol, colActivo, colId, colEditar, colEliminar });
            }
            else
            {
                dataGridView1.Columns[0].DataPropertyName = "Nombre"; 
                dataGridView1.Columns[1].DataPropertyName = "Username";
                dataGridView1.Columns[2].DataPropertyName = "Correo"; 
                dataGridView1.Columns[3].DataPropertyName = "Rol"; 
                dataGridView1.Columns[4].DataPropertyName = "Activo"; 
                dataGridView1.Columns[5].DataPropertyName = "Id"; 
                dataGridView1.Columns[5].Visible = true;
              
            }
        }

        private void CargarDatos()
        {
            // Asegurar que las columnas botón usen el texto definido
            var editarCol = dataGridView1.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Name == "colEditar") as DataGridViewButtonColumn;
            var eliminarCol = dataGridView1.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.Name == "colEliminar") as DataGridViewButtonColumn;
            if (editarCol != null) editarCol.UseColumnTextForButtonValue = true;
            if (eliminarCol != null) eliminarCol.UseColumnTextForButtonValue = true;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaUsuarios.Select(u => new {
                u.Nombre,
                u.Username,
                u.Correo,
                u.Rol,
                Activo = u.Activo ? "Activo" : "Inactivo",
                u.Id
            }).ToList();

            // Forzar explícitamente el texto de los botones en cada fila (sobrescribe valores numéricos)
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (editarCol != null && dataGridView1.Columns.Contains("colEditar")) row.Cells["colEditar"].Value = editarCol.Text ?? "Editar";
                if (eliminarCol != null && dataGridView1.Columns.Contains("colEliminar")) row.Cells["colEliminar"].Value = eliminarCol.Text ?? "Eliminar";
            }
            dataGridView1.Refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
         
            string nombre = textBox7.Text?.Trim();
            string username = textBox4.Text?.Trim();
            string contrasena = textBox5.Text?.Trim();
            string correo = textBox6.Text?.Trim();
            string rol = comboBox1.SelectedItem as string ?? comboBox1.Text;
            string estado = comboBox2.SelectedItem as string ?? comboBox2.Text;

            if (string.IsNullOrWhiteSpace(nombre)) { MessageBox.Show("El nombre es obligatorio."); textBox7.Focus(); return; }
            if (string.IsNullOrWhiteSpace(username)) { MessageBox.Show("El usuario es obligatorio."); textBox4.Focus(); return; }
            if (string.IsNullOrWhiteSpace(contrasena) || contrasena.Length < 4) { MessageBox.Show("La contraseña debe tener al menos 4 caracteres."); textBox5.Focus(); return; }
            if (string.IsNullOrWhiteSpace(correo) || !correo.Contains("@")) { MessageBox.Show("Introduce un correo válido."); textBox6.Focus(); return; }
            if (string.IsNullOrWhiteSpace(rol)) { MessageBox.Show("Selecciona un rol."); comboBox1.Focus(); return; }

            bool activo = string.Equals(estado, "Activo", StringComparison.OrdinalIgnoreCase);

            if (editingUserId == -1)
            {
             
                var u = new Usuario
                {
                    Id = nextUserId++,
                    Nombre = nombre,
                    Username = username,
                    Contrasena = contrasena,
                    Correo = correo,
                    Rol = rol,
                    Activo = activo
                };
                listaUsuarios.Add(u);
                MessageBox.Show("Usuario agregado correctamente.");
            }
            else
            {
                
                var u = listaUsuarios.FirstOrDefault(x => x.Id == editingUserId);
                if (u != null)
                {
                    u.Nombre = nombre;
                    u.Username = username;
                    u.Contrasena = contrasena;
                    u.Correo = correo;
                    u.Rol = rol;
                    u.Activo = activo;
                    MessageBox.Show("Usuario actualizado correctamente.");
                }
            }

            ClearFields();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario de la lista para editar.");
                return;
            }
          
            dataGridView1_SelectionChanged(this, EventArgs.Empty);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);
            var usuario = listaUsuarios.FirstOrDefault(u => u.Id == id);
            if (usuario == null) return;

            var confirm = MessageBox.Show($"¿Eliminar al usuario '{usuario.Nombre}'?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                listaUsuarios.RemoveAll(u => u.Id == id);
                ClearFields();
                CargarDatos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClearFields();
            editingUserId = -1;
            textBox7.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var filtro = textBox1.Text?.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(filtro))
            {
                CargarDatos();
                return;
            }

            var filtrados = listaUsuarios.Where(u => u.Nombre.ToLower().Contains(filtro) || u.Correo.ToLower().Contains(filtro) || (u.Username??"").ToLower().Contains(filtro)).ToList();
            dataGridView1.DataSource = filtrados.Select(u => new {
                u.Nombre,
                u.Username,
                u.Correo,
                u.Rol,
                Activo = u.Activo ? "Activo" : "Inactivo",
                u.Id
            }).ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            var row = dataGridView1.SelectedRows[0];

            object idObj = null;
            if (row.DataBoundItem != null)
            {
                var prop = row.DataBoundItem.GetType().GetProperty("Id");
                if (prop != null) idObj = prop.GetValue(row.DataBoundItem);
            }
            if (idObj == null && row.Cells.Count > 5) idObj = row.Cells[5].Value;

            if (idObj == null || !int.TryParse(idObj.ToString(), out int id))
            {
                MessageBox.Show("Id no disponible o inválido.");
                return;
            }

            var u = listaUsuarios.FirstOrDefault(x => x.Id == id);
            if (u == null) return;

            editingUserId = u.Id;
            textBox7.Text = u.Nombre;
            textBox4.Text = u.Username;
            textBox5.Text = u.Contrasena;
            textBox6.Text = u.Correo;
            comboBox1.SelectedItem = u.Rol;
            comboBox2.SelectedItem = u.Activo ? "Activo" : "Inactivo";
        }

        private void ClearFields()
        {
            editingUserId = -1;
            textBox7.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dataGridView1.ClearSelection();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ayuda ayuda = new ayuda();
            ayuda.Show();
        }
    }
}
