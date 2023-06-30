namespace Venta_Comida.Pantallas
{
    partial class Clientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonAtras = new System.Windows.Forms.Button();
            this.textCelular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.textNombres = new System.Windows.Forms.TextBox();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.textCi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonCancelarB = new System.Windows.Forms.Button();
            this.dataClientes = new System.Windows.Forms.DataGridView();
            this.bdD_Venta_ComidaDataSet = new Venta_Comida.BdD_Venta_ComidaDataSet();
            this.bdDVentaComidaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Venta_Comida.BdD_Venta_ComidaDataSetTableAdapters.ClientesTableAdapter();
            this.cIclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdD_Venta_ComidaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDVentaComidaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonAtras);
            this.groupBox1.Controls.Add(this.textCelular);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.botonCancelar);
            this.groupBox1.Controls.Add(this.botonEliminar);
            this.groupBox1.Controls.Add(this.botonModificar);
            this.groupBox1.Controls.Add(this.botonAgregar);
            this.groupBox1.Controls.Add(this.textNombres);
            this.groupBox1.Controls.Add(this.textApellidos);
            this.groupBox1.Controls.Add(this.textCi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(456, 1028);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Datos del Cliente:";
            // 
            // botonAtras
            // 
            this.botonAtras.BackColor = System.Drawing.Color.Gold;
            this.botonAtras.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAtras.Location = new System.Drawing.Point(58, 946);
            this.botonAtras.Margin = new System.Windows.Forms.Padding(4);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(322, 75);
            this.botonAtras.TabIndex = 17;
            this.botonAtras.Text = "MENÚ PRINCIPAL";
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // textCelular
            // 
            this.textCelular.Location = new System.Drawing.Point(56, 456);
            this.textCelular.Margin = new System.Windows.Forms.Padding(4);
            this.textCelular.Name = "textCelular";
            this.textCelular.Size = new System.Drawing.Size(324, 38);
            this.textCelular.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 401);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Celular:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.BackColor = System.Drawing.Color.White;
            this.botonCancelar.Location = new System.Drawing.Point(129, 742);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(172, 65);
            this.botonCancelar.TabIndex = 9;
            this.botonCancelar.Text = "Limpiar";
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.Color.White;
            this.botonEliminar.Location = new System.Drawing.Point(129, 667);
            this.botonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(172, 65);
            this.botonEliminar.TabIndex = 8;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = false;
            // 
            // botonModificar
            // 
            this.botonModificar.BackColor = System.Drawing.Color.White;
            this.botonModificar.Location = new System.Drawing.Point(129, 593);
            this.botonModificar.Margin = new System.Windows.Forms.Padding(4);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(172, 65);
            this.botonModificar.TabIndex = 7;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = false;
            // 
            // botonAgregar
            // 
            this.botonAgregar.BackColor = System.Drawing.Color.White;
            this.botonAgregar.Location = new System.Drawing.Point(129, 519);
            this.botonAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(172, 65);
            this.botonAgregar.TabIndex = 6;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = false;
            // 
            // textNombres
            // 
            this.textNombres.Location = new System.Drawing.Point(56, 338);
            this.textNombres.Margin = new System.Windows.Forms.Padding(4);
            this.textNombres.Name = "textNombres";
            this.textNombres.Size = new System.Drawing.Size(324, 38);
            this.textNombres.TabIndex = 5;
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(56, 222);
            this.textApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(324, 38);
            this.textApellidos.TabIndex = 4;
            // 
            // textCi
            // 
            this.textCi.Location = new System.Drawing.Point(56, 110);
            this.textCi.Margin = new System.Windows.Forms.Padding(4);
            this.textCi.Name = "textCi";
            this.textCi.Size = new System.Drawing.Size(324, 38);
            this.textCi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "C.I.:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonCancelarB);
            this.groupBox2.Controls.Add(this.botonBuscar);
            this.groupBox2.Controls.Add(this.textBuscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(482, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1232, 123);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes:";
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackColor = System.Drawing.Color.White;
            this.botonBuscar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.Location = new System.Drawing.Point(851, 47);
            this.botonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(148, 54);
            this.botonBuscar.TabIndex = 19;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = false;
            // 
            // textBuscar
            // 
            this.textBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(129, 55);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(663, 30);
            this.textBuscar.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buscar:";
            // 
            // botonCancelarB
            // 
            this.botonCancelarB.BackColor = System.Drawing.Color.White;
            this.botonCancelarB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelarB.Location = new System.Drawing.Point(1034, 45);
            this.botonCancelarB.Margin = new System.Windows.Forms.Padding(4);
            this.botonCancelarB.Name = "botonCancelarB";
            this.botonCancelarB.Size = new System.Drawing.Size(148, 54);
            this.botonCancelarB.TabIndex = 21;
            this.botonCancelarB.Text = "Cancelar";
            this.botonCancelarB.UseVisualStyleBackColor = false;
            this.botonCancelarB.Click += new System.EventHandler(this.botonCancelarB_Click);
            // 
            // dataClientes
            // 
            this.dataClientes.AutoGenerateColumns = false;
            this.dataClientes.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIclienteDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn});
            this.dataClientes.DataSource = this.clientesBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataClientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataClientes.Location = new System.Drawing.Point(586, 167);
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.RowHeadersWidth = 51;
            this.dataClientes.RowTemplate.Height = 24;
            this.dataClientes.Size = new System.Drawing.Size(1054, 750);
            this.dataClientes.TabIndex = 5;
            // 
            // bdD_Venta_ComidaDataSet
            // 
            this.bdD_Venta_ComidaDataSet.DataSetName = "BdD_Venta_ComidaDataSet";
            this.bdD_Venta_ComidaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdDVentaComidaDataSetBindingSource
            // 
            this.bdDVentaComidaDataSetBindingSource.DataSource = this.bdD_Venta_ComidaDataSet;
            this.bdDVentaComidaDataSetBindingSource.Position = 0;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.bdD_Venta_ComidaDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // cIclienteDataGridViewTextBoxColumn
            // 
            this.cIclienteDataGridViewTextBoxColumn.DataPropertyName = "CI_cliente";
            this.cIclienteDataGridViewTextBoxColumn.HeaderText = "CI_cliente";
            this.cIclienteDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cIclienteDataGridViewTextBoxColumn.Name = "cIclienteDataGridViewTextBoxColumn";
            this.cIclienteDataGridViewTextBoxColumn.Width = 250;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.Width = 250;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.Width = 250;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.Width = 250;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1924, 1028);
            this.Controls.Add(this.dataClientes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Clientes";
            this.Text = "Geston de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdD_Venta_ComidaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDVentaComidaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.TextBox textNombres;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.TextBox textCi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCelular;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonCancelarB;
        private System.Windows.Forms.DataGridView dataClientes;
        private System.Windows.Forms.BindingSource bdDVentaComidaDataSetBindingSource;
        private BdD_Venta_ComidaDataSet bdD_Venta_ComidaDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private BdD_Venta_ComidaDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
    }
}