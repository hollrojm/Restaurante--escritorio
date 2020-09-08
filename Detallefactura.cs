using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Detallefactura : Form
    {
        public Detallefactura()
        {
            InitializeComponent();
        }

        

       

       
        

       

       

        private void fillToolStripButton1_Click_4(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton1_Click_5(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton1_Click_6(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_insertar_facturaTableAdapter1.Fill(this.restauranteDataSet5.sp_insertar_factura, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(id_facturaToolStripTextBox1.Text, typeof(decimal))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(documento_clienteToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fecha_facturaToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_insertar_detalle_facturaTableAdapter1.Fill(this.restauranteDataSet6.sp_insertar_detalle_factura, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(id_facturaToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(documento_empleadoToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(id_platoToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(id_mesaToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Detallefactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteDataSet7.Facturacion' Puede moverla o quitarla según sea necesario.
            this.facturacionTableAdapter1.Fill(this.restauranteDataSet7.Facturacion);
            // TODO: esta línea de código carga datos en la tabla 'restauranteDataSet6.Facturacion' Puede moverla o quitarla según sea necesario.
            this.facturacionTableAdapter.Fill(this.restauranteDataSet6.Facturacion);

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes nvocli = new Clientes();
            nvocli.Show();
            this.Hide();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modCliente modcli = new modCliente();
            modcli.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarClientes concli = new consultarClientes();
            concli.Show();
            this.Hide();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Empleados empl = new Empleados();

            empl.Show();
            this.Hide();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modEmpleado modemp = new modEmpleado();
            modemp.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultarEmpleado conemp = new consultarEmpleado();
            conemp.Show();
            this.Hide();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mesas mes = new Mesas();
            mes.Show();
            this.Hide();
        }

        private void platosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Platos platos = new Platos();
            platos.Show();
            this.Hide();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas();
            reservas.Show();
            this.Hide();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir del Sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultac btnconcli = new consultac();
            btnconcli.Owner = this;
            btnconcli.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaEmp btnconemp = new ConsultaEmp();
            btnconemp.Owner = this;
            btnconemp.ShowDialog();
        }
    }
}
