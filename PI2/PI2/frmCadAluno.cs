using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI2
{
    public partial class frmCadAluno : Form
    {

        #region CONSTRUTOR
        public frmCadAluno()
        {
            InitializeComponent();
            AtualizarGrid();
        }
        #endregion

        #region MÉTODOS

        private void LimparDados()
        {
            txtCodAluno.Text = "";
            txtIDFaculdade.Text = "";
            txtIDCurso.Text = "";
            txtNome.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtDataNascimento.Value = DateTime.Now.Date;
            cboTipo.SelectedItem = "Aluno";
            txtUsuario.Text = "";
            txtSenha.Text = "";
                                 
            txtBuscaId.Text = "";
            txtBuscaNome.Text = "";

            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }
        
        private bool ValidarDados()
        {
            if (String.IsNullOrEmpty(txtDescricaoFaculdade.Text))
            {
                MessageBox.Show("Faculdade inválida!", "SISTEMA PI - CAMPOS OBRIGATÓRIOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtIDFaculdade.Focus();
                txtIDFaculdade.SelectAll();
                return false;
            }

            if (String.IsNullOrEmpty(txtDescricaoCurso.Text))
            {
                MessageBox.Show("Curso inválido!", "SISTEMA PI - CAMPOS OBRIGATÓRIOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtIDCurso.Focus();
                txtIDCurso.SelectAll();
                return false;
            }

            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Informar campos obrigatórios!", "SISTEMA PI - CAMPOS OBRIGATÓRIOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtNome.Focus();
                txtNome.SelectAll();
                return false;
            }
            
            return true;
        }

        private void AtualizarGrid()
        {
            //VERIFICA SE EXISTE ALGUM FILTRO PREENCHIDO
            string where = "";
            if (!String.IsNullOrEmpty(txtBuscaId.Text))            
                where += "cod_aluno = " + txtBuscaId.Text + " AND ";
            if (!String.IsNullOrEmpty(txtBuscaNome.Text))
                where += "nome_alun LIKE '%" + txtBuscaNome.Text + "%' AND ";
            where += "1=1";

            //CONSULTA PARA BUSCAR ASS FACULDADES
            string sql = @"SELECT a.cod_aluno ID, 
                                  a.nome_alun Aluno,
                                  f.nome_faculdade Faculdade,
                                  c.nome_curso Curso,
                                  a.usuario Usuario
                           FROM tb_aluno a
                           INNER JOIN tb_faculdade f ON f.cod_faculdade = a.cod_faculdade
                           INNER JOIN tb_curso c ON c.cod_curso = a.cod_curso
                           WHERE " + where;
            DataSet ds = BancoDeDados.ConsultaSQL(sql);
            if(ds == null)
            {
                dataGridView1.DataSource = null;
                return;
            }
                        
            //PREENCHE AS FACULDADES NA GRID
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private ArrayList GetInfoAluno()
        {
            ArrayList info = new ArrayList();
            info.Add(txtIDFaculdade.Text);
            info.Add(txtIDCurso.Text);
            info.Add(txtNome.Text);
            info.Add(txtCPF.Text);
            info.Add(txtEmail.Text);
            info.Add(txtTelefone.Text);
            info.Add(txtDataNascimento.Value);
            info.Add(cboTipo.SelectedItem.ToString());
            info.Add(txtUsuario.Text);
            info.Add(txtSenha.Text);

            return info;
        }

        private DataRow GetDataRowAluno(string cod_aluno)
        {
            if (cod_aluno == "")
                return null;

            DataSet ds = BancoDeDados.ConsultaSQL("SELECT * FROM tb_aluno WHERE cod_aluno = " + cod_aluno);

            if (ds.Tables[0].Rows.Count == 0)
                return null;

            return ds.Tables[0].Rows[0];
        }

        #endregion

        #region EVENTOS
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidarDados())
                return;

            ArrayList infoAluno = GetInfoAluno();
            
            if (BancoDeDados.InserirAluno(infoAluno))
            {
                MessageBox.Show("Cadastro Efetuado com Sucesso!", "SISTEMA PI - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDados();
                AtualizarGrid();
            }
        }
                
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!ValidarDados())
                return;

            ArrayList infoAluno = GetInfoAluno();

            if (BancoDeDados.AlterarAluno(infoAluno, txtCodAluno.Text))
            {
                MessageBox.Show("Cadastro Alterado com Sucesso!", "SISTEMA PI - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDados();
                AtualizarGrid();
                btnAdicionar.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir o cadastro selecionado?", "SISTEMA PI - CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
                return;

            if (BancoDeDados.ExcluirAluno(txtCodAluno.Text))
            {
                MessageBox.Show("Cadastro Excluido com Sucesso!", "SISTEMA PI - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDados();
                AtualizarGrid();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
                
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            if (drv == null)
                return;

            string cod_aluno = drv.Row["ID"].ToString();

            DataRow dr = GetDataRowAluno(cod_aluno);
            txtCodAluno.Text = dr["cod_aluno"].ToString();
            txtIDFaculdade.Text = dr["cod_faculdade"].ToString();
            txtIDCurso.Text = dr["cod_curso"].ToString();            
            txtNome.Text = dr["nome_alun"].ToString();
            txtCPF.Text = dr["cpf_alun"].ToString();
            txtEmail.Text = dr["email_alun"].ToString();
            txtTelefone.Text = dr["fone_alun"].ToString();
            txtDataNascimento.Text = dr["nascimento_alun"].ToString();
            cboTipo.SelectedItem = dr["perfil_alun"].ToString();
            txtUsuario.Text = dr["usuario"].ToString();
            txtSenha.Text = dr["senha"].ToString();

            btnAdicionar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        #endregion

        private void txtIDCurso_TextChanged(object sender, EventArgs e)
        {
            txtDescricaoCurso.Text = BancoDeDados.BuscarCurso(txtIDCurso.Text);
        }

        private void txtIDFaculdade_TextChanged(object sender, EventArgs e)
        {
            txtDescricaoFaculdade.Text = BancoDeDados.BuscarFaculdade(txtIDFaculdade.Text);
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
