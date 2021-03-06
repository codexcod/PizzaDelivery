using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzeriaOsvaldo
{
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnPedidosPendientes_Click(object sender, EventArgs e)
        {
            PedidosPendiente pendientes = new PedidosPendiente();
            pendientes.Show(); 
        }

        private void btnVerPedido_Click(object sender, EventArgs e)
        {
            PedidoEnDetalle detalle = new PedidoEnDetalle();
            detalle.Show(); // or form.ShowDialog(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Seguro que queres salir?", "consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
