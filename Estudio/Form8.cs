using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Estudio
{
    public partial class cadastrar_Turma : Form
    {
        public cadastrar_Turma()
        {
            try
            {
                InitializeComponent();
                WindowState = FormWindowState.Maximized;
                Modalidade con_Mod = new Modalidade();
                MySqlDataReader r = con_Mod.ConsultarTodasModalidadesAtivas();

                while (r.Read())
                {
                    int a = int.Parse(r["ativa"].ToString());
                    if (a == 0)
                    {
                        dataGridView1.Rows.Add(r["descricaoModalidade"].ToString());
                    }
                }
                txtMod.Enabled = false;
                String[] listaDias = { "seg", "ter", "qua", "qui", "sex" };
                comboBox1.Items.AddRange(listaDias);
                comboBox2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no preencher");
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string dia_semana = (comboBox1.SelectedItem.ToString() + "/" + comboBox2.SelectedItem.ToString());
                string hora = mkdHora.Text;
                string prof = txtProfessor.Text;
                string mod = txtMod.Text;
                int modalidade = -1;
                int qtde = int.Parse(txtQtdeAluno.Text);

                Modalidade m = new Modalidade();
                MySqlDataReader r = m.consultarModalidade(mod);
                while (r.Read())
                {
                    modalidade = int.Parse(r["idEstudio_Modalidade"].ToString());
                }

                DAO_Conexao.con.Close();

                Turma t = new Turma(prof, dia_semana, hora, modalidade, qtde);

                if (t.cadastar())
                {
                    MessageBox.Show("Turma cadastrada");
                }
                else
                {
                    MessageBox.Show("Erro ao cadatrar turma");
                }
                comboBox2.Enabled = false;
                mkdHora.Text = "";
                txtProfessor.Text = "";
                txtMod.Text = "";
                txtQtdeAluno.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMod.Text = dataGridView1.CurrentCell.Value.ToString();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Items.Clear();
                comboBox2.Enabled = true;
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (!comboBox1.Items[i].ToString().Equals(comboBox1.SelectedItem.ToString()))
                    {
                        comboBox2.Items.Add(comboBox1.Items[i].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}