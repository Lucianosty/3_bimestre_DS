namespace vitoriaLanches2
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        public void CarregarPanel(string nomeFormulario)
        {

            Form formulario = nomeFormulario switch
            {
                "FormBoasVindas" => new boasvindas(),
                "FormCriarconta" => new cadastro(),
                "FormLogin" => new login(),


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
            CarregarPanel("FormBoasVindas");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregarPanel("FormCriarconta");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarPanel("FormBoasVindas");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            CarregarPanel("FormLogin");
        }
    }
}
