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
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_insertar_reservaTableAdapter.Fill(this.restauranteDataSet4.sp_insertar_reserva, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(id_reservaToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(documento_clienteToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(id_mesaToolStripTextBox.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fecha_reservaToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sp_insertar_reservaTableAdapter.Fill(this.restauranteDataSet4.sp_insertar_reserva, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(id_reservaToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(documento_clienteToolStripTextBox.Text, typeof(decimal))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(id_mesaToolStripTextBox.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fecha_reservaToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sp_insertar_reservaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea modificar la reserva?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    this.sp_modificar_reservaTableAdapter.Fill(this.restauranteDataSet.sp_modificar_reserva, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(id_reservaToolStripTextBox1.Text, typeof(decimal))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(documento_clienteToolStripTextBox1.Text, typeof(decimal))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(id_mesaToolStripTextBox1.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fecha_reservaToolStripTextBox1.Text, typeof(System.DateTime))))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar la reserva?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    this.sp_eliminar_reservasTableAdapter.Fill(this.restauranteDataSet.sp_eliminar_reservas, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(id_reservaToolStripTextBox2.Text, typeof(decimal))))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteDataSet.Fecha_reserva_cliente' Puede moverla o quitarla según sea necesario.
            this.fecha_reserva_clienteTableAdapter.Fill(this.restauranteDataSet.Fecha_reserva_cliente);

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

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
