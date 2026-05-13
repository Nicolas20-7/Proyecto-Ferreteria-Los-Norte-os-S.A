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
    public partial class formulario_usuario : Form
    {
        public formulario_usuario()
        {
            InitializeComponent();

            // Configurar columnas de la tabla al iniciar
            if (this.dgvUsuarios != null)
            {
                this.dgvUsuarios.Columns.Add("Documento", "Nro Documento");
                this.dgvUsuarios.Columns.Add("Nombre", "Nombre Completo");
                this.dgvUsuarios.Columns.Add("Correo", "Correo");
                this.dgvUsuarios.Columns.Add("Rol", "Rol");
                this.dgvUsuarios.Columns.Add("Estado", "Estado");
            }

            // Cargar datos de prueba para los ComboBox
            if (this.cboRol != null)
            {
                this.cboRol.Items.Add("Administrador");
                this.cboRol.Items.Add("Empleado");
            }

            if (this.cboEstado != null)
            {
                this.cboEstado.Items.Add("Activo");
                this.cboEstado.Items.Add("No Activo");
            }

            // Opciones de búsqueda
            if (this.cboBuscar != null)
            {
                this.cboBuscar.Items.Add("Documento");
                this.cboBuscar.Items.Add("Nombre");
                this.cboBuscar.Items.Add("Correo");
                this.cboBuscar.SelectedIndex = 0;
            }
        }

        private void pnlIzquierdo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
