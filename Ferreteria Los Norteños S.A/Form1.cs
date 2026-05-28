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
            
            RedondearBoton(btnNuevacompra, 20);
            RedondearBoton(btnNuevaventa, 20);
            RedondearBoton(btnCaja, 20);
            RedondearBoton(btnProductos, 20);
            RedondearBoton(btnProveedores, 20);
            RedondearBoton(btnClientes, 20);
            RedondearBoton(btnInicio, 20);
            RedondearBoton(btnCerrar, 20);
            RedondearBoton(btnCredito, 20);
            RedondearBoton(btnUsuarios, 20);
            RedondearBoton(btnReportes, 20);
            RedondearBoton(btnDevolucion, 20);

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
            AbrirFormularioEnPanel(new Inicio());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Nuevacompra());
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
            AbrirFormularioEnPanel(new Nuevaventa());
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
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

        private void button1_Click_3(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Inicio());
        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbCerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void historialDeCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Credito());
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new caja());
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Productos());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tssbHerramientas_ButtonClick(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Clientes());
        }

        private void btnProveedores_Click_2(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Proveedores());
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Usuarios());
        }

        private void btnProveedores_Click_3(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Proveedores());
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Credito());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Usuarios());
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Devoluciones());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Reportes());
        }
    }
}
