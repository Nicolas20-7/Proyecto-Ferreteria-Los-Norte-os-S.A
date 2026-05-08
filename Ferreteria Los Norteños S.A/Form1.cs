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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            RedondearBoton(btnNuevacompra, 13);
            RedondearBoton(btnNuevaventa, 13);
            RedondearBoton(btnCaja, 13);
            RedondearBoton(btnProductos, 13);
            RedondearBoton(btnProveedores, 13);
            RedondearBoton(btnClientes, 13);
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
    private void AbrirFormularioEnPanel(object Form2)
        {

            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);


            Form fh = Form2 as Form;


            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;

            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Form2());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click_1(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnNuevaventa_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Form3());
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbtnInicio_Click(object sender, EventArgs e)
        {

        }

        private void tbtnHerramientas_Click(object sender, EventArgs e)
        {

        }

        private void ts_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
