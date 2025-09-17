using ClassLibrary1;
using ClassLibrary1.Data;
using ClassLibrary1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Tablas;
using WinFormsApp.Ventanas_Emergentes;
using WinFormsApp.Ventanas_Emergentes.Paneles_tipos_de_Empleados;

namespace WinFormsApp.Ventanas
{
    public partial class UserControlAdministrar : UserControl
    {
        TablasForm tablas;
        public UserControlAdministrar()
        {
            InitializeComponent();
        }

        private void UserControlAdministrar_Load(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (BotonOpcionesAdmin.Checked == false)
            {
                panelAdminOpciones.Visible = false;
            }
            else
            {
                panelAdminOpciones.Visible = true;
            }
        }

        private void BotonAgregarAdmin_Click(object sender, EventArgs e)
        {
            var parentForm = this.FindForm() as FormApp;
            if (parentForm != null)
            {
                EmergenteAgregar agregar = new EmergenteAgregar(this);
                agregar.Owner = parentForm;
                agregar.Show();
            }

        }

        private void BotonLimpiarLista_Click(object sender, EventArgs e)
        {
            EmpleadoServices service = new EmpleadoServices();

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar todos los empleados?", "Confirmar eliminación", buttons);
            if (result == DialogResult.Yes)
            {
                service.LimpiarListaEmpleadosForm();
                MessageBox.Show("Todos los empleados han sido eliminados.");
                var parentForm = this.FindForm() as FormApp;
                parentForm?.RefrescarTablas();
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }

        private void BotonEditarAdmin_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRowCollection = dataGridViewAdministrador.SelectedRows;

            if (selectedRowCollection == null || selectedRowCollection.Count == 0)
            {
                MessageBox.Show("No ha selccionado ningun Empleado todavia de la lista. ");
                return;
            }

            foreach (DataGridViewRow row in selectedRowCollection)
            {
                nombre = row.Cells["Nombre"].Value.ToString();
                apellido = row.Cells["Apellido"].Value.ToString();
                nss = row.Cells["NSS"].Value.ToString();
                tipoEmpleado = row.Cells["Tipo de Empleado"].Value.ToString();
            }


            EmergenteEditar emergente = new EmergenteEditar(this);
            var parentForm = this.FindForm() as FormApp;
            emergente.Owner = parentForm;
            emergente.Show();
        }

        private void BotonEliminarAdmin_Click(object sender, EventArgs e)
        {
            EmpleadoServices services = new EmpleadoServices();

            DataGridViewSelectedRowCollection selectedRowCollection = dataGridViewAdministrador.SelectedRows;

            if (selectedRowCollection == null || selectedRowCollection.Count == 0)
            {
                MessageBox.Show("No ha selccionado ningun Empleado todavia de la lista. ");
                return;
            }

            foreach (DataGridViewRow row in selectedRowCollection)
            {
                nombre = row.Cells["Nombre"].Value.ToString();
                apellido = row.Cells["Apellido"].Value.ToString();
                nss = row.Cells["NSS"].Value.ToString();
                tipoEmpleado = row.Cells["Tipo de Empleado"].Value.ToString();
            }

            var result = MessageBox.Show($"Estas seguro de eliminar a {nombre} {apellido} NSS: {nss}?","Eliminar Empleado",MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) 
            { 
                services.RemoveEmpleado(nss); 
                MessageBox.Show("Empleado Eliminado");
                var parentForm = this.FindForm() as FormApp;
                parentForm?.RefrescarTablas();
            }
            else MessageBox.Show("Operación cancelada.");

        }

        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nss { get; set; }
        public string tipoEmpleado { get; set; }
    }
}
