using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vitoriaLanches2
{
    public partial class login : Form
    {

        private string textoparaconexao = "server=127.0.0.1;database=bd_vitoria_lanches;user=root;password=root;";

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            string username;
            string password;
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            try {
                using (MySqlConnection conechao = new MySqlConnection(textoparaconexao)) {

                    conechao.Open();
                    string loginUser = "SELECT tb_usuarios WHERE TB_USUARIOS_USERNAME = @username, TB_USUARIOS_PASSWORD = @password";
                    MySqlCommand comandito = new MySqlCommand(loginUser, conechao);
                    comandito.Parameters.AddWithValue("@username", textlogin.Text);
                    comandito.Parameters.AddWithValue("@password", textsenha.Text);
                    using (MySqlDataReader reader = comandito.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tipoUsuario = reader["TB_USUARIOS_TIPO"].ToString();
                            if (tipoUsuario.Equals("administrador", StringComparison.OrdinalIgnoreCase))
                            {
                                administrador gerenciamento = new administrador();
                                gerenciamento.TopLevel = true;
                                
                            }
                            else if (tipoUsuario.Equals("cliente", StringComparison.OrdinalIgnoreCase){

                            }
                            else
                            {
                                MessageBox.Show("Erro ao entrar!");
                            }
                        }
                    }
                }
            }
            catch {
                MessageBox.Show("Erro!");
            }
        }
    }
}
