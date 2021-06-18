
namespace PI2
{
    partial class frmCadFaculdade
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
            this.txtCodFaculdade = new System.Windows.Forms.TextBox();
            this.txtFaculdade = new System.Windows.Forms.TextBox();
            this.btnAdicionarFaculdade = new System.Windows.Forms.Button();
            this.btnAlterarFaculdade = new System.Windows.Forms.Button();
            this.btnExcluirFaculdade = new System.Windows.Forms.Button();
            this.btnLimparFaculdade = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbFaculdadeConsuta = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBuscaNomeFaculdade = new System.Windows.Forms.TextBox();
            this.txtBuscaIdFaculdade = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblCadFaculdade.Location = new System.Drawing.Point(33, 99);
            this.lblCadFaculdade.Name = "lblCadFaculdade";
            this.lblCadFaculdade.Size = new System.Drawing.Size(83, 17);
            this.lblCadFaculdade.TabIndex = 1;
            this.lblCadFaculdade.Text = "Faculdade";
            // 
            // txtCodFaculdade
            // 
            this.txtCodFaculdade.Enabled = false;
            this.txtCodFaculdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFaculdade.Location = new System.Drawing.Point(145, 67);
            this.txtCodFaculdade.Name = "txtCodFaculdade";
            this.txtCodFaculdade.Size = new System.Drawing.Size(54, 23);
            this.txtCodFaculdade.TabIndex = 2;
            // 
            // txtFaculdade
            // 
            this.txtFaculdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaculdade.Location = new System.Drawing.Point(145, 96);
            this.txtFaculdade.Name = "txtFaculdade";
            this.txtFaculdade.Size = new System.Drawing.Size(384, 23);
            this.txtFaculdade.TabIndex = 3;
            // 
            // btnAdicionarFaculdade
            // 
            this.btnAdicionarFaculdade.Location = new System.Drawing.Point(36, 21);
            this.btnAdicionarFaculdade.Name = "btnAdicionarFaculdade";
            this.btnAdicionarFaculdade.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarFaculdade.TabIndex = 4;
            this.btnAdicionarFaculdade.Text = "Adicionar";
            this.btnAdicionarFaculdade.UseVisualStyleBackColor = true;
            this.btnAdicionarFaculdade.Click += new System.EventHandler(this.btnAdicionarFaculdade_Click);
            // 
            // btnAlterarFaculdade
            // 
            this.btnAlterarFaculdade.Enabled = false;
            this.btnAlterarFaculdade.Location = new System.Drawing.Point(117, 21);
            this.btnAlterarFaculdade.Name = "btnAlterarFaculdade";
            this.btnAlterarFaculdade.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarFaculdade.TabIndex = 6;
            this.btnAlterarFaculdade.Text = "Alterar";
            this.btnAlterarFaculdade.UseVisualStyleBackColor = true;
            this.btnAlterarFaculdade.Click += new System.EventHandler(this.btnAlterarFaculdade_Click);
            // 
            // btnExcluirFaculdade
            // 
            this.btnExcluirFaculdade.Enabled = false;
            this.btnExcluirFaculdade.Location = new System.Drawing.Point(198, 21);
            this.btnExcluirFaculdade.Name = "btnExcluirFaculdade";
            this.btnExcluirFaculdade.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirFaculdade.TabIndex = 7;
            this.btnExcluirFaculdade.Text = "Excluir";
            this.btnExcluirFaculdade.UseVisualStyleBackColor = true;
            this.btnExcluirFaculdade.Click += new System.EventHandler(this.btnExcluirFaculdade_Click);
            // 
            // btnLimparFaculdade
            // 
            this.btnLimparFaculdade.Location = new System.Drawing.Point(279, 21);
            this.btnLimparFaculdade.Name = "btnLimparFaculdade";
            this.btnLimparFaculdade.Size = new System.Drawing.Size(75, 23);
            this.btnLimparFaculdade.TabIndex = 8;
            this.btnLimparFaculdade.Text = "Limpar";
            this.btnLimparFaculdade.UseVisualStyleBackColor = true;
            this.btnLimparFaculdade.Click += new System.EventHandler(this.btnLimparFaculdade_Click);
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
            this.gbFaculdadeConsuta.Controls.Add(this.txtBuscaNomeFaculdade);
            this.gbFaculdadeConsuta.Controls.Add(this.txtBuscaIdFaculdade);
            this.gbFaculdadeConsuta.Controls.Add(this.btnBuscar);
            this.gbFaculdadeConsuta.Controls.Add(this.label2);
            this.gbFaculdadeConsuta.Controls.Add(this.label1);
            this.gbFaculdadeConsuta.Location = new System.Drawing.Point(36, 137);
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
            this.Faculdade});
            this.dataGridView1.Location = new System.Drawing.Point(21, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txtBuscaNomeFaculdade
            // 
            this.txtBuscaNomeFaculdade.Location = new System.Drawing.Point(139, 22);
            this.txtBuscaNomeFaculdade.Name = "txtBuscaNomeFaculdade";
            this.txtBuscaNomeFaculdade.Size = new System.Drawing.Size(260, 20);
            this.txtBuscaNomeFaculdade.TabIndex = 4;
            // 
            // txtBuscaIdFaculdade
            // 
            this.txtBuscaIdFaculdade.Location = new System.Drawing.Point(38, 22);
            this.txtBuscaIdFaculdade.Name = "txtBuscaIdFaculdade";
            this.txtBuscaIdFaculdade.Size = new System.Drawing.Size(54, 20);
            this.txtBuscaIdFaculdade.TabIndex = 3;
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
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Faculdade
            // 
            this.Faculdade.DataPropertyName = "Faculdade";
            this.Faculdade.HeaderText = "Faculdade";
            this.Faculdade.Name = "Faculdade";
            this.Faculdade.ReadOnly = true;
            this.Faculdade.Width = 300;
            // 
            // frmCadFaculdade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 360);
            this.Controls.Add(this.gbFaculdadeConsuta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimparFaculdade);
            this.Controls.Add(this.btnExcluirFaculdade);
            this.Controls.Add(this.btnAlterarFaculdade);
            this.Controls.Add(this.btnAdicionarFaculdade);
            this.Controls.Add(this.txtFaculdade);
            this.Controls.Add(this.txtCodFaculdade);
            this.Controls.Add(this.lblCadFaculdade);
            this.Controls.Add(this.lblCodCadFaculdade);
            this.Name = "frmCadFaculdade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA PI - Cadastro Faculdade";
            this.gbFaculdadeConsuta.ResumeLayout(false);
            this.gbFaculdadeConsuta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodCadFaculdade;
        private System.Windows.Forms.Label lblCadFaculdade;
        private System.Windows.Forms.TextBox txtCodFaculdade;
        private System.Windows.Forms.TextBox txtFaculdade;
        private System.Windows.Forms.Button btnAdicionarFaculdade;
        private System.Windows.Forms.Button btnAlterarFaculdade;
        private System.Windows.Forms.Button btnExcluirFaculdade;
        private System.Windows.Forms.Button btnLimparFaculdade;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbFaculdadeConsuta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaNomeFaculdade;
        private System.Windows.Forms.TextBox txtBuscaIdFaculdade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculdade;
    }
}