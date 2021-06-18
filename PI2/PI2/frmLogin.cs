using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            BancoDeDados.Conectar();            
            txtSenha.Focus();
            txtSenha.SelectAll();
        }

        #region MÉTODOS

        private bool LoginValido(out string cod_aluno, out string tipo)
        {
            cod_aluno = ""; tipo = "";
            string sql = "SELECT * FROM tb_aluno WHERE usuario = '" + txtUsuario.Text + "' AND senha = '" + txtSenha.Text + "'";

            DataSet ds = BancoDeDados.ConsultaSQL(sql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                cod_aluno = ds.Tables[0].Rows[0]["cod_aluno"].ToString();
                tipo = ds.Tables[0].Rows[0]["perfil_alun"].ToString();
                return true;
            }

            MessageBox.Show("Usuário e/ou Senha inválido(s)");
            txtSenha.Focus();
            txtSenha.SelectAll();
            return false;
        }

        #endregion
                
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string cod_aluno, tipo;
            if (!LoginValido(out cod_aluno, out tipo))
                return;

            frmPrincipal home = new frmPrincipal(cod_aluno, tipo);
            home.Show();
            this.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
