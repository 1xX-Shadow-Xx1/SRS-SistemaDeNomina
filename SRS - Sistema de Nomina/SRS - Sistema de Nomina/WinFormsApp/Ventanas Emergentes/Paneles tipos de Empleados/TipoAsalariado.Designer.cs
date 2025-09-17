namespace WinFormsApp.Ventanas_Emergentes.Paneles_tipos_de_Empleados
{
    partial class TipoAsalariado
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
            label3 = new Label();
            textBoxAsalariado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(343, 212);
            button1.Name = "button1";
            button1.Size = new Size(102, 29);
            button1.TabIndex = 5;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(242, 108);
            label3.Name = "label3";
            label3.Size = new Size(15, 17);
            label3.TabIndex = 8;
            label3.Text = "$";
            // 
            // textBoxAsalariado
            // 
            textBoxAsalariado.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAsalariado.Location = new Point(97, 105);
            textBoxAsalariado.Name = "textBoxAsalariado";
            textBoxAsalariado.Size = new Size(139, 22);
            textBoxAsalariado.TabIndex = 7;
            textBoxAsalariado.Text = "\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 108);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 6;
            label1.Text = "Salario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 28);
            label2.Name = "label2";
            label2.Size = new Size(179, 19);
            label2.TabIndex = 9;
            label2.Text = "Empleado Asalariado";
            // 
            // TipoAsalariado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(textBoxAsalariado);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "TipoAsalariado";
            Size = new Size(460, 256);
            Load += TipoAsalariado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private TextBox textBoxAsalariado;
        private Label label1;
        private Label label2;
    }
}
