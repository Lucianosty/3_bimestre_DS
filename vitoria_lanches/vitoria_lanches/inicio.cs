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

                // Adicione outros formul�rios aqui
                _ => throw new ArgumentException("Formul�rio n�o reconhecido.")
            };

            formulario.TopLevel = false;                       // Define que o objeto do Form atualizar n�o � um formul�rio de n�vel superior
            formulario.FormBorderStyle = FormBorderStyle.None; // Remove a borda do objeto do Form atualizar
            formulario.Dock = DockStyle.Fill;                  // Faz com que o objeto do Form atualizar preencha todo o painel
            panel2.Controls.Clear();                       // Apaga todos os elemento anteriores do painel 3 para poder exibir os novos 
            panel2.Controls.Add(formulario);                   // Adiciona o objeto do Form atualizar ao painel 3
            formulario.Show();                                 // Exibe o conte�do do objeto do Form atualizar
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CarregarPanel("FormBoasVindas"); // Chama o m�todo inicial para carregar o formul�rio de boas-vindas
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            CarregarPanel("FormCriarconta"); // Chama o m�todo inicial ao carregar o formul�rio principal
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            CarregarPanel("FormBoasVindas"); // Chama o m�todo inicial ao carregar o formul�rio principal
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            CarregarPanel("FormCadProd");
        }
    }
}

