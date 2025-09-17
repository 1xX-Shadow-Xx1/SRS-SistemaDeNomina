namespace WinFormsApp.Ventanas
{
    partial class UserControlAdministrar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewAdministrador = new DataGridView();
            TituloInicio = new Label();
            BotonAgregarAdmin = new Button();
            panelAdminOpciones = new Panel();
            BotonEliminarAdmin = new Button();
            BotonEditarAdmin = new Button();
            BotonLimpiarLista = new Button();
            BotonOpcionesAdmin = new CheckBox();
            labelListaEmpleadoAdministrar = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdministrador).BeginInit();
            panelAdminOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAdministrador
            // 
            dataGridViewAdministrador.AllowUserToAddRows = false;
            dataGridViewAdministrador.AllowUserToDeleteRows = false;
            dataGridViewAdministrador.Location = new Point(45, 124);
            dataGridViewAdministrador.Name = "dataGridViewAdministrador";
            dataGridViewAdministrador.ReadOnly = true;
            dataGridViewAdministrador.Size = new Size(887, 371);
            dataGridViewAdministrador.TabIndex = 2;
            // 
            // TituloInicio
            // 
            TituloInicio.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TituloInicio.Location = new Point(27, 20);
            TituloInicio.Name = "TituloInicio";
            TituloInicio.Size = new Size(413, 41);
            TituloInicio.TabIndex = 1;
            TituloInicio.Text = "Administrador de Empleados";
            // 
            // BotonAgregarAdmin
            // 
            BotonAgregarAdmin.Dock = DockStyle.Top;
            BotonAgregarAdmin.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonAgregarAdmin.Location = new Point(0, 0);
            BotonAgregarAdmin.Name = "BotonAgregarAdmin";
            BotonAgregarAdmin.Size = new Size(130, 35);
            BotonAgregarAdmin.TabIndex = 4;
            BotonAgregarAdmin.Text = "Agregar";
            BotonAgregarAdmin.UseVisualStyleBackColor = true;
            BotonAgregarAdmin.Click += BotonAgregarAdmin_Click;
            // 
            // panelAdminOpciones
            // 
            panelAdminOpciones.Controls.Add(BotonEliminarAdmin);
            panelAdminOpciones.Controls.Add(BotonEditarAdmin);
            panelAdminOpciones.Controls.Add(BotonAgregarAdmin);
            panelAdminOpciones.Location = new Point(64, 566);
            panelAdminOpciones.Name = "panelAdminOpciones";
            panelAdminOpciones.Size = new Size(130, 106);
            panelAdminOpciones.TabIndex = 9;
            panelAdminOpciones.Visible = false;
            // 
            // BotonEliminarAdmin
            // 
            BotonEliminarAdmin.Dock = DockStyle.Top;
            BotonEliminarAdmin.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonEliminarAdmin.Location = new Point(0, 70);
            BotonEliminarAdmin.Name = "BotonEliminarAdmin";
            BotonEliminarAdmin.Size = new Size(130, 35);
            BotonEliminarAdmin.TabIndex = 6;
            BotonEliminarAdmin.Text = "Eliminar";
            BotonEliminarAdmin.UseVisualStyleBackColor = true;
            BotonEliminarAdmin.Click += BotonEliminarAdmin_Click;
            // 
            // BotonEditarAdmin
            // 
            BotonEditarAdmin.Dock = DockStyle.Top;
            BotonEditarAdmin.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonEditarAdmin.Location = new Point(0, 35);
            BotonEditarAdmin.Name = "BotonEditarAdmin";
            BotonEditarAdmin.Size = new Size(130, 35);
            BotonEditarAdmin.TabIndex = 5;
            BotonEditarAdmin.Text = "Editar";
            BotonEditarAdmin.UseVisualStyleBackColor = true;
            BotonEditarAdmin.Click += BotonEditarAdmin_Click;
            // 
            // BotonLimpiarLista
            // 
            BotonLimpiarLista.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonLimpiarLista.Location = new Point(807, 636);
            BotonLimpiarLista.Name = "BotonLimpiarLista";
            BotonLimpiarLista.Size = new Size(125, 33);
            BotonLimpiarLista.TabIndex = 10;
            BotonLimpiarLista.Text = "Limpiar lista";
            BotonLimpiarLista.UseVisualStyleBackColor = true;
            BotonLimpiarLista.Click += BotonLimpiarLista_Click;
            // 
            // BotonOpcionesAdmin
            // 
            BotonOpcionesAdmin.Appearance = Appearance.Button;
            BotonOpcionesAdmin.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonOpcionesAdmin.Location = new Point(45, 528);
            BotonOpcionesAdmin.Name = "BotonOpcionesAdmin";
            BotonOpcionesAdmin.Size = new Size(99, 32);
            BotonOpcionesAdmin.TabIndex = 11;
            BotonOpcionesAdmin.Text = "Opciones";
            BotonOpcionesAdmin.TextAlign = ContentAlignment.MiddleCenter;
            BotonOpcionesAdmin.UseVisualStyleBackColor = true;
            BotonOpcionesAdmin.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // labelListaEmpleadoAdministrar
            // 
            labelListaEmpleadoAdministrar.AutoSize = true;
            labelListaEmpleadoAdministrar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelListaEmpleadoAdministrar.Location = new Point(45, 88);
            labelListaEmpleadoAdministrar.Name = "labelListaEmpleadoAdministrar";
            labelListaEmpleadoAdministrar.Size = new Size(184, 22);
            labelListaEmpleadoAdministrar.TabIndex = 12;
            labelListaEmpleadoAdministrar.Text = "Lista de Empleados";
            // 
            // UserControlAdministrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelListaEmpleadoAdministrar);
            Controls.Add(BotonOpcionesAdmin);
            Controls.Add(BotonLimpiarLista);
            Controls.Add(panelAdminOpciones);
            Controls.Add(TituloInicio);
            Controls.Add(dataGridViewAdministrador);
            Name = "UserControlAdministrar";
            Size = new Size(972, 696);
            Load += UserControlAdministrar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdministrador).EndInit();
            panelAdminOpciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TituloInicio;
        private Button BotonAgregarAdmin;
        private Panel panelAdminOpciones;
        private Button BotonEliminarAdmin;
        private Button BotonEditarAdmin;
        private Button BotonLimpiarLista;
        private CheckBox BotonOpcionesAdmin;
        public DataGridView dataGridViewAdministrador;
        private Label labelListaEmpleadoAdministrar;
    }
}
