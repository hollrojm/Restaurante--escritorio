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
    public partial class ConsultaEmp : Form
    {
        public ConsultaEmp()
        {
            InitializeComponent();
        }

        private void ConsultaEmp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'restauranteDataSet.sp_consultar_empleado' Puede moverla o quitarla según sea necesario.
            this.sp_consultar_empleadoTableAdapter.Fill(this.restauranteDataSet.sp_consultar_empleado);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
