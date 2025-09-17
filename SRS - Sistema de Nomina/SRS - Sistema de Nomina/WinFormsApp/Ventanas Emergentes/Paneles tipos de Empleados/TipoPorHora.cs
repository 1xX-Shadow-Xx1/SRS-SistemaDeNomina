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
    public partial class TipoPorHora : UserControl
    {
        EmergenteAgregar _emergenteAgregar;
        EmergenteEditar _emergenteEditar;
        public TipoPorHora(EmergenteAgregar emergente, EmergenteEditar emergenteEditar)
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
            EmpleadoServices services = new EmpleadoServices();

            string nombre = emergente.textBoxNombre.Text;
            string apellido = emergente.textBoxApellido.Text;
            string nss = emergente.textBoxNSS.Text;
            decimal sueldo = Decimal.Parse(textBoxSalarioPorHora.Text);
            int horas = Int32.Parse(textBoxHoras.Text);

            EmpleadoPorHoras empleadoPorHora = new EmpleadoPorHoras(nombre, apellido, nss, sueldo, horas);
            services.AddEmpleado(empleadoPorHora);

            MessageBox.Show("Empleado por horas agregado exitosamente");
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
            decimal sueldo = Decimal.Parse(textBoxSalarioPorHora.Text);
            int horas = Int32.Parse(textBoxHoras.Text);

            EmpleadoPorHoras empleadoPorHora = new EmpleadoPorHoras(nombre, apellido, nss, sueldo, horas);
            services.ActualizarEmpleado(empleadoPorHora);

            MessageBox.Show("Empleado por horas Editado exitosamente");
            var parentForm = _emergenteEditar.Owner as FormApp;
            parentForm?.RefrescarTablas();
            emergente.Close();

        }

        private void TipoPorHora_Load(object sender, EventArgs e)
        {
            if (_emergenteEditar != null)
            {

                EmergenteEditar emergente = _emergenteEditar;
                EmpleadoServices services = new EmpleadoServices();

                if(emergente.tipo == 3)
                {
                    EmpleadoPorHoras porHoras = (EmpleadoPorHoras)services.BuscarEmpleado(emergente.textBoxNSS.Text);
                    textBoxSalarioPorHora.Text = Convert.ToString(porHoras.SueldoPorHora);
                    textBoxHoras.Text = Convert.ToString(porHoras.HorasTrabajadas);
                }

                button1.Text = "Editar";

            }
            else if (_emergenteAgregar != null) button1.Text = "Agregar";

        }
    }
}
