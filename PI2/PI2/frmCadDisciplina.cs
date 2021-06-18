using System;
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
    public partial class frmCadDisciplina : Form
    {

        #region CONSTRUTOR
        public frmCadDisciplina()
        {
            InitializeComponent();
            AtualizarGrid();
        }
        #endregion

        #region MÉTODOS

        private void LimparDados()
        {
            txtDisciplina.Text = "";
            txtCodDisciplina.Text = "";
            txtIDCurso.Text = "";

            txtBuscaIdDisciplina.Text = "";
            txtBuscaNomeDisciplina.Text = "";

            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }
        
        private bool ValidarDados()
        {
            if (String.IsNullOrEmpty(txtDescricaoCurso.Text))
            {
                MessageBox.Show("Curso inválido!", "SISTEMA PI - CAMPOS OBRIGATÓRIOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtIDCurso.Focus();
                txtIDCurso.SelectAll();
                return false;
            }

            if (txtDisciplina.Text == "")
            {
                MessageBox.Show("Informar campos obrigatórios!", "SISTEMA PI - CAMPOS OBRIGATÓRIOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtDisciplina.Focus();
                txtDisciplina.SelectAll();
                return false;
            }
            
            return true;
        }

        private void AtualizarGrid()
        {
            //VERIFICA SE EXISTE ALGUM FILTRO PREENCHIDO
            string where = "";
            if (!String.IsNullOrEmpty(txtBuscaIdDisciplina.Text))            
                where += "cod_disciplina = " + txtBuscaIdDisciplina.Text + " AND ";
            if (!String.IsNullOrEmpty(txtBuscaNomeDisciplina.Text))
                where += "nome_disciplina LIKE '%" + txtBuscaNomeDisciplina.Text + "%' AND ";
            where += "1=1";

            //CONSULTA PARA BUSCAR ASS FACULDADES
            string sql = @"SELECT d.cod_disciplina ID, 
                                  d.nome_disciplina Disciplina,
                                  d.cod_curso idCurso,
                                  c.nome_curso Curso 
                           FROM tb_disciplina d
                           INNER JOIN tb_curso c ON c.cod_curso = d.cod_curso
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

        #endregion

        #region EVENTOS
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidarDados())
                return;

            if (BancoDeDados.InserirDisciplina(txtDisciplina.Text, txtIDCurso.Text))
            {
                MessageBox.Show("Cadastro Efetuado com Sucesso!", "SISTEMA PI - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDisciplina.Text = "";
                AtualizarGrid();
            }
        }
                
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!ValidarDados())
                return;

            if (BancoDeDados.AlterarDisciplina(txtDisciplina.Text, txtIDCurso.Text, txtCodDisciplina.Text))
            {
                MessageBox.Show("Cadastro Alterado com Sucesso!", "SISTEMA PI - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodDisciplina.Text = "";
                txtDisciplina.Text = "";
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

            if (BancoDeDados.ExcluirDisciplina(txtCodDisciplina.Text))
            {
                MessageBox.Show("Cadastro Excluido com Sucesso!", "SISTEMA PI - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodDisciplina.Text = "";
                txtDisciplina.Text = "";
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

            DataRow dr = drv.Row;
            txtCodDisciplina.Text = dr["ID"].ToString();
            txtIDCurso.Text = dr["idCurso"].ToString();
            txtDisciplina.Text = dr["Disciplina"].ToString();

            btnAdicionar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        #endregion

        private void txtIDCurso_TextChanged(object sender, EventArgs e)
        {
            txtDescricaoCurso.Text = BancoDeDados.BuscarCurso(txtIDCurso.Text);
        }
    }
}
