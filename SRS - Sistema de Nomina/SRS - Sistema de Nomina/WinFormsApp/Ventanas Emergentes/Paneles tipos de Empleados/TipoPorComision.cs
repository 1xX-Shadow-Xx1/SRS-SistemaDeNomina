using ClassLibrary1;
using ClassLibrary1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Ventanas_Emergentes.Paneles_tipos_de_Empleados
{
    public partial class TipoPorComision : UserControl
    {
        EmergenteAgregar _emergenteAgregar;
        EmergenteEditar _emergenteEditar;
        public TipoPorComision(EmergenteAgregar emergente, EmergenteEditar emergenteEditar)
        {
            InitializeComponent();
            _emergenteAgregar = emergente;
            _emergenteEditar = emergenteEditar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_emergenteEditar != null) BtnEditar();
            else if(_emergenteAgregar != null) BtnAgregar();
        }

        private void BtnAgregar()
        {
            EmergenteAgregar emergente = _emergenteAgregar;
            EmpleadoServices services = new EmpleadoServices();

            string nombre = emergente.textBoxNombre.Text;
            string apellido = emergente.textBoxApellido.Text;
            string nss = emergente.textBoxNSS.Text;
            decimal tarifa = numericUpDownTarifa.Value;
            decimal ventas = Decimal.Parse(textBoxVentas.Text);
            decimal Tax = tarifa / 100;

            EmpleadoPorComision empleadoPorComision = new EmpleadoPorComision(nombre, apellido, nss, Tax, ventas);
            services.AddEmpleado(empleadoPorComision);

            MessageBox.Show("Empleado por comisión agregado exitosamente.");
            var parentForm = _emergenteAgregar.Owner as FormApp;
            parentForm?.RefrescarTablas();
            emergente.Close();
        }

        private void BtnEditar()
        {
            EmergenteEditar emergente = _emergenteEditar;
            EmpleadoServices services = new EmpleadoServices();

            string nombre = emergente.textBoxNombre.Text;
            string apellido = emergente.textBoxApellido.Text;
            string nss = emergente.textBoxNSS.Text;
            decimal tarifa = numericUpDownTarifa.Value;
            decimal ventas = Decimal.Parse(textBoxVentas.Text);
            decimal Tax = tarifa / 100;

            EmpleadoPorComision empleadoPorComision = new EmpleadoPorComision(nombre, apellido, nss, Tax, ventas);
            services.ActualizarEmpleado(empleadoPorComision);

            MessageBox.Show("Empleado por comisión Editado exitosamente.");
            var parentForm = _emergenteEditar.Owner as FormApp;
            parentForm?.RefrescarTablas();
            emergente.Close();
        }

        private void TipoPorComision_Load(object sender, EventArgs e)
        {
            if (_emergenteEditar != null)
            {
                EmergenteEditar emergente = _emergenteEditar;
                EmpleadoServices services = new EmpleadoServices();

                if (emergente.tipo == 2)
                {
                    EmpleadoPorComision porComision = (EmpleadoPorComision)services.BuscarEmpleado(emergente.textBoxNSS.Text);

                    textBoxVentas.Text = Convert.ToString(porComision.VentasBrutas);
                    int porciento = Convert.ToInt32(porComision.TarifaComision * 100);
                    numericUpDownTarifa.Value = porciento;
                }
                button1.Text = "Editar";
            }
            if(_emergenteAgregar == null) button1.Text = "Agregar";
        }
    }
}
