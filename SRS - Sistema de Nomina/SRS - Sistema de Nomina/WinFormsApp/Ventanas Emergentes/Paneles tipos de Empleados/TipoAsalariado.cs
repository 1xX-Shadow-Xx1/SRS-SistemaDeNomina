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
using WinFormsApp.Tablas;

namespace WinFormsApp.Ventanas_Emergentes.Paneles_tipos_de_Empleados
{

    public partial class TipoAsalariado : UserControl
    {
        EmergenteAgregar _emergenteAgregar;
        EmergenteEditar _emergenteEditar;

        public TipoAsalariado(EmergenteAgregar emergente, EmergenteEditar emergenteEditar)
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
            EmpleadoServices services = new EmpleadoServices();

            EmergenteAgregar emergente = _emergenteAgregar;

            string nombre = emergente.textBoxNombre.Text;
            string apellido = emergente.textBoxApellido.Text;
            string nss = emergente.textBoxNSS.Text;
            decimal salario = Decimal.Parse(textBoxAsalariado.Text);

            EmpleadoAsalariado empleadoAsalariado = new EmpleadoAsalariado(nombre, apellido, nss, salario);
            services.AddEmpleado(empleadoAsalariado);

            MessageBox.Show("Empleado Agregado Exitosamente");
            var parentForm = _emergenteAgregar.Owner as FormApp;
            parentForm?.RefrescarTablas();
            emergente.Close();
        }
        private void BtnEditar()
        {
            EmpleadoServices services = new EmpleadoServices();
            EmergenteEditar emergente = _emergenteEditar;

            string nombre = emergente.textBoxNombre.Text;
            string apellido = emergente.textBoxApellido.Text;
            string nss = emergente.textBoxNSS.Text;
            decimal salario = Decimal.Parse(textBoxAsalariado.Text);

            EmpleadoAsalariado empleado = new EmpleadoAsalariado(nombre, apellido, nss, salario);
            services.ActualizarEmpleado(empleado, nss);
            MessageBox.Show("Empleado Editado Exitosamente");

            var parentForm = _emergenteEditar.Owner as FormApp;
            parentForm?.RefrescarTablas();
            emergente.Close();

        }

        private void TipoAsalariado_Load(object sender, EventArgs e)
        {
            if (_emergenteEditar != null)
            {
                EmergenteEditar emergente = _emergenteEditar;
                EmpleadoServices services = new EmpleadoServices();
                button1.Text = "Editar";

                if (emergente.tipo == 0)
                {
                    EmpleadoAsalariado porHoras = (EmpleadoAsalariado)services.BuscarEmpleado(emergente.textBoxNSS.Text);
                    textBoxAsalariado.Text = Convert.ToString(porHoras.SalarioSemanal);
                }

            }
            else if (_emergenteAgregar != null) button1.Text = "Agregar"; 
        }
    }
}
