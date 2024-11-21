namespace SkyFarm
{
    partial class GerenciarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarProduto));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            boxProdutos = new ListBox();
            panel2 = new Panel();
            panel4 = new Panel();
            btConfirmar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txNome = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txCodigo = new TextBox();
            txQuantidade = new TextBox();
            txPreco = new TextBox();
            label8 = new Label();
            label9 = new Label();
            cbMedida = new ComboBox();
            txDescricao = new TextBox();
            bxImage = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            btRemover = new Button();
            btNovo = new Button();
            dgAberturaImage = new OpenFileDialog();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bxImage).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.YellowGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 80);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OliveDrab;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(310, 45);
            label1.TabIndex = 0;
            label1.Text = "Gerenciar Produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 110);
            label2.Name = "label2";
            label2.Size = new Size(184, 30);
            label2.TabIndex = 5;
            label2.Text = "Lista de Produtos";
            // 
            // boxProdutos
            // 
            boxProdutos.FormattingEnabled = true;
            boxProdutos.ItemHeight = 15;
            boxProdutos.Location = new Point(15, 157);
            boxProdutos.Name = "boxProdutos";
            boxProdutos.Size = new Size(247, 349);
            boxProdutos.TabIndex = 6;
            boxProdutos.SelectedIndexChanged += boxProdutos_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(268, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(678, 408);
            panel2.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Honeydew;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(btConfirmar);
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(15, 98);
            panel4.Name = "panel4";
            panel4.Size = new Size(660, 293);
            panel4.TabIndex = 3;
            // 
            // btConfirmar
            // 
            btConfirmar.BackColor = Color.DarkGoldenrod;
            btConfirmar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btConfirmar.ForeColor = Color.White;
            btConfirmar.Location = new Point(43, 213);
            btConfirmar.Name = "btConfirmar";
            btConfirmar.Size = new Size(116, 49);
            btConfirmar.TabIndex = 6;
            btConfirmar.Text = "Confirmar";
            btConfirmar.UseVisualStyleBackColor = false;
            btConfirmar.Click += btConfirmar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txNome, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(txCodigo, 1, 1);
            tableLayoutPanel1.Controls.Add(txQuantidade, 1, 3);
            tableLayoutPanel1.Controls.Add(txPreco, 1, 5);
            tableLayoutPanel1.Controls.Add(label8, 0, 4);
            tableLayoutPanel1.Controls.Add(label9, 0, 5);
            tableLayoutPanel1.Controls.Add(cbMedida, 1, 4);
            tableLayoutPanel1.Controls.Add(txDescricao, 1, 2);
            tableLayoutPanel1.Location = new Point(279, 16);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(378, 274);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // txNome
            // 
            txNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txNome.Location = new Point(192, 3);
            txNome.Name = "txNome";
            txNome.Size = new Size(183, 29);
            txNome.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 4;
            label4.Text = "Produto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 45);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 5;
            label5.Text = "Código";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 90);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 6;
            label6.Text = "Descrição";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 135);
            label7.Name = "label7";
            label7.Size = new Size(100, 21);
            label7.TabIndex = 7;
            label7.Text = "Quantidade";
            // 
            // txCodigo
            // 
            txCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txCodigo.Location = new Point(192, 48);
            txCodigo.Name = "txCodigo";
            txCodigo.Size = new Size(183, 29);
            txCodigo.TabIndex = 8;
            // 
            // txQuantidade
            // 
            txQuantidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txQuantidade.Location = new Point(192, 138);
            txQuantidade.Name = "txQuantidade";
            txQuantidade.Size = new Size(183, 29);
            txQuantidade.TabIndex = 10;
            // 
            // txPreco
            // 
            txPreco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txPreco.Location = new Point(192, 228);
            txPreco.Name = "txPreco";
            txPreco.Size = new Size(183, 29);
            txPreco.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 180);
            label8.Name = "label8";
            label8.Size = new Size(68, 21);
            label8.TabIndex = 13;
            label8.Text = "Medida";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 225);
            label9.Name = "label9";
            label9.Size = new Size(50, 21);
            label9.TabIndex = 14;
            label9.Text = "Valor";
            // 
            // cbMedida
            // 
            cbMedida.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbMedida.FormattingEnabled = true;
            cbMedida.Items.AddRange(new object[] { "gramas", "unidade", "ml" });
            cbMedida.Location = new Point(192, 183);
            cbMedida.Name = "cbMedida";
            cbMedida.Size = new Size(183, 29);
            cbMedida.TabIndex = 16;
            // 
            // txDescricao
            // 
            txDescricao.Location = new Point(192, 93);
            txDescricao.Multiline = true;
            txDescricao.Name = "txDescricao";
            txDescricao.Size = new Size(183, 39);
            txDescricao.TabIndex = 17;
            // 
            // bxImage
            // 
            bxImage.ErrorImage = (Image)resources.GetObject("bxImage.ErrorImage");
            bxImage.Image = Properties.Resources.img;
            bxImage.InitialImage = Properties.Resources.img;
            bxImage.Location = new Point(18, 13);
            bxImage.Name = "bxImage";
            bxImage.Size = new Size(216, 111);
            bxImage.TabIndex = 1;
            bxImage.TabStop = false;
            bxImage.Click += bxImage_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 16);
            label3.Name = "label3";
            label3.Size = new Size(174, 21);
            label3.TabIndex = 2;
            label3.Text = "Selecione uma image";
            // 
            // panel3
            // 
            panel3.BackColor = Color.OliveDrab;
            panel3.Controls.Add(btRemover);
            panel3.Controls.Add(btNovo);
            panel3.Location = new Point(3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(672, 92);
            panel3.TabIndex = 0;
            // 
            // btRemover
            // 
            btRemover.BackColor = Color.Violet;
            btRemover.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRemover.ForeColor = SystemColors.ButtonHighlight;
            btRemover.Location = new Point(392, 15);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(203, 64);
            btRemover.TabIndex = 1;
            btRemover.Text = "Remover produto Selecionado";
            btRemover.UseVisualStyleBackColor = false;
            btRemover.Click += btRemover_Click;
            // 
            // btNovo
            // 
            btNovo.BackColor = Color.RoyalBlue;
            btNovo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNovo.ForeColor = SystemColors.ControlLightLight;
            btNovo.Location = new Point(37, 12);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(144, 67);
            btNovo.TabIndex = 0;
            btNovo.Text = "Criar novo produto";
            btNovo.UseVisualStyleBackColor = false;
            btNovo.Click += btNovo_Click;
            // 
            // dgAberturaImage
            // 
            dgAberturaImage.FileName = "aberturaImage";
            // 
            // panel5
            // 
            panel5.BackColor = Color.ForestGreen;
            panel5.Controls.Add(bxImage);
            panel5.Location = new Point(25, 48);
            panel5.Name = "panel5";
            panel5.Size = new Size(248, 135);
            panel5.TabIndex = 7;
            // 
            // GerenciarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 518);
            Controls.Add(panel2);
            Controls.Add(boxProdutos);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "GerenciarProduto";
            Text = "GerenciarProduto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bxImage).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ListBox boxProdutos;
        private Panel panel2;
        private Panel panel3;
        private Button btNovo;
        private Button btRemover;
        private PictureBox bxImage;
        private OpenFileDialog dgAberturaImage;
        private Label label3;
        private Panel panel4;
        private TextBox txNome;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox txCodigo;
        private TextBox txPreco;
        private TextBox txQuantidade;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private ComboBox cbMedida;
        private Button btConfirmar;
        private Label label6;
        private TextBox txDescricao;
        private Panel panel5;
    }
}