namespace WinFormsApp.Ventanas_Emergentes
{
    partial class EmergenteEditar
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
            panelContenedorEmergenteEditar = new Panel();
            comboBoxTipoEmpleado = new ComboBox();
            label5 = new Label();
            textBoxNSS = new TextBox();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelContenedorEditarTiposEmpleados = new Panel();
            panelContenedorEmergenteEditar.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedorEmergenteEditar
            // 
            panelContenedorEmergenteEditar.Controls.Add(comboBoxTipoEmpleado);
            panelContenedorEmergenteEditar.Controls.Add(label5);
            panelContenedorEmergenteEditar.Controls.Add(textBoxNSS);
            panelContenedorEmergenteEditar.Controls.Add(textBoxApellido);
            panelContenedorEmergenteEditar.Controls.Add(textBoxNombre);
            panelContenedorEmergenteEditar.Controls.Add(label4);
            panelContenedorEmergenteEditar.Controls.Add(label3);
            panelContenedorEmergenteEditar.Controls.Add(label2);
            panelContenedorEmergenteEditar.Controls.Add(label1);
            panelContenedorEmergenteEditar.Controls.Add(panelContenedorEditarTiposEmpleados);
            panelContenedorEmergenteEditar.Dock = DockStyle.Fill;
            panelContenedorEmergenteEditar.Location = new Point(0, 0);
            panelContenedorEmergenteEditar.Name = "panelContenedorEmergenteEditar";
            panelContenedorEmergenteEditar.Size = new Size(460, 527);
            panelContenedorEmergenteEditar.TabIndex = 0;
            // 
            // comboBoxTipoEmpleado
            // 
            comboBoxTipoEmpleado.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTipoEmpleado.FormattingEnabled = true;
            comboBoxTipoEmpleado.Items.AddRange(new object[] { "Empleado Asalariado", "Empleado Asalariado por Comisión", "Empleado por Comisión", "Empleado por Horas" });
            comboBoxTipoEmpleado.Location = new Point(154, 237);
            comboBoxTipoEmpleado.Name = "comboBoxTipoEmpleado";
            comboBoxTipoEmpleado.Size = new Size(215, 25);
            comboBoxTipoEmpleado.TabIndex = 9;
            comboBoxTipoEmpleado.SelectedIndexChanged += comboBoxTipoEmpleado_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 239);
            label5.Name = "label5";
            label5.Size = new Size(117, 17);
            label5.TabIndex = 8;
            label5.Text = "Tipo de Empleado:";
            // 
            // textBoxNSS
            // 
            textBoxNSS.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNSS.Location = new Point(100, 174);
            textBoxNSS.Name = "textBoxNSS";
            textBoxNSS.Size = new Size(177, 22);
            textBoxNSS.TabIndex = 7;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxApellido.Location = new Point(100, 127);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(175, 22);
            textBoxApellido.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNombre.Location = new Point(100, 83);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(177, 22);
            textBoxNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 177);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 4;
            label4.Text = "NSS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 130);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 3;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 83);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 1;
            label1.Text = "Editar Empleado";
            // 
            // panelContenedorEditarTiposEmpleados
            // 
            panelContenedorEditarTiposEmpleados.Dock = DockStyle.Bottom;
            panelContenedorEditarTiposEmpleados.Location = new Point(0, 271);
            panelContenedorEditarTiposEmpleados.Name = "panelContenedorEditarTiposEmpleados";
            panelContenedorEditarTiposEmpleados.Size = new Size(460, 256);
            panelContenedorEditarTiposEmpleados.TabIndex = 0;
            // 
            // EmergenteEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 527);
            Controls.Add(panelContenedorEmergenteEditar);
            Name = "EmergenteEditar";
            Text = "EmergenteEditar";
            panelContenedorEmergenteEditar.ResumeLayout(false);
            panelContenedorEmergenteEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedorEmergenteEditar;
        private Panel panelContenedorEditarTiposEmpleados;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        public TextBox textBoxNSS;
        public TextBox textBoxApellido;
        public TextBox textBoxNombre;
        public ComboBox comboBoxTipoEmpleado;
    }
}