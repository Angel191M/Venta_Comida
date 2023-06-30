namespace Venta_Comida
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonSuministros = new System.Windows.Forms.Button();
            this.botonVentas = new System.Windows.Forms.Button();
            this.botonUsuarios = new System.Windows.Forms.Button();
            this.botonClientes = new System.Windows.Forms.Button();
            this.botonPedido = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.botonSuministros);
            this.panel1.Controls.Add(this.botonVentas);
            this.panel1.Controls.Add(this.botonUsuarios);
            this.panel1.Controls.Add(this.botonClientes);
            this.panel1.Controls.Add(this.botonPedido);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 887);
            this.panel1.TabIndex = 0;
            // 
            // botonSuministros
            // 
            this.botonSuministros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botonSuministros.FlatAppearance.BorderSize = 0;
            this.botonSuministros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.botonSuministros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonSuministros.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSuministros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonSuministros.Location = new System.Drawing.Point(0, 620);
            this.botonSuministros.Margin = new System.Windows.Forms.Padding(4);
            this.botonSuministros.Name = "botonSuministros";
            this.botonSuministros.Size = new System.Drawing.Size(392, 106);
            this.botonSuministros.TabIndex = 5;
            this.botonSuministros.Text = "Gestión del Menú";
            this.botonSuministros.UseVisualStyleBackColor = true;
            this.botonSuministros.Click += new System.EventHandler(this.botonSuministros_Click);
            // 
            // botonVentas
            // 
            this.botonVentas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botonVentas.FlatAppearance.BorderSize = 0;
            this.botonVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.botonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonVentas.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVentas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonVentas.Location = new System.Drawing.Point(0, 722);
            this.botonVentas.Margin = new System.Windows.Forms.Padding(4);
            this.botonVentas.Name = "botonVentas";
            this.botonVentas.Size = new System.Drawing.Size(392, 106);
            this.botonVentas.TabIndex = 4;
            this.botonVentas.Text = "Reporte de Ventas";
            this.botonVentas.UseVisualStyleBackColor = true;
            this.botonVentas.Click += new System.EventHandler(this.botonVentas_Click);
            // 
            // botonUsuarios
            // 
            this.botonUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botonUsuarios.FlatAppearance.BorderSize = 0;
            this.botonUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.botonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonUsuarios.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonUsuarios.Location = new System.Drawing.Point(0, 519);
            this.botonUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.botonUsuarios.Name = "botonUsuarios";
            this.botonUsuarios.Size = new System.Drawing.Size(392, 106);
            this.botonUsuarios.TabIndex = 3;
            this.botonUsuarios.Text = "Gestion de Usuarios";
            this.botonUsuarios.UseVisualStyleBackColor = true;
            this.botonUsuarios.Click += new System.EventHandler(this.botonUsuarios_Click);
            // 
            // botonClientes
            // 
            this.botonClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botonClientes.FlatAppearance.BorderSize = 0;
            this.botonClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.botonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonClientes.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonClientes.Location = new System.Drawing.Point(0, 417);
            this.botonClientes.Margin = new System.Windows.Forms.Padding(4);
            this.botonClientes.Name = "botonClientes";
            this.botonClientes.Size = new System.Drawing.Size(392, 106);
            this.botonClientes.TabIndex = 2;
            this.botonClientes.Text = "Gestion de Clientes";
            this.botonClientes.UseVisualStyleBackColor = true;
            this.botonClientes.Click += new System.EventHandler(this.botonClientes_Click);
            // 
            // botonPedido
            // 
            this.botonPedido.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botonPedido.FlatAppearance.BorderSize = 0;
            this.botonPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.botonPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonPedido.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPedido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonPedido.Location = new System.Drawing.Point(0, 315);
            this.botonPedido.Margin = new System.Windows.Forms.Padding(4);
            this.botonPedido.Name = "botonPedido";
            this.botonPedido.Size = new System.Drawing.Size(392, 106);
            this.botonPedido.TabIndex = 1;
            this.botonPedido.Text = "Pedidos";
            this.botonPedido.UseVisualStyleBackColor = true;
            this.botonPedido.Click += new System.EventHandler(this.botonPedido_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1712, 887);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonUsuarios;
        private System.Windows.Forms.Button botonClientes;
        private System.Windows.Forms.Button botonPedido;
        private System.Windows.Forms.Button botonVentas;
        private System.Windows.Forms.Button botonSuministros;
    }
}