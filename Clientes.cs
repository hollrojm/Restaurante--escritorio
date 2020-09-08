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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_insertar_clienteTableAdapter.Fill(this.restauranteDataSet.sp_insertar_cliente, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(documento_clienteToolStripTextBox.Text, typeof(decimal))))), nom_clienteToolStripTextBox.Text, apellido_clienteToolStripTextBox.Text, direccion_clienteToolStripTextBox.Text, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(telefono_clienteToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fecha_registroToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fecha_nacimeintoToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Empleados empl = new Empleados();

            empl.Show();
            this.Hide();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Mesas mes = new Mesas();

            mes.Show();
            this.Hide();
        }

        ///
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir del Sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detallefactura factura = new Detallefactura();
            factura.Show();
            this.Hide();
        }
    }
}
