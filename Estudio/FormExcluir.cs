using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Estudio
{
    public partial class FormExcluir : Form
    {
        private int index;
        private string nomeTurma;
        private string nomeModalidade;
        private String[] resultado;
        private string modalidadeSelected;
        private string horarioSelected;
        private int idModalidadeBusca;
        private int idTurma;
        private string horario;
        private string horaSelected;

        public FormExcluir()
        {
            InitializeComponent();
            btnExcluir.Visible = false;

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int idTurmaAtt = -1;
                int id = -1;
                Modalidade modalidade = new Modalidade();
                MySqlDataReader dataModalidade = modalidade.consultarModalidade(comboBox1.SelectedItem.ToString());
                while (dataModalidade.Read())
                {
                    id = int.Parse(dataModalidade["idEstudio_Modalidade"].ToString());
                }
                DAO_Conexao.con.Close();

                idTurmaAtt = obterIdTurma();
                Turma turma = new Turma(idTurmaAtt, 0);
                if (turma.excluir())
                {
                    MessageBox.Show("Atualizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro a atualizar");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void dadosTela()
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

        private int obterIdTurma()
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
            return idTurma;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void cbxSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                nomeTurma = "";
                nomeModalidade = "";
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
                    horario = rLbx["horaTurma"].ToString();
                    nomeTurma = nomeModalidade + "-" + rLbx["diaSemanaTurma"].ToString() + "-" + horario;
                    listBox1.Items.Add(nomeTurma);
                }
                DAO_Conexao.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            dadosTela();
            btnExcluir.Visible = true;
        }
    }
}