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
         
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            CreatedUsuario = new Usuario
            {
                Id = 0, 
                Nombre = textBox1.Text?.Trim(),
                Contrasena = textBox2.Text,
                Correo = textBox3.Text?.Trim(),
                
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void nuevo_usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
