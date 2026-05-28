using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Ferreteria_Los_Norteños_S.A
{
    public partial class formulario_compra : Form
    {
        public formulario_compra()
        {
            InitializeComponent();
            ConfigurarFormulario();

            RedondearBoton(btnBuscarProducto, 20);
            RedondearBoton(btnNuevoproducto, 20);
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

        private void formulario_compra_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
