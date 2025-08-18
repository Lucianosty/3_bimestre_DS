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
            // Método para carregar o formulário especificado no painel2
            // O nome do formulário deve ser passado como uma string, por exemplo: "FormBoasVindas", "FormCriar", etc.
            Form formulario = nomeFormulario switch
            {
                "FormBoasVindas" => new FormBoasVindas(),
                "FormCriar" => new FormCriar(),
                "FormEditar" => new FormEditar(),
                "FormTarefas" => new FormTarefas(),
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


        private void button1_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormBoasVindas"); // Chama o método inicial para carregar o formulário de boas-vindas
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            CarregarnoPainel("FormBoasVindas"); // Chama o método inicial ao carregar o formulário principal
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormCriar"); // Chama o método inicial ao carregar o formulário principal
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormTarefas"); // Chama o método inicial ao carregar o formulário principal
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarregarnoPainel("FormEditar"); // Chama o método inicial ao carregar o formulário principal
        }
    }
}
