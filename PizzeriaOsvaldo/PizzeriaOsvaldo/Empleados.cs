using PizzeriaOsvaldo.Datos;
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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Seguro que queres salir?", "consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CreateEmpleado createEmpleado = new CreateEmpleado();
            createEmpleado.Show(); // or form.ShowDialog(this);
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            using (PizzaDbEntities db = new PizzaDbEntities())
            {
                dataEmpleados.AutoGenerateColumns = false;
                var lstEmpleados = db.Empleado.ToList();
                dataEmpleados.DataSource = lstEmpleados;
            }
        }

        private void dataEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
