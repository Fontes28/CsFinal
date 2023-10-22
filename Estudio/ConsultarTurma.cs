using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Estudio
{
    public partial class ConsultarTurma : Form
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
        private bool deletado;

        public ConsultarTurma()
        {
            InitializeComponent();
            txtDiaSemana.Enabled = false;
            txtModalidade.Enabled = false;
            txtProfessor.Enabled = false;
            txtQntdAlunos.Enabled = false;
            mkdHora.Enabled = false;
            btnAtualizar.Visible = false;
            checkBox1.Visible = false;
            checkBox1.Enabled = false;

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtDiaSemana.Text = "";
                txtModalidade.Text = "";
                txtProfessor.Text = "";
                txtQntdAlunos.Text = "";
                mkdHora.Text = "";
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int ativo;
                if (checkBox1.Checked)
                    ativo = 1;
                else
                {
                    ativo = 0;
                }
                int idTurmaAtt = -1;
                int id = -1;
                Modalidade modalidade = new Modalidade();
                MySqlDataReader dataModalidade = modalidade.consultarModalidade(txtModalidade.Text);
                while (dataModalidade.Read())
                {
                    id = int.Parse(dataModalidade["idEstudio_Modalidade"].ToString());
                }
                DAO_Conexao.con.Close();

                idTurmaAtt = obterIdTurma();
                Turma turma = new Turma(txtProfessor.Text, txtDiaSemana.Text, mkdHora.Text, id, int.Parse(txtQntdAlunos.Text), idTurmaAtt, ativo);
                if (turma.atualizar())
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

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("-o-o-o-o-o-o");
                dadosTela();
                txtDiaSemana.Enabled = true;
                txtProfessor.Enabled = true;
                txtQntdAlunos.Enabled = true;
                mkdHora.Enabled = true;
                btnAtualizar.Visible = true;
                checkBox1.Visible = true;
                checkBox1.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dadosTela()
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
                rDia = turma.consultarTurmaIdTurma(idTurma);
                while (rDia.Read())
                {
                    txtDiaSemana.Text = rDia["diaSemanaTurma"].ToString();
                    txtModalidade.Text = modalidadeSelected;
                    txtProfessor.Text = rDia["professorTurma"].ToString();
                    txtQntdAlunos.Text = rDia["qtde_alunosMatriculados"].ToString();
                    mkdHora.Text = rDia["horaTurma"].ToString();
                    if (int.Parse(rDia["ativo"].ToString()) == 1)
                    {
                        checkBox1.Checked = true;
                    }
                    else if (int.Parse(rDia["ativo"].ToString()) == 0)
                    {
                        checkBox1.Checked = false;
                    }
                }
                DAO_Conexao.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                dadosTela();

                txtDiaSemana.Enabled = false;
                txtModalidade.Enabled = false;
                txtProfessor.Enabled = false;
                txtQntdAlunos.Enabled = false;
                mkdHora.Enabled = false;
                btnAtualizar.Visible = false;
                checkBox1.Visible = true;
                checkBox1.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}