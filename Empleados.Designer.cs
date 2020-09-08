namespace Restaurante
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.restauranteDataSet = new Restaurante.RestauranteDataSet();
            this.sp_insertar_EmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_insertar_EmpleadoTableAdapter = new Restaurante.RestauranteDataSetTableAdapters.sp_insertar_EmpleadoTableAdapter();
            this.tableAdapterManager = new Restaurante.RestauranteDataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.documento_empleadoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.documento_empleadoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nom_empleadoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nom_empleadoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.apellido_empleadoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.apellido_empleadoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.direccion_empleadoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.direccion_empleadoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.telefono_empleadoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.telefono_empleadoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.cargoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.cargoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fecha_contratacionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fecha_contratacionToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.sp_insertar_EmpleadoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.platosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_insertar_EmpleadoBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_insertar_EmpleadoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // restauranteDataSet
            // 
            this.restauranteDataSet.DataSetName = "RestauranteDataSet";
            this.restauranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_insertar_EmpleadoBindingSource
            // 
            this.sp_insertar_EmpleadoBindingSource.DataMember = "sp_insertar_Empleado";
            this.sp_insertar_EmpleadoBindingSource.DataSource = this.restauranteDataSet;
            // 
            // sp_insertar_EmpleadoTableAdapter
            // 
            this.sp_insertar_EmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Detalle_FacturaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.FacturasTableAdapter = null;
            this.tableAdapterManager.MesasTableAdapter = null;
            this.tableAdapterManager.PlatosTableAdapter = null;
            this.tableAdapterManager.ReservasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Restaurante.RestauranteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillToolStrip.AutoSize = false;
            this.fillToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documento_empleadoToolStripLabel,
            this.documento_empleadoToolStripTextBox,
            this.nom_empleadoToolStripLabel,
            this.nom_empleadoToolStripTextBox,
            this.apellido_empleadoToolStripLabel,
            this.apellido_empleadoToolStripTextBox,
            this.direccion_empleadoToolStripLabel,
            this.direccion_empleadoToolStripTextBox,
            this.telefono_empleadoToolStripLabel,
            this.telefono_empleadoToolStripTextBox,
            this.cargoToolStripLabel,
            this.cargoToolStripTextBox,
            this.fecha_contratacionToolStripLabel,
            this.fecha_contratacionToolStripTextBox,
            this.fillToolStripButton,
            this.toolStripButton1});
            this.fillToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.fillToolStrip.Location = new System.Drawing.Point(60, 26);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.fillToolStrip.Size = new System.Drawing.Size(292, 372);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // documento_empleadoToolStripLabel
            // 
            this.documento_empleadoToolStripLabel.Name = "documento_empleadoToolStripLabel";
            this.documento_empleadoToolStripLabel.Size = new System.Drawing.Size(73, 15);
            this.documento_empleadoToolStripLabel.Text = "Documento:";
            // 
            // documento_empleadoToolStripTextBox
            // 
            this.documento_empleadoToolStripTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.documento_empleadoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.documento_empleadoToolStripTextBox.Name = "documento_empleadoToolStripTextBox";
            this.documento_empleadoToolStripTextBox.Size = new System.Drawing.Size(120, 23);
            // 
            // nom_empleadoToolStripLabel
            // 
            this.nom_empleadoToolStripLabel.Name = "nom_empleadoToolStripLabel";
            this.nom_empleadoToolStripLabel.Size = new System.Drawing.Size(54, 15);
            this.nom_empleadoToolStripLabel.Text = "Nombre:";
            // 
            // nom_empleadoToolStripTextBox
            // 
            this.nom_empleadoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nom_empleadoToolStripTextBox.Name = "nom_empleadoToolStripTextBox";
            this.nom_empleadoToolStripTextBox.Size = new System.Drawing.Size(200, 23);
            // 
            // apellido_empleadoToolStripLabel
            // 
            this.apellido_empleadoToolStripLabel.Name = "apellido_empleadoToolStripLabel";
            this.apellido_empleadoToolStripLabel.Size = new System.Drawing.Size(54, 15);
            this.apellido_empleadoToolStripLabel.Text = "Apellido:";
            // 
            // apellido_empleadoToolStripTextBox
            // 
            this.apellido_empleadoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.apellido_empleadoToolStripTextBox.Name = "apellido_empleadoToolStripTextBox";
            this.apellido_empleadoToolStripTextBox.Size = new System.Drawing.Size(200, 23);
            // 
            // direccion_empleadoToolStripLabel
            // 
            this.direccion_empleadoToolStripLabel.Name = "direccion_empleadoToolStripLabel";
            this.direccion_empleadoToolStripLabel.Size = new System.Drawing.Size(60, 15);
            this.direccion_empleadoToolStripLabel.Text = "Direccion:";
            // 
            // direccion_empleadoToolStripTextBox
            // 
            this.direccion_empleadoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.direccion_empleadoToolStripTextBox.Name = "direccion_empleadoToolStripTextBox";
            this.direccion_empleadoToolStripTextBox.Size = new System.Drawing.Size(200, 23);
            // 
            // telefono_empleadoToolStripLabel
            // 
            this.telefono_empleadoToolStripLabel.Name = "telefono_empleadoToolStripLabel";
            this.telefono_empleadoToolStripLabel.Size = new System.Drawing.Size(55, 15);
            this.telefono_empleadoToolStripLabel.Text = "Telefono:";
            // 
            // telefono_empleadoToolStripTextBox
            // 
            this.telefono_empleadoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.telefono_empleadoToolStripTextBox.Name = "telefono_empleadoToolStripTextBox";
            this.telefono_empleadoToolStripTextBox.Size = new System.Drawing.Size(200, 23);
            // 
            // cargoToolStripLabel
            // 
            this.cargoToolStripLabel.Name = "cargoToolStripLabel";
            this.cargoToolStripLabel.Size = new System.Drawing.Size(42, 15);
            this.cargoToolStripLabel.Text = "Cargo:";
            // 
            // cargoToolStripTextBox
            // 
            this.cargoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cargoToolStripTextBox.Name = "cargoToolStripTextBox";
            this.cargoToolStripTextBox.Size = new System.Drawing.Size(200, 23);
            // 
            // fecha_contratacionToolStripLabel
            // 
            this.fecha_contratacionToolStripLabel.Name = "fecha_contratacionToolStripLabel";
            this.fecha_contratacionToolStripLabel.Size = new System.Drawing.Size(103, 15);
            this.fecha_contratacionToolStripLabel.Text = "Inicio de contrato:";
            // 
            // fecha_contratacionToolStripTextBox
            // 
            this.fecha_contratacionToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fecha_contratacionToolStripTextBox.Name = "fecha_contratacionToolStripTextBox";
            this.fecha_contratacionToolStripTextBox.Size = new System.Drawing.Size(200, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillToolStripButton.Margin = new System.Windows.Forms.Padding(110, 10, 10, 2);
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Padding = new System.Windows.Forms.Padding(10);
            this.fillToolStripButton.Size = new System.Drawing.Size(90, 39);
            this.fillToolStripButton.Text = "INGRESAR";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // sp_insertar_EmpleadoDataGridView
            // 
            this.sp_insertar_EmpleadoDataGridView.AutoGenerateColumns = false;
            this.sp_insertar_EmpleadoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sp_insertar_EmpleadoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sp_insertar_EmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sp_insertar_EmpleadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.sp_insertar_EmpleadoDataGridView.DataSource = this.sp_insertar_EmpleadoBindingSource;
            this.sp_insertar_EmpleadoDataGridView.Location = new System.Drawing.Point(31, 367);
            this.sp_insertar_EmpleadoDataGridView.Name = "sp_insertar_EmpleadoDataGridView";
            this.sp_insertar_EmpleadoDataGridView.Size = new System.Drawing.Size(743, 178);
            this.sp_insertar_EmpleadoDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Documento_empleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom_empleado";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellido_empleado";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Direccion_empleado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono_empleado";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cargo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cargo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha_contratacion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha de contratación";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.empleados;
            this.pictureBox1.Location = new System.Drawing.Point(355, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(399, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "INGRESAR EMPLEADO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem,
            this.consultarClienteToolStripMenuItem,
            this.platosToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.facturasToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ingresarClienteToolStripMenuItem
            // 
            this.ingresarClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.ingresarClienteToolStripMenuItem.Name = "ingresarClienteToolStripMenuItem";
            this.ingresarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarClienteToolStripMenuItem.Text = "Clientes";
            this.ingresarClienteToolStripMenuItem.Click += new System.EventHandler(this.ingresarClienteToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.consultarToolStripMenuItem1});
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarClienteToolStripMenuItem.Text = "Empleados";
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem1.Text = "Nuevo";
            this.nuevoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarClienteToolStripMenuItem.Text = "Mesas";
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // platosToolStripMenuItem
            // 
            this.platosToolStripMenuItem.Name = "platosToolStripMenuItem";
            this.platosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.platosToolStripMenuItem.Text = "Platos";
            this.platosToolStripMenuItem.Click += new System.EventHandler(this.platosToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurante.Properties.Resources.fondoapp3;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sp_insertar_EmpleadoDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_insertar_EmpleadoBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_insertar_EmpleadoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet restauranteDataSet;
        private System.Windows.Forms.BindingSource sp_insertar_EmpleadoBindingSource;
        private RestauranteDataSetTableAdapters.sp_insertar_EmpleadoTableAdapter sp_insertar_EmpleadoTableAdapter;
        private RestauranteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripLabel documento_empleadoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox documento_empleadoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nom_empleadoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nom_empleadoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel apellido_empleadoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox apellido_empleadoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel direccion_empleadoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox direccion_empleadoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel telefono_empleadoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox telefono_empleadoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel cargoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox cargoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel fecha_contratacionToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fecha_contratacionToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView sp_insertar_EmpleadoDataGridView;
        public System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem platosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}