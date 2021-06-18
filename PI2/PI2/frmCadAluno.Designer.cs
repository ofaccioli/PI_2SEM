
namespace PI2
{
    partial class frmCadAluno
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
            this.lblCodCadFaculdade = new System.Windows.Forms.Label();
            this.lblCadFaculdade = new System.Windows.Forms.Label();
            this.txtCodAluno = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbFaculdadeConsuta = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricaoCurso = new System.Windows.Forms.TextBox();
            this.txtDescricaoFaculdade = new System.Windows.Forms.TextBox();
            this.txtIDFaculdade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbFaculdadeConsuta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodCadFaculdade
            // 
            this.lblCodCadFaculdade.AutoSize = true;
            this.lblCodCadFaculdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCadFaculdade.Location = new System.Drawing.Point(33, 53);
            this.lblCodCadFaculdade.Name = "lblCodCadFaculdade";
            this.lblCodCadFaculdade.Size = new System.Drawing.Size(58, 17);
            this.lblCodCadFaculdade.TabIndex = 0;
            this.lblCodCadFaculdade.Text = "Código";
            // 
            // lblCadFaculdade
            // 
            this.lblCadFaculdade.AutoSize = true;
            this.lblCadFaculdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadFaculdade.Location = new System.Drawing.Point(33, 153);
            this.lblCadFaculdade.Name = "lblCadFaculdade";
            this.lblCadFaculdade.Size = new System.Drawing.Size(49, 17);
            this.lblCadFaculdade.TabIndex = 1;
            this.lblCadFaculdade.Text = "Nome";
            // 
            // txtCodAluno
            // 
            this.txtCodAluno.Enabled = false;
            this.txtCodAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAluno.Location = new System.Drawing.Point(36, 72);
            this.txtCodAluno.Name = "txtCodAluno";
            this.txtCodAluno.Size = new System.Drawing.Size(75, 23);
            this.txtCodAluno.TabIndex = 0;
            this.txtCodAluno.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(36, 172);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(457, 23);
            this.txtNome.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(36, 21);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(117, 21);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(198, 21);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(279, 21);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(360, 21);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbFaculdadeConsuta
            // 
            this.gbFaculdadeConsuta.Controls.Add(this.dataGridView1);
            this.gbFaculdadeConsuta.Controls.Add(this.txtBuscaNome);
            this.gbFaculdadeConsuta.Controls.Add(this.txtBuscaId);
            this.gbFaculdadeConsuta.Controls.Add(this.btnBuscar);
            this.gbFaculdadeConsuta.Controls.Add(this.label2);
            this.gbFaculdadeConsuta.Controls.Add(this.label1);
            this.gbFaculdadeConsuta.Location = new System.Drawing.Point(36, 297);
            this.gbFaculdadeConsuta.Name = "gbFaculdadeConsuta";
            this.gbFaculdadeConsuta.Size = new System.Drawing.Size(689, 186);
            this.gbFaculdadeConsuta.TabIndex = 10;
            this.gbFaculdadeConsuta.TabStop = false;
            this.gbFaculdadeConsuta.Text = "Consulta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Aluno,
            this.Faculdade,
            this.Curso,
            this.Usuario});
            this.dataGridView1.Location = new System.Drawing.Point(21, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(655, 130);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // Aluno
            // 
            this.Aluno.DataPropertyName = "Aluno";
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.ReadOnly = true;
            this.Aluno.Width = 200;
            // 
            // Faculdade
            // 
            this.Faculdade.DataPropertyName = "Faculdade";
            this.Faculdade.HeaderText = "Faculdade";
            this.Faculdade.Name = "Faculdade";
            this.Faculdade.ReadOnly = true;
            this.Faculdade.Width = 150;
            // 
            // Curso
            // 
            this.Curso.DataPropertyName = "Curso";
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.Visible = false;
            this.Curso.Width = 150;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 150;
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaNome.Location = new System.Drawing.Point(139, 22);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(456, 20);
            this.txtBuscaNome.TabIndex = 1;
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.Location = new System.Drawing.Point(38, 22);
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.Size = new System.Drawing.Size(54, 20);
            this.txtBuscaId.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(601, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtIDCurso
            // 
            this.txtIDCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCurso.Location = new System.Drawing.Point(36, 122);
            this.txtIDCurso.Name = "txtIDCurso";
            this.txtIDCurso.Size = new System.Drawing.Size(54, 23);
            this.txtIDCurso.TabIndex = 4;
            this.txtIDCurso.TextChanged += new System.EventHandler(this.txtIDCurso_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Curso";
            // 
            // txtDescricaoCurso
            // 
            this.txtDescricaoCurso.Enabled = false;
            this.txtDescricaoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoCurso.Location = new System.Drawing.Point(96, 122);
            this.txtDescricaoCurso.Name = "txtDescricaoCurso";
            this.txtDescricaoCurso.Size = new System.Drawing.Size(629, 23);
            this.txtDescricaoCurso.TabIndex = 6;
            this.txtDescricaoCurso.TabStop = false;
            // 
            // txtDescricaoFaculdade
            // 
            this.txtDescricaoFaculdade.Enabled = false;
            this.txtDescricaoFaculdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoFaculdade.Location = new System.Drawing.Point(177, 72);
            this.txtDescricaoFaculdade.Name = "txtDescricaoFaculdade";
            this.txtDescricaoFaculdade.Size = new System.Drawing.Size(548, 23);
            this.txtDescricaoFaculdade.TabIndex = 3;
            this.txtDescricaoFaculdade.TabStop = false;
            // 
            // txtIDFaculdade
            // 
            this.txtIDFaculdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDFaculdade.Location = new System.Drawing.Point(117, 72);
            this.txtIDFaculdade.Name = "txtIDFaculdade";
            this.txtIDFaculdade.Size = new System.Drawing.Size(54, 23);
            this.txtIDFaculdade.TabIndex = 1;
            this.txtIDFaculdade.TextChanged += new System.EventHandler(this.txtIDFaculdade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Faculdade";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(499, 172);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(108, 23);
            this.txtCPF.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "CPF";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(441, 222);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(166, 23);
            this.txtTelefone.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(438, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(36, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(399, 23);
            this.txtEmail.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "E-mail";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataNascimento.Location = new System.Drawing.Point(613, 172);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(112, 23);
            this.txtDataNascimento.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(610, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Data Nasc.";
            // 
            // cboTipo
            // 
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Administrador",
            "Aluno"});
            this.cboTipo.Location = new System.Drawing.Point(613, 221);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(112, 24);
            this.cboTipo.TabIndex = 12;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(610, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tipo";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(441, 270);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(166, 23);
            this.txtSenha.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(438, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(36, 270);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(399, 23);
            this.txtUsuario.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Usuário";
            // 
            // frmCadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 495);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescricaoFaculdade);
            this.Controls.Add(this.txtIDFaculdade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricaoCurso);
            this.Controls.Add(this.txtIDCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbFaculdadeConsuta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodAluno);
            this.Controls.Add(this.lblCadFaculdade);
            this.Controls.Add(this.lblCodCadFaculdade);
            this.Name = "frmCadAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA PI - Cadastro Aluno";
            this.gbFaculdadeConsuta.ResumeLayout(false);
            this.gbFaculdadeConsuta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodCadFaculdade;
        private System.Windows.Forms.Label lblCadFaculdade;
        private System.Windows.Forms.TextBox txtCodAluno;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbFaculdadeConsuta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricaoCurso;
        private System.Windows.Forms.TextBox txtDescricaoFaculdade;
        private System.Windows.Forms.TextBox txtIDFaculdade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtDataNascimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    }
}