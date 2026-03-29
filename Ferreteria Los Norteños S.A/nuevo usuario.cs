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
    public partial class nuevo_usuario : Form
    {
        public Usuario CreatedUsuario { get; private set; }

        public nuevo_usuario()
        {
            InitializeComponent();
            // Wire up cancel button (designer does not have handler)
            button2.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Guardar nuevo usuario
            CreatedUsuario = new Usuario
            {
                Id = 0, // será asignado por el formulario padre
                Nombre = textBox1.Text?.Trim(),
                Contrasena = textBox2.Text,
                Correo = textBox3.Text?.Trim(),
                Activo = checkBox2.Checked
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
