namespace WinFormsApp.Ventanas
{
    partial class UserControlReportes
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
            TituloReporte = new Label();
            DataGridViewReporte = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewReporte).BeginInit();
            SuspendLayout();
            // 
            // TituloReporte
            // 
            TituloReporte.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TituloReporte.Location = new Point(27, 20);
            TituloReporte.Name = "TituloReporte";
            TituloReporte.Size = new Size(144, 41);
            TituloReporte.TabIndex = 2;
            TituloReporte.Text = "Reportes";
            // 
            // DataGridViewReporte
            // 
            DataGridViewReporte.AllowUserToAddRows = false;
            DataGridViewReporte.AllowUserToDeleteRows = false;
            DataGridViewReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewReporte.Location = new Point(48, 127);
            DataGridViewReporte.Name = "DataGridViewReporte";
            DataGridViewReporte.ReadOnly = true;
            DataGridViewReporte.Size = new Size(861, 414);
            DataGridViewReporte.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(757, 609);
            button1.Name = "button1";
            button1.Size = new Size(152, 36);
            button1.TabIndex = 4;
            button1.Text = "Generar Reporte";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserControlReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(DataGridViewReporte);
            Controls.Add(TituloReporte);
            Name = "UserControlReportes";
            Size = new Size(972, 696);
            ((System.ComponentModel.ISupportInitialize)DataGridViewReporte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label TituloReporte;
        private Button button1;
        public DataGridView DataGridViewReporte;
    }
}
