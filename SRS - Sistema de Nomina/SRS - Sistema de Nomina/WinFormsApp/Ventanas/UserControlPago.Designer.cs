namespace WinFormsApp.Ventanas
{
    partial class UserControlPago
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
            DataGridViewPagos = new DataGridView();
            TituloInicio = new Label();
            label1 = new Label();
            panel1 = new Panel();
            TxtNumericoTotaldePagos = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPagos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridViewPagos
            // 
            DataGridViewPagos.AllowUserToAddRows = false;
            DataGridViewPagos.AllowUserToDeleteRows = false;
            DataGridViewPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewPagos.Location = new Point(85, 141);
            DataGridViewPagos.Name = "DataGridViewPagos";
            DataGridViewPagos.ReadOnly = true;
            DataGridViewPagos.Size = new Size(780, 413);
            DataGridViewPagos.TabIndex = 0;
            // 
            // TituloInicio
            // 
            TituloInicio.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TituloInicio.Location = new Point(27, 20);
            TituloInicio.Name = "TituloInicio";
            TituloInicio.Size = new Size(118, 41);
            TituloInicio.TabIndex = 2;
            TituloInicio.Text = "Pagos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 599);
            label1.Name = "label1";
            label1.Size = new Size(115, 19);
            label1.TabIndex = 3;
            label1.Text = "Total a Pagar:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(TxtNumericoTotaldePagos);
            panel1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(197, 596);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 24);
            panel1.TabIndex = 4;
            // 
            // TxtNumericoTotaldePagos
            // 
            TxtNumericoTotaldePagos.Dock = DockStyle.Fill;
            TxtNumericoTotaldePagos.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNumericoTotaldePagos.Location = new Point(0, 0);
            TxtNumericoTotaldePagos.Name = "TxtNumericoTotaldePagos";
            TxtNumericoTotaldePagos.Size = new Size(163, 22);
            TxtNumericoTotaldePagos.TabIndex = 0;
            TxtNumericoTotaldePagos.Text = "0";
            TxtNumericoTotaldePagos.TextAlign = ContentAlignment.MiddleRight;
            TxtNumericoTotaldePagos.Click += TxtNumericoTotaldePagos_Click;
            // 
            // UserControlPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(TituloInicio);
            Controls.Add(DataGridViewPagos);
            Name = "UserControlPago";
            Size = new Size(972, 696);
            ((System.ComponentModel.ISupportInitialize)DataGridViewPagos).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TituloInicio;
        private Label label1;
        private Panel panel1;
        public DataGridView DataGridViewPagos;
        public Label TxtNumericoTotaldePagos;
    }
}
