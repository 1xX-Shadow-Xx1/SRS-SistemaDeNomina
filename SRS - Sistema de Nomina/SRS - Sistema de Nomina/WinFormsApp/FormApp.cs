using ClassLibrary1.Data;
using ClassLibrary1.Services;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp.Tablas;
using WinFormsApp.Ventanas;

namespace WinFormsApp
{
    public partial class FormApp : Form
    {
        EmpleadoRepository repository = new EmpleadoRepository();
        UserControlAdministrar VnAdministrar;
        UserControlInicio VnInicio;
        UserControlBuscar VnBuscar;
        UserControlListas VnListas;
        UserControlPago VnPago;
        UserControlReportes VnReportes;
        TablasForm tablas;

        public FormApp()
        {
            VnAdministrar = new UserControlAdministrar();
            VnInicio = new UserControlInicio();
            VnBuscar = new UserControlBuscar();
            VnListas = new UserControlListas();
            VnPago = new UserControlPago();
            VnReportes = new UserControlReportes();

            InitializeComponent();

            tablas = new TablasForm(VnInicio, VnAdministrar, VnListas, VnPago, VnReportes);
            tablas.RefrescarTabla();

            VnAdministrar.Dock = DockStyle.Fill;
            VnInicio.Dock = DockStyle.Fill;
            VnReportes.Dock = DockStyle.Fill;
            VnPago.Dock = DockStyle.Fill;
            VnListas.Dock = DockStyle.Fill;
            VnBuscar.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(VnInicio);
            panelContenedor.Controls.Add(VnPago);
            panelContenedor.Controls.Add(VnListas);
            panelContenedor.Controls.Add(VnBuscar);
            panelContenedor.Controls.Add(VnReportes);
            panelContenedor.Controls.Add(VnAdministrar);
        }

        private void BotonInicio_CheckedChanged(object sender, EventArgs e)
        {
            tablas.DataBase();
            VnInicio.BringToFront();
        }

        private void BotonAdministrarEmpleados_CheckedChanged(object sender, EventArgs e)
        {
            tablas.DataBase();
            VnAdministrar.BringToFront();
        }
        public void RefrescarTablas()
        {
            tablas.RefrescarTabla();
        }

        private void BotonPago_CheckedChanged(object sender, EventArgs e)
        {
            tablas.refrescarTablaPagos();
            VnPago.BringToFront();
        }

        private void BotonLista_CheckedChanged(object sender, EventArgs e)
        {
            tablas.refrescarTablaAsalariado();
            tablas.refrescarTablaAsalariadoConComision();
            tablas.refrescarTablaPorComision();
            tablas.refrescarTablaPorHora();
            VnListas.BringToFront();
        }

        private void BotonReportes_CheckedChanged(object sender, EventArgs e)
        {
            tablas.refrescarTablaPagos();
            VnReportes.BringToFront();
        }

        private void BotonBuscarEmpleados_CheckedChanged(object sender, EventArgs e)
        {
            VnBuscar.BringToFront();
            VnBuscar.TxtInfoNombre.Text = "";
            VnBuscar.TxtInfoApellido.Text = "";
            VnBuscar.TxtInfoNSS.Text = "";
            VnBuscar.TxtInfoTipoEmpleado.Text = "";
            VnBuscar.TxtInfoPago.Text = "";
            VnBuscar.panelInfoEmpleado.Visible = false;
        }
    }

}
