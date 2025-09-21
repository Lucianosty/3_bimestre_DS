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
using System.Xml.Linq;
using ZstdSharp.Unsafe;

namespace vitoria_lanches
{
    public partial class CadProd : Form
    {
        public CadProd()
        {
            InitializeComponent();
        }

        public string vNomeprod { get; set; }
        public string vDescprod { get; set; }

        public int vTipoprod { get; set; }

        public decimal vPrecoprod { get; set; }

        private void TipoProd(){

            using (MySqlConnection mySqlConnection = new MySqlConnection(Program.conexao))
            {
                mySqlConnection.Open();
                string sql = "SELECT tb_tipo_produto_id, tb_tipo_produto_desc FROM tb_tipo_produto";
                MySqlDataAdapter uga = new MySqlDataAdapter(sql,mySqlConnection);
                DataTable ula = new DataTable();
                uga.Fill(ula); // Vai preencher com os dados que foram enviados pro data table
                //comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged; maybe?
                comboBox1.DataSource = ula;
                comboBox1.DisplayMember = "TB_TIPO_PRODUTO_DESC"; //Para mostrar pro usuario
                comboBox1.ValueMember = "TB_TIPO_PRODUTO_ID"; //Para saber que dado ele tem que pegar
                

            }

        }

        public bool addProd()
        {
            try {

                using (MySqlConnection mySqlConnection = new MySqlConnection(Program.conexao))
                {
                    mySqlConnection.Open();
                    string sql = "INSERT INTO tb_produto(TB_PRODUTO_NOME, TB_PRODUTO_DESC, TB_PRODUTO_PRECO, FK_TIPO_PRODUTO_ID)" + "VALUES (@nome, @desc, @tipo, @preco)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@nome", vNomeprod);
                        cmd.Parameters.AddWithValue("@desc", vDescprod);
                        cmd.Parameters.AddWithValue("@tipo", vTipoprod);
                        cmd.Parameters.AddWithValue("@preco", vPrecoprod);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Produto criado com Sucesso!");
                    return true;
                }
                }
            catch(Exception ex) {
                MessageBox.Show("Falha ao adicionar o produto" + ex.Message);
                return false;
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNomeProd.Text) && !string.IsNullOrWhiteSpace(txtPreco.Text) && !string.IsNullOrWhiteSpace(txtdesc.Text))
            {
                vNomeprod = txtNomeProd.Text;
                vDescprod = txtdesc.Text;
                if (!decimal.TryParse(txtPreco.Text, out decimal precoconvertido)) 
                {
                    MessageBox.Show("Digite um preço válido");
                    return;
                }
                vPrecoprod = precoconvertido;
            }
            int tipoid;
            if (!int.TryParse(comboBox1.SelectedValue.ToString(),out tipoid)) //Para converter o combobox que é string para int
            {
                if (comboBox1.SelectedItem is DataRowView una)
                {
                    tipoid = Convert.ToInt32(una["TB_TIPO_PRODUTO_ID"]);
                }
                else {
                    MessageBox.Show("Tipo Inválido");
                }
                vTipoprod = tipoid;

                if (addProd())
                {
                    MessageBox.Show("Produto cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possivel cadastrar");
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente!");
            }

        }
    }
}
