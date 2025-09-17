namespace WinFormsApp.Ventanas_Emergentes.Paneles_tipos_de_Empleados
{
    partial class TipoPorHora
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
            label2 = new Label();
            textBoxSalarioPorHora = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            textBoxHoras = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 109);
            label1.Name = "label1";
            label1.Size = new Size(115, 17);
            label1.TabIndex = 0;
            label1.Text = "Salario por hora:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 28);
            label2.Name = "label2";
            label2.Size = new Size(161, 19);
            label2.TabIndex = 1;
            label2.Text = "Empleado por Hora";
            // 
            // textBoxSalarioPorHora
            // 
            textBoxSalarioPorHora.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSalarioPorHora.Location = new Point(158, 106);
            textBoxSalarioPorHora.Name = "textBoxSalarioPorHora";
            textBoxSalarioPorHora.Size = new Size(139, 22);
            textBoxSalarioPorHora.TabIndex = 2;
            textBoxSalarioPorHora.Text = "\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(303, 109);
            label3.Name = "label3";
            label3.Size = new Size(15, 17);
            label3.TabIndex = 3;
            label3.Text = "$";
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(341, 211);
            button1.Name = "button1";
            button1.Size = new Size(102, 29);
            button1.TabIndex = 4;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 159);
            label4.Name = "label4";
            label4.Size = new Size(123, 17);
            label4.TabIndex = 5;
            label4.Text = "Horas trabajadas:";
            // 
            // textBoxHoras
            // 
            textBoxHoras.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxHoras.Location = new Point(166, 156);
            textBoxHoras.Name = "textBoxHoras";
            textBoxHoras.Size = new Size(67, 22);
            textBoxHoras.TabIndex = 6;
            textBoxHoras.Text = "\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(239, 161);
            label5.Name = "label5";
            label5.Size = new Size(16, 17);
            label5.TabIndex = 7;
            label5.Text = "h";
            // 
            // TipoPorHora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(textBoxHoras);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBoxSalarioPorHora);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TipoPorHora";
            Size = new Size(460, 256);
            Load += TipoPorHora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxSalarioPorHora;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox textBoxHoras;
        private Label label5;
    }
}
