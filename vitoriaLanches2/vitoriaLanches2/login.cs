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

        private Form1 lForm1;

        public login(Form1 form)
        {
            InitializeComponent();
            this.lForm1 = form;
        }


        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string username = textlogin.Text;
            string password = textsenha.Text;

            using (MySqlConnection conechao = new MySqlConnection(textoparaconexao))
            {
                try
                {
                    conechao.Open();
                    string loginUser = @"SELECT TB_USUARIOS_ID, TB_USUARIOS_USERNAME, TB_USUARIOS_TIPO FROM tb_usuarios WHERE TB_USUARIOS_USERNAME = @username AND TB_USUARIOS_PASSWORD = @password";
                    MySqlCommand comandito = new MySqlCommand(loginUser, conechao);
                    comandito.Parameters.AddWithValue("@username", username);
                    comandito.Parameters.AddWithValue("@password", password);
                    using (MySqlDataReader reader = comandito.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tipoUsuario = reader["TB_USUARIOS_TIPO"].ToString();
                            if (tipoUsuario.Equals("administrador", StringComparison.OrdinalIgnoreCase))
                            {   
                                 
                                
                                 lForm1.Controls["panel2"].Controls.Clear();
                                 administrador gerenciamento = new administrador();
                                 gerenciamento.TopLevel = false;
                                 gerenciamento.FormBorderStyle = FormBorderStyle.None;
                                 gerenciamento.Dock = DockStyle.Fill;
                                 lForm1.Controls["panel2"].Controls.Add(gerenciamento);
                                 gerenciamento.Show();



                            }
                            else if (tipoUsuario.Equals("cliente", StringComparison.OrdinalIgnoreCase))
                            {   
                               
                                lForm1.Controls["panel2"].Controls.Clear();
                                cliente cli = new cliente();
                                cli.TopLevel = false;
                                cli.FormBorderStyle = FormBorderStyle.None;
                                cli.Dock = DockStyle.Fill;
                                lForm1.Controls["panel2"].Controls.Add(cli);
                                cli.Show();

                            }
                            else
                            {
                                MessageBox.Show("Erro ao entrar!");
                            }
                        }
                    }

                }
                catch (Exception ex) 
                    {
                        
                        MessageBox.Show("Erro!"+ ex.Message);
                    }
                }
            }
        }
    }
