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
    public partial class cadastrar_Turma : Form
    {
        bool att;
        public cadastrar_Turma()
        {
            try
            {
            InitializeComponent();
                WindowState = FormWindowState.Maximized;
                Modalidade con_Mod = new Modalidade();
                 MySqlDataReader r = con_Mod.ConsultarTodasModalidadesAtivas();
                
                 while(r.Read())
                    {
                    int a =int.Parse(r["ativa"].ToString());
                    if (a== 0)
                    {
                        dataGridView1.Rows.Add(r["descricaoModalidade"].ToString());
                    }
                     }
                txtMod.Enabled = false;
            }
            catch(Exception ex)
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
            
            string dia_semana = txtSemana.Text;
            string hora = mkdHora.Text;
            string prof = txtProfessor.Text;
            string mod = txtMod.Text;
            int modalidade=-1;
            int qtde = int.Parse(txtQtdeAluno.Text);
            try
            {
                Modalidade m = new Modalidade();
                MySqlDataReader r = m.consultarModalidade(mod);
                while (r.Read())
                {
                    modalidade = int.Parse(r["idEstudio_Modalidade"].ToString());
                }
                MessageBox.Show(modalidade.ToString());

                DAO_Conexao.con.Close();
                MessageBox.Show(modalidade.ToString());
                Turma t = new Turma(prof,dia_semana,hora,modalidade,qtde);
                
                    if (t.cadastar())
                    {
                        MessageBox.Show("Turma cadastrada");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadatrar turma");
                    }
                txtSemana.Text = "";
                mkdHora.Text="";
                txtProfessor.Text = "";
                txtMod.Text = "";
                txtQtdeAluno.Text = "";


            }
            catch(Exception ex)
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
            txtMod.Text = dataGridView1.CurrentCell.Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
