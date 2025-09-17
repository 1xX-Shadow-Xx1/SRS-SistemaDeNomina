using ClassLibrary1;
using ClassLibrary1.Data;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp.Ventanas;

namespace WinFormsApp.Tablas
{
    public class TablasForm
    {
        private readonly EmpleadoRepository repository = new EmpleadoRepository();
        private readonly UserControlAdministrar VnAdministrar;
        private readonly UserControlInicio VnInicio;
        private readonly UserControlListas VnListas;
        private readonly UserControlPago VnPago;
        private readonly UserControlReportes VnReportes;
        private readonly DataTable DTableBase = new DataTable(); 
        private readonly DataTable TablaAsalariado = new DataTable();
        private readonly DataTable TablaAsalariadoConComision = new DataTable();
        private readonly DataTable TablaPorComision = new DataTable();
        private readonly DataTable TablaPorHora = new DataTable();
        private readonly DataTable TablaPagos = new DataTable();

        public TablasForm(UserControlInicio inicio, UserControlAdministrar administrar, UserControlListas vnListas, UserControlPago vnPago, UserControlReportes vnReportes)
        {
            VnInicio = inicio;
            VnAdministrar = administrar;
            VnListas = vnListas;
            VnPago = vnPago;
            VnReportes = vnReportes;

            CrearTablaBase();
            ConfigurarDataGrids();
            test();
        }

        private void CrearTablaBase()
        {
            DTableBase.Columns.Add("Nombre", typeof(string));
            DTableBase.Columns.Add("Apellido", typeof(string));
            DTableBase.Columns.Add("NSS", typeof(string));
            DTableBase.Columns.Add("Tipo de Empleado", typeof(string));
            DTableBase.Columns.Add("Salario", typeof(string));

            TablaAsalariado.Columns.Add("Nombre", typeof(string));
            TablaAsalariado.Columns.Add("Apellido", typeof(string));
            TablaAsalariado.Columns.Add("NSS", typeof(string));
            TablaAsalariado.Columns.Add("Salario Semanal", typeof(string));

            TablaAsalariadoConComision.Columns.Add("Nombre", typeof(string));
            TablaAsalariadoConComision.Columns.Add("Apellido", typeof(string));
            TablaAsalariadoConComision.Columns.Add("NSS", typeof(string));
            TablaAsalariadoConComision.Columns.Add("Comision", typeof(string));
            TablaAsalariadoConComision.Columns.Add("Ventas", typeof(string));
            TablaAsalariadoConComision.Columns.Add("Salario Base", typeof(string));
            TablaAsalariadoConComision.Columns.Add("Salario", typeof(string));


            TablaPorComision.Columns.Add("Nombre", typeof(string));
            TablaPorComision.Columns.Add("Apellido", typeof(string));
            TablaPorComision.Columns.Add("NSS", typeof(string));
            TablaPorComision.Columns.Add("Comision", typeof(string));
            TablaPorComision.Columns.Add("Ventas", typeof(string));
            TablaPorComision.Columns.Add("Salario", typeof(string));

            TablaPorHora.Columns.Add("Nombre", typeof(string));
            TablaPorHora.Columns.Add("Apellido", typeof(string));
            TablaPorHora.Columns.Add("NSS", typeof(string));
            TablaPorHora.Columns.Add("Sueldo por hora", typeof(string));
            TablaPorHora.Columns.Add("Horas", typeof(string));
            TablaPorHora.Columns.Add("Salario", typeof(string));


            TablaPagos.Columns.Add("Nombre", typeof(string));
            TablaPagos.Columns.Add("Apellido", typeof(string));
            TablaPagos.Columns.Add("NSS", typeof(string));
            TablaPagos.Columns.Add("Tipo de Empleado", typeof(string));
            TablaPagos.Columns.Add("Pago", typeof(string));

        }

