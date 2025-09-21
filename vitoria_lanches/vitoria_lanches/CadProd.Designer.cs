namespace vitoria_lanches
{
    partial class CadProd
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
            label3 = new Label();
            txtNomeProd = new TextBox();
            label4 = new Label();
            txtPreco = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            txtdesc = new TextBox();
            btnCriar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(122, 51);
            label1.Name = "label1";
            label1.Size = new Size(275, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(94, 136);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 1;
            label2.Text = "Tipo do produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(94, 193);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 2;
            label3.Text = "Nome produto";
            // 
            // txtNomeProd
            // 
            txtNomeProd.Font = new Font("Segoe UI", 12F);
            txtNomeProd.Location = new Point(244, 193);
            txtNomeProd.Multiline = true;
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(167, 34);
            txtNomeProd.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(94, 259);
            label4.Name = "label4";
            label4.Size = new Size(134, 28);
            label4.TabIndex = 4;
            label4.Text = "Preço unitário";
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 12F);
            txtPreco.Location = new Point(244, 258);
            txtPreco.Multiline = true;
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(167, 34);
            txtPreco.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(258, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 29);
            comboBox1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(94, 313);
            label5.Name = "label5";
            label5.Size = new Size(174, 28);
            label5.TabIndex = 7;
            label5.Text = "Descrição produto";
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(274, 313);
            txtdesc.Multiline = true;
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(182, 36);
            txtdesc.TabIndex = 8;
            // 
            // btnCriar
            // 
            btnCriar.Font = new Font("Segoe UI", 15F);
            btnCriar.Location = new Point(94, 366);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(158, 40);
            btnCriar.TabIndex = 9;
            btnCriar.Text = "Criar Produto";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // CadProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCriar);
            Controls.Add(txtdesc);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(txtPreco);
            Controls.Add(label4);
            Controls.Add(txtNomeProd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadProd";
            Text = "CadProd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNomeProd;
        private Label label4;
        private TextBox txtPreco;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox txtdesc;
        private Button btnCriar;
    }
}