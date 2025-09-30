namespace vitoriaLanches2
{
    partial class Form1
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
            panel1 = new Panel();
            btnLog = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 39, 39);
            panel1.Controls.Add(btnLog);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 449);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.FromArgb(43, 39, 39);
            btnLog.FlatAppearance.BorderSize = 0;
            btnLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLog.ForeColor = Color.FromArgb(248, 180, 0);
            btnLog.Location = new Point(23, 329);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(170, 41);
            btnLog.TabIndex = 2;
            btnLog.Text = "Login";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(43, 39, 39);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(248, 180, 0);
            button2.Location = new Point(23, 271);
            button2.Name = "button2";
            button2.Size = new Size(170, 41);
            button2.TabIndex = 1;
            button2.Text = "Cadastro";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Vitória__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(43, 39, 39);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 15F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(248, 180, 0);
            button1.Location = new Point(23, 214);
            button1.Name = "button1";
            button1.Size = new Size(170, 41);
            button1.TabIndex = 0;
            button1.Text = "Boas-Vindas!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(227, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 449);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 39, 39);
            ClientSize = new Size(1030, 451);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Button btnLog;
        private PictureBox pictureBox1;
    }
}
