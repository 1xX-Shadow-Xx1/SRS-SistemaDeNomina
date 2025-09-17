namespace WinFormsApp.Ventanas_Emergentes.Paneles_tipos_de_Empleados
{
    partial class TipoAsalariadoComi
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
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBoxSalario = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxVentas = new TextBox();
            label7 = new Label();
            numericUpDownTarifa = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTarifa).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(335, 210);
            button1.Name = "button1";
            button1.Size = new Size(102, 29);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 28);
            label2.Name = "label2";
            label2.Size = new Size(289, 19);
            label2.TabIndex = 7;
            label2.Text = "Empleado Asalariado con Comision";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(248, 92);
            label3.Name = "label3";
            label3.Size = new Size(15, 17);
            label3.TabIndex = 11;
            label3.Text = "$";
            // 
            // textBoxSalario
            // 
            textBoxSalario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSalario.Location = new Point(103, 89);
            textBoxSalario.Name = "textBoxSalario";
            textBoxSalario.Size = new Size(139, 22);
            textBoxSalario.TabIndex = 10;
            textBoxSalario.Text = "\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 92);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 9;
            label1.Text = "Salario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 133);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 12;
            label5.Text = "Tarifa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(293, 169);
            label6.Name = "label6";
            label6.Size = new Size(15, 17);
            label6.TabIndex = 17;
            label6.Text = "$";
            // 
            // textBoxVentas
            // 
            textBoxVentas.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxVentas.Location = new Point(148, 166);
            textBoxVentas.Name = "textBoxVentas";
            textBoxVentas.Size = new Size(139, 22);
            textBoxVentas.TabIndex = 16;
            textBoxVentas.Text = "\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 169);
            label7.Name = "label7";
            label7.Size = new Size(100, 17);
            label7.TabIndex = 15;
            label7.Text = "Ventas brutas:";
            // 
            // numericUpDownTarifa
            // 
            numericUpDownTarifa.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownTarifa.Location = new Point(94, 132);
            numericUpDownTarifa.Name = "numericUpDownTarifa";
            numericUpDownTarifa.Size = new Size(48, 23);
            numericUpDownTarifa.TabIndex = 18;
            numericUpDownTarifa.Tag = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(148, 138);
            label4.Name = "label4";
            label4.Size = new Size(18, 17);
            label4.TabIndex = 19;
            label4.Text = "%";
            // 
            // TipoAsalariadoComi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(numericUpDownTarifa);
            Controls.Add(label6);
            Controls.Add(textBoxVentas);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBoxSalario);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "TipoAsalariadoComi";
            Size = new Size(460, 256);
            Load += TipoAsalariadoComi_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownTarifa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBoxSalario;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox textBoxVentas;
        private Label label7;
        private NumericUpDown numericUpDownTarifa;
        private Label label4;
    }
}
