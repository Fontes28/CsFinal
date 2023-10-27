using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Estudio
{
    public partial class ConsultarMatricula : Form
    {
        private int index;
        private string nomeModalidade;
        private string nomeTurma;
        private String[] resultado;
        private string modalidadeSelected;
        private string horarioSelected;
        private int idModalidadeBusca;
        private string horaSelected;
        private int idTurma;
        private String nomeAluno;

        public ConsultarMatricula()
        {
            InitializeComponent();
            try
            {
                Modalidade m = new Modalidade();
                MySqlDataReader r = m.ConsultarTodasModalidadesAtivas();
                while (r.Read())
                {
                    comboBox1.Items.Add(r["descricaoModalidade"].ToString());
                }
                DAO_Conexao.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                listBox1.Items.Clear();
                Modalidade m = new Modalidade();
                MySqlDataReader rIdx = m.consultarModalidade(comboBox1.SelectedItem.ToString());
                while (rIdx.Read())
                {
                    index = int.Parse(rIdx["idEstudio_Modalidade"].ToString());
                    nomeModalidade = (rIdx["descricaoModalidade"].ToString());
                }
                DAO_Conexao.con.Close();

                Turma t = new Turma();
                MySqlDataReader rLbx = t.consultarTurmaId(index);
                while (rLbx.Read())
                {
                    nomeTurma = nomeModalidade + "-" + rLbx["diaSemanaTurma"].ToString() + "-" + rLbx["horaTurma"].ToString();
                    listBox2.Items.Add(nomeTurma);
                }
                DAO_Conexao.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Matricula matricula = new Matricula();
                Aluno a = new Aluno();
                MySqlDataReader reader2;
                MySqlDataReader mySqlDataReader = matricula.consultarAlunos(obterIdTurma());
                /*listBox1.Items.Clear();
                listBox2.Items.Clear();*/
                while (mySqlDataReader.Read())
                {
                    a.setCPF(mySqlDataReader["cpf_Aluno"].ToString());
                    reader2 = a.consultarAluno01Extra();
                    while (reader2.Read())
                    {
                        nomeAluno = reader2["nomeAluno"].ToString();
                    }
                    listBox1.Items.Add(nomeAluno);
                }
                DAO_Conexao.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private int obterIdTurma()
        {
            try
            {
                resultado = (listBox2.SelectedItem.ToString()).Split('-');
                modalidadeSelected = resultado[0];
                horarioSelected = resultado[1];
                horaSelected = resultado[2];

                Modalidade modalidade = new Modalidade();
                MySqlDataReader rMod = modalidade.consultarModalidade(modalidadeSelected);
                while (rMod.Read())
                {
                    idModalidadeBusca = int.Parse(rMod["idEstudio_Modalidade"].ToString());
                }
                DAO_Conexao.con.Close();

                Turma turma = new Turma();
                MySqlDataReader rDia = turma.consultarTurmaIdDiaHora(idModalidadeBusca, horarioSelected, horaSelected);
                while (rDia.Read())
                {
                    idTurma = int.Parse(rDia["idEstudio_Turma"].ToString());
                }
                DAO_Conexao.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return idTurma;
        }
    }
}