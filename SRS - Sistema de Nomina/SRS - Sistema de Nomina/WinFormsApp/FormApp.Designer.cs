namespace WinFormsApp
{
    partial class FormApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panelMenu = new Panel();
            BotonAdministrarEmpleados = new RadioButton();
            BotonBuscarEmpleados = new RadioButton();
            BotonReportes = new RadioButton();
            BotonLista = new RadioButton();
            BotonPago = new RadioButton();
            BotonInicio = new RadioButton();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(panelMenu);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 696);
            panel1.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(BotonAdministrarEmpleados);
            panelMenu.Controls.Add(BotonBuscarEmpleados);
            panelMenu.Controls.Add(BotonReportes);
            panelMenu.Controls.Add(BotonLista);
            panelMenu.Controls.Add(BotonPago);
            panelMenu.Controls.Add(BotonInicio);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 239);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(313, 457);
            panelMenu.TabIndex = 1;
            // 
            // BotonAdministrarEmpleados
            // 
            BotonAdministrarEmpleados.Appearance = Appearance.Button;
            BotonAdministrarEmpleados.Dock = DockStyle.Top;
            BotonAdministrarEmpleados.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonAdministrarEmpleados.Location = new Point(0, 305);
            BotonAdministrarEmpleados.Name = "BotonAdministrarEmpleados";
            BotonAdministrarEmpleados.Size = new Size(313, 61);
            BotonAdministrarEmpleados.TabIndex = 5;
            BotonAdministrarEmpleados.Text = "Administrar Empleados";
            BotonAdministrarEmpleados.TextAlign = ContentAlignment.MiddleCenter;
            BotonAdministrarEmpleados.UseVisualStyleBackColor = true;
            BotonAdministrarEmpleados.CheckedChanged += BotonAdministrarEmpleados_CheckedChanged;
            // 
            // BotonBuscarEmpleados
            // 
            BotonBuscarEmpleados.Appearance = Appearance.Button;
            BotonBuscarEmpleados.Dock = DockStyle.Top;
            BotonBuscarEmpleados.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBuscarEmpleados.Location = new Point(0, 244);
            BotonBuscarEmpleados.Name = "BotonBuscarEmpleados";
            BotonBuscarEmpleados.Size = new Size(313, 61);
            BotonBuscarEmpleados.TabIndex = 4;
            BotonBuscarEmpleados.Text = "Buscar Empleados";
            BotonBuscarEmpleados.TextAlign = ContentAlignment.MiddleCenter;
            BotonBuscarEmpleados.UseVisualStyleBackColor = true;
            BotonBuscarEmpleados.CheckedChanged += BotonBuscarEmpleados_CheckedChanged;
            // 
            // BotonReportes
            // 
            BotonReportes.Appearance = Appearance.Button;
            BotonReportes.Dock = DockStyle.Top;
            BotonReportes.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonReportes.Location = new Point(0, 183);
            BotonReportes.Name = "BotonReportes";
            BotonReportes.Size = new Size(313, 61);
            BotonReportes.TabIndex = 3;
            BotonReportes.Text = "Reportes";
            BotonReportes.TextAlign = ContentAlignment.MiddleCenter;
            BotonReportes.UseVisualStyleBackColor = true;
            BotonReportes.CheckedChanged += BotonReportes_CheckedChanged;
            // 
            // BotonLista
            // 
            BotonLista.Appearance = Appearance.Button;
            BotonLista.Dock = DockStyle.Top;
            BotonLista.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonLista.Location = new Point(0, 122);
            BotonLista.Name = "BotonLista";
            BotonLista.Size = new Size(313, 61);
            BotonLista.TabIndex = 2;
            BotonLista.Text = "Lista";
            BotonLista.TextAlign = ContentAlignment.MiddleCenter;
            BotonLista.UseVisualStyleBackColor = true;
            BotonLista.CheckedChanged += BotonLista_CheckedChanged;
            // 
            // BotonPago
            // 
            BotonPago.Appearance = Appearance.Button;
            BotonPago.Dock = DockStyle.Top;
            BotonPago.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonPago.Location = new Point(0, 61);
            BotonPago.Name = "BotonPago";
            BotonPago.Size = new Size(313, 61);
            BotonPago.TabIndex = 1;
            BotonPago.Text = "Pago";
            BotonPago.TextAlign = ContentAlignment.MiddleCenter;
            BotonPago.UseVisualStyleBackColor = true;
            BotonPago.CheckedChanged += BotonPago_CheckedChanged;
            // 
            // BotonInicio
            // 
            BotonInicio.Appearance = Appearance.Button;
            BotonInicio.CheckAlign = ContentAlignment.MiddleCenter;
            BotonInicio.Checked = true;
            BotonInicio.Cursor = Cursors.Hand;
            BotonInicio.Dock = DockStyle.Top;
            BotonInicio.FlatAppearance.BorderColor = Color.MediumBlue;
            BotonInicio.FlatAppearance.CheckedBackColor = Color.Blue;
            BotonInicio.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            BotonInicio.FlatAppearance.MouseOverBackColor = Color.Red;
            BotonInicio.FlatStyle = FlatStyle.System;
            BotonInicio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonInicio.Location = new Point(0, 0);
            BotonInicio.Name = "BotonInicio";
            BotonInicio.Size = new Size(313, 61);
            BotonInicio.TabIndex = 0;
            BotonInicio.TabStop = true;
            BotonInicio.Text = "Inicio";
            BotonInicio.TextAlign = ContentAlignment.MiddleCenter;
            BotonInicio.UseVisualStyleBackColor = false;
            BotonInicio.CheckedChanged += BotonInicio_CheckedChanged;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(313, 239);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dropbox;
            pictureBox1.Location = new Point(29, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(313, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(972, 696);
            panelContenedor.TabIndex = 1;
            // 
            // FormApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 696);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Name = "FormApp";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelContenedor;
        private Panel panelMenu;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private RadioButton BotonAdministrarEmpleados;
        private RadioButton BotonBuscarEmpleados;
        private RadioButton BotonReportes;
        private RadioButton BotonLista;
        private RadioButton BotonPago;
        private RadioButton BotonInicio;
    }
}
