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
    public partial class frmCadCurso : Form
    {

        #region CONSTRUTOR
        public frmCadCurso()
        {
            InitializeComponent();
            AtualizarGrid();
        }
        #endregion

        #region MÉTODOS

        private void LimparDados()
        {
            txtFaculdade.Text = "";
            txtCodFaculdade.Text = "";

            txtBuscaIdFaculdade.Text = "";
            txtBuscaNomeFaculdade.Text = "";

            btnAdicionarFaculdade.Enabled = true;
            btnAlterarFaculdade.Enabled = false;
            btnExcluirFaculdade.Enabled = false;
        }
        
        private bool ValidarDados()
        {
            if (txtFaculdade.Text == "")
            {
                MessageBox.Show("Informar campos obrigatórios!", "SISTEMA PI - CAMPOS OBRIGATÓRIOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtFaculdade.Focus();
                txtFaculdade.SelectAll();
                return false;
            }
            
            return true;
        }

        private void AtualizarGrid()
        {
            //VERIFICA SE EXISTE ALGUM FILTRO PREENCHIDO
            string where = "";
            if (!String.IsNullOrEmpty(txtBuscaIdFaculdade.Text))            
                where += "cod_curso = " + txtBuscaIdFaculdade.Text + " AND ";
            if (!String.IsNullOrEmpty(txtBuscaNomeFaculdade.Text))
                where += "nome_curso LIKE '%" + txtBuscaNomeFaculdade.Text + "%' AND ";
            where += "1=1";

            //CONSULTA PARA BUSCAR ASS FACULDADES
            string sql = @"SELECT cod_curso ID, nome_curso Curso FROM tb_curso WHERE " + where;
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
        private void btnAdicionarCurso_Click(object sender, EventArgs e)
        {
            if (!ValidarDados())
                return;

            if (BancoDeDados.InserirCurso(txtFaculdade.Text))
            {
                MessageBox.Show("Cadastro Efetuado com Sucesso!", "SISTEMA PI - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFaculdade.Text = "";
                AtualizarGrid();
            }
        }
                
        private void btnAlterarCurso_Click(object sender, EventArgs e)
        {
            if (!ValidarDados())
                return;

            if (BancoDeDados.AlterarCurso(txtCodFaculdade.Text, txtFaculdade.Text))
            {
                MessageBox.Show("Cadastro Alterado com Sucesso!", "SISTEMA PI - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodFaculdade.Text = "";
                txtFaculdade.Text = "";
                AtualizarGrid();
                btnAdicionarFaculdade.Enabled = true;
                btnAlterarFaculdade.Enabled = false;
                btnExcluirFaculdade.Enabled = false;
            }
        }

        private void btnExcluirCurso_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir o cadastro selecionado?", "SISTEMA PI - CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
                return;

            if (BancoDeDados.ExcluirCurso(txtCodFaculdade.Text))
            {
                MessageBox.Show("Cadastro Excluido com Sucesso!", "SISTEMA PI - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodFaculdade.Text = "";
                txtFaculdade.Text = "";
                AtualizarGrid();
            }
        }

        private void btnLimparCurso_Click(object sender, EventArgs e)
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
        
        #endregion

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            if (drv == null)
                return;

            DataRow dr = drv.Row;
            txtCodFaculdade.Text = dr["ID"].ToString();
            txtFaculdade.Text = dr["Curso"].ToString();

            btnAdicionarFaculdade.Enabled = false;
            btnAlterarFaculdade.Enabled = true;
            btnExcluirFaculdade.Enabled = true;
        }
    }
}
