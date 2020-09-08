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
    public partial class Platos : Form
    {
        public Platos()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este plato?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    this.sp_insertar_platoTableAdapter.Fill(this.restauranteDataSet.sp_insertar_plato, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_platoToolStripTextBox.Text, typeof(int))))), nombre_platoToolStripTextBox.Text, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(precio_platoToolStripTextBox.Text, typeof(decimal))))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sp_insertar_plato2TableAdapter.Fill(this.restauranteDataSet3.sp_insertar_plato2, nombre_platoToolStripTextBox.Text, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(precio_platoToolStripTextBox.Text, typeof(decimal))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_eliminar_platoTableAdapter.Fill(this.restauranteDataSet.sp_eliminar_plato, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_platoToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void Platos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteDataSet.sp_consultar_consultar_plato' Puede moverla o quitarla según sea necesario.
            this.sp_consultar_consultar_platoTableAdapter.Fill(this.restauranteDataSet.sp_consultar_consultar_plato);

        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detallefactura factura = new Detallefactura();
            factura.Show();
            this.Hide();
        }
    }
}
