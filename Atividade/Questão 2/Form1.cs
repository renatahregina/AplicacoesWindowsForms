namespace Questão_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double cotacao, quantidade, resultado;

            cotacao = Convert.ToDouble(txtCotacao.Text);
            quantidade = Convert.ToDouble(txtDolares.Text);

            resultado = quantidade * cotacao;

            lblResultado.Text = resultado.ToString();

        }

        private void txtDolares_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
