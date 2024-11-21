namespace SkyFarm
{
    partial class FormLogin
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
            bt_conectar = new Button();
            label1 = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // bt_conectar
            // 
            bt_conectar.BackColor = Color.DarkOliveGreen;
            bt_conectar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_conectar.ForeColor = SystemColors.ButtonHighlight;
            bt_conectar.Location = new Point(560, 255);
            bt_conectar.Name = "bt_conectar";
            bt_conectar.Size = new Size(143, 55);
            bt_conectar.TabIndex = 0;
            bt_conectar.Text = "Conectar";
            bt_conectar.UseVisualStyleBackColor = false;
            bt_conectar.Click += bt_conectar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 119);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 1;
            label1.Text = "Login ou E-mail";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.Location = new Point(204, 119);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(499, 33);
            txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(204, 195);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(499, 33);
            txtSenha.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(132, 195);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(bt_conectar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 322);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(694, 70);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(511, 20);
            label3.Name = "label3";
            label3.Size = new Size(180, 32);
            label3.TabIndex = 0;
            label3.Text = "Faça seu Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 322);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bt_conectar;
        private Label label1;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
    }
}