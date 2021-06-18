using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace PI2
{
    class BancoDeDados
    {
        #region CONEXAO

        //ESSA AQUI FOI A STRING DE CONEXÃO USADA PARA OS TESTES
        //"DATA SOURCE=@@server; INITIAL CATALOG=@@dataBase;  Integrated Security = True; Pooling = False";
        
        private static string connectionString = "Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=fatec;Data Source=OTAVIO-PC-GMR\\SQLEXPRESS";
        public static SqlConnection conexao;
        #endregion

        #region MÉTODOS GERAIS

        public static void Conectar()
        {   
            BancoDeDados.conexao = new SqlConnection(connectionString);
            BancoDeDados.conexao.Open();
        }
        
        //RETORNA UM DATA SET COM O RESULTADO DA CONSULTA INFORMADA NO PARÂMETRO "script"
        public static DataSet ConsultaSQL(string script)
        {            
            DataSet ds = new DataSet();
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                SqlDataAdapter adapter = new SqlDataAdapter(script, conexao);

                adapter.Fill(ds);
                adapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return ds;
        }

        public static string BuscarFaculdade(string idFaculdade)
        {
            string descricao = "";
            idFaculdade = idFaculdade.Replace(" ", "");
            if (String.IsNullOrEmpty(idFaculdade))
                return descricao;

            string sql = "SELECT * FROM tb_faculdade WHERE cod_faculdade = " + idFaculdade;
            DataSet ds = ConsultaSQL(sql);
            if (ds.Tables[0].Rows.Count > 0)
                descricao = ds.Tables[0].Rows[0]["nome_faculdade"].ToString();

            return descricao;
        }

        public static string BuscarCurso(string idCurso)
        {
            string descricao = "";
            idCurso = idCurso.Replace(" ", "");
            if (String.IsNullOrEmpty(idCurso))
                return descricao;

            string sql = "SELECT * FROM tb_curso WHERE cod_curso = " + idCurso;
            DataSet ds = ConsultaSQL(sql);
            if (ds.Tables[0].Rows.Count > 0)
                descricao = ds.Tables[0].Rows[0]["nome_curso"].ToString();

            return descricao;
        }

        public static string BuscarDisciplina(string idDisciplina, string cod_aluno)
        {
            string descricao = "";
            idDisciplina = idDisciplina.Replace(" ", "");
            if (String.IsNullOrEmpty(idDisciplina))
                return descricao;

            string sql = @"SELECT DISTINCT d.* FROM tb_disciplina d
                           INNER JOIN tb_aluno a ON a.cod_curso = d.cod_curso
                           WHERE cod_disciplina = " + idDisciplina + " AND a.cod_aluno = " + cod_aluno;
            DataSet ds = ConsultaSQL(sql);
            if (ds.Tables[0].Rows.Count > 0)
                descricao = ds.Tables[0].Rows[0]["nome_disciplina"].ToString();

            return descricao;
        }

        #endregion

        #region MÉTODOS CADASTRO ---FACULDADE---

        public static bool InserirFaculdade(string descricaoFaculdade)
        {            
            SqlCommand command = new SqlCommand("insert into tb_faculdade(nome_faculdade) values (@nome_faculdade)", conexao);
            command.Parameters.Add("@nome_faculdade", SqlDbType.VarChar).Value = descricaoFaculdade;
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();
                
                command.ExecuteNonQuery();                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Efetuar Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool AlterarFaculdade(string idFaculdade, string descricaoFaculdade)
        {
            string script = "UPDATE tb_faculdade SET nome_faculdade = '" + descricaoFaculdade + "' WHERE cod_faculdade = " + idFaculdade;
            SqlCommand command = new SqlCommand(script, conexao);            
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool ExcluirFaculdade(string idFaculdade)
        {
            string script = "DELETE tb_faculdade WHERE cod_faculdade = " + idFaculdade;
            SqlCommand command = new SqlCommand(script, conexao);
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        #endregion

        #region MÉTODOS CADASTRO ---CURSO---

        public static bool InserirCurso(string descricaoCurso)
        {
            SqlCommand command = new SqlCommand("insert into tb_curso(nome_curso) values (@nome_curso)", conexao);
            command.Parameters.Add("@nome_curso", SqlDbType.VarChar).Value = descricaoCurso;
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Efetuar Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool AlterarCurso(string idCurso, string descricaoCurso)
        {
            string script = "UPDATE tb_curso SET nome_curso = '" + descricaoCurso + "' WHERE cod_curso = " + idCurso;
            SqlCommand command = new SqlCommand(script, conexao);
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool ExcluirCurso(string idCurso)
        {
            string script = "DELETE tb_curso WHERE cod_curso = " + idCurso;
            SqlCommand command = new SqlCommand(script, conexao);
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        #endregion

        #region MÉTODOS CADASTRO ---DISCIPLINA---

        public static bool InserirDisciplina(string descricaoDisciplina, string idCurso)
        {
            SqlCommand command = new SqlCommand("insert into tb_disciplina(nome_disciplina, cod_curso) values (@nome_disciplina, @cod_curso)", conexao);
            command.Parameters.Add("@nome_disciplina", SqlDbType.VarChar).Value = descricaoDisciplina;
            command.Parameters.Add("@cod_curso", SqlDbType.Int).Value = idCurso;
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Efetuar Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool AlterarDisciplina(string descricaoDisciplina, string idCurso, string idDisciplina)
        {
            string script = "UPDATE tb_disciplina SET nome_disciplina = '" + descricaoDisciplina + "', cod_curso = " + idCurso + " WHERE cod_disciplina = " + idDisciplina;
            SqlCommand command = new SqlCommand(script, conexao);
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool ExcluirDisciplina(string idDisciplina)
        {
            string script = "DELETE tb_disciplina WHERE cod_disciplina = " + idDisciplina;
            SqlCommand command = new SqlCommand(script, conexao);
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
        
        #endregion

        #region MÉTODOS CADASTRO ---ALUNO---

        public static bool InserirAluno(ArrayList infoAluno)
        {
            string comandoSQL = @"insert into tb_aluno(cod_faculdade, 
                                                       cod_curso,
                                                       nome_alun,
                                                       cpf_alun,
                                                       email_alun,
                                                       fone_alun,                                                       
                                                       nascimento_alun,
                                                       perfil_alun,
                                                       usuario,
                                                       senha)
                                  values (@codFaculdade,
                                          @codCurso, 
                                          @nome,
                                          @cpf,
                                          @email,
                                          @fone,
                                          @dataNascimento,
                                          @tipo,
                                          @usuario,
                                          @senha)";

            SqlCommand command = new SqlCommand(comandoSQL, conexao);
            command.Parameters.Add("@codFaculdade", SqlDbType.Int).Value = infoAluno[0];
            command.Parameters.Add("@codCurso", SqlDbType.Int).Value = infoAluno[1];
            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = infoAluno[2];
            command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = infoAluno[3];
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = infoAluno[4];
            command.Parameters.Add("@fone", SqlDbType.VarChar).Value = infoAluno[5];
            command.Parameters.Add("@dataNascimento", SqlDbType.Date).Value = infoAluno[6];
            command.Parameters.Add("@tipo", SqlDbType.VarChar).Value = infoAluno[7];
            command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = infoAluno[8];
            command.Parameters.Add("@senha", SqlDbType.VarChar).Value = infoAluno[9];
            
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Efetuar Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool AlterarAluno(ArrayList infoAluno, string idAluno)
        {
            string script = @"UPDATE tb_aluno SET cod_faculdade = @codFaculdade, 
                                                       cod_curso = @codCurso,
                                                       nome_alun = '@nome',
                                                       cpf_alun = '@cpf',
                                                       email_alun = '@email',
                                                       fone_alun = '@fone',
                                                       nascimento_alun = '@dataNascimento',
                                                       perfil_alun = '@tipo',
                                                       usuario = '@usuario',
                                                       senha = '@senha'
                              WHERE cod_aluno = @codAluno";
            script = script.Replace("@codFaculdade", infoAluno[0].ToString());
            script = script.Replace("@codCurso", infoAluno[1].ToString());
            script = script.Replace("@nome", infoAluno[2].ToString());
            script = script.Replace("@cpf", infoAluno[3].ToString());
            script = script.Replace("@email", infoAluno[4].ToString());
            script = script.Replace("@fone", infoAluno[5].ToString());
            script = script.Replace("@dataNascimento", infoAluno[6].ToString());
            script = script.Replace("@tipo", infoAluno[7].ToString());
            script = script.Replace("@usuario", infoAluno[8].ToString());
            script = script.Replace("@senha", infoAluno[9].ToString());
            script = script.Replace("@codAluno", idAluno);                                                
            
            SqlCommand command = new SqlCommand(script, conexao);
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool ExcluirAluno(string idAluno)
        {
            string script = "DELETE tb_aluno WHERE cod_aluno = " + idAluno;
            SqlCommand command = new SqlCommand(script, conexao);
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        #endregion

        #region MÉTODOS CADASTRO ---TAREFA---

        public static bool InserirTarefa(ArrayList infoTarefa, string idAluno)
        {
            try
            {
                string comandoSQL = @"insert into tb_tarefas(cod_disciplina,
                                                         descricao_tarefa,
                                                         data_entrega_tarefa,                                                         
                                                         andamento_tarefa)
                                  values (@codDisciplina,
                                          @descricao,
                                          @data,                                           
                                          @status)";

                SqlCommand command = new SqlCommand(comandoSQL, conexao);
                command.Parameters.Add("@codDisciplina", SqlDbType.Int).Value = infoTarefa[0];                
                command.Parameters.Add("@descricao", SqlDbType.VarChar).Value = infoTarefa[1];
                command.Parameters.Add("@data", SqlDbType.Date).Value = infoTarefa[2];
                command.Parameters.Add("@status", SqlDbType.VarChar).Value = "Pendente";


                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();

                string cod_tarefa = BancoDeDados.ConsultaSQL("SELECT MAX(cod_tarefa) id FROM tb_tarefas").Tables[0].Rows[0][0].ToString();

                comandoSQL = @"insert into tb_participantes (cod_aluno,
                                                             cod_tarefa)
                                  values (@codAluno,
                                          @codTarefa)";
                command = new SqlCommand(comandoSQL, conexao);
                command.Parameters.Add("@codAluno", SqlDbType.Int).Value = idAluno;
                command.Parameters.Add("@codTarefa", SqlDbType.Int).Value = cod_tarefa;
                
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Efetuar Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool AlterarTarefa(ArrayList infoTarefa, string idTarefa)
        {
            string script = @"UPDATE tb_tarefas SET cod_disciplina = @codDisciplina, 
                                                    data_entrega_tarefa = '@data',
                                                    descricao_tarefa = '@nome',                                                    
                              WHERE cod_aluno = @codTarefa";
            script = script.Replace("@codDisciplina", infoTarefa[0].ToString());
            script = script.Replace("@data", infoTarefa[1].ToString());
            script = script.Replace("@nome", infoTarefa[2].ToString());            
            
            script = script.Replace("@codTarefa", idTarefa);

            SqlCommand command = new SqlCommand(script, conexao);
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
                
        public static bool ExcluirTarefa(string idTarefa, string idAluno)
        {
            try
            {
                string script = "DELETE tb_tarefas WHERE cod_tarefa = " + idTarefa;
                SqlCommand command = new SqlCommand(script, conexao);

                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();

                script = "DELETE tb_participantes WHERE cod_tarefa = " + idTarefa + " AND cod_aluno = " + idAluno;
                command = new SqlCommand(script, conexao);

                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static bool AlterarAndamentoTarefa(string idTarefa, string status)
        {
            string script = @"UPDATE tb_tarefas SET andamento_tarefa = '@status'                                                    
                              WHERE cod_tarefa = @codTarefa";
            script = script.Replace("@status", status);
            script = script.Replace("@codTarefa", idTarefa);

            SqlCommand command = new SqlCommand(script, conexao);
            try
            {
                if (conexao.State != ConnectionState.Open)
                    Conectar();

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Alterar Cadastro: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        #endregion

    }
}
