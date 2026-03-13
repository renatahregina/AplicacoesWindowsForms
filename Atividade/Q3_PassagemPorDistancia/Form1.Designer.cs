namespace Q3_PassagemPorDistancia
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
            label1 = new Label();
            label2 = new Label();
            txtKM = new TextBox();
            button1 = new Button();
            lblvalor = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(67, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Simule sua viagem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 38);
            label2.Name = "label2";
            label2.Size = new Size(182, 30);
            label2.TabIndex = 1;
            label2.Text = "      Até 200 km : R$ 0,50 por km\r\nAcima de 200 km: R$ 0,45 por km";
            // 
            // txtKM
            // 
            txtKM.Location = new Point(73, 110);
            txtKM.Name = "txtKM";
            txtKM.Size = new Size(100, 23);
            txtKM.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(87, 139);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblvalor
            // 
            lblvalor.AutoSize = true;
            lblvalor.ForeColor = Color.DarkRed;
            lblvalor.Location = new Point(48, 182);
            lblvalor.Name = "lblvalor";
            lblvalor.Size = new Size(148, 15);
            lblvalor.TabIndex = 4;
            lblvalor.Text = "O valor da sua viagem sera";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 82);
            label4.Name = "label4";
            label4.Size = new Size(201, 15);
            label4.TabIndex = 5;
            label4.Text = "Digite quantos KM para saber o valor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 220);
            Controls.Add(label4);
            Controls.Add(lblvalor);
            Controls.Add(button1);
            Controls.Add(txtKM);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKM;
        private Button button1;
        private Label lblvalor;
        private Label label4;
    }
}
