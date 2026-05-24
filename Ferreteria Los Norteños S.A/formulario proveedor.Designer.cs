using System.Drawing;
using System.Windows.Forms;

namespace Ferreteria_Los_Norteños_S.A
{
    partial class formulario_proveedor : Form
    {
        // Paleta de colores de la imagen
        private Color colorFondo = Color.FromArgb(244, 245, 247);
        private Color colorAzulPrincipal = Color.FromArgb(59, 91, 219); // #3b5bdb
        private Color colorAzulOscuro = Color.FromArgb(43, 57, 144);
        private Color colorVerde = Color.FromArgb(34, 197, 94); // #22c55e
        private Color colorRojo = Color.FromArgb(239, 68, 68); // #ef4444
        private Color colorTexto = Color.FromArgb(55, 65, 81);

     

        private void ConfigurarFormulario()
        {
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = colorFondo;
            this.FormBorderStyle = FormBorderStyle.None; // Quitamos el borde por defecto de Windows
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private void ConstruirInterfaz()
        {
            // 1. Barra de Título Personalizada
            Panel pnlTopBar = new Panel { Dock = DockStyle.Top, Height = 40, BackColor = Color.White };
            Label lblTituloApp = new Label { Text = "Gestión de Proveedores", ForeColor = colorAzulOscuro, Font = new Font("Segoe UI", 10F, FontStyle.Bold), Location = new Point(20, 10), AutoSize = true };
            Button btnCerrar = CrearBotonFlat("X", Color.White, Color.Gray, new Point(this.Width - 40, 0), 40, 40);
            btnCerrar.Click += (s, e) => this.Close();
            pnlTopBar.Controls.Add(lblTituloApp);
            pnlTopBar.Controls.Add(btnCerrar);
            this.Controls.Add(pnlTopBar);

            // 2. Encabezado Central
            Label lblMainTitle = new Label { Text = "Gestión de Proveedores", Font = new Font("Segoe UI", 24F, FontStyle.Bold), ForeColor = colorAzulOscuro, AutoSize = true };
            lblMainTitle.Location = new Point((this.Width - lblMainTitle.Width) / 2 - 80, 70);
            this.Controls.Add(lblMainTitle);

            Label lblSubTitle = new Label { Text = "Administra y mantén la información de tus proveedores", Font = new Font("Segoe UI", 10F), ForeColor = Color.Gray, AutoSize = true };
            lblSubTitle.Location = new Point((this.Width - lblSubTitle.Width) / 2 - 80, 115);
            this.Controls.Add(lblSubTitle);

            // 3. Contenedor "Datos del Proveedor" (Tarjeta Blanca superior)
            Panel pnlDatos = new Panel { BackColor = Color.White, Location = new Point(40, 180), Size = new Size(1120, 250) };
            pnlDatos.BorderStyle = BorderStyle.FixedSingle; // Simula el borde de la tarjeta

            Label lblDatosTitulo = new Label { Text = "Datos del Proveedor", Font = new Font("Segoe UI", 12F, FontStyle.Bold), ForeColor = colorAzulOscuro, Location = new Point(20, 15), AutoSize = true };
            pnlDatos.Controls.Add(lblDatosTitulo);

            // Campos de texto (Ejemplo: Nombre y Teléfono)
            pnlDatos.Controls.Add(CrearEtiquetaCampo("Nombre del proveedor *", new Point(20, 60)));
            pnlDatos.Controls.Add(CrearTextBox("Ingrese el nombre completo", new Point(20, 85), 300));

            pnlDatos.Controls.Add(CrearEtiquetaCampo("Teléfono *", new Point(340, 60)));
            pnlDatos.Controls.Add(CrearTextBox("Ingrese el teléfono", new Point(340, 85), 250));

            pnlDatos.Controls.Add(CrearEtiquetaCampo("Correo electrónico", new Point(610, 60)));
            pnlDatos.Controls.Add(CrearTextBox("ejemplo@correo.com", new Point(610, 85), 250));

            // Botones de Acción
            Button btnGuardar = CrearBotonFlat("Guardar", colorVerde, Color.White, new Point(20, 190), 100, 35);
            Button btnLimpiar = CrearBotonFlat("Limpiar", colorAzulPrincipal, Color.White, new Point(130, 190), 100, 35);
            Button btnCancelar = CrearBotonFlat("Cancelar", colorRojo, Color.White, new Point(240, 190), 100, 35);

            pnlDatos.Controls.Add(btnGuardar);
            pnlDatos.Controls.Add(btnLimpiar);
            pnlDatos.Controls.Add(btnCancelar);

            this.Controls.Add(pnlDatos);

            // 4. Contenedor "Lista de Proveedores" (Tarjeta Blanca inferior)
            Panel pnlLista = new Panel { BackColor = Color.White, Location = new Point(40, 450), Size = new Size(1120, 280) };
            pnlLista.BorderStyle = BorderStyle.FixedSingle;

            Label lblListaTitulo = new Label { Text = "Lista de Proveedores", Font = new Font("Segoe UI", 12F, FontStyle.Bold), ForeColor = colorAzulOscuro, Location = new Point(20, 15), AutoSize = true };
            pnlLista.Controls.Add(lblListaTitulo);

            // DataGridView para la tabla
            DataGridView dgvProveedores = new DataGridView();
            dgvProveedores.Location = new Point(20, 50);
            dgvProveedores.Size = new Size(1080, 200);
            dgvProveedores.BackgroundColor = Color.White;
            dgvProveedores.BorderStyle = BorderStyle.None;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.AllowUserToAddRows = false;

            // Estilos de la tabla
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);
            dgvProveedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
            dgvProveedores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProveedores.ColumnHeadersHeight = 40;

            // Agregando columnas de ejemplo
            dgvProveedores.Columns.Add("ID", "ID");
            dgvProveedores.Columns.Add("Nombre", "Nombre del proveedor");
            dgvProveedores.Columns.Add("Telefono", "Teléfono");
            dgvProveedores.Columns.Add("Correo", "Correo electrónico");
            dgvProveedores.Columns.Add("Estado", "Estado");

            pnlLista.Controls.Add(dgvProveedores);
            this.Controls.Add(pnlLista);

            // 5. Botones Inferiores Globales
            Button btnNuevo = CrearBotonFlat("+ Nuevo proveedor", colorAzulPrincipal, Color.White, new Point(40, 745), 160, 40);
            Button btnEditar = CrearBotonFlat("Editar proveedor", colorAzulPrincipal, Color.White, new Point(810, 745), 160, 40);
            Button btnEliminar = CrearBotonFlat("Eliminar proveedor", colorRojo, Color.White, new Point(980, 745), 180, 40);

            this.Controls.Add(btnNuevo);
            this.Controls.Add(btnEditar);
            this.Controls.Add(btnEliminar);
        }

