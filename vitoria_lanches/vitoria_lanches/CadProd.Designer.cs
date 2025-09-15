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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(283, 74);
            label1.Name = "label1";
            label1.Size = new Size(203, 28);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(106, 142);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 1;
            label2.Text = "Tipo do produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(107, 178);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 2;
            label3.Text = "Nome produto";
            // 
            // txtNomeProd
            // 
            txtNomeProd.Location = new Point(242, 178);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(162, 23);
            txtNomeProd.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(107, 216);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 4;
            label4.Text = "Preço unitário";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(242, 220);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(162, 23);
            txtPreco.TabIndex = 5;
            // 
            // CadProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}