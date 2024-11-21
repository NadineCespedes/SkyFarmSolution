using SkyFarmClasses.entidades;

namespace SkyFarm
{
    partial class FormGerenciarFuncionarios
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
            listFuncionario = new ListBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            tabFuncionario = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            txUsuario = new TextBox();
            label3 = new Label();
            label4 = new Label();
            email = new Label();
            txEmail = new TextBox();
            txSenha = new TextBox();
            btConfirma = new Button();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            txNome = new TextBox();
            txDataNascimento = new TextBox();
            txRG = new TextBox();
            txCPF = new TextBox();
            txFiliacao = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            cbEscola = new ComboBox();
            cbCivil = new ComboBox();
            tabPage4 = new TabPage();
            tabPage3 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            label14 = new Label();
            listFuncionarioPermission = new ListBox();
            panel4 = new Panel();
            ggg = new TextBox();
            label13 = new Label();
            label12 = new Label();
            listAllPermission = new ListBox();
            panel3 = new Panel();
            btRemoverFuncionario = new Button();
            btNovoFuncionario = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label15 = new Label();
            textBox1 = new TextBox();
            label16 = new Label();
            label17 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabFuncionario.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage3.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // listFuncionario
            // 
            listFuncionario.FormattingEnabled = true;
            listFuncionario.ItemHeight = 15;
            listFuncionario.Items.AddRange(new object[] { "asdasd", "nadine" });
            listFuncionario.Location = new Point(12, 169);
            listFuncionario.Name = "listFuncionario";
            listFuncionario.Size = new Size(217, 394);
            listFuncionario.TabIndex = 2;
            listFuncionario.SelectedIndexChanged += listFuncionario_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 80);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(3, 20);
            label1.Name = "label1";
            label1.Size = new Size(363, 45);
            label1.TabIndex = 0;
            label1.Text = "Gerenciar Funcionarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 114);
            label2.Name = "label2";
            label2.Size = new Size(214, 32);
            label2.TabIndex = 4;
            label2.Text = "Lista de Registros";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(tabFuncionario);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(235, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(677, 465);
            panel2.TabIndex = 5;
            // 
            // tabFuncionario
            // 
            tabFuncionario.Controls.Add(tabPage1);
            tabFuncionario.Controls.Add(tabPage2);
            tabFuncionario.Controls.Add(tabPage4);
            tabFuncionario.Controls.Add(tabPage3);
            tabFuncionario.Location = new Point(6, 71);
            tabFuncionario.Name = "tabFuncionario";
            tabFuncionario.SelectedIndex = 0;
            tabFuncionario.Size = new Size(665, 391);
            tabFuncionario.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(657, 363);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sistema";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.51938F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.48062F));
            tableLayoutPanel1.Controls.Add(txUsuario, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(email, 0, 2);
            tableLayoutPanel1.Controls.Add(txEmail, 1, 2);
            tableLayoutPanel1.Controls.Add(txSenha, 1, 1);
            tableLayoutPanel1.Controls.Add(btConfirma, 0, 3);
            tableLayoutPanel1.Location = new Point(6, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(645, 351);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txUsuario
            // 
            txUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txUsuario.Location = new Point(245, 3);
            txUsuario.Name = "txUsuario";
            txUsuario.Size = new Size(397, 33);
            txUsuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 0;
            label3.Text = "Login do usuário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 87);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 2;
            label4.Text = "Senha";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.Location = new Point(3, 174);
            email.Name = "email";
            email.Size = new Size(67, 25);
            email.TabIndex = 4;
            email.Text = "E-mail";
            // 
            // txEmail
            // 
            txEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txEmail.Location = new Point(245, 177);
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(397, 33);
            txEmail.TabIndex = 5;
            // 
            // txSenha
            // 
            txSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txSenha.Location = new Point(245, 90);
            txSenha.Name = "txSenha";
            txSenha.PasswordChar = '@';
            txSenha.Size = new Size(397, 33);
            txSenha.TabIndex = 6;
            // 
            // btConfirma
            // 
            btConfirma.BackColor = Color.OliveDrab;
            btConfirma.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btConfirma.ForeColor = SystemColors.Info;
            btConfirma.Location = new Point(3, 264);
            btConfirma.Name = "btConfirma";
            btConfirma.Size = new Size(236, 48);
            btConfirma.TabIndex = 7;
            btConfirma.Text = "Confirmar";
            btConfirma.UseVisualStyleBackColor = false;
            btConfirma.Click += btConfirma_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(657, 363);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados Pessoais";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(txNome, 1, 0);
            tableLayoutPanel2.Controls.Add(txDataNascimento, 1, 1);
            tableLayoutPanel2.Controls.Add(txRG, 1, 2);
            tableLayoutPanel2.Controls.Add(txCPF, 1, 3);
            tableLayoutPanel2.Controls.Add(txFiliacao, 1, 4);
            tableLayoutPanel2.Controls.Add(label6, 0, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Controls.Add(label8, 0, 3);
            tableLayoutPanel2.Controls.Add(label9, 0, 4);
            tableLayoutPanel2.Controls.Add(label10, 0, 5);
            tableLayoutPanel2.Controls.Add(label11, 0, 6);
            tableLayoutPanel2.Controls.Add(cbEscola, 1, 5);
            tableLayoutPanel2.Controls.Add(cbCivil, 1, 6);
            tableLayoutPanel2.Location = new Point(6, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel2.Size = new Size(645, 357);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 0;
            label5.Text = "Nome";
            // 
            // txNome
            // 
            txNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txNome.Location = new Point(325, 3);
            txNome.Name = "txNome";
            txNome.Size = new Size(317, 33);
            txNome.TabIndex = 1;
            // 
            // txDataNascimento
            // 
            txDataNascimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txDataNascimento.Location = new Point(325, 54);
            txDataNascimento.Name = "txDataNascimento";
            txDataNascimento.Size = new Size(317, 33);
            txDataNascimento.TabIndex = 2;
            // 
            // txRG
            // 
            txRG.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txRG.Location = new Point(325, 105);
            txRG.Name = "txRG";
            txRG.Size = new Size(317, 33);
            txRG.TabIndex = 3;
            // 
            // txCPF
            // 
            txCPF.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txCPF.Location = new Point(325, 156);
            txCPF.Name = "txCPF";
            txCPF.Size = new Size(317, 33);
            txCPF.TabIndex = 4;
            // 
            // txFiliacao
            // 
            txFiliacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txFiliacao.Location = new Point(325, 207);
            txFiliacao.Name = "txFiliacao";
            txFiliacao.Size = new Size(317, 33);
            txFiliacao.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 51);
            label6.Name = "label6";
            label6.Size = new Size(190, 25);
            label6.TabIndex = 6;
            label6.Text = "Data de Nascimento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 102);
            label7.Name = "label7";
            label7.Size = new Size(38, 25);
            label7.TabIndex = 7;
            label7.Text = "RG";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 153);
            label8.Name = "label8";
            label8.Size = new Size(46, 25);
            label8.TabIndex = 8;
            label8.Text = "CPF";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 204);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 9;
            label9.Text = "Filiação";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 255);
            label10.Name = "label10";
            label10.Size = new Size(133, 25);
            label10.TabIndex = 10;
            label10.Text = "Escolariedade";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 306);
            label11.Name = "label11";
            label11.Size = new Size(113, 25);
            label11.TabIndex = 11;
            label11.Text = "Estado Civil";
            // 
            // cbEscola
            // 
            cbEscola.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbEscola.FormattingEnabled = true;
            cbEscola.Items.AddRange(new object[] { "teste" });
            cbEscola.Location = new Point(325, 258);
            cbEscola.Name = "cbEscola";
            cbEscola.Size = new Size(317, 33);
            cbEscola.TabIndex = 12;
            // 
            // cbCivil
            // 
            cbCivil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbCivil.FormattingEnabled = true;
            cbCivil.Location = new Point(325, 309);
            cbCivil.Name = "cbCivil";
            cbCivil.Size = new Size(317, 33);
            cbCivil.TabIndex = 13;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tableLayoutPanel3);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(657, 363);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Endereço";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(listFuncionarioPermission);
            tabPage3.Controls.Add(panel4);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(listAllPermission);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(657, 363);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Permissões";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Cursor = Cursors.No;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(253, 254);
            button4.Name = "button4";
            button4.Size = new Size(75, 28);
            button4.TabIndex = 6;
            button4.Text = "Remover";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(253, 194);
            button3.Name = "button3";
            button3.Size = new Size(75, 28);
            button3.TabIndex = 5;
            button3.Text = "Adicionar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(362, 156);
            label14.Name = "label14";
            label14.Size = new Size(266, 25);
            label14.TabIndex = 4;
            label14.Text = "Permissões para este usuario";
            // 
            // listFuncionarioPermission
            // 
            listFuncionarioPermission.FormattingEnabled = true;
            listFuncionarioPermission.ItemHeight = 15;
            listFuncionarioPermission.Location = new Point(362, 194);
            listFuncionarioPermission.Name = "listFuncionarioPermission";
            listFuncionarioPermission.Size = new Size(266, 154);
            listFuncionarioPermission.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(ggg);
            panel4.Controls.Add(label13);
            panel4.Location = new Point(253, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(389, 122);
            panel4.TabIndex = 2;
            // 
            // ggg
            // 
            ggg.Location = new Point(12, 34);
            ggg.Multiline = true;
            ggg.Name = "ggg";
            ggg.Size = new Size(363, 73);
            ggg.TabIndex = 1;
            ggg.Text = "asasddasd\r\nasdasdas\r\ndasfgewfsd\r\nsdfsdfsd\r\nsdfsdf";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(12, 10);
            label13.Name = "label13";
            label13.Size = new Size(286, 21);
            label13.TabIndex = 0;
            label13.Text = "Descrição da Permissão Selecionada";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(20, 18);
            label12.Name = "label12";
            label12.Size = new Size(189, 25);
            label12.TabIndex = 1;
            label12.Text = "Todas as permissões";
            // 
            // listAllPermission
            // 
            listAllPermission.FormattingEnabled = true;
            listAllPermission.ItemHeight = 15;
            listAllPermission.Location = new Point(13, 74);
            listAllPermission.Name = "listAllPermission";
            listAllPermission.Size = new Size(196, 274);
            listAllPermission.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DeepSkyBlue;
            panel3.Controls.Add(btRemoverFuncionario);
            panel3.Controls.Add(btNovoFuncionario);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(671, 58);
            panel3.TabIndex = 0;
            // 
            // btRemoverFuncionario
            // 
            btRemoverFuncionario.BackColor = Color.BlueViolet;
            btRemoverFuncionario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRemoverFuncionario.ForeColor = SystemColors.ControlLightLight;
            btRemoverFuncionario.Location = new Point(479, 7);
            btRemoverFuncionario.Name = "btRemoverFuncionario";
            btRemoverFuncionario.Size = new Size(189, 44);
            btRemoverFuncionario.TabIndex = 1;
            btRemoverFuncionario.Text = "Remover Funcionario";
            btRemoverFuncionario.UseVisualStyleBackColor = false;
            btRemoverFuncionario.Click += btRemoverFuncionario_Click;
            // 
            // btNovoFuncionario
            // 
            btNovoFuncionario.BackColor = Color.Violet;
            btNovoFuncionario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNovoFuncionario.ForeColor = SystemColors.ButtonHighlight;
            btNovoFuncionario.Location = new Point(3, 3);
            btNovoFuncionario.Name = "btNovoFuncionario";
            btNovoFuncionario.Size = new Size(257, 48);
            btNovoFuncionario.TabIndex = 0;
            btNovoFuncionario.Text = "Novo Funcionario";
            btNovoFuncionario.UseVisualStyleBackColor = false;
            btNovoFuncionario.Click += btNovoFuncionario_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label15, 0, 0);
            tableLayoutPanel3.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel3.Controls.Add(label16, 0, 1);
            tableLayoutPanel3.Controls.Add(label17, 0, 2);
            tableLayoutPanel3.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel3.Controls.Add(textBox3, 1, 1);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(658, 357);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(120, 25);
            label15.TabIndex = 0;
            label15.Text = "Logradouro";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(332, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 33);
            textBox1.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(3, 119);
            label16.Name = "label16";
            label16.Size = new Size(86, 25);
            label16.TabIndex = 2;
            label16.Text = "Número";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(3, 238);
            label17.Name = "label17";
            label17.Size = new Size(46, 25);
            label17.TabIndex = 3;
            label17.Text = "CEP";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(332, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 33);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(332, 122);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(319, 33);
            textBox3.TabIndex = 5;
            // 
            // FormGerenciarFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 575);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(listFuncionario);
            Name = "FormGerenciarFuncionarios";
            Text = "FormGerenciarFuncionarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabFuncionario.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listFuncionario;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Button btRemoverFuncionario;
        private Button btNovoFuncionario;
        private TabControl tabFuncionario;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txUsuario;
        private Label label3;
        private Label label4;
        private Label email;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox txEmail;
        private TextBox txSenha;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private TextBox txNome;
        private TextBox txDataNascimento;
        private TextBox txRG;
        private TextBox txCPF;
        private TextBox txFiliacao;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox cbEscola;
        private ComboBox cbCivil;
        private Panel panel4;
        private TextBox ggg;
        private Label label13;
        private Label label12;
        private ListBox listAllPermission;
        private Button button4;
        private Button button3;
        private Label label14;
        private ListBox listFuncionarioPermission;
        private Button btConfirma;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label15;
        private TextBox textBox1;
        private Label label16;
        private Label label17;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}