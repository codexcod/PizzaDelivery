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
    public partial class CreateEmpleado : Form
    {
        public CreateEmpleado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            using (PizzaDbEntities db = new PizzaDbEntities())
            {
                Empleado newEmpleado = new Empleado();
                newEmpleado.Nombre = txtNombre.Text;
                newEmpleado.Dni = txtDni.Text;
                newEmpleado.Telefono = txtTelefono.Text;
                newEmpleado.Direccion = txtDireccion.Text;
                newEmpleado.Sucursal1 = db.Sucursal.Where(d => d.idSucursal == int.Parse(cbSucursal.SelectedValue.ToString())).First();



                db.Empleado.Add(newEmpleado);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CreateEmpleado_Load(object sender, EventArgs e)
        {
            using (PizzaDbEntities db = new PizzaDbEntities())
            {
                var lstSucursales = db.Sucursal.ToList();
                cbSucursal.DataSource = lstSucursales;
                cbSucursal.DisplayMember = "Nombre";
                cbSucursal.ValueMember = "idSucursal";
            }
        }
    }
}
