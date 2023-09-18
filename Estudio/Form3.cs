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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(maskedTextBox1.Text);
            if(e.KeyChar==13)
            {
               
                
                    if (aluno.consultarAluno())
                    {
                    MessageBox.Show("Aluno já cadastrado");
                    try
                    {

                        MySqlDataReader r = aluno.consultarAluno01();
                        
                        if (r.Read())
                        {
                            maskedTextBox1.Text = r["CPFAluno"].ToString();
                            textBox1.Text = r["nomeAluno"].ToString();
                            textBox2.Text = r["ruaAluno"].ToString();
                            textBox5.Text = r["numeroAluno"].ToString();
                            textBox3.Text = r["bairroAluno"].ToString();
                            textBox6.Text = r["complementoAluno"].ToString();
                            maskedTextBox2.Text = r["CEPAluno"].ToString();
                            textBox4.Text = r["cidadeAluno"].ToString();
                            textBox7.Text = r["estadoAluno"].ToString();
                            maskedTextBox3.Text = r["telefoneAluno"].ToString();
                            textBox8.Text = r["emailAluno"].ToString();



                        }
                        maskedTextBox1.Enabled = false;



                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    finally
                    {
                        DAO_Conexao.con.Close();
                    }
                }
                else
                {
                    textBox1.Focus();
                }
                    DAO_Conexao.con.Close();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)

        {
            
            Aluno aluno = new Aluno(maskedTextBox1.Text, textBox1.Text,textBox2.Text,textBox5.Text,textBox3.Text,textBox6.Text,maskedTextBox2.Text,textBox4.Text,textBox7.Text,maskedTextBox3.Text,textBox8.Text);

            
         
                if (aluno.cadastrarAluno())

                {
                    MessageBox.Show("Cadastro realizado");

                }
                else
                {
                    MessageBox.Show("Erro no cadastro");

                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(maskedTextBox1.Text, textBox1.Text, textBox2.Text, textBox5.Text, textBox3.Text, textBox6.Text, maskedTextBox2.Text, textBox4.Text, textBox7.Text, maskedTextBox3.Text, textBox8.Text);
            if (aluno.atualizarAluno())
            {
                MessageBox.Show("Atualizado com Sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao Atualizar");
            }
           
        }
    }
}
