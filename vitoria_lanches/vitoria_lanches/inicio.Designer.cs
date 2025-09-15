namespace vitoria_lanches
{
    partial class inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnEntrar = new Button();
            btnSair = new Button();
            panel1 = new Panel();
            btnProduto = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(275, 220);
            label1.Name = "label1";
            label1.Size = new Size(265, 25);
            label1.TabIndex = 0;
            label1.Text = "Bem vindo ao Vitória Lanches.\r\n";
            label1.Click += this.label1_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 12F);
            btnEntrar.Location = new Point(43, 28);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(111, 39);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 12F);
            btnSair.Location = new Point(295, 328);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(111, 43);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnProduto);
            panel1.Controls.Add(btnEntrar);
            panel1.Location = new Point(0, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 88);
            panel1.TabIndex = 3;
            // 
            // btnProduto
            // 
            btnProduto.Font = new Font("Segoe UI", 12F);
            btnProduto.Location = new Point(174, 28);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(111, 39);
            btnProduto.TabIndex = 4;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(321, 28);
            button1.Name = "button1";
            button1.Size = new Size(85, 37);
            button1.TabIndex = 5;
            button1.Text = "Pedido";
            button1.UseVisualStyleBackColor = true;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnSair);
            Controls.Add(label1);
            Name = "inicio";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEntrar;
        private Button btnSair;
        private Panel panel1;
        private Button button1;
        private Button btnProduto;
    }
}
