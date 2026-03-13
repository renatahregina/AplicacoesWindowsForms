namespace Q5_CadastroSimples
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
            txtnome = new TextBox();
            label2 = new Label();
            txtidade = new TextBox();
            button1 = new Button();
            lstpessoas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(56, 34);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Idade";
            // 
            // txtidade
            // 
            txtidade.Location = new Point(56, 79);
            txtidade.Name = "txtidade";
            txtidade.Size = new Size(100, 23);
            txtidade.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(56, 120);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstpessoas
            // 
            lstpessoas.FormattingEnabled = true;
            lstpessoas.ItemHeight = 15;
            lstpessoas.Location = new Point(36, 163);
            lstpessoas.Name = "lstpessoas";
            lstpessoas.Size = new Size(120, 94);
            lstpessoas.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(203, 290);
            Controls.Add(lstpessoas);
            Controls.Add(button1);
            Controls.Add(txtidade);
            Controls.Add(label2);
            Controls.Add(txtnome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnome;
        private Label label2;
        private TextBox txtidade;
        private Button button1;
        private ListBox lstpessoas;
    }
}
