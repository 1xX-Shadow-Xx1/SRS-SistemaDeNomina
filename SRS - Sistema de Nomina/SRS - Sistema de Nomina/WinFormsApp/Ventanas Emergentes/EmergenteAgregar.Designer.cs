namespace WinFormsApp.Ventanas_Emergentes
{
    partial class EmergenteAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContenedorEmergrenteAgregar = new Panel();
            panelContenedorTipos = new Panel();
            textBoxNSS = new TextBox();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelContenedorEmergrenteAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedorEmergrenteAgregar
            // 
            panelContenedorEmergrenteAgregar.Controls.Add(panelContenedorTipos);
            panelContenedorEmergrenteAgregar.Controls.Add(textBoxNSS);
            panelContenedorEmergrenteAgregar.Controls.Add(textBoxApellido);
            panelContenedorEmergrenteAgregar.Controls.Add(textBoxNombre);
            panelContenedorEmergrenteAgregar.Controls.Add(label5);
            panelContenedorEmergrenteAgregar.Controls.Add(comboBox1);
            panelContenedorEmergrenteAgregar.Controls.Add(label4);
            panelContenedorEmergrenteAgregar.Controls.Add(label3);
            panelContenedorEmergrenteAgregar.Controls.Add(label2);
            panelContenedorEmergrenteAgregar.Controls.Add(label1);
            panelContenedorEmergrenteAgregar.Dock = DockStyle.Fill;
            panelContenedorEmergrenteAgregar.Location = new Point(0, 0);
            panelContenedorEmergrenteAgregar.Name = "panelContenedorEmergrenteAgregar";
            panelContenedorEmergrenteAgregar.Size = new Size(460, 527);
            panelContenedorEmergrenteAgregar.TabIndex = 0;
            // 
            // panelContenedorTipos
            // 
            panelContenedorTipos.Dock = DockStyle.Bottom;
            panelContenedorTipos.Location = new Point(0, 271);
            panelContenedorTipos.Name = "panelContenedorTipos";
            panelContenedorTipos.Size = new Size(460, 256);
            panelContenedorTipos.TabIndex = 1;
            // 
            // textBoxNSS
            // 
            textBoxNSS.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNSS.Location = new Point(101, 170);
            textBoxNSS.Name = "textBoxNSS";
            textBoxNSS.Size = new Size(155, 22);
            textBoxNSS.TabIndex = 10;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxApellido.Location = new Point(101, 122);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(155, 22);
            textBoxApellido.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNombre.Location = new Point(101, 73);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(155, 22);
            textBoxNombre.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 229);
            label5.Name = "label5";
            label5.Size = new Size(130, 17);
            label5.TabIndex = 6;
            label5.Text = "Tipo de Empleado:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Empleado Asalariado", "Empleado Asalariado con Comision", "Empleado por Comision", "Empleado por hora" });
            comboBox1.Location = new Point(165, 227);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 25);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 20);
            label4.Name = "label4";
            label4.Size = new Size(188, 23);
            label4.TabIndex = 4;
            label4.Text = "Agregar Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 172);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 3;
            label3.Text = "NSS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 124);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 75);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // EmergenteAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 527);
            Controls.Add(panelContenedorEmergrenteAgregar);
            Name = "EmergenteAgregar";
            Text = "Form1";
            panelContenedorEmergrenteAgregar.ResumeLayout(false);
            panelContenedorEmergrenteAgregar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedorEmergrenteAgregar;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private ComboBox comboBox1;
        private Panel panelContenedorTipos;
        public TextBox textBoxNSS;
        public TextBox textBoxApellido;
        public TextBox textBoxNombre;
    }
}