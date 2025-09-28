using Org.BouncyCastle.Asn1.Esf;
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
    public partial class administrador : Form
    {
        public administrador()
        {
            InitializeComponent();
        }

        private void GerenciarProd()
        {
            GerenciarProd prod = new GerenciarProd();
            prod.TopLevel = false;                       // Define que o objeto do Form atualizar não é um formulário de nível superior
            prod.FormBorderStyle = FormBorderStyle.None; // Remove a borda do objeto do Form atualizar
            prod.Dock = DockStyle.Fill;                  // Faz com que o objeto do Form atualizar preencha todo o painel
            panel1.Controls.Clear();                       // Apaga todos os elemento anteriores do painel 3 para poder exibir os novos 
            panel1.Controls.Add(prod);                   // Adiciona o objeto do Form atualizar ao painel 3
            prod.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GerenciarProd();
        }
    }
}
