namespace vitoriaLanches2
{
    partial class cadastro
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
            textlogin = new TextBox();
            label3 = new Label();
            textsenha = new TextBox();
            btncadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 60);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 109);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // textlogin
            // 
            textlogin.Location = new Point(326, 141);
            textlogin.Name = "textlogin";
            textlogin.Size = new Size(100, 23);
            textlogin.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 209);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // textsenha
            // 
            textsenha.Location = new Point(326, 249);
            textsenha.Name = "textsenha";
            textsenha.Size = new Size(100, 23);
            textsenha.TabIndex = 4;
            // 
            // btncadastrar
            // 
            btncadastrar.Location = new Point(338, 314);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(75, 23);
            btncadastrar.TabIndex = 5;
            btncadastrar.Text = "Cadastrar";
            btncadastrar.UseVisualStyleBackColor = true;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btncadastrar);
            Controls.Add(textsenha);
            Controls.Add(label3);
            Controls.Add(textlogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "cadastro";
            Text = "cadastro";
            Load += cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textlogin;
        private Label label3;
        private TextBox textsenha;
        private Button btncadastrar;
    }
}