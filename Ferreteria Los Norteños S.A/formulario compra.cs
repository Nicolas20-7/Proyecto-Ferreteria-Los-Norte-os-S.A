using System;
using System.Windows.Forms;

namespace Ferreteria_Los_Norteños_S.A
{
    public partial class formulario_compra : Form
    {
        public formulario_compra()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
        
            if (this.dateTimePicker1 != null)
            {
                this.dateTimePicker1.Value = DateTime.Now;
            }

 
            if (this.cboTipoDocumento != null && this.cboTipoDocumento.Items.Count > 0)
            {
                this.cboTipoDocumento.SelectedIndex = 0;
            }
        }

        private void gbInfoProveedor_Enter(object sender, EventArgs e)
        {

        }
    }
}