        private void ConfigurarDataGrids()
        {
            VnInicio.dataGridViewInicio.DataSource = DTableBase;
            VnInicio.dataGridViewInicio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            VnAdministrar.dataGridViewAdministrador.DataSource = DTableBase;
            VnAdministrar.dataGridViewAdministrador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            VnListas.DataGridViewAsalariado.DataSource = TablaAsalariado;
            VnListas.DataGridViewAsalariado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            VnListas.DataGridViewAsalariadoConComision.DataSource = TablaAsalariadoConComision;
            VnListas.DataGridViewAsalariadoConComision.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            VnListas.DataGridViewPorComision.DataSource = TablaPorComision;
            VnListas.DataGridViewPorComision.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            VnListas.DataGridViewPorHora.DataSource = TablaPorHora;
            VnListas.DataGridViewPorHora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            VnPago.DataGridViewPagos.DataSource = TablaPagos;
            VnPago.DataGridViewPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            VnReportes.DataGridViewReporte.DataSource = TablaPagos;
            VnReportes.DataGridViewReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void RefrescarTabla()
        {
            DTableBase.Clear();
            TablaAsalariado.Clear();
            TablaAsalariadoConComision.Clear();
            TablaPorComision.Clear();
            TablaPorHora.Clear();
            TablaPagos.Clear();

            foreach (var emp in repository.ObtenerEmpleados())
            {
                DataRow dr = DTableBase.NewRow();
                dr["Nombre"] = emp.PrimerNombre;
                dr["Apellido"] = emp.ApellidoPaterno;
                dr["NSS"] = emp.NumeroSeguroSocial;
                dr["Tipo de Empleado"] = emp.TipoEmpleado;
                dr["Salario"] = $"{emp.Ingresos():C}";
                DTableBase.Rows.Add(dr);
            }

            foreach(var emp in repository.ObtenerEmpleados())
            {
                if (emp.TipoEmpleado == "Empleado Asalariado")
                {
                    EmpleadoAsalariado empleado = (EmpleadoAsalariado)emp;
                    DataRow dr = TablaAsalariado.NewRow();
                    dr["Nombre"] = empleado.PrimerNombre;
                    dr["Apellido"] = empleado.ApellidoPaterno;
                    dr["NSS"] = empleado.NumeroSeguroSocial;
                    dr["Salario Semanal"] = $"{empleado.SalarioSemanal:C}";
                    TablaAsalariado.Rows.Add(dr);
                }
            }

            foreach (var emp in repository.ObtenerEmpleados())
            {
                if (emp.TipoEmpleado == "Empleado Asalariado por Comisión")
                {
                    EmpleadoAsalariadoPorComision empleado = (EmpleadoAsalariadoPorComision)emp;
                    decimal TAX = empleado.TarifaComision * 100;
                    string tx = $"{(int)TAX}%";
                    DataRow dr = TablaAsalariadoConComision.NewRow();
                    dr["Nombre"] = empleado.PrimerNombre;
                    dr["Apellido"] = empleado.ApellidoPaterno;
                    dr["NSS"] = empleado.NumeroSeguroSocial;
                    dr["Comision"] = tx;
                    dr["Ventas"] = $"{empleado.VentasBrutas:C}";
                    dr["Salario Base"] = $"{empleado.SalarioBase:C}";
                    dr["Salario"] = $"{empleado.Ingresos():C}";
                    TablaAsalariadoConComision.Rows.Add(dr);
                }
            }

            foreach (var emp in repository.ObtenerEmpleados())
            {
                if (emp.TipoEmpleado == "Empleado por Comisión")
                {
                    EmpleadoPorComision empleado = (EmpleadoPorComision)emp;
                    decimal TAX = empleado.TarifaComision * 100;
                    string tx = $"{(int)TAX}%";
                    DataRow dr = TablaPorComision.NewRow();
                    dr["Nombre"] = empleado.PrimerNombre;
                    dr["Apellido"] = empleado.ApellidoPaterno;
                    dr["NSS"] = empleado.NumeroSeguroSocial;
                    dr["Comision"] = tx;
                    dr["Ventas"] = $"{empleado.VentasBrutas:C}";
                    dr["Salario"] = $"{empleado.Ingresos():C}";
                    TablaPorComision.Rows.Add(dr);
                }
            }

            foreach (var emp in repository.ObtenerEmpleados())
            {
                if (emp.TipoEmpleado == "Empleado por Horas")
                {
                    EmpleadoPorHoras empleado = (EmpleadoPorHoras)emp;
                    string horas = $"{empleado.HorasTrabajadas}h";
                    DataRow dr = TablaPorHora.NewRow();
                    dr["Nombre"] = empleado.PrimerNombre;
                    dr["Apellido"] = empleado.ApellidoPaterno;
                    dr["NSS"] = empleado.NumeroSeguroSocial;
                    dr["Sueldo por hora"] = $"{empleado.SueldoPorHora:C}";
                    dr["Horas"] = horas;
                    dr["Salario"] = $"{empleado.Ingresos():C}";
                    TablaPorHora.Rows.Add(dr);
                }
            }

            decimal pago = 0;
            foreach (var emp in repository.ObtenerEmpleados())
            {
                DataRow dr = TablaPagos.NewRow();
                dr["Nombre"] = emp.PrimerNombre;
                dr["Apellido"] = emp.ApellidoPaterno;
                dr["NSS"] = emp.NumeroSeguroSocial;
                dr["Tipo de Empleado"] = emp.TipoEmpleado;
                dr["Pago"] = $"{emp.Ingresos():C}";
                pago += emp.Ingresos();
                TablaPagos.Rows.Add(dr);
            }
            VnPago.TxtNumericoTotaldePagos.Text = $"{pago:C}";
        }
        public void test()
        {

            EmpleadoAsalariado empleadoAsalariado = new EmpleadoAsalariado("Juan", "Perez", "101", 800m);
            EmpleadoPorHoras empleadoPorHoras = new EmpleadoPorHoras("Ana", "Gomez", "102", 20m, 40);
            EmpleadoPorComision empleadoPorComision = new EmpleadoPorComision("Luis", "Martinez", "103", 0.06m, 10000m);
            EmpleadoAsalariadoPorComision empleadoAsalariadoPorComision = new EmpleadoAsalariadoPorComision("Maria", "Lopez", "104", 0.04m, 300m, 5000m);

            for (int i = 0; i < 20; i++)
            {
                repository.AgregarEmpleado(new EmpleadoAsalariado($"Nombre: Test{i}", $"Apellido Ta{i}", $"{i:D3}", 1000.00m + i));
                i++;
                repository.AgregarEmpleado(new EmpleadoPorHoras($"Nombre: Test{i}", $"Apellido Ta{i}", $"{i:D3}", 1000m + i, i));
                i++;
                repository.AgregarEmpleado(new EmpleadoPorComision($"Nombre: Test{i}", $"Apellido Ta{i}", $"{i:D3}",0.05m, 1000m + i));
                i++;
                repository.AgregarEmpleado(new EmpleadoAsalariadoPorComision($"Nombre: Test{i}", $"Apellido Ta{i}", $"{i:D3}", 0.08m, 2000m + i, 1000m + i));
                i++;
            }
        }
    }
}

