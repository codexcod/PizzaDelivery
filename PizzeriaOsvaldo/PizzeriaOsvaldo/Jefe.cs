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
    public partial class frmJefe : Form
    {
        public frmJefe()
        {
            InitializeComponent();
        }

        private void btnSalirJefe_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Seguro que queres salir?", "consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            
        }
    }
}
