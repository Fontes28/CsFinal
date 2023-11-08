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
        private string nomeLista;
        private string modalidadeSelected;
        private string horarioSelected;
        private int idModalidadeBusca;
        private string horaSelected;
        private int idTurma;
        private String nomeAluno;
        private string CPFAluno;
        private int contador = 1;

        public ConsultarMatricula(int id)
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
                btnExcluir.Visible = false;
                textBox1.Enabled = false;
                if (id == 1)
                {
                    btnExcluir.Visible = true;
                    this.Text = "Excluir";
                    textBox1.Visible = false;
                    label2.Visible = false;
                }
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
                Turma t = new Turma();
                t.setQtdeMax(index);
                
                    Aluno a = new Aluno();

                    MySqlDataReader reader = matricula.consultarInnerJoin(obterIdTurma());

                    while (reader.Read())
                    {
                        nomeLista = reader["nomeAluno"].ToString() + "-" + reader["CPFAluno"].ToString();
                        listBox1.Items.Add(nomeLista);
                    }
                    DAO_Conexao.con.Close();
                textBox1.Text = matricula.contarAlunos(obterIdTurma()).ToString();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Matricula matricula = new Matricula();
                if (matricula.excluirAlunoMatricula(obterCPFAluno()))
                {
                    MessageBox.Show("Excluido Com Sucesso!");
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private string obterCPFAluno()
        {
            try
            {
                resultado = (listBox1.SelectedItem.ToString()).Split('-');
                nomeAluno = resultado[0];
                CPFAluno = resultado[1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return CPFAluno;
        }
    }
}