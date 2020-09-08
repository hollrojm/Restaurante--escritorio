namespace Restaurante
{
    partial class ConsultaEmp
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
            this.restauranteDataSet = new Restaurante.RestauranteDataSet();
            this.sp_consultar_empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_consultar_empleadoTableAdapter = new Restaurante.RestauranteDataSetTableAdapters.sp_consultar_empleadoTableAdapter();
            this.tableAdapterManager = new Restaurante.RestauranteDataSetTableAdapters.TableAdapterManager();
            this.sp_consultar_empleadoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_consultar_empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_consultar_empleadoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // restauranteDataSet
            // 
            this.restauranteDataSet.DataSetName = "RestauranteDataSet";
            this.restauranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_consultar_empleadoBindingSource
            // 
            this.sp_consultar_empleadoBindingSource.DataMember = "sp_consultar_empleado";
            this.sp_consultar_empleadoBindingSource.DataSource = this.restauranteDataSet;
            // 
            // sp_consultar_empleadoTableAdapter
            // 
            this.sp_consultar_empleadoTableAdapter.ClearBeforeFill = true;
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
            // sp_consultar_empleadoDataGridView
            // 
            this.sp_consultar_empleadoDataGridView.AutoGenerateColumns = false;
            this.sp_consultar_empleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sp_consultar_empleadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.sp_consultar_empleadoDataGridView.DataSource = this.sp_consultar_empleadoBindingSource;
            this.sp_consultar_empleadoDataGridView.Location = new System.Drawing.Point(0, 29);
            this.sp_consultar_empleadoDataGridView.Name = "sp_consultar_empleadoDataGridView";
            this.sp_consultar_empleadoDataGridView.Size = new System.Drawing.Size(758, 216);
            this.sp_consultar_empleadoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Documento_empleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Documento_empleado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom_empleado";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom_empleado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellido_empleado";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido_empleado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Direccion_empleado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Direccion_empleado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono_empleado";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono_empleado";
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
            this.dataGridViewTextBoxColumn7.HeaderText = "fecha_contratacion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(683, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "CERRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurante.Properties.Resources.fondoapp3;
            this.ClientSize = new System.Drawing.Size(761, 247);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sp_consultar_empleadoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaEmp";
            this.Load += new System.EventHandler(this.ConsultaEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_consultar_empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_consultar_empleadoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RestauranteDataSet restauranteDataSet;
        private System.Windows.Forms.BindingSource sp_consultar_empleadoBindingSource;
        private RestauranteDataSetTableAdapters.sp_consultar_empleadoTableAdapter sp_consultar_empleadoTableAdapter;
        private RestauranteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sp_consultar_empleadoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
    }
}