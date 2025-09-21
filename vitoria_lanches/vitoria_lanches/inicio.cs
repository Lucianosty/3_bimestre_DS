namespace vitoria_lanches
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        public void CarregarPanel(string nomeFormulario)
        {

            Form formulario = nomeFormulario switch
            {
                "FormBoasVindas" => new BoasVindas(),
                "FormCriarconta" => new Criarconta(),
                "FormCadProd" => new CadProd(),

                // Adicione outros formulários aqui
                _ => throw new ArgumentException("Formulário não reconhecido.")
            };

            formulario.TopLevel = false;                       // Define que o objeto do Form atualizar não é um formulário de nível superior
            formulario.FormBorderStyle = FormBorderStyle.None; // Remove a borda do objeto do Form atualizar
            formulario.Dock = DockStyle.Fill;                  // Faz com que o objeto do Form atualizar preencha todo o painel
            panel2.Controls.Clear();                       // Apaga todos os elemento anteriores do painel 3 para poder exibir os novos 
            panel2.Controls.Add(formulario);                   // Adiciona o objeto do Form atualizar ao painel 3
            formulario.Show();                                 // Exibe o conteúdo do objeto do Form atualizar
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CarregarPanel("FormBoasVindas"); // Chama o método inicial para carregar o formulário de boas-vindas
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            CarregarPanel("FormCriarconta"); // Chama o método inicial ao carregar o formulário principal
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            CarregarPanel("FormBoasVindas"); // Chama o método inicial ao carregar o formulário principal
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            CarregarPanel("FormCadProd");
        }
    }
}

