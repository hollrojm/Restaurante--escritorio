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
    public partial class Mesas : Form
    {
        public Mesas()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_insertar_mesaTableAdapter.Fill(this.restauranteDataSet.sp_insertar_mesa, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_mesaToolStripTextBox.Text, typeof(int))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(num_mesaToolStripTextBox.Text, typeof(decimal))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sp_insertar_mesaTableAdapter1.Fill(this.restauranteDataSet1.sp_insertar_mesa, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(num_mesaToolStripTextBox.Text, typeof(decimal))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void num_mesaToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                

                    this.sp_insertar_mesaTableAdapter2.Fill(this.restauranteDataSet2.sp_insertar_mesa, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_mesaToolStripTextBox.Text, typeof(int))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(num_mesaToolStripTextBox.Text, typeof(decimal))))));
                
                }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        

        private void Mesas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteDataSet.sp_consultar_mesa' Puede moverla o quitarla según sea necesario.
            this.sp_consultar_mesaTableAdapter.Fill(this.restauranteDataSet.sp_consultar_mesa);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_modificar_mesaTableAdapter.Fill(this.restauranteDataSet.sp_modificar_mesa, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_mesaToolStripTextBox1.Text, typeof(int))))), new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(num_mesaToolStripTextBox1.Text, typeof(decimal))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar la mesa?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {


                    this.sp_eliminar_mesaTableAdapter.Fill(this.restauranteDataSet.sp_eliminar_mesa, new System.Nullable<decimal>(((decimal)(System.Convert.ChangeType(num_mesaToolStripTextBox2.Text, typeof(decimal))))));
                }
                catch (System.Exception ex)
                {

                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
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
            Detallefactura factura = new Detallefactura();
            factura.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir del Sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
