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
    public partial class Form5 : Form
    {
        private bool att;
        String descricacaoSel;




        public Form5(bool att)
        {
            InitializeComponent();
            Modalidade modalidade1 = new Modalidade();
            MySqlDataReader x = modalidade1.ConsultarTodasModalidades();
            while (x.Read())
            {

                comboBox1.Items.Add(x["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
            this.att = att;
            if(!att)
            {
                btnAtualizar.Visible=false;
                txtAluno.Enabled = false;
                txtAulas.Enabled = false;
                txtPreco.Enabled = false;
                checkBox1.Enabled = false;
                //btnAtualizar.Name = "btnConsultar";
                
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (att)
            {
                float preco = float.Parse(txtPreco.Text);
                int alunos = int.Parse(txtAluno.Text);
                int aulas = int.Parse(txtAulas.Text);
                int del;
                if(checkBox1.Checked)
                {
                    del = 1;
                }
                else
                {
                    del = 0;
                }
                Modalidade m = new Modalidade(descricacaoSel, preco, alunos, aulas,del);
                if (m.atualizaModalidade())
                {
                    MessageBox.Show("Atualizado com Sucesso");

                }
                else
                {
                    MessageBox.Show("Erro ao atualizar");
                }
            }
            else
            {
                try
                {
                    Modalidade md = new Modalidade();
                    descricacaoSel = comboBox1.SelectedItem.ToString();
                    MessageBox.Show(descricacaoSel);
                    MySqlDataReader r = md.consultarModalidade(descricacaoSel);
                    while (r.Read())
                    {
                        descricacaoSel = r["descricaoModalidade"].ToString();
                        txtAluno.Text = r["qtdeAlunos"].ToString();
                        txtAulas.Text = r["qtdeAulas"].ToString();
                        txtPreco.Text = r["precoModalidade"].ToString();

                    }
                    DAO_Conexao.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


                try
                {
                    Modalidade md = new Modalidade();
                    descricacaoSel = comboBox1.SelectedItem.ToString();
                    //MessageBox.Show(descricacaoSel);
                    MySqlDataReader r = md.consultarModalidade(descricacaoSel);
                    while (r.Read())
                    {
                        descricacaoSel = r["descricaoModalidade"].ToString();
                        txtAluno.Text = r["qtdeAlunos"].ToString();
                        txtAulas.Text = r["qtdeAulas"].ToString();
                        txtPreco.Text = r["precoModalidade"].ToString();
                    bool a;
                        if(r["ativa"].ToString().Equals("1"))
                        {
                        checkBox1.Checked = true;
                        }
                        else
                        {
                        checkBox1.Checked = false;
                        }
                        

                    }
                    DAO_Conexao.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }
    }
}
