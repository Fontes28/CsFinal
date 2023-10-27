using MySql.Data.MySqlClient;
using System;

namespace Estudio
{
    internal class Matricula
    {
        public Matricula()
        {
        }

        public bool cadastrar(int idTurma, string cpf)
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insere = new MySqlCommand("insert into Estudio_Matricula(id_Turma,cpf_Aluno) values (" + idTurma + ",'" + cpf + "')", DAO_Conexao.con);
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

        public MySqlDataReader consultarAlunos(int idTurma)
        {
            MySqlCommand consultaTodos = null;
            MySqlDataReader resultadoTodos = null;

            try
            {
                DAO_Conexao.con.Open();
                consultaTodos = new MySqlCommand("SELECT * FROM Estudio_Matricula where id_Turma='" + idTurma + "'", DAO_Conexao.con);
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
    }
}