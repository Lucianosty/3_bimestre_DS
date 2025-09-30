using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vitoriaLanches2
{
    public partial class cadastro : Form
    {

        private string textoparaconexao = "server=127.0.0.1;database=bd_vitoria_lanches;user=root;password=root;";

        public cadastro()
        {
            InitializeComponent();
        }

        private void cadastro_Load(object sender, EventArgs e)
        {
            string username;
            string password;
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                using (MySqlConnection conechao = new MySqlConnection(textoparaconexao))
                {

                    conechao.Open();
                    string adicionarUser = "INSERT INTO tb_usuarios (TB_USUARIOS_USERNAME, TB_USUARIOS_PASSWORD, TB_USUARIOS_TIPO)"
                        + " VALUES (@username, @password, 'cliente')";
                    MySqlCommand comandito = new MySqlCommand(adicionarUser, conechao);
                    comandito.Parameters.AddWithValue("@username", textlogin.Text);
                    comandito.Parameters.AddWithValue("@password", textsenha.Text);
                    comandito.ExecuteNonQuery();
                    MessageBox.Show("Cliente inserido com sucesso!"); //Cadastrou o usuario
                    conechao.Close(); //Fechar a conexao
                }
            }
            catch
            {
                MessageBox.Show("Cliente não inserido!");
            }

        }

        private void textsenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
