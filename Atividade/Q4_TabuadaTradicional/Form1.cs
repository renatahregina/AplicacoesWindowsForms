namespace Q4_TabuadaTradicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabuada.Items.Clear();

            int numero = int.Parse(textBox1.Text);

            for (int i = 1; i <= 10; i++)
            {
                Tabuada.Items.Add(numero + " x " + i + " = " + numero * i);
            }
        }
    }
}
