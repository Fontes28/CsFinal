using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Estudio
{
    internal class Modalidade
    {
        private string descricao;
        private float preco;
        private int qtde_alunos, qtde_aulas;
        private int del;
        private int codigoID;

        public Modalidade(string descricao, float preco, int qtde_alunos, int qtde_aulas, int del)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
            this.del = del;
        }

        public Modalidade(string descricao, float preco, int qtde_alunos, int qtde_aulas, int del, int codigoID)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
            this.del = del;
            this.codigoID = codigoID;
        }

        public Modalidade(string descricao)
        {
            this.descricao = descricao;
        }

        public Modalidade()
        {
        }

        public Modalidade(string descricao, float preco, int qtde_alunos, int qtde_aulas)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
        }

        public string Descricao { get => descricao; set => descricao = value; }
        public float Preco { get => preco; set => preco = value; }
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }

        public bool cadastrarModalidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidade(descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) values ('" + descricao + "'," + preco + "," + qtde_alunos + "," + qtde_aulas + ")", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

        public MySqlDataReader consultarModalidade(String descEscolhida)
        {
            MySqlCommand consulta = null;
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade WHERE descricaoModalidade='" + descEscolhida + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
            }
            return resultado;
        }

        public int qtdeAlunosViaID(int idModalidade)
        {
            int quantidade=0;
            MySqlCommand consulta = null;
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                consulta = new MySqlCommand("SELECT qtdeAlunos FROM Estudio_Modalidade WHERE idEstudio_Modalidade='" + idModalidade + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
                while(resultado.Read())
                {
                    quantidade = int.Parse(resultado["qtdeAlunos"].ToString());
                }
                DAO_Conexao.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
            }
            return quantidade;
        }

        public bool consultarBoolean()
        {
            bool existe = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consultaBool = new MySqlCommand("SELECT * FROM Estudio_Modalidade WHERE descricaoModalidade = '" + descricao + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consultaBool.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                DAO_Conexao.con.Close();
            }

            return existe;
        }

        public MySqlDataReader ConsultarTodasModalidades()
        {
            MySqlCommand consultaTodos = null;
            MySqlDataReader resultadoTodos = null;

            try
            {
                DAO_Conexao.con.Open();
                consultaTodos = new MySqlCommand("SELECT * FROM Estudio_Modalidade", DAO_Conexao.con);
                resultadoTodos = consultaTodos.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
            }
            return resultadoTodos;
        }

        public MySqlDataReader ConsultarTodasModalidadesAtivas()
        {
            MySqlCommand consultaTodos = null;
            MySqlDataReader resultadoTodos = null;

            try
            {
                DAO_Conexao.con.Open();
                consultaTodos = new MySqlCommand("SELECT * FROM Estudio_Modalidade where ativa=0", DAO_Conexao.con);
                resultadoTodos = consultaTodos.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
            }
            return resultadoTodos;
        }

        public bool atualizaModalidade()
        {
            bool updated = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand update = new MySqlCommand("update Estudio_Modalidade set descricaoModalidade='" + descricao + "', precoModalidade=" + preco + ", qtdeAlunos=" + qtde_alunos + ", qtdeAulas=" + qtde_aulas + ", ativa=" + del + " where idEstudio_Modalidade=" + codigoID + "", DAO_Conexao.con);
                update.ExecuteNonQuery();
                updated = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return updated;
        }

        public bool excluirModalidade()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Modalidade set ativa=1 where descricaoModalidade = '" + Descricao + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

        public static Boolean verificaExistencia(string consultar)
        {
            MySqlCommand consultaTodos = null;
            MySqlDataReader resultadoTodos = null;
            Boolean existe = true;

            try
            {
                DAO_Conexao.con.Open();
                consultaTodos = new MySqlCommand("SELECT * FROM Estudio_Modalidade where descricaoModalidade = '" + consultar + "'", DAO_Conexao.con);
                resultadoTodos = consultaTodos.ExecuteReader();
                if (resultadoTodos.Read())
                {
                    existe = true;
                }
                else
                {
                    existe = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                DAO_Conexao.con.Close();
            }
            return existe;
        }
    }
}