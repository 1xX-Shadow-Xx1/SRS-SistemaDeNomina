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
    public partial class TipoAsalariadoComi : UserControl
    {
        EmergenteAgregar _emergenteAgregar;
        EmergenteEditar _emergenteEditar;
        public TipoAsalariadoComi(EmergenteAgregar emergente, EmergenteEditar emergenteEditar)
        {
            InitializeComponent();
            _emergenteAgregar = emergente;
            _emergenteEditar = emergenteEditar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_emergenteEditar != null) BtnEditar();
            else if (_emergenteAgregar != null) BtnAgregar();

        }

        private void BtnAgregar()
        {
            EmergenteAgregar emergente = _emergenteAgregar;
            string nombre = emergente.textBoxNombre.Text;
            string apellido = emergente.textBoxApellido.Text;
            string nss = emergente.textBoxNSS.Text;
            decimal tarifa = numericUpDownTarifa.Value;
            int ventas = Int32.Parse(textBoxVentas.Text);
            decimal salario = Decimal.Parse(textBoxSalario.Text);
            decimal Tax = tarifa / 100;

            EmpleadoAsalariadoPorComision empleadoAsalariadoPorComision = new EmpleadoAsalariadoPorComision(nombre, apellido, nss, Tax, ventas, salario);
            EmpleadoServices services = new EmpleadoServices();
            services.AddEmpleado(empleadoAsalariadoPorComision);

            MessageBox.Show("Empleado Agregado Exitosamente");
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
            int ventas = Int32.Parse(textBoxVentas.Text);
            decimal salario = Decimal.Parse(textBoxSalario.Text);
            decimal Tax = tarifa / 100;

            EmpleadoAsalariadoPorComision NewEmpleado = new EmpleadoAsalariadoPorComision(nombre,apellido,nss, Tax, ventas,salario);
            services.ActualizarEmpleado(NewEmpleado);

            MessageBox.Show("Empleado Editado Exitosamente");
            var parentForm = _emergenteEditar.Owner as FormApp;
            parentForm?.RefrescarTablas();
            emergente.Close();

        }

        private void TipoAsalariadoComi_Load(object sender, EventArgs e)
        {
            if (_emergenteEditar != null)
            {

                EmergenteEditar emergente = _emergenteEditar;
                EmpleadoServices services = new EmpleadoServices();

                if (emergente.tipo == 1)
                {
                    EmpleadoAsalariadoPorComision empleado = (EmpleadoAsalariadoPorComision)services.BuscarEmpleado(emergente.textBoxNSS.Text);

                    textBoxSalario.Text = Convert.ToString(empleado.SalarioBase);
                    textBoxVentas.Text = Convert.ToString(empleado.VentasBrutas);
                    int porciento = Convert.ToInt32(empleado.TarifaComision * 100);
                    numericUpDownTarifa.Value = porciento;
                }
                button1.Text = "Editar";

            }
            else if (_emergenteAgregar != null) button1.Text = "Agregar";
        }
    }
}
