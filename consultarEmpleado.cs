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
    public partial class consultarEmpleado : Form
    {
        public consultarEmpleado()
        {
            InitializeComponent();
        }

        private void consultarEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteDataSet.sp_consultar_empleado' Puede moverla o quitarla según sea necesario.
            this.sp_consultar_empleadoTableAdapter.Fill(this.restauranteDataSet.sp_consultar_empleado);

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
