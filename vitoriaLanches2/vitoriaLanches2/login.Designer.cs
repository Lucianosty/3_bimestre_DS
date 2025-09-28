namespace vitoriaLanches2
{
    partial class login
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
            btncadastrar = new Button();
            textsenha = new TextBox();
            label3 = new Label();
            textlogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btncadastrar
            // 
            btncadastrar.Location = new Point(331, 357);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(75, 23);
            btncadastrar.TabIndex = 11;
            btncadastrar.Text = "Entrar";
            btncadastrar.UseVisualStyleBackColor = true;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // textsenha
            // 
            textsenha.Location = new Point(319, 292);
            textsenha.Name = "textsenha";
            textsenha.Size = new Size(100, 23);
            textsenha.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 252);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Senha";
            // 
            // textlogin
            // 
            textlogin.Location = new Point(319, 184);
            textlogin.Name = "textlogin";
            textlogin.Size = new Size(100, 23);
            textlogin.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 152);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 7;
            label2.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 100);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 6;
            label1.Text = "login";
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 447);
            panel1.TabIndex = 12;
            // 
            // login
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
            Controls.Add(panel1);
            Name = "login";
            Text = "login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncadastrar;
        private TextBox textsenha;
        private Label label3;
        private TextBox textlogin;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}