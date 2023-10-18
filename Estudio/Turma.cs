using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    class Turma
    {
        private string professor, dia_semana, hora;
        private int modalidade, qtde_Alunos,id,del;

        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma(string professor, string dia_semana, string hora, int modalidade)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
        }

        public Turma(string dia_semana, int modalidade)
        {
            this.dia_semana = dia_semana;
            this.modalidade = modalidade;
        }

        public Turma(string professor, string dia_semana, string hora, int modalidade, int qtde_Alunos)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
            this.Qtde_Alunos = qtde_Alunos;
        }
        public Turma()
        {
          
        }

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }
        public int Qtde_Alunos { get => qtde_Alunos; set => qtde_Alunos = value; }
        public int Id { get => id; set => id = value; }

        public bool cadastar()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand insere = new MySqlCommand("insert into Estudio_Turma(idModalidade,professorTurma, diaSemanaTurma, horaTurma,qtde_alunosMatriculados) values (" + modalidade + ",'" + professor + "','" + dia_semana + "','" + hora + "'," + Qtde_Alunos + ")", DAO_Conexao.con);
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

        public bool consultarBoolean()
        {
            bool existe = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consultaBool = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE idEstudio_Turma = '" + Id + "'", DAO_Conexao.con);
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
        
        
        public bool atualizar()
        {
            bool updated = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand update = new MySqlCommand("update Estudio_Turma set idModalidade='" + modalidade + "', professorTurma=" + professor + ", horaTurma=" + hora + ", qtde_alunosMatriculados=" + qtde_Alunos + " where idEstudio_Turma=" + id + "", DAO_Conexao.con);
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

        public MySqlDataReader consultarTodasTurmas()
        {
            MySqlCommand consultaTodos = null;
            MySqlDataReader resultadoTodos = null;

            try
            {
                DAO_Conexao.con.Open();
                consultaTodos = new MySqlCommand("SELECT * FROM Estudio_Turma", DAO_Conexao.con);
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

        public bool excluir()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Turma set ativa=1 where idModalidade = '" + id + "'", DAO_Conexao.con);
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
        public MySqlDataReader consultarTurmaId(int id)
        {
            MySqlCommand consulta = null;
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                consulta = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE idModalidade='" + id + "'", DAO_Conexao.con);
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
        public MySqlDataReader consultarTurmaIdTurma(int id)
        {
            MySqlCommand consulta = null;
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                consulta = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE idEstudio_Turma='" + id + "'", DAO_Conexao.con);
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
        public MySqlDataReader consultarTurmaIdDia(int id, string dia)
        {
            MySqlCommand consulta = null;
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                consulta = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE idModalidade='" + id + "' AND diaSemanaTurma='"+dia+"'", DAO_Conexao.con);
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

    }

}

