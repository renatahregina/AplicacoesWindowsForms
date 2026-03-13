namespace Q4_TabuadaTradicional
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
            txtNumero = new TextBox();
            btnGerar = new Button();
            Tabuada = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(228, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite um número para realizar a tabuada:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(93, 57);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(58, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(79, 96);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(85, 24);
            btnGerar.TabIndex = 2;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += button1_Click;
            // 
            // Tabuada
            // 
            Tabuada.FormattingEnabled = true;
            Tabuada.ItemHeight = 15;
            Tabuada.Location = new Point(79, 142);
            Tabuada.Name = "Tabuada";
            Tabuada.Size = new Size(85, 199);
            Tabuada.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 353);
            Controls.Add(Tabuada);
            Controls.Add(btnGerar);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnGerar;
        private ListBox Tabuada;
    }
}
