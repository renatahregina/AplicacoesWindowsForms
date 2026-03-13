namespace Questão_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius, fahrenheit;
            celsius = Convert.ToDouble(txtCelsius.Text);
            fahrenheit = (celsius * 9 / 5) + 32;
            lblFahrenheit.Text = fahrenheit.ToString();
        }

        private void lblFahrenheit_Click(object sender, EventArgs e)
        {

        }
    }
}
