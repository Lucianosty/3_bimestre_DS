namespace vitoriaLanches2
{
    partial class GerenciarProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtnomeprod = new TextBox();
            txtdescprod = new TextBox();
            txtprecoprod = new TextBox();
            button1 = new Button();
            label6 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            comboBox3 = new ComboBox();
            txtcat = new TextBox();
            label8 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 41);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de produtos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 107);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo de produtos";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(156, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 146);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 3;
            label3.Text = "Nome Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 178);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Descricao";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 213);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 5;
            label5.Text = "Preco";
            // 
            // txtnomeprod
            // 
            txtnomeprod.Location = new Point(156, 143);
            txtnomeprod.Name = "txtnomeprod";
            txtnomeprod.Size = new Size(100, 23);
            txtnomeprod.TabIndex = 6;
            // 
            // txtdescprod
            // 
            txtdescprod.Location = new Point(156, 175);
            txtdescprod.Name = "txtdescprod";
            txtdescprod.Size = new Size(100, 23);
            txtdescprod.TabIndex = 7;
            // 
            // txtprecoprod
            // 
            txtprecoprod.Location = new Point(156, 213);
            txtprecoprod.Name = "txtprecoprod";
            txtprecoprod.Size = new Size(100, 23);
            txtprecoprod.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(36, 266);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
            button1.TabIndex = 9;
            button1.Text = "Criar produto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(339, 41);
            label6.Name = "label6";
            label6.Size = new Size(227, 15);
            label6.TabIndex = 10;
            label6.Text = "Selecione o produto para excluir ou editar";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(372, 74);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(401, 107);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(193, 266);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(349, 193);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 14;
            label7.Text = "Tipo de produtos";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(349, 271);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 15;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // txtcat
            // 
            txtcat.Location = new Point(439, 229);
            txtcat.Name = "txtcat";
            txtcat.Size = new Size(100, 23);
            txtcat.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(349, 232);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 17;
            label8.Text = "Criar categoria";
            // 
            // button4
            // 
            button4.Location = new Point(349, 323);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 18;
            button4.Text = "Criar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(464, 323);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 19;
            button5.Text = "Excluir";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(405, 363);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 20;
            button6.Text = "atualizar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // GerenciarProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label8);
            Controls.Add(txtcat);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(txtprecoprod);
            Controls.Add(txtdescprod);
            Controls.Add(txtnomeprod);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GerenciarProd";
            Text = "GerenciarProd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtnomeprod;
        private TextBox txtdescprod;
        private TextBox txtprecoprod;
        private Button button1;
        private Label label6;
        private ComboBox comboBox2;
        private Button button2;
        private Button button3;
        private Label label7;
        private ComboBox comboBox3;
        private TextBox txtcat;
        private Label label8;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}