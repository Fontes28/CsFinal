using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Modalidade
    {
        private String Descricao;
        private float preco;
        private int qtde_alunos, qtde_aulas;

        public Modalidade(string descricao, float preco, int qtde_alunos, int qtde_aulas)
        {
            Descricao = descricao;
            this.preco = preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
        }
        public Modalidade(string descricao)
        {
            Descricao = descricao;
           
        }
        public Modalidade()
        {
            
        }

        public string Descricao1 { get => Descricao; set => Descricao = value; }
        public float Preco { get => preco; set => preco = value; }              
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }


        public bool cadastrarModalidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidade(descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) values ('" + Descricao + "'," + preco + "," + qtde_alunos + "," + qtde_aulas+")", DAO_Conexao.con);
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
        public bool consultarBoolean()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consultaBool = new MySqlCommand("SELECT* FROM Estudio_Aluno WHERE descricaoModalidade='" + Descricao + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consultaBool.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
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
        public bool atualizaModalidade()
        {
            bool updated = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand update = new MySqlCommand("update Estudio_Aluno set descricaoModalidade='" + Descricao + "', precoModalidade=" + preco + ", qtdeAlunos=" + qtde_alunos + ", qtdeAulas=" + qtde_aulas + " where descricaoModalidade='" + Descricao + "'", DAO_Conexao.con);
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
                 MySqlCommand exclui = new MySqlCommand("update Estudio_Modalidade set ativo=1 where descricaoModalidade='" + Descricao1 + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }


    }
}
