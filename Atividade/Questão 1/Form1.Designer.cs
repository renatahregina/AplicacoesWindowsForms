namespace Questão_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCelsius = new Label();
            lblFahrenheit = new Label();
            txtCelsius = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblCelsius
            // 
            lblCelsius.AutoSize = true;
            lblCelsius.Location = new Point(25, 85);
            lblCelsius.Name = "lblCelsius";
            lblCelsius.Size = new Size(47, 15);
            lblCelsius.TabIndex = 0;
            lblCelsius.Text = "Celsius:";
            // 
            // lblFahrenheit
            // 
            lblFahrenheit.AutoSize = true;
            lblFahrenheit.ForeColor = Color.Navy;
            lblFahrenheit.Location = new Point(78, 121);
            lblFahrenheit.Name = "lblFahrenheit";
            lblFahrenheit.Size = new Size(138, 15);
            lblFahrenheit.TabIndex = 1;
            lblFahrenheit.Text = "Resultado em Fahrenheit\r\n";
            lblFahrenheit.Click += lblFahrenheit_Click;
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(78, 82);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(100, 23);
            txtCelsius.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(78, 148);
            button1.Name = "button1";
            button1.Size = new Size(100, 29);
            button1.TabIndex = 4;
            button1.Text = "Converter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 23);
            label4.Name = "label4";
            label4.Size = new Size(181, 15);
            label4.TabIndex = 6;
            label4.Text = "Digite abaixo para converter uma";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 38);
            label5.Name = "label5";
            label5.Size = new Size(201, 15);
            label5.TabIndex = 7;
            label5.Text = "temperatura em °C e mostrar em °F :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 198);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtCelsius);
            Controls.Add(lblFahrenheit);
            Controls.Add(lblCelsius);
            Name = "Form1";
            Text = "Conversão C° em °F";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCelsius;
        private Label lblFahrenheit;
        private TextBox txtCelsius;
        private Button button1;
        private Label label4;
        private Label label5;
    }
}
