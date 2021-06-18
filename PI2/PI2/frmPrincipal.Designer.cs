
namespace PI2
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.barraMenu = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faculdadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDescricaoDisciplina = new System.Windows.Forms.TextBox();
            this.txtIDDisciplina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCodCadFaculdade = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.barraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barraMenu
            // 
            this.barraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.barraMenu.Location = new System.Drawing.Point(0, 0);
            this.barraMenu.Name = "barraMenu";
            this.barraMenu.Size = new System.Drawing.Size(1188, 24);
            this.barraMenu.TabIndex = 0;
            this.barraMenu.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.disciplinaToolStripMenuItem,
            this.faculdadeToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.cursoToolStripMenuItem.Text = "Curso";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // disciplinaToolStripMenuItem
            // 
            this.disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            this.disciplinaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.disciplinaToolStripMenuItem.Text = "Disciplina";
            this.disciplinaToolStripMenuItem.Click += new System.EventHandler(this.disciplinaToolStripMenuItem_Click);
            // 
            // faculdadeToolStripMenuItem
            // 
            this.faculdadeToolStripMenuItem.Name = "faculdadeToolStripMenuItem";
            this.faculdadeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.faculdadeToolStripMenuItem.Text = "Faculdade";
            this.faculdadeToolStripMenuItem.Click += new System.EventHandler(this.faculdadeToolStripMenuItem_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.desenvolvedoresToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // desenvolvedoresToolStripMenuItem
            // 
            this.desenvolvedoresToolStripMenuItem.Name = "desenvolvedoresToolStripMenuItem";
            this.desenvolvedoresToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.desenvolvedoresToolStripMenuItem.Text = "Desenvolvedores";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 435);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(631, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 92);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(257, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(894, 325);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txtDescricaoDisciplina
            // 
            this.txtDescricaoDisciplina.Enabled = false;
            this.txtDescricaoDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoDisciplina.Location = new System.Drawing.Point(398, 58);
            this.txtDescricaoDisciplina.Name = "txtDescricaoDisciplina";
            this.txtDescricaoDisciplina.Size = new System.Drawing.Size(233, 23);
            this.txtDescricaoDisciplina.TabIndex = 2;
            this.txtDescricaoDisciplina.TabStop = false;
            // 
            // txtIDDisciplina
            // 
            this.txtIDDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDisciplina.Location = new System.Drawing.Point(338, 58);
            this.txtIDDisciplina.Name = "txtIDDisciplina";
            this.txtIDDisciplina.Size = new System.Drawing.Size(54, 23);
            this.txtIDDisciplina.TabIndex = 1;
            this.txtIDDisciplina.TextChanged += new System.EventHandler(this.txtIDDisciplina_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Disciplina";
            // 
            // txtTarefa
            // 
            this.txtTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarefa.Location = new System.Drawing.Point(637, 58);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(233, 23);
            this.txtTarefa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(634, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tarefa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(873, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Data Entrega";
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEntrega.Location = new System.Drawing.Point(876, 58);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(112, 23);
            this.txtDataEntrega.TabIndex = 4;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(257, 58);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(75, 23);
            this.txtCod.TabIndex = 0;
            this.txtCod.TabStop = false;
            // 
            // lblCodCadFaculdade
            // 
            this.lblCodCadFaculdade.AutoSize = true;
            this.lblCodCadFaculdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCadFaculdade.Location = new System.Drawing.Point(254, 39);
            this.lblCodCadFaculdade.Name = "lblCodCadFaculdade";
            this.lblCodCadFaculdade.Size = new System.Drawing.Size(58, 17);
            this.lblCodCadFaculdade.TabIndex = 30;
            this.lblCodCadFaculdade.Text = "Código";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(1076, 58);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(176, 324);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(176, 295);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(176, 266);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(176, 394);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Enabled = false;
            this.btnConcluir.Location = new System.Drawing.Point(176, 365);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(75, 23);
            this.btnConcluir.TabIndex = 10;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1188, 568);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCodCadFaculdade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDataEntrega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.txtDescricaoDisciplina);
            this.Controls.Add(this.txtIDDisciplina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barraMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.barraMenu;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                       ";
            this.barraMenu.ResumeLayout(false);
            this.barraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip barraMenu;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem faculdadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDescricaoDisciplina;
        private System.Windows.Forms.TextBox txtIDDisciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtDataEntrega;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCodCadFaculdade;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConcluir;
    }
}