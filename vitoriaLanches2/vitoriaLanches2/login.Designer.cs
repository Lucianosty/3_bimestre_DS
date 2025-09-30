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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btncadastrar
            // 
            btncadastrar.BackColor = Color.FromArgb(43, 39, 39);
            btncadastrar.FlatAppearance.BorderSize = 0;
            btncadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btncadastrar.FlatStyle = FlatStyle.Flat;
            btncadastrar.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncadastrar.ForeColor = Color.FromArgb(248, 180, 0);
            btncadastrar.Location = new Point(313, 312);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(119, 38);
            btncadastrar.TabIndex = 11;
            btncadastrar.Text = "Entrar";
            btncadastrar.UseVisualStyleBackColor = false;
            btncadastrar.Click += btncadastrar_Click;
            // 
            // textsenha
            // 
            textsenha.Location = new Point(294, 261);
            textsenha.Multiline = true;
            textsenha.Name = "textsenha";
            textsenha.Size = new Size(155, 27);
            textsenha.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(248, 180, 0);
            label3.Location = new Point(331, 220);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 9;
            label3.Text = "Senha";
            // 
            // textlogin
            // 
            textlogin.Location = new Point(294, 163);
            textlogin.Multiline = true;
            textlogin.Name = "textlogin";
            textlogin.Size = new Size(155, 27);
            textlogin.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(248, 180, 0);
            label2.Location = new Point(308, 130);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 7;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F);
            label1.ForeColor = Color.FromArgb(248, 180, 0);
            label1.Location = new Point(327, 70);
            label1.Name = "label1";
            label1.Size = new Size(87, 39);
            label1.TabIndex = 6;
            label1.Text = "Login";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 39, 39);
            panel1.Controls.Add(btncadastrar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textsenha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textlogin);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 447);
            panel1.TabIndex = 12;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 39, 39);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "login";
            Text = "login";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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