namespace WinFormsApp.Ventanas_Emergentes.Paneles_tipos_de_Empleados
{
    partial class TipoPorComision
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
            label4 = new Label();
            numericUpDownTarifa = new NumericUpDown();
            label6 = new Label();
            textBoxVentas = new TextBox();
            label7 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTarifa).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(342, 215);
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
            label2.Size = new Size(196, 19);
            label2.TabIndex = 7;
            label2.Text = "Empleado por Comision";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(150, 113);
            label4.Name = "label4";
            label4.Size = new Size(18, 17);
            label4.TabIndex = 25;
            label4.Text = "%";
            // 
            // numericUpDownTarifa
            // 
            numericUpDownTarifa.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownTarifa.Location = new Point(96, 107);
            numericUpDownTarifa.Name = "numericUpDownTarifa";
            numericUpDownTarifa.Size = new Size(48, 23);
            numericUpDownTarifa.TabIndex = 24;
            numericUpDownTarifa.Tag = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(295, 154);
            label6.Name = "label6";
            label6.Size = new Size(15, 17);
            label6.TabIndex = 23;
            label6.Text = "$";
            // 
            // textBoxVentas
            // 
            textBoxVentas.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxVentas.Location = new Point(150, 151);
            textBoxVentas.Name = "textBoxVentas";
            textBoxVentas.Size = new Size(139, 22);
            textBoxVentas.TabIndex = 22;
            textBoxVentas.Text = "\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(44, 154);
            label7.Name = "label7";
            label7.Size = new Size(100, 17);
            label7.TabIndex = 21;
            label7.Text = "Ventas brutas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 108);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 20;
            label5.Text = "Tarifa:";
            // 
            // TipoPorComision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(numericUpDownTarifa);
            Controls.Add(label6);
            Controls.Add(textBoxVentas);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "TipoPorComision";
            Size = new Size(460, 256);
            Load += TipoPorComision_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownTarifa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label4;
        private NumericUpDown numericUpDownTarifa;
        private Label label6;
        private TextBox textBoxVentas;
        private Label label7;
        private Label label5;
    }
}
