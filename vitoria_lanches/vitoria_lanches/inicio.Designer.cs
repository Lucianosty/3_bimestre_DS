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
            btnEntrar = new Button();
            panel1 = new Panel();
            btnInicio = new Button();
            button1 = new Button();
            btnProduto = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 12F);
            btnEntrar.Location = new Point(219, 28);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(111, 39);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnProduto);
            panel1.Controls.Add(btnEntrar);
            panel1.Location = new Point(0, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 88);
            panel1.TabIndex = 3;
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Segoe UI", 12F);
            btnInicio.Location = new Point(72, 34);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(90, 33);
            btnInicio.TabIndex = 6;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(462, 28);
            button1.Name = "button1";
            button1.Size = new Size(85, 37);
            button1.TabIndex = 5;
            button1.Text = "Pedido";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            btnProduto.Font = new Font("Segoe UI", 12F);
            btnProduto.Location = new Point(345, 26);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(111, 39);
            btnProduto.TabIndex = 4;
            btnProduto.Text = "Produtos";
            btnProduto.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 315);
            panel2.TabIndex = 4;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "inicio";
            Text = "Form1";
            Load += inicio_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnEntrar;
        private Panel panel1;
        private Button button1;
        private Button btnProduto;
        private Panel panel2;
        private Button btnInicio;
    }
}
