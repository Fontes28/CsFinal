using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class ConsultarTurma : Form
    {
        int index;
        string nomeTurma;
        string nomeModalidade;
        String[] resultado;
        string modalidadeSelected;
        string horarioSelected;
        int idModalidadeBusca;
        int idTurma;
        public ConsultarTurma()
        {
            InitializeComponent();
            txtDiaSemana.Enabled = false;
            txtModalidade.Enabled = false;
            txtProfessor.Enabled = false;
            txtQntdAlunos.Enabled = false;
            mkdHora.Enabled = false;
            
            try
            {
                Modalidade m = new Modalidade();
                MySqlDataReader r = m.ConsultarTodasModalidadesAtivas();
                while(r.Read())
                {
                    comboBox1.Items.Add(r["descricaoModalidade"].ToString());
                }
                DAO_Conexao.con.Close();
            }
            catch(Exception ex)
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
                    nomeTurma = nomeModalidade + "-" + rLbx["diaSemanaTurma"].ToString();
                    listBox1.Items.Add(nomeTurma);
                    
                }
                DAO_Conexao.con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
           
            resultado=listBox1.SelectedItem.ToString().Split('-');
            modalidadeSelected = resultado[0];
            horarioSelected = resultado[1];
            MessageBox.Show(modalidadeSelected + "~~" + horarioSelected);
            Modalidade modalidade = new Modalidade();
            MySqlDataReader rMod = modalidade.consultarModalidade(modalidadeSelected);
            while(rMod.Read())
            {
                idModalidadeBusca = int.Parse(rMod["idEstudio_Modalidade"].ToString());
            }
            DAO_Conexao.con.Close();

            Turma turma = new Turma();
            MySqlDataReader rDia = turma.consultarTurmaIdDia(idModalidadeBusca, horarioSelected);
            while(rDia.Read())
            {
                idTurma = int.Parse(rDia["idEstudio_Turma"].ToString());
                MessageBox.Show(":"+idTurma);
            }rDia.Close();
            DAO_Conexao.con.Close();
            rDia = turma.consultarTurmaId(idTurma);
            while(rDia.Read())
            {
                txtDiaSemana.Text = rDia["diaSemanaTurma"].ToString();
                txtModalidade.Text = modalidadeSelected;
                txtProfessor.Text = rDia["professorTurma"].ToString();
                txtQntdAlunos.Text = rDia["qtde_alunosMatriculados"].ToString();
            }
            DAO_Conexao.con.Close();
            txtDiaSemana.Enabled = true;
            txtProfessor.Enabled = true;
            txtQntdAlunos.Enabled = true;
            mkdHora.Enabled = true;



        }
    }
}
