namespace SCOPI
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
            panel1 = new Panel();
            label1 = new Label();
            txtUsuario = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            txtSenha = new TextBox();
            button1 = new Button();
            label2 = new Label();
            checkBox1 = new CheckBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 0, 85);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 450);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(459, 105);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 1;
            label1.Text = "INICIAR SESSÃO";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(2, 0, 85);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.ForeColor = SystemColors.Window;
            txtUsuario.Location = new Point(3, 17);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nome do Usuario (sem acento)";
            txtUsuario.Size = new Size(290, 25);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 0, 85);
            panel2.Controls.Add(txtUsuario);
            panel2.Cursor = Cursors.IBeam;
            panel2.Location = new Point(382, 187);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 54);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(2, 0, 85);
            panel3.Controls.Add(txtSenha);
            panel3.Cursor = Cursors.IBeam;
            panel3.Location = new Point(382, 261);
            panel3.Name = "panel3";
            panel3.Size = new Size(296, 54);
            panel3.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(2, 0, 85);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.ForeColor = SystemColors.Window;
            txtSenha.Location = new Point(3, 16);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Palavra Passe";
            txtSenha.Size = new Size(290, 24);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 0, 85);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(382, 351);
            button1.Name = "button1";
            button1.Size = new Size(135, 36);
            button1.TabIndex = 6;
            button1.Text = "ENTRAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(2, 0, 85);
            label2.Location = new Point(768, 9);
            label2.Name = "label2";
            label2.Size = new Size(20, 21);
            label2.TabIndex = 7;
            label2.Text = "X";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(2, 0, 85);
            checkBox1.Location = new Point(382, 326);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Mostrar senha";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtUsuario;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtSenha;
        private Button button1;
        private Label label2;
        private CheckBox checkBox1;
    }
}