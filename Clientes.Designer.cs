﻿namespace Restaurante
{
    partial class Clientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.restauranteDataSet = new Restaurante.RestauranteDataSet();
            this.sp_insertar_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_insertar_clienteTableAdapter = new Restaurante.RestauranteDataSetTableAdapters.sp_insertar_clienteTableAdapter();
            this.tableAdapterManager = new Restaurante.RestauranteDataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.documento_clienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.documento_clienteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nom_clienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nom_clienteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.apellido_clienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.apellido_clienteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.direccion_clienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.direccion_clienteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.telefono_clienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.telefono_clienteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fecha_registroToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fecha_registroToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fecha_nacimeintoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fecha_nacimeintoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sp_insertar_clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_insertar_clienteBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_insertar_clienteDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // restauranteDataSet
            // 
            this.restauranteDataSet.DataSetName = "RestauranteDataSet";
            this.restauranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_insertar_clienteBindingSource
            // 
            this.sp_insertar_clienteBindingSource.DataMember = "sp_insertar_cliente";
            this.sp_insertar_clienteBindingSource.DataSource = this.restauranteDataSet;
            // 
            // sp_insertar_clienteTableAdapter
            // 
            this.sp_insertar_clienteTableAdapter.ClearBeforeFill = true;
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
            this.fillToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillToolStrip.AutoSize = false;
            this.fillToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documento_clienteToolStripLabel,
            this.documento_clienteToolStripTextBox,
            this.nom_clienteToolStripLabel,
            this.nom_clienteToolStripTextBox,
            this.apellido_clienteToolStripLabel,
            this.apellido_clienteToolStripTextBox,
            this.direccion_clienteToolStripLabel,
            this.direccion_clienteToolStripTextBox,
            this.telefono_clienteToolStripLabel,
            this.telefono_clienteToolStripTextBox,
            this.fecha_registroToolStripLabel,
            this.fecha_registroToolStripTextBox,
            this.fecha_nacimeintoToolStripLabel,
            this.fecha_nacimeintoToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.fillToolStrip.Location = new System.Drawing.Point(22, 50);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.fillToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.fillToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fillToolStrip.Size = new System.Drawing.Size(236, 415);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // documento_clienteToolStripLabel
            // 
            this.documento_clienteToolStripLabel.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documento_clienteToolStripLabel.ForeColor = System.Drawing.Color.Navy;
            this.documento_clienteToolStripLabel.Margin = new System.Windows.Forms.Padding(1, 10, 0, 2);
            this.documento_clienteToolStripLabel.Name = "documento_clienteToolStripLabel";
            this.documento_clienteToolStripLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.documento_clienteToolStripLabel.Size = new System.Drawing.Size(81, 16);
            this.documento_clienteToolStripLabel.Text = "Documento:";
            // 
            // documento_clienteToolStripTextBox
            // 
            this.documento_clienteToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.documento_clienteToolStripTextBox.MaxLength = 32769;
            this.documento_clienteToolStripTextBox.Name = "documento_clienteToolStripTextBox";
            this.documento_clienteToolStripTextBox.Size = new System.Drawing.Size(120, 23);
            // 
            // nom_clienteToolStripLabel
            // 
            this.nom_clienteToolStripLabel.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_clienteToolStripLabel.ForeColor = System.Drawing.Color.Navy;
            this.nom_clienteToolStripLabel.Margin = new System.Windows.Forms.Padding(1, 10, 0, 2);
            this.nom_clienteToolStripLabel.Name = "nom_clienteToolStripLabel";
            this.nom_clienteToolStripLabel.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.nom_clienteToolStripLabel.Size = new System.Drawing.Size(61, 16);
            this.nom_clienteToolStripLabel.Text = "Nombre:";
            // 
            // nom_clienteToolStripTextBox
            // 
            this.nom_clienteToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nom_clienteToolStripTextBox.Name = "nom_clienteToolStripTextBox";
            this.nom_clienteToolStripTextBox.Size = new System.Drawing.Size(200, 23);
            // 
            // apellido_clienteToolStripLabel
            // 
            this.apellido_clienteToolStripLabel.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido_clienteToolStripLabel.ForeColor = System.Drawing.Color.Navy;
            this.apellido_clienteToolStripLabel.Margin = new System.Windows.Forms.Padding(1, 10, 0, 2);
            this.apellido_clienteToolStripLabel.Name = "apellido_clienteToolStripLabel";
            this.apellido_clienteToolStripLabel.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.apellido_clienteToolStripLabel.Size = new System.Drawing.Size(67, 16);
            this.apellido_clienteToolStripLabel.Text = "Apellidos:";
            // 
            // apellido_clienteToolStripTextBox
            // 
            this.apellido_clienteToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.apellido_clienteToolStripTextBox.Name = "apellido_clienteToolStripTextBox";
            this.apellido_clienteToolStripTextBox.Size = new System.Drawing.Size(200, 23);
            // 
            // direccion_clienteToolStripLabel
            // 
            this.direccion_clienteToolStripLabel.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_clienteToolStripLabel.ForeColor = System.Drawing.Color.Navy;
            this.direccion_clienteToolStripLabel.Margin = new System.Windows.Forms.Padding(1, 10, 0, 2);
            this.direccion_clienteToolStripLabel.Name = "direccion_clienteToolStripLabel";
            this.direccion_clienteToolStripLabel.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.direccion_clienteToolStripLabel.Size = new System.Drawing.Size(71, 16);
            this.direccion_clienteToolStripLabel.Text = "Direccion:";
            // 
            // direccion_clienteToolStripTextBox
            // 
            this.direccion_clienteToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.direccion_clienteToolStripTextBox.Name = "direccion_clienteToolStripTextBox";
            this.direccion_clienteToolStripTextBox.Size = new System.Drawing.Size(200, 23);
            // 
            // telefono_clienteToolStripLabel
            // 
            this.telefono_clienteToolStripLabel.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono_clienteToolStripLabel.ForeColor = System.Drawing.Color.Navy;
            this.telefono_clienteToolStripLabel.Margin = new System.Windows.Forms.Padding(1, 10, 0, 2);
            this.telefono_clienteToolStripLabel.Name = "telefono_clienteToolStripLabel";
            this.telefono_clienteToolStripLabel.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.telefono_clienteToolStripLabel.Size = new System.Drawing.Size(65, 16);
            this.telefono_clienteToolStripLabel.Text = "Telefono:";
            // 
            // telefono_clienteToolStripTextBox
            // 
            this.telefono_clienteToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.telefono_clienteToolStripTextBox.Name = "telefono_clienteToolStripTextBox";
            this.telefono_clienteToolStripTextBox.Size = new System.Drawing.Size(200, 23);
            // 
            // fecha_registroToolStripLabel
            // 
            this.fecha_registroToolStripLabel.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_registroToolStripLabel.ForeColor = System.Drawing.Color.Navy;
            this.fecha_registroToolStripLabel.Margin = new System.Windows.Forms.Padding(1, 10, 0, 2);
            this.fecha_registroToolStripLabel.Name = "fecha_registroToolStripLabel";
            this.fecha_registroToolStripLabel.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.fecha_registroToolStripLabel.Size = new System.Drawing.Size(114, 16);
            this.fecha_registroToolStripLabel.Text = "Fecha de registro:";
            // 
            // fecha_registroToolStripTextBox
            // 
            this.fecha_registroToolStripTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.fecha_registroToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fecha_registroToolStripTextBox.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.fecha_registroToolStripTextBox.Name = "fecha_registroToolStripTextBox";
            this.fecha_registroToolStripTextBox.Size = new System.Drawing.Size(200, 23);
            // 
            // fecha_nacimeintoToolStripLabel
            // 
            this.fecha_nacimeintoToolStripLabel.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_nacimeintoToolStripLabel.ForeColor = System.Drawing.Color.Navy;
            this.fecha_nacimeintoToolStripLabel.Margin = new System.Windows.Forms.Padding(1, 10, 0, 2);
            this.fecha_nacimeintoToolStripLabel.Name = "fecha_nacimeintoToolStripLabel";
            this.fecha_nacimeintoToolStripLabel.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.fecha_nacimeintoToolStripLabel.Size = new System.Drawing.Size(87, 16);
            this.fecha_nacimeintoToolStripLabel.Text = "Cumpleaños:";
            // 
            // fecha_nacimeintoToolStripTextBox
            // 
            this.fecha_nacimeintoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fecha_nacimeintoToolStripTextBox.Name = "fecha_nacimeintoToolStripTextBox";
            this.fecha_nacimeintoToolStripTextBox.Size = new System.Drawing.Size(200, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fillToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.fillToolStripButton.BackgroundImage = global::Restaurante.Properties.Resources.boton_guardar;
            this.fillToolStripButton.Image = global::Restaurante.Properties.Resources.boton_guardar;
            this.fillToolStripButton.Margin = new System.Windows.Forms.Padding(100, 15, 0, 2);
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Padding = new System.Windows.Forms.Padding(10);
            this.fillToolStripButton.Size = new System.Drawing.Size(101, 40);
            this.fillToolStripButton.Text = "GUARDAR";
            this.fillToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            
            // 
            // sp_insertar_clienteDataGridView
            // 
            this.sp_insertar_clienteDataGridView.AutoGenerateColumns = false;
            this.sp_insertar_clienteDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.sp_insertar_clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sp_insertar_clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.sp_insertar_clienteDataGridView.DataSource = this.sp_insertar_clienteBindingSource;
            this.sp_insertar_clienteDataGridView.GridColor = System.Drawing.Color.Black;
            this.sp_insertar_clienteDataGridView.Location = new System.Drawing.Point(251, 132);
            this.sp_insertar_clienteDataGridView.Name = "sp_insertar_clienteDataGridView";
            this.sp_insertar_clienteDataGridView.Size = new System.Drawing.Size(745, 220);
            this.sp_insertar_clienteDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Documento_cliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom_cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellido_cliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Direccion_cliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono_cliente";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fecha_registro";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha de registro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha_nacimeinto";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cumpleaños";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 3;
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
            this.modificarClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "INGRESAR CLIENTE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Restaurante.Properties.Resources.pngocean_com;
            this.pictureBox1.Location = new System.Drawing.Point(713, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurante.Properties.Resources.fondoapp3;
            this.ClientSize = new System.Drawing.Size(1018, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sp_insertar_clienteDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_insertar_clienteBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_insertar_clienteDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestauranteDataSet restauranteDataSet;
        private System.Windows.Forms.BindingSource sp_insertar_clienteBindingSource;
        private RestauranteDataSetTableAdapters.sp_insertar_clienteTableAdapter sp_insertar_clienteTableAdapter;
        private RestauranteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel documento_clienteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox documento_clienteToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nom_clienteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nom_clienteToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel apellido_clienteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox apellido_clienteToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel direccion_clienteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox direccion_clienteToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel telefono_clienteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox telefono_clienteToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel fecha_registroToolStripLabel;
        private System.Windows.Forms.ToolStripLabel fecha_nacimeintoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fecha_nacimeintoToolStripTextBox;
        private System.Windows.Forms.DataGridView sp_insertar_clienteDataGridView;
        public System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripTextBox fecha_registroToolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem platosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

