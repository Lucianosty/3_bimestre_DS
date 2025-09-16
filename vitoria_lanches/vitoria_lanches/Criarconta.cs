using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vitoria_lanches
{
    public partial class Criarconta : Form
    {


        public Criarconta()
        {
            InitializeComponent();
        }

        public string vNome { get; set; }
        public string vSenha { get; set; }

        public string vTipo { get; set; } = "cliente";

        public bool CriarConta()
        {
            try
            {

                using (MySqlConnection mySqlConnection = new MySqlConnection(Program.conexao))
                {
                    string sql = "INSERT INTO tb_usuarios (TB_USUARIOS_USERNAME, TB_USUARIOS_PASSWORD, TB_USUARIOS_TIPO) VALUES (@vNome, @vSenha, @vTipo)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@vNome", vNome);
                        cmd.Parameters.AddWithValue("@vSenha", vSenha);
                        cmd.Parameters.AddWithValue("@vTipo", vTipo);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Sua conta foi criada");
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void txtNomelog_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            if (CriarConta())
            {
                MessageBox.Show("Sua conta foi criada");
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
