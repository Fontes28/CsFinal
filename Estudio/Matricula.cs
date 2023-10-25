using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Matricula
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


    }
}
