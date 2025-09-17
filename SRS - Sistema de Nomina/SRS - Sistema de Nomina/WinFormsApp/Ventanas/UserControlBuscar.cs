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

namespace WinFormsApp.Ventanas
{
    public partial class UserControlBuscar : UserControl
    {
        public UserControlBuscar()
        {
            InitializeComponent();
        }

        private void buttonInfoBuscar_Click(object sender, EventArgs e)
        {
            EmpleadoServices services = new EmpleadoServices();
            string nss = textBoxInfoBuscar.Text;
            Empleado empleado = services.BuscarEmpleado(nss);

            if (empleado != null)
            {

                TxtInfoNombre.Text = empleado.PrimerNombre;
                TxtInfoApellido.Text = empleado.ApellidoPaterno;
                TxtInfoNSS.Text = empleado.NumeroSeguroSocial;
                TxtInfoTipoEmpleado.Text = empleado.TipoEmpleado;
                TxtInfoPago.Text = $"{empleado.Ingresos():C}";

                panelInfoEmpleado.Visible = true;
            }
            else MessageBox.Show("Empleado no encontrado");
        }
    }
}
