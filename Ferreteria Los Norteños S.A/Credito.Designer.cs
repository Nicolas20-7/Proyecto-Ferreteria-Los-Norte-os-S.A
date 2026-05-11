namespace Ferreteria_Los_Norteños_S.A
{
    partial class Credito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credito));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cIdFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTelefonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAcciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdFactura,
            this.cFecha,
            this.cCajero,
            this.cCliente,
            this.cTelefonos,
            this.cTotal,
            this.cAbono,
            this.cPendiente,
            this.cEstado,
            this.cAcciones});
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 369);
            this.dataGridView1.TabIndex = 5;
            // 
            // cIdFactura
            // 
            this.cIdFactura.HeaderText = "Id Factura";
            this.cIdFactura.Name = "cIdFactura";
            this.cIdFactura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cFecha
            // 
            this.cFecha.HeaderText = "Fecha y Hora";
            this.cFecha.Name = "cFecha";
            // 
            // cCajero
            // 
            this.cCajero.HeaderText = "Cajero";
            this.cCajero.Name = "cCajero";
            // 
            // cCliente
            // 
            this.cCliente.HeaderText = "Clientes";
            this.cCliente.Name = "cCliente";
            // 
            // cTelefonos
            // 
            this.cTelefonos.HeaderText = "Teléfono";
            this.cTelefonos.Name = "cTelefonos";
            // 
            // cTotal
            // 
            this.cTotal.HeaderText = "Total";
            this.cTotal.Name = "cTotal";
            // 
            // cAbono
            // 
            this.cAbono.HeaderText = "Abono";
            this.cAbono.Name = "cAbono";
            // 
            // cPendiente
            // 
            this.cPendiente.HeaderText = "Pendiente";
            this.cPendiente.Name = "cPendiente";
            // 
            // cEstado
            // 
            this.cEstado.HeaderText = "Estado";
            this.cEstado.Name = "cEstado";
            // 
            // cAcciones
            // 
            this.cAcciones.HeaderText = "Acciones";
            this.cAcciones.Name = "cAcciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Historial de créditos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(864, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pendiente";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(109)))));
            this.btnRecargar.BackgroundImage = global::Ferreteria_Los_Norteños_S.A.Properties.Resources._81501;
            this.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecargar.Image")));
            this.btnRecargar.Location = new System.Drawing.Point(907, 24);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(10, 10);
            this.btnRecargar.TabIndex = 7;
            this.btnRecargar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(148)))), ((int)(((byte)(109)))));
            this.button2.BackgroundImage = global::Ferreteria_Los_Norteños_S.A.Properties.Resources._81501;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(722, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 25);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.button1);
            this.Name = "Credito";
            this.Text = "Credito";
            this.Load += new System.EventHandler(this.Credito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTelefonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAcciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}