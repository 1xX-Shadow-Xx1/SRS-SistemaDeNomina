namespace WinFormsApp.Ventanas
{
    partial class UserControlBuscar
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
            TituloBuscar = new Label();
            label1 = new Label();
            textBoxInfoBuscar = new TextBox();
            buttonInfoBuscar = new Button();
            panelInfoEmpleado = new Panel();
            TxtInfoTipoEmpleado = new Label();
            TxtInfoNSS = new Label();
            TxtInfoApellido = new Label();
            TxtInfoNombre = new Label();
            TxtInfoPago = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelInfoEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // TituloBuscar
            // 
            TituloBuscar.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TituloBuscar.Location = new Point(27, 20);
            TituloBuscar.Name = "TituloBuscar";
            TituloBuscar.Size = new Size(263, 41);
            TituloBuscar.TabIndex = 2;
            TituloBuscar.Text = "Buscar Empleados";
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 110);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el NSS:";
            // 
            // textBoxInfoBuscar
            // 
            textBoxInfoBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInfoBuscar.Location = new Point(218, 107);
            textBoxInfoBuscar.Name = "textBoxInfoBuscar";
            textBoxInfoBuscar.Size = new Size(161, 27);
            textBoxInfoBuscar.TabIndex = 4;
            // 
            // buttonInfoBuscar
            // 
            buttonInfoBuscar.Location = new Point(397, 107);
            buttonInfoBuscar.Name = "buttonInfoBuscar";
            buttonInfoBuscar.Size = new Size(51, 30);
            buttonInfoBuscar.TabIndex = 5;
            buttonInfoBuscar.Text = "Buscar";
            buttonInfoBuscar.UseVisualStyleBackColor = true;
            buttonInfoBuscar.Click += buttonInfoBuscar_Click;
            // 
            // panelInfoEmpleado
            // 
            panelInfoEmpleado.BackColor = SystemColors.ControlLight;
            panelInfoEmpleado.Controls.Add(TxtInfoTipoEmpleado);
            panelInfoEmpleado.Controls.Add(TxtInfoNSS);
            panelInfoEmpleado.Controls.Add(TxtInfoApellido);
            panelInfoEmpleado.Controls.Add(TxtInfoNombre);
            panelInfoEmpleado.Controls.Add(TxtInfoPago);
            panelInfoEmpleado.Controls.Add(label7);
            panelInfoEmpleado.Controls.Add(label6);
            panelInfoEmpleado.Controls.Add(label5);
            panelInfoEmpleado.Controls.Add(label4);
            panelInfoEmpleado.Controls.Add(label3);
            panelInfoEmpleado.Controls.Add(label2);
            panelInfoEmpleado.Location = new Point(76, 190);
            panelInfoEmpleado.Name = "panelInfoEmpleado";
            panelInfoEmpleado.Size = new Size(467, 410);
            panelInfoEmpleado.TabIndex = 6;
            panelInfoEmpleado.Visible = false;
            // 
            // TxtInfoTipoEmpleado
            // 
            TxtInfoTipoEmpleado.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtInfoTipoEmpleado.Location = new Point(168, 273);
            TxtInfoTipoEmpleado.Name = "TxtInfoTipoEmpleado";
            TxtInfoTipoEmpleado.Size = new Size(193, 17);
            TxtInfoTipoEmpleado.TabIndex = 13;
            // 
            // TxtInfoNSS
            // 
            TxtInfoNSS.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtInfoNSS.Location = new Point(110, 225);
            TxtInfoNSS.Name = "TxtInfoNSS";
            TxtInfoNSS.Size = new Size(193, 17);
            TxtInfoNSS.TabIndex = 12;
            // 
            // TxtInfoApellido
            // 
            TxtInfoApellido.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtInfoApellido.Location = new Point(110, 169);
            TxtInfoApellido.Name = "TxtInfoApellido";
            TxtInfoApellido.Size = new Size(193, 17);
            TxtInfoApellido.TabIndex = 11;
            // 
            // TxtInfoNombre
            // 
            TxtInfoNombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtInfoNombre.Location = new Point(110, 114);
            TxtInfoNombre.Name = "TxtInfoNombre";
            TxtInfoNombre.Size = new Size(193, 17);
            TxtInfoNombre.TabIndex = 10;
            // 
            // TxtInfoPago
            // 
            TxtInfoPago.BorderStyle = BorderStyle.FixedSingle;
            TxtInfoPago.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtInfoPago.Location = new Point(321, 364);
            TxtInfoPago.Name = "TxtInfoPago";
            TxtInfoPago.Size = new Size(129, 26);
            TxtInfoPago.TabIndex = 9;
            TxtInfoPago.Text = "0";
            TxtInfoPago.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(265, 366);
            label7.Name = "label7";
            label7.Size = new Size(60, 24);
            label7.TabIndex = 8;
            label7.Text = "Pago:";
            // 
            // label6
            // 
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 273);
            label6.Name = "label6";
            label6.Size = new Size(136, 17);
            label6.TabIndex = 7;
            label6.Text = "Tipo de Empleado:";
            // 
            // label5
            // 
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(69, 225);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 6;
            label5.Text = "NSS:";
            // 
            // label4
            // 
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 169);
            label4.Name = "label4";
            label4.Size = new Size(98, 17);
            label4.TabIndex = 5;
            label4.Text = "Apellido:";
            // 
            // label3
            // 
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 114);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 18);
            label2.Name = "label2";
            label2.Size = new Size(287, 29);
            label2.TabIndex = 3;
            label2.Text = "Informacion del Empleado";
            // 
            // UserControlBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelInfoEmpleado);
            Controls.Add(buttonInfoBuscar);
            Controls.Add(textBoxInfoBuscar);
            Controls.Add(label1);
            Controls.Add(TituloBuscar);
            Name = "UserControlBuscar";
            Size = new Size(972, 696);
            panelInfoEmpleado.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TituloBuscar;
        private Label label1;
        private TextBox textBoxInfoBuscar;
        private Button buttonInfoBuscar;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label12;
        private Label label10;
        public Label TxtInfoNombre;
        public Label TxtInfoApellido;
        public Label TxtInfoTipoEmpleado;
        public Label TxtInfoNSS;
        public Label TxtInfoPago;
        public Panel panelInfoEmpleado;
    }
}