        // --- Funciones Auxiliares para crear controles con estilo ---

        private Button CrearBotonFlat(string texto, Color bgColor, Color textColor, Point location, int width, int height)
        {
            Button btn = new Button();
            btn.Text = texto;
            btn.BackColor = bgColor;
            btn.ForeColor = textColor;
            btn.Location = location;
            btn.Size = new Size(width, height);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            return btn;
        }

        private Label CrearEtiquetaCampo(string texto, Point location)
        {
            return new Label { Text = texto, Location = location, AutoSize = true, ForeColor = colorTexto, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
        }

        private TextBox CrearTextBox(string placeholder, Point location, int width)
        {
            TextBox txt = new TextBox();
            txt.Location = location;
            txt.Width = width;
            txt.Font = new Font("Segoe UI", 10F);
            txt.BorderStyle = BorderStyle.FixedSingle;
            // Simulación de placeholder
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;
            txt.Enter += (s, e) => { if (txt.Text == placeholder) { txt.Text = ""; txt.ForeColor = Color.Black; } };
            txt.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txt.Text)) { txt.Text = placeholder; txt.ForeColor = Color.Gray; } };
            return txt;
        }

        // Método requerido por el diseñador de WinForms
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }
        private void InitializeComponent() { this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; }
    

        

    }
}