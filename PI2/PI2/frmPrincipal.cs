using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI2
{
    public partial class frmPrincipal : Form
    {
        string cod_aluno, tipo;
        #region CONSTRUTOR

        public frmPrincipal(string cod_aluno, string tipo)
        {
            InitializeComponent();
            this.cod_aluno = cod_aluno;
            this.tipo = tipo;

            LoadDados();
        }
        #endregion

        #region MÉTODOS
        private void LoadDados()
        {
            //DESABILITA FUNÇÕES EXCLUSIVAS DO USUÁRIO TIPO ADMINISTRADOR
            if(tipo == "Aluno")
            {                
                cursoToolStripMenuItem.Visible = false;
                faculdadeToolStripMenuItem.Visible = false;
                disciplinaToolStripMenuItem.Visible = false;
            }

            AtualizaGridTarefas();
        }

        private void LimparDados()
        {
            txtCod.Text = "";
            txtTarefa.Text = "";
            txtDataEntrega.Value = DateTime.Now.Date;
            txtIDDisciplina.Text = "";
        }

        private void AtualizaGridTarefas()
        {
            //VERIFICA SE EXISTE ALGUM FILTRO PREENCHIDO
            string where = "";

            if (monthCalendar1.SelectionStart != null)
                where += "t.data_entrega_tarefa >= '" + monthCalendar1.SelectionStart.ToString("d") + "' AND ";
            if (monthCalendar1.SelectionEnd != null)
                where += "t.data_entrega_tarefa <= '" + monthCalendar1.SelectionEnd.ToString("d") + " 23:59:59' AND ";
                                    
            where += "1=1";

            //CONSULTA PARA BUSCAR AS TAREFAS
            string sql = @"SELECT t.cod_tarefa ID, 
                                  t.descricao_tarefa Tarefa,
                                  d.nome_disciplina Disciplina,
                                  t.data_entrega_tarefa 'Data Entrega',
                                  t.andamento_tarefa Status
                           FROM tb_tarefas t
                           INNER JOIN tb_disciplina d ON d.cod_disciplina = t.cod_disciplina
                           INNER JOIN tb_participantes p ON t.cod_tarefa = p.cod_tarefa AND p.cod_aluno = @codAluno
                           WHERE " + where + " ORDER BY t.data_entrega_tarefa, d.nome_disciplina, t.descricao_tarefa";
            sql = sql.Replace("@codAluno", cod_aluno);
            DataSet ds = BancoDeDados.ConsultaSQL(sql);
            if (ds == null)
            {
                dataGridView1.DataSource = null;
                return;
            }

            //PREENCHE AS FACULDADES NA GRID
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private bool ValidarDados()
        {
            if (String.IsNullOrEmpty(txtDescricaoDisciplina.Text))
            {
                MessageBox.Show("Disciplina inválida!", "SISTEMA PI - CAMPOS OBRIGATÓRIOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtIDDisciplina.Focus();
                txtIDDisciplina.SelectAll();
                return false;
            }

            if (String.IsNullOrEmpty(txtTarefa.Text))
            {
                MessageBox.Show("Tarefa inválida!", "SISTEMA PI - CAMPOS OBRIGATÓRIOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtTarefa.Focus();
                txtTarefa.SelectAll();
                return false;
            }
            return true;
        }

        private ArrayList GetInfoTarefa()
        {
            ArrayList info = new ArrayList();
            info.Add(txtIDDisciplina.Text);            
            info.Add(txtTarefa.Text);
            info.Add(txtDataEntrega.Text);            

            return info;
        }

        private DataRow GetDataRowTarefa(string cod_tarefa)
        {
            if (cod_tarefa == "")
                return null;

            DataSet ds = BancoDeDados.ConsultaSQL("SELECT * FROM tb_tarefas WHERE cod_tarefa = " + cod_tarefa);

            if (ds.Tables[0].Rows.Count == 0)
                return null;

            return ds.Tables[0].Rows[0];
        }

        #endregion


        #region EVENTOS
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            AtualizaGridTarefas();
        }

        private void faculdadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFaculdade faculdade = new frmCadFaculdade();
            faculdade.Show();
        }
        
        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCurso curso = new frmCadCurso();
            curso.Show();
        }
        
        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadDisciplina disc = new frmCadDisciplina();
            disc.Show();
        }
        #endregion

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidarDados())
                return;

            ArrayList infoTarefa = GetInfoTarefa();

            if (BancoDeDados.InserirTarefa(infoTarefa, cod_aluno))
            {
                MessageBox.Show("Cadastro Efetuado com Sucesso!", "SISTEMA PI - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDados();
                AtualizaGridTarefas();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!ValidarDados())
                return;

            ArrayList infoTarefa = GetInfoTarefa();

            if (BancoDeDados.AlterarTarefa(infoTarefa, txtCod.Text))
            {
                MessageBox.Show("Cadastro Alterado com Sucesso!", "SISTEMA PI - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDados();
                AtualizaGridTarefas();
                btnAdicionar.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnConcluir.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir o cadastro selecionado?", "SISTEMA PI - CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
                return;

            if (BancoDeDados.ExcluirTarefa(txtCod.Text, cod_aluno))
            {
                MessageBox.Show("Cadastro Excluido com Sucesso!", "SISTEMA PI - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDados();
                AtualizaGridTarefas();
                btnAdicionar.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnConcluir.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnConcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            if (drv == null)
                return;

            string cod_tarefa = drv.Row["ID"].ToString();

            DataRow dr = GetDataRowTarefa(cod_tarefa);
            txtCod.Text = cod_tarefa;
            txtIDDisciplina.Text = dr["cod_disciplina"].ToString();
            txtTarefa.Text = dr["descricao_tarefa"].ToString();
            txtDataEntrega.Text = dr["data_entrega_tarefa"].ToString();
            
            btnAdicionar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnConcluir.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void txtIDDisciplina_TextChanged(object sender, EventArgs e)
        {
            txtDescricaoDisciplina.Text = BancoDeDados.BuscarDisciplina(txtIDDisciplina.Text, cod_aluno);
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente concluir a tarefa selecionada?", "SISTEMA PI - CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
                return;

            if (BancoDeDados.AlterarAndamentoTarefa(txtCod.Text, "Concluída"))
            {
                MessageBox.Show("Tarefa Concluida!", "SISTEMA PI - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDados();
                AtualizaGridTarefas();
                btnAdicionar.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnConcluir.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente cancelar a tarefa selecionada?", "SISTEMA PI - CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
                return;

            if (BancoDeDados.AlterarAndamentoTarefa(txtCod.Text, "Cancelada"))
            {
                MessageBox.Show("Tarefa Cancelada!", "SISTEMA PI - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDados();
                AtualizaGridTarefas();
                btnAdicionar.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnConcluir.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadAluno aluno = new frmCadAluno();
            aluno.Show();
        }
    }
}
