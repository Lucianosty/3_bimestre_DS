using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Sec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vitoriaLanches2
{
    public partial class GerenciarProd : Form
    {

        private string textoparaconexao = "server=127.0.0.1;database=bd_vitoria_lanches;user=root;password=root;";

        public GerenciarProd()
        {
            InitializeComponent();
            Tipoprod();
            comboboxDeletProd();
            mostrarTipo();


        }
        public string vNomeprod { get; set; }
        public string vDescprod { get; set; }

        public string vTiponome { get; set; }

        public int vTipoprod { get; set; }

        public decimal vPrecoprod { get; set; }



        private void mostrarTipo()
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(textoparaconexao))
            {
                mySqlConnection.Open();
                string sql = "SELECT TB_TIPO_PRODUTO_ID, TB_TIPO_PRODUTO_DESC FROM tb_tipo_produto";
                MySqlDataAdapter uga = new MySqlDataAdapter(sql, mySqlConnection);
                DataTable ula = new DataTable();
                uga.Fill(ula); // Vai preencher com os dados que foram enviados pro data table
                comboBox3.SelectedIndexChanged -= comboBox3_SelectedIndexChanged;
                comboBox3.DataSource = ula;
                comboBox3.DisplayMember = "TB_TIPO_PRODUTO_DESC"; //Para mostrar pro usuario
                comboBox3.ValueMember = "TB_TIPO_PRODUTO_ID"; //Para saber que dado ele tem que pegar
                comboBox3.SelectedIndex = -1;
                comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            }

        }


        private void Tipoprod()
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(textoparaconexao))
            {
                mySqlConnection.Open();
                string sql = "SELECT TB_TIPO_PRODUTO_ID, TB_TIPO_PRODUTO_DESC FROM tb_tipo_produto";
                MySqlDataAdapter uga = new MySqlDataAdapter(sql, mySqlConnection);
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
            try
            {

                using (MySqlConnection mySqlConnection = new MySqlConnection(textoparaconexao))
                {
                    mySqlConnection.Open();
                    string sql = "INSERT INTO tb_produto(TB_PRODUTO_NOME, TB_PRODUTO_DESC, TB_PRODUTO_PRECO_UNIT, TB_TIPO_PRODUTO_ID)" + "VALUES (@nome, @desc, @preco, @tipo)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@nome", vNomeprod);
                        cmd.Parameters.AddWithValue("@desc", vDescprod);
                        cmd.Parameters.AddWithValue("@preco", vPrecoprod);
                        cmd.Parameters.AddWithValue("@tipo", vTipoprod);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Produto criado com Sucesso!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao adicionar o produto" + ex.Message);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtnomeprod.Text) && !string.IsNullOrWhiteSpace(txtprecoprod.Text) && !string.IsNullOrWhiteSpace(txtdescprod.Text))
            {
                vNomeprod = txtnomeprod.Text;
                vDescprod = txtdescprod.Text;
                if (!decimal.TryParse(txtprecoprod.Text, out decimal precoconvertido))
                {
                    MessageBox.Show("Digite um preço válido");
                    return;
                }
                vPrecoprod = precoconvertido;

                int tipoid;
                if (!int.TryParse(comboBox1.SelectedValue.ToString(), out tipoid)) //Para converter o combobox que é string para int
                {
                    if (comboBox1.SelectedItem is DataRowView una)
                    {
                        tipoid = Convert.ToInt32(una["TB_TIPO_PRODUTO_ID"]);
                    }
                    else
                    {
                        MessageBox.Show("Tipo Inválido");
                    }
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

        private void comboboxDeletProd()
        {

            using (MySqlConnection mySqlConnection = new MySqlConnection(textoparaconexao))
            {
                mySqlConnection.Open();
                string sql = "SELECT TB_PRODUTO_ID, TB_PRODUTO_NOME FROM tb_produto";
                MySqlDataAdapter uga = new MySqlDataAdapter(sql, mySqlConnection);
                DataTable ula = new DataTable();
                uga.Fill(ula); // Vai preencher com os dados que foram enviados pro data table
                comboBox2.SelectedIndexChanged -= comboBox2_SelectedIndexChanged;
                comboBox2.DataSource = ula;
                comboBox2.DisplayMember = "TB_PRODUTO_NOME"; //Para mostrar pro usuario
                comboBox2.ValueMember = "TB_PRODUTO_ID"; //Para saber que dado ele tem que pegar
                comboBox2.SelectedIndex = -1;
                comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;

            }
        }



        public bool deletProd(int id)
        {
            try
            {

                using (MySqlConnection mySqlConnection = new MySqlConnection(textoparaconexao))
                {
                    mySqlConnection.Open();
                    string sql = "DELETE FROM tb_produto WHERE TB_PRODUTO_ID = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Produto deletado com Sucesso!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao deletar o produto" + ex.Message);
                return false;
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null) return;
            int id = Convert.ToInt32(comboBox2.SelectedValue);
            deletProd(id);
            comboboxDeletProd();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um produto!");
                return;
            }
            int id = Convert.ToInt32(comboBox2.SelectedValue);
            vNomeprod = txtnomeprod.Text;
            vDescprod = txtdescprod.Text;
            if (!decimal.TryParse(txtprecoprod.Text, out decimal precoconvertido))
            {
                MessageBox.Show("Digite um preço válido");
                return;
            }
            vPrecoprod = precoconvertido;

            int tipoid;
            vTipoprod = Convert.ToInt32(comboBox1.SelectedValue);
            if (atualizarProd(id))
            {
                MessageBox.Show("Produto atualizado com sucesso");
            }

        }

        public bool atualizarProd(int id)
        {
            try
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection(textoparaconexao))
                {
                    mySqlConnection.Open();
                    string sql = "UPDATE tb_produto SET " +
             "TB_PRODUTO_NOME = @nome, " +
             "TB_PRODUTO_DESC = @desc, " +
             "TB_PRODUTO_PRECO_UNIT = @preco, " +
             "TB_TIPO_PRODUTO_ID = @tipo " +
             "WHERE TB_PRODUTO_ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@nome", vNomeprod);
                        cmd.Parameters.AddWithValue("@desc", vDescprod);
                        cmd.Parameters.AddWithValue("@preco", vPrecoprod);
                        cmd.Parameters.AddWithValue("@tipo", vTipoprod);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Produto atualizado com Sucesso!");
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao atualizar o produto" + ex.Message);
                return false;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1 || comboBox2.SelectedValue == null)
                return;

            int id = Convert.ToInt32(comboBox2.SelectedValue);

            using (MySqlConnection conn = new MySqlConnection(textoparaconexao))
            {
                conn.Open();
                string sql = "SELECT * FROM tb_produto WHERE tb_produto_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtnomeprod.Text = reader["tb_produto_nome"].ToString();
                            txtdescprod.Text = reader["tb_produto_desc"].ToString();
                            decimal precoProduto = Convert.ToDecimal(reader["tb_produto_preco_unit"]);
                            txtprecoprod.Text = precoProduto.ToString("0.00");
                            comboBox1.SelectedValue = Convert.ToInt32(reader["TB_TIPO_PRODUTO_ID"]);
                        }
                    }
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == -1 || comboBox3.SelectedValue == null)
                return;

            int id = Convert.ToInt32(comboBox3.SelectedValue);

            using (MySqlConnection conn = new MySqlConnection(textoparaconexao))
            {
                conn.Open();
                string sql = "SELECT tb_tipo_produto_desc from tb_tipo_produto where tb_tipo_produto_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtcat.Text = reader["tb_tipo_produto_desc"].ToString();
                        }
                    }
                }
            }
        }


        public bool addTipo()
        {
            try
            {

                using (MySqlConnection mySqlConnection = new MySqlConnection(textoparaconexao))
                {
                    mySqlConnection.Open();
                    string sql = "INSERT INTO tb_tipo_produto(TB_TIPO_PRODUTO_DESC)" + "VALUES (@tiponome)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@tiponome", vTiponome);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao adicionar o tipo de produto" + ex.Message);
                return false;
            }
        }

        public bool atualizarTipo(int id)
        {
            try
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection(textoparaconexao))
                {
                    mySqlConnection.Open();
                    string sql = "UPDATE tb_tipo_produto SET " +
             "TB_TIPO_PRODUTO_DESC = @nome " +
             "WHERE TB_TIPO_PRODUTO_ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@nome", vTiponome);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Tipo de produto atualizado com Sucesso!");
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao atualizar o tipo de produto" + ex.Message);
                return false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtcat.Text))
            {


                vTiponome = txtcat.Text;
                if (addTipo())
                {
                    MessageBox.Show("Tipo do produto criado com sucesso");
                    mostrarTipo();
                    Tipoprod();
                }
                else
                {
                    MessageBox.Show("Tipo do produto nao foi possivel cadastrar");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de produto!");
                return;
            }
            int id = Convert.ToInt32(comboBox3.SelectedValue);
            vTiponome = txtcat.Text;

            if (atualizarTipo(id))
            {
                MessageBox.Show("Tipo de produto atualizado com sucesso");
                mostrarTipo();
                Tipoprod();
            }
        }
    }
}





    


