namespace SkyFarm
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            painelLogado = new Panel();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btFuncionario = new Button();
            btProduto = new Button();
            btCliente = new Button();
            label1 = new Label();
            panel2 = new Panel();
            lbIdentificaUsuario = new Label();
            panel1 = new Panel();
            boxLogo = new PictureBox();
            painelLogado.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boxLogo).BeginInit();
            SuspendLayout();
            // 
            // painelLogado
            // 
            painelLogado.BackColor = Color.Gray;
            painelLogado.Controls.Add(panel3);
            painelLogado.Controls.Add(panel2);
            painelLogado.Controls.Add(panel1);
            painelLogado.Location = new Point(12, 12);
            painelLogado.Name = "painelLogado";
            painelLogado.Size = new Size(1167, 489);
            painelLogado.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 175);
            panel3.Name = "panel3";
            panel3.Size = new Size(731, 291);
            panel3.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btFuncionario);
            flowLayoutPanel1.Controls.Add(btProduto);
            flowLayoutPanel1.Controls.Add(btCliente);
            flowLayoutPanel1.Location = new Point(34, 99);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(650, 100);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btFuncionario
            // 
            btFuncionario.BackColor = Color.DodgerBlue;
            btFuncionario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btFuncionario.ForeColor = SystemColors.Control;
            btFuncionario.Location = new Point(3, 3);
            btFuncionario.Name = "btFuncionario";
            btFuncionario.Size = new Size(160, 88);
            btFuncionario.TabIndex = 1;
            btFuncionario.Text = "Gerenciar Funcionario";
            btFuncionario.UseVisualStyleBackColor = false;
            btFuncionario.Click += btFuncionario_Click;
            // 
            // btProduto
            // 
            btProduto.BackColor = Color.DarkOrchid;
            btProduto.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btProduto.ForeColor = SystemColors.Control;
            btProduto.Location = new Point(169, 3);
            btProduto.Name = "btProduto";
            btProduto.Size = new Size(160, 88);
            btProduto.TabIndex = 2;
            btProduto.Text = "Gerenciar Produtos";
            btProduto.UseVisualStyleBackColor = false;
            btProduto.Click += btProduto_Click;
            // 
            // btCliente
            // 
            btCliente.BackColor = Color.DarkOrchid;
            btCliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCliente.ForeColor = SystemColors.Control;
            btCliente.Location = new Point(335, 3);
            btCliente.Name = "btCliente";
            btCliente.Size = new Size(160, 88);
            btCliente.TabIndex = 3;
            btCliente.Text = "Apoio ao Cliente";
            btCliente.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 23);
            label1.Name = "label1";
            label1.Size = new Size(264, 37);
            label1.TabIndex = 0;
            label1.Text = "O que deseja fazer?";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(lbIdentificaUsuario);
            panel2.Location = new Point(3, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(731, 51);
            panel2.TabIndex = 3;
            // 
            // lbIdentificaUsuario
            // 
            lbIdentificaUsuario.AutoSize = true;
            lbIdentificaUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbIdentificaUsuario.Location = new Point(78, 11);
            lbIdentificaUsuario.Name = "lbIdentificaUsuario";
            lbIdentificaUsuario.Size = new Size(118, 30);
            lbIdentificaUsuario.TabIndex = 0;
            lbIdentificaUsuario.Text = "Bem vindo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(boxLogo);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 97);
            panel1.TabIndex = 2;
            // 
            // boxLogo
            // 
            boxLogo.Image = (Image)resources.GetObject("boxLogo.Image");
            boxLogo.Location = new Point(583, 13);
            boxLogo.Name = "boxLogo";
            boxLogo.Size = new Size(127, 72);
            boxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            boxLogo.TabIndex = 0;
            boxLogo.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 513);
            Controls.Add(painelLogado);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            painelLogado.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)boxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel painelLogado;
        private Panel panel1;
        private Panel panel2;
        private Label lbIdentificaUsuario;
        private Panel panel3;
        private Label label1;
        private Button btProduto;
        private Button btFuncionario;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btCliente;
        private PictureBox boxLogo;
    }
}
