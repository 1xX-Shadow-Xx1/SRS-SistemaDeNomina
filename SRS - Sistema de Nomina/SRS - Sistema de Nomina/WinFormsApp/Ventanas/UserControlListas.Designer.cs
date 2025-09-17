namespace WinFormsApp.Ventanas
{
    partial class UserControlListas
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
            TituloLista = new Label();
            DataGridViewAsalariado = new DataGridView();
            DataGridViewAsalariadoConComision = new DataGridView();
            DataGridViewPorComision = new DataGridView();
            DataGridViewPorHora = new DataGridView();
            TituloListaAsalariado = new Label();
            TituloListaAsalariadoConComision = new Label();
            TituloListaPorComision = new Label();
            TituloListaPorHora = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAsalariado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAsalariadoConComision).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPorComision).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPorHora).BeginInit();
            SuspendLayout();
            // 
            // TituloLista
            // 
            TituloLista.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TituloLista.Location = new Point(27, 20);
            TituloLista.Name = "TituloLista";
            TituloLista.Size = new Size(292, 41);
            TituloLista.TabIndex = 2;
            TituloLista.Text = "Listas de Empleados";
            // 
            // DataGridViewAsalariado
            // 
            DataGridViewAsalariado.AllowUserToAddRows = false;
            DataGridViewAsalariado.AllowUserToDeleteRows = false;
            DataGridViewAsalariado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewAsalariado.Location = new Point(87, 195);
            DataGridViewAsalariado.Name = "DataGridViewAsalariado";
            DataGridViewAsalariado.ReadOnly = true;
            DataGridViewAsalariado.Size = new Size(776, 426);
            DataGridViewAsalariado.TabIndex = 3;
            // 
            // DataGridViewAsalariadoConComision
            // 
            DataGridViewAsalariadoConComision.AllowUserToAddRows = false;
            DataGridViewAsalariadoConComision.AllowUserToDeleteRows = false;
            DataGridViewAsalariadoConComision.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewAsalariadoConComision.Location = new Point(87, 907);
            DataGridViewAsalariadoConComision.Name = "DataGridViewAsalariadoConComision";
            DataGridViewAsalariadoConComision.ReadOnly = true;
            DataGridViewAsalariadoConComision.Size = new Size(776, 458);
            DataGridViewAsalariadoConComision.TabIndex = 4;
            // 
            // DataGridViewPorComision
            // 
            DataGridViewPorComision.AllowUserToAddRows = false;
            DataGridViewPorComision.AllowUserToDeleteRows = false;
            DataGridViewPorComision.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewPorComision.Location = new Point(87, 1626);
            DataGridViewPorComision.Name = "DataGridViewPorComision";
            DataGridViewPorComision.ReadOnly = true;
            DataGridViewPorComision.Size = new Size(776, 476);
            DataGridViewPorComision.TabIndex = 5;
            // 
            // DataGridViewPorHora
            // 
            DataGridViewPorHora.AllowUserToAddRows = false;
            DataGridViewPorHora.AllowUserToDeleteRows = false;
            DataGridViewPorHora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewPorHora.Location = new Point(87, 2364);
            DataGridViewPorHora.Name = "DataGridViewPorHora";
            DataGridViewPorHora.ReadOnly = true;
            DataGridViewPorHora.Size = new Size(776, 454);
            DataGridViewPorHora.TabIndex = 6;
            // 
            // TituloListaAsalariado
            // 
            TituloListaAsalariado.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TituloListaAsalariado.Location = new Point(87, 162);
            TituloListaAsalariado.Name = "TituloListaAsalariado";
            TituloListaAsalariado.Size = new Size(455, 30);
            TituloListaAsalariado.TabIndex = 7;
            TituloListaAsalariado.Text = "Listas de Empleados Asalariados";
            // 
            // TituloListaAsalariadoConComision
            // 
            TituloListaAsalariadoConComision.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TituloListaAsalariadoConComision.Location = new Point(87, 864);
            TituloListaAsalariadoConComision.Name = "TituloListaAsalariadoConComision";
            TituloListaAsalariadoConComision.Size = new Size(494, 30);
            TituloListaAsalariadoConComision.TabIndex = 9;
            TituloListaAsalariadoConComision.Text = "Listas de Empleados Asalariados con Comision";
            // 
            // TituloListaPorComision
            // 
            TituloListaPorComision.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TituloListaPorComision.Location = new Point(87, 1584);
            TituloListaPorComision.Name = "TituloListaPorComision";
            TituloListaPorComision.Size = new Size(455, 30);
            TituloListaPorComision.TabIndex = 10;
            TituloListaPorComision.Text = "Listas de Empleados por Comision";
            // 
            // TituloListaPorHora
            // 
            TituloListaPorHora.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TituloListaPorHora.Location = new Point(87, 2318);
            TituloListaPorHora.Name = "TituloListaPorHora";
            TituloListaPorHora.Size = new Size(329, 30);
            TituloListaPorHora.TabIndex = 11;
            TituloListaPorHora.Text = "Listas de Empleados por Hora";
            // 
            // UserControlListas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 80);
            Controls.Add(TituloListaPorHora);
            Controls.Add(TituloListaPorComision);
            Controls.Add(TituloListaAsalariadoConComision);
            Controls.Add(TituloListaAsalariado);
            Controls.Add(DataGridViewPorHora);
            Controls.Add(DataGridViewPorComision);
            Controls.Add(DataGridViewAsalariadoConComision);
            Controls.Add(DataGridViewAsalariado);
            Controls.Add(TituloLista);
            Name = "UserControlListas";
            Size = new Size(955, 3015);
            ((System.ComponentModel.ISupportInitialize)DataGridViewAsalariado).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAsalariadoConComision).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPorComision).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPorHora).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label TituloLista;
        private Label TituloListaAsalariado;
        private Label TituloListaAsalariadoConComision;
        private Label TituloListaPorComision;
        private Label TituloListaPorHora;
        public DataGridView DataGridViewAsalariado;
        public DataGridView DataGridViewAsalariadoConComision;
        public DataGridView DataGridViewPorComision;
        public DataGridView DataGridViewPorHora;
    }
}
