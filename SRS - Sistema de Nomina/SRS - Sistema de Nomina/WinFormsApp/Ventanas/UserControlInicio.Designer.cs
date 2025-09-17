namespace WinFormsApp.Ventanas
{
    partial class UserControlInicio
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
            label1 = new Label();
            labelListaEmpleadoInicio = new Label();
            dataGridViewInicio = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInicio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 0;
            label1.Text = "Inicio";
            // 
            // labelListaEmpleadoInicio
            // 
            labelListaEmpleadoInicio.AutoSize = true;
            labelListaEmpleadoInicio.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelListaEmpleadoInicio.Location = new Point(43, 89);
            labelListaEmpleadoInicio.Name = "labelListaEmpleadoInicio";
            labelListaEmpleadoInicio.Size = new Size(110, 22);
            labelListaEmpleadoInicio.TabIndex = 4;
            labelListaEmpleadoInicio.Text = "Empleados";
            // 
            // dataGridViewInicio
            // 
            dataGridViewInicio.AllowUserToAddRows = false;
            dataGridViewInicio.AllowUserToDeleteRows = false;
            dataGridViewInicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInicio.Location = new Point(41, 134);
            dataGridViewInicio.Name = "dataGridViewInicio";
            dataGridViewInicio.ReadOnly = true;
            dataGridViewInicio.Size = new Size(883, 392);
            dataGridViewInicio.TabIndex = 5;
            dataGridViewInicio.TabStop = false;
            // 
            // UserControlInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewInicio);
            Controls.Add(labelListaEmpleadoInicio);
            Controls.Add(label1);
            Name = "UserControlInicio";
            Size = new Size(972, 696);
            Load += UserControlInicio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelListaEmpleadoInicio;
        public DataGridView dataGridViewInicio;
    }
}
