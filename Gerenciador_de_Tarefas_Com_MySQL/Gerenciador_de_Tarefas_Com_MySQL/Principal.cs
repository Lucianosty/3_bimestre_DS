namespace Gerenciador_de_Tarefas_Com_MySQL
{
    public partial class Principal : Form
    {

        

        public Principal()
        {
            InitializeComponent();
        }

        public void CarregarnoPainel(string nomeFormulario)
        {
            // M�todo para carregar o formul�rio especificado no painel2
            // O nome do formul�rio deve ser passado como uma string, por exemplo: "FormBoasVindas", "FormCriar", etc.
            Form formulario = nomeFormulario switch
            {
                "FormBoasVindas" => new FormBoasVindas(),
                "FormCriar" => new FormCriar(),
                "FormEditar" => new FormEditar(),
                "FormTarefas" => new FormTarefas(),
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


        private void button1_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormBoasVindas"); // Chama o m�todo inicial para carregar o formul�rio de boas-vindas
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            CarregarnoPainel("FormBoasVindas"); // Chama o m�todo inicial ao carregar o formul�rio principal
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormCriar"); // Chama o m�todo inicial ao carregar o formul�rio principal
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormTarefas"); // Chama o m�todo inicial ao carregar o formul�rio principal
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormEditar"); // Chama o m�todo inicial ao carregar o formul�rio principal
        }
    }
}
