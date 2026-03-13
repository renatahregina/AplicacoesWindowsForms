namespace Q5_CadastroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoas novapessoa = new Pessoas();

            novapessoa.pessoa = txtnome.Text;
            novapessoa.idade = txtidade.Text;

            Repositorio.adicionarpessoa.Add(novapessoa);
            lstpessoas.Items.Add($"{novapessoa.pessoa} {novapessoa.idade}");

        }
    }
}
