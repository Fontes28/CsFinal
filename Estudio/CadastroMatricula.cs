using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Estudio
{
    public partial class CadastroMatricula : Form
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

        public CadastroMatricula()
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

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBox1.Text;
            int id = obterIdTurma();
            Matricula m = new Matricula();
            Turma t = new Turma();
            t.setQtdeMax(index);
            if (m.contarAlunos(obterIdTurma()) < t.QtdeMax)
            {
                Aluno a = new Aluno(cpf);

                if (a.verificaCPF())
                {
                    cpf = a.getCPF();

                    if (m.cadastrar(id, cpf))
                    {
                        MessageBox.Show("Cadastro realizado");
                    }
                    else
                    {
                        MessageBox.Show("Erro no cadastro");
                    }
                }
            }
            else
            {
                MessageBox.Show("Não é possível mais cadastrar alunos nesta turma");
            }
        }

        private int obterIdTurma()
        {
            try
            {
                resultado = listBox1.SelectedItem.ToString().Split('-');
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
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
                    listBox1.Items.Add(nomeTurma);
                }
                DAO_Conexao.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}