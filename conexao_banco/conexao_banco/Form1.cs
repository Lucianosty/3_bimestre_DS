using System.Drawing.Text;
using MySql.Data.MySqlClient;
namespace conexao_banco
{
    public partial class Form1 : Form
    {
        private string textoparaconexao = "server=127.0.0.1;database=Aluno;user=root;password=root;"; //criando uma variavel do tipo string para as conexoes do banco de dados
        //o server usa os numeros(127.0.0.1) pois sao melhores do que os nomes ,sempre ter preferencia por nome
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string id;
            string nome;
            string telefone;
            string rua;
            string bairro;
            string cidade;
            string estado;
            string cep;//Quando carregar o formulario irá carregar todas essas variaveis
        }

        private void pesquisa_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conechao = new MySqlConnection(textoparaconexao)) //Criando uma nova instancia do mysql conection que vai acessar a private string (server=127.0.0.1;database=Aluno;user=root;password=root;) 
            {
                conechao.Open();//Mandando abrir a nova instancia
                string oiaum = "SELECT * FROM Cliente WHERE ID_Cli = @ID";//criando uma variavel chamada oiaum que tem um select, aonde o id do cliente for igual ao @id
                MySqlCommand comandito = new MySqlCommand(oiaum, conechao);//Vai ter um novo objeto do mysql commnado guardando um novo comando pro oiaum ate o conechao
                comandito.Parameters.AddWithValue("@ID", id.Text);//Aonde que ele encontrou o @id ele vai trocar o conteudo da text box1
                MySqlDataReader reader = comandito.ExecuteReader();//Serve para ler o comando do comandito sendo o novo leitor,sendo um novo separador tambem
                if (reader.Read())//se foi feito a leitura
                {
                    nome.Text = reader["Nom_Cli"].ToString(); // a textbox nome vai ser atualizada com as novas informacoes
                    telefone.Text = reader["Tel_Cli"].ToString(); //extraindo cada um desses campos e colocando nas textboxs
                    rua.Text = reader["Rua_Cli"].ToString();
                    bairro.Text = reader["Bai_Cli"].ToString();
                    cidade.Text = reader["Cid_Cli"].ToString();
                    estado.Text = reader["Est_Cli"].ToString();
                    cep.Text = reader["CEP_Cli"].ToString();
                }
                else //se nao ele vai falar que nao foi encontrado
                {
                    MessageBox.Show("Cliente não encontrado!");
                    //LimparCampos();
                }
                reader.Close(); //fechando a leitura
                conechao.Close(); //fechando a conechao, sempre feche isso 

            }
        }

        private void inserir_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conechao = new MySqlConnection(textoparaconexao))
            {
                conechao.Open();
                string botalah = "INSERT INTO Cliente (Nom_Cli, Tel_Cli, Rua_Cli, Bai_Cli, Cid_Cli, Est_Cli, CEP_Cli) " +
                    "VALUES (@nome, @telefone, @rua, @bairro, @cidade, @estado, @cep)";
                MySqlCommand comandito = new MySqlCommand(botalah, conechao);
                comandito.Parameters.AddWithValue("@Nome", nome.Text);
                comandito.Parameters.AddWithValue("@Telefone", telefone.Text);
                comandito.Parameters.AddWithValue("@Rua", rua.Text);
                comandito.Parameters.AddWithValue("@Bairro", bairro.Text);
                comandito.Parameters.AddWithValue("@Cidade", cidade.Text);
                comandito.Parameters.AddWithValue("@Estado", estado.Text);
                comandito.Parameters.AddWithValue("@CEP", cep.Text);
                comandito.ExecuteNonQuery();
                MessageBox.Show("Cliente inserido com sucesso!");
                conechao.Close();
                //LimparCampos();
            }
        }
    }
}
