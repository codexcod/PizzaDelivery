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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos pedidos = new frmPedidos();
            pedidos.Show(); 
        }

        private void btnJefe_Click(object sender, EventArgs e)
        {
            frmJefe jefe = new frmJefe();
            jefe.Show();
        }

        private void btnGerente_Click(object sender, EventArgs e)
        {
            frmGerente gerente = new frmGerente();
            gerente.Show();
        }

                
    }
}
