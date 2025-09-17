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
using WinFormsApp.Ventanas;
using WinFormsApp.Ventanas_Emergentes.Paneles_tipos_de_Empleados;

namespace WinFormsApp.Ventanas_Emergentes
{
    public partial class EmergenteAgregar : Form
    {
        UserControlAdministrar _userControlAdministrar;
        public EmergenteAgregar(UserControlAdministrar controlAdministrar)
        {
            InitializeComponent();
            _userControlAdministrar = controlAdministrar;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoAsalariado tipoAsalariado = new TipoAsalariado(this, null);
            TipoAsalariadoComi tipoAsalariadoComi = new TipoAsalariadoComi(this, null);
            TipoPorComision tipoComision = new TipoPorComision(this, null);
            TipoPorHora tipoPorHora = new TipoPorHora(this, null);

            tipoAsalariado.Dock = DockStyle.Fill;
            tipoAsalariadoComi.Dock = DockStyle.Fill;
            tipoComision.Dock = DockStyle.Fill;
            tipoPorHora.Dock = DockStyle.Fill;

            panelContenedorTipos.Controls.Clear();
            panelContenedorTipos.Controls.Add(tipoAsalariado);
            panelContenedorTipos.Controls.Add(tipoAsalariadoComi);
            panelContenedorTipos.Controls.Add(tipoComision);
            panelContenedorTipos.Controls.Add(tipoPorHora);

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    tipoAsalariado.BringToFront();
                    break;
                case 1:
                    tipoAsalariadoComi.BringToFront();
                    break;
                case 2:
                    tipoComision.BringToFront();
                    break;
                case 3:
                    tipoPorHora.BringToFront();
                    break;
                default:
                    break;
            }
        }
    }
}
