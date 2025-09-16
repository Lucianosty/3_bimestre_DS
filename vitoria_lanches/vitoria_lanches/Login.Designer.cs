namespace vitoria_lanches
{
    partial class Login
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
            txtNomelog = new TextBox();
            label3 = new Label();
            txtSenhaLog = new TextBox();
            label4 = new Label();
            btnCriarcont = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(362, 75);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 0;
            label1.Text = "Entrar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(335, 142);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome do Login";
            // 
            // txtNomelog
            // 
            txtNomelog.Font = new Font("Segoe UI", 12F);
            txtNomelog.Location = new Point(301, 166);
            txtNomelog.Name = "txtNomelog";
            txtNomelog.Size = new Size(183, 29);
            txtNomelog.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(362, 231);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // txtSenhaLog
            // 
            txtSenhaLog.Location = new Point(301, 255);
            txtSenhaLog.Name = "txtSenhaLog";
            txtSenhaLog.Size = new Size(183, 23);
            txtSenhaLog.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(244, 311);
            label4.Name = "label4";
            label4.Size = new Size(289, 21);
            label4.TabIndex = 5;
            label4.Text = "Não tem uma conta? Clique nesse botão";
            label4.Click += label4_Click;
            // 
            // btnCriarcont
            // 
            btnCriarcont.Font = new Font("Segoe UI", 12F);
            btnCriarcont.Location = new Point(345, 345);
            btnCriarcont.Name = "btnCriarcont";
            btnCriarcont.Size = new Size(96, 45);
            btnCriarcont.TabIndex = 6;
            btnCriarcont.Text = "Criar conta";
            btnCriarcont.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCriarcont);
            Controls.Add(label4);
            Controls.Add(txtSenhaLog);
            Controls.Add(label3);
            Controls.Add(txtNomelog);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNomelog;
        private Label label3;
        private TextBox txtSenhaLog;
        private Label label4;
        private Button btnCriarcont;
    }
}