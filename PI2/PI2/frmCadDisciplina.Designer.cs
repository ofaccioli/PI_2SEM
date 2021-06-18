
namespace PI2
{
    partial class frmCadDisciplina
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
            this.txtCodDisciplina = new System.Windows.Forms.TextBox();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbFaculdadeConsuta = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBuscaNomeDisciplina = new System.Windows.Forms.TextBox();
            this.txtBuscaIdDisciplina = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricaoCurso = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFaculdadeConsuta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodCadFaculdade
            // 
            this.lblCodCadFaculdade.AutoSize = true;
            this.lblCodCadFaculdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCadFaculdade.Location = new System.Drawing.Point(33, 70);
            this.lblCodCadFaculdade.Name = "lblCodCadFaculdade";
            this.lblCodCadFaculdade.Size = new System.Drawing.Size(58, 17);
            this.lblCodCadFaculdade.TabIndex = 0;
            this.lblCodCadFaculdade.Text = "Código";
            // 
            // lblCadFaculdade
            // 
            this.lblCadFaculdade.AutoSize = true;
            this.lblCadFaculdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadFaculdade.Location = new System.Drawing.Point(33, 131);
            this.lblCadFaculdade.Name = "lblCadFaculdade";
            this.lblCadFaculdade.Size = new System.Drawing.Size(78, 17);
            this.lblCadFaculdade.TabIndex = 1;
            this.lblCadFaculdade.Text = "Disciplina";
            // 
            // txtCodDisciplina
            // 
            this.txtCodDisciplina.Enabled = false;
            this.txtCodDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodDisciplina.Location = new System.Drawing.Point(145, 67);
            this.txtCodDisciplina.Name = "txtCodDisciplina";
            this.txtCodDisciplina.Size = new System.Drawing.Size(54, 23);
            this.txtCodDisciplina.TabIndex = 2;
            this.txtCodDisciplina.TabStop = false;
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisciplina.Location = new System.Drawing.Point(145, 128);
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(384, 23);
            this.txtDisciplina.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(36, 21);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 4;
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
            this.btnAlterar.TabIndex = 6;
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
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(279, 21);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(360, 21);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbFaculdadeConsuta
            // 
            this.gbFaculdadeConsuta.Controls.Add(this.dataGridView1);
            this.gbFaculdadeConsuta.Controls.Add(this.txtBuscaNomeDisciplina);
            this.gbFaculdadeConsuta.Controls.Add(this.txtBuscaIdDisciplina);
            this.gbFaculdadeConsuta.Controls.Add(this.btnBuscar);
            this.gbFaculdadeConsuta.Controls.Add(this.label2);
            this.gbFaculdadeConsuta.Controls.Add(this.label1);
            this.gbFaculdadeConsuta.Location = new System.Drawing.Point(36, 159);
            this.gbFaculdadeConsuta.Name = "gbFaculdadeConsuta";
            this.gbFaculdadeConsuta.Size = new System.Drawing.Size(493, 211);
            this.gbFaculdadeConsuta.TabIndex = 10;
            this.gbFaculdadeConsuta.TabStop = false;
            this.gbFaculdadeConsuta.Text = "Consulta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Disciplina,
            this.Curso,
            this.idCurso});
            this.dataGridView1.Location = new System.Drawing.Point(21, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txtBuscaNomeDisciplina
            // 
            this.txtBuscaNomeDisciplina.Location = new System.Drawing.Point(139, 22);
            this.txtBuscaNomeDisciplina.Name = "txtBuscaNomeDisciplina";
            this.txtBuscaNomeDisciplina.Size = new System.Drawing.Size(260, 20);
            this.txtBuscaNomeDisciplina.TabIndex = 4;
            // 
            // txtBuscaIdDisciplina
            // 
            this.txtBuscaIdDisciplina.Location = new System.Drawing.Point(38, 22);
            this.txtBuscaIdDisciplina.Name = "txtBuscaIdDisciplina";
            this.txtBuscaIdDisciplina.Size = new System.Drawing.Size(54, 20);
            this.txtBuscaIdDisciplina.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(405, 21);
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
            this.txtIDCurso.Location = new System.Drawing.Point(145, 97);
            this.txtIDCurso.Name = "txtIDCurso";
            this.txtIDCurso.Size = new System.Drawing.Size(54, 23);
            this.txtIDCurso.TabIndex = 12;
            this.txtIDCurso.TextChanged += new System.EventHandler(this.txtIDCurso_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Curso";
            // 
            // txtDescricaoCurso
            // 
            this.txtDescricaoCurso.Enabled = false;
            this.txtDescricaoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoCurso.Location = new System.Drawing.Point(205, 97);
            this.txtDescricaoCurso.Name = "txtDescricaoCurso";
            this.txtDescricaoCurso.Size = new System.Drawing.Size(324, 23);
            this.txtDescricaoCurso.TabIndex = 13;
            this.txtDescricaoCurso.TabStop = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Disciplina
            // 
            this.Disciplina.DataPropertyName = "Disciplina";
            this.Disciplina.HeaderText = "Disciplina";
            this.Disciplina.Name = "Disciplina";
            this.Disciplina.ReadOnly = true;
            this.Disciplina.Width = 200;
            // 
            // Curso
            // 
            this.Curso.DataPropertyName = "Curso";
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            this.Curso.Width = 150;
            // 
            // idCurso
            // 
            this.idCurso.DataPropertyName = "idCurso";
            this.idCurso.HeaderText = "idCurso";
            this.idCurso.Name = "idCurso";
            this.idCurso.ReadOnly = true;
            this.idCurso.Visible = false;
            // 
            // frmCadDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 393);
            this.Controls.Add(this.txtDescricaoCurso);
            this.Controls.Add(this.txtIDCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbFaculdadeConsuta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.txtCodDisciplina);
            this.Controls.Add(this.lblCadFaculdade);
            this.Controls.Add(this.lblCodCadFaculdade);
            this.Name = "frmCadDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA PI - Cadastro Disciplina";
            this.gbFaculdadeConsuta.ResumeLayout(false);
            this.gbFaculdadeConsuta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodCadFaculdade;
        private System.Windows.Forms.Label lblCadFaculdade;
        private System.Windows.Forms.TextBox txtCodDisciplina;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbFaculdadeConsuta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaNomeDisciplina;
        private System.Windows.Forms.TextBox txtBuscaIdDisciplina;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricaoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurso;
    }
}