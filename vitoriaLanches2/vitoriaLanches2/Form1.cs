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
                              
        }

        private void login()
        {
            login log = new login(this);
            log.TopLevel = false;                       // Define que o objeto do Form atualizar não é um formulário de nível superior
            log.FormBorderStyle = FormBorderStyle.None; // Remove a borda do objeto do Form atualizar
            log.Dock = DockStyle.Fill;                  // Faz com que o objeto do Form atualizar preencha todo o painel
            panel2.Controls.Clear();                       // Apaga todos os elemento anteriores do painel 3 para poder exibir os novos 
            panel2.Controls.Add(log);                   // Adiciona o objeto do Form atualizar ao painel 3
            log.Show();
        }

        private void boasvindas()
        {
            boasvindas boas = new boasvindas();
            boas.TopLevel = false;                       // Define que o objeto do Form atualizar não é um formulário de nível superior
            boas.FormBorderStyle = FormBorderStyle.None; // Remove a borda do objeto do Form atualizar
            boas.Dock = DockStyle.Fill;                  // Faz com que o objeto do Form atualizar preencha todo o painel
            panel2.Controls.Clear();                       // Apaga todos os elemento anteriores do painel 3 para poder exibir os novos 
            panel2.Controls.Add(boas);                   // Adiciona o objeto do Form atualizar ao painel 3
            boas.Show();
        }

        private void cadastro()
        {
            cadastro cad = new cadastro();
            cad.TopLevel = false;                       // Define que o objeto do Form atualizar não é um formulário de nível superior
            cad.FormBorderStyle = FormBorderStyle.None; // Remove a borda do objeto do Form atualizar
            cad.Dock = DockStyle.Fill;                  // Faz com que o objeto do Form atualizar preencha todo o painel
            panel2.Controls.Clear();                       // Apaga todos os elemento anteriores do painel 3 para poder exibir os novos 
            panel2.Controls.Add(cad);                   // Adiciona o objeto do Form atualizar ao painel 3
            cad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boasvindas();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastro();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boasvindas();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            login();
        }
        private void telaadm()
        {
            administrador adm = new administrador();

            adm.TopLevel = false;                       // Define que o objeto do Form atualizar não é um formulário de nível superior
            adm.FormBorderStyle = FormBorderStyle.None; // Remove a borda do objeto do Form atualizar
            adm.Dock = DockStyle.Fill;                  // Faz com que o objeto do Form atualizar preencha todo o painel
            panel2.Controls.Clear();                       // Apaga todos os elemento anteriores do painel 3 para poder exibir os novos 
            panel2.Controls.Add(adm);                   // Adiciona o objeto do Form atualizar ao painel 3
            adm.Show();                                 // Exibe o conteúdo do objeto do Form atualizar
        }
    }
}
