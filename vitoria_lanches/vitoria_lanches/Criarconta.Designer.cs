namespace vitoria_lanches
{
    partial class Criarconta
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
            txtSenhaLog = new TextBox();
            label3 = new Label();
            txtNomelog = new TextBox();
            label2 = new Label();
            btnCriarConta = new Button();
            SuspendLayout();
            // 
            // txtSenhaLog
            // 
            txtSenhaLog.Location = new Point(309, 146);
            txtSenhaLog.Name = "txtSenhaLog";
            txtSenhaLog.Size = new Size(183, 23);
            txtSenhaLog.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(370, 122);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 7;
            label3.Text = "Senha";
            // 
            // txtNomelog
            // 
            txtNomelog.Font = new Font("Segoe UI", 12F);
            txtNomelog.Location = new Point(309, 57);
            txtNomelog.Name = "txtNomelog";
            txtNomelog.Size = new Size(183, 29);
            txtNomelog.TabIndex = 6;
            txtNomelog.TextChanged += txtNomelog_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(343, 33);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 5;
            label2.Text = "Nome do Login";
            // 
            // btnCriarConta
            // 
            btnCriarConta.Location = new Point(365, 222);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(75, 23);
            btnCriarConta.TabIndex = 9;
            btnCriarConta.Text = "Criar conta";
            btnCriarConta.UseVisualStyleBackColor = true;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // Criarconta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCriarConta);
            Controls.Add(txtSenhaLog);
            Controls.Add(label3);
            Controls.Add(txtNomelog);
            Controls.Add(label2);
            Name = "Criarconta";
            Text = "Criarconta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenhaLog;
        private Label label3;
        private TextBox txtNomelog;
        private Label label2;
        private Button btnCriarConta;
    }
}