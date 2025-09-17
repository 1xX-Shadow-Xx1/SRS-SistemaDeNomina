using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Ventanas;
using WinFormsApp.Ventanas_Emergentes.Paneles_tipos_de_Empleados;

namespace WinFormsApp.Ventanas_Emergentes
{
    public partial class EmergenteEditar : Form
    {
        UserControlAdministrar _userControlAdministrar;
        public EmergenteEditar(UserControlAdministrar controlAdministrar)
        {
            InitializeComponent();
            _userControlAdministrar = controlAdministrar;
            PrepararVentanaEditar();

        }

        public void PrepararVentanaEditar()
        {
            UserControlAdministrar administrar = _userControlAdministrar;

            textBoxNombre.Text = administrar.nombre;
            textBoxApellido.Text = administrar.apellido;
            textBoxNSS.Text = administrar.nss;

            comboBoxTipoEmpleado.SelectedItem = administrar.tipoEmpleado;
            switch (administrar.tipoEmpleado)
            {
                case "Empleado Asalariado": tipo = 0; break;
                case "Empleado Asalariado por Comisión": tipo = 1; break;
                case "Empleado por Comisión": tipo = 2; break;
                case "Empleado por Horas": tipo = 3; break;
                default:
                    MessageBox.Show("No seleccionaste");
                    break;
            }

        }

        private void comboBoxTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBoxTipoEmpleado.SelectedIndex;
            
            TipoAsalariado tipoAsalariado = new TipoAsalariado(null, this);
            TipoAsalariadoComi tipoAsalariadoComi = new TipoAsalariadoComi(null, this);
            TipoPorComision tipoComision = new TipoPorComision(null, this);
            TipoPorHora tipoPorHora = new TipoPorHora(null, this);

            tipoAsalariado.Dock = DockStyle.Fill;
            tipoAsalariadoComi.Dock = DockStyle.Fill;
            tipoComision.Dock = DockStyle.Fill;
            tipoPorHora.Dock = DockStyle.Fill;

            panelContenedorEditarTiposEmpleados.Controls.Clear();
            panelContenedorEditarTiposEmpleados.Controls.Add(tipoAsalariado);
            panelContenedorEditarTiposEmpleados.Controls.Add(tipoAsalariadoComi);
            panelContenedorEditarTiposEmpleados.Controls.Add(tipoComision);
            panelContenedorEditarTiposEmpleados.Controls.Add(tipoPorHora);


            switch (indice)
            {
                case 0: tipoAsalariado.BringToFront(); break;
                case 1: tipoAsalariadoComi.BringToFront(); break;
                case 2: tipoComision.BringToFront(); break;
                case 3: tipoPorHora.BringToFront(); break;
                default:
                    return;
            }
        }
        public int tipo { get; set; }
    }
}
