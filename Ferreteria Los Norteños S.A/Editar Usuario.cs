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
    public partial class Editar_Usuario : Form
    {
        private Usuario usuario;

        public Editar_Usuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            // Cargar datos
            textBox1.Text = usuario?.Nombre;
            textBox2.Text = usuario?.Contrasena;
            textBox3.Text = usuario?.Correo;
            checkBox2.Checked = usuario?.Activo ?? false;

            // Asignar eventos
            button1.Click += Button1_Click; // Guardar
            button2.Click += Button2_Click; // Cancelar
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                // Actualizar usuario existente
                usuario.Nombre = textBox1.Text?.Trim();
                usuario.Contrasena = textBox2.Text;
                usuario.Correo = textBox3.Text?.Trim();
                usuario.Activo = checkBox2.Checked;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
