namespace Q3_PassagemPorDistancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double KM, PRECO;
            KM = Convert.ToDouble(txtKM.Text);
            if (KM <= 200)
            {
                PRECO = KM * 0.5;
            }
            else
            {
                PRECO = KM * 0.45;
            }
            lblvalor.Text = PRECO.ToString();
        }
    }
}
