using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Estudio
{
    public partial class Form3 : Form
    {
        public Form3(bool att)
        {
            InitializeComponent();
            if (att)
            {
                button2.Visible = false;
            }
            else
            {
                button3.Visible = false;
                checkBox1.Checked = false;
                checkBox1.Visible = false;
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(maskedTextBox1.Text);

            if (e.KeyChar == 13)
            {
                aluno.verificaCPF();
                MessageBox.Show(maskedTextBox1.Text);
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
                            if (r["ativo"].ToString().Equals("1"))
                            {
                                checkBox1.Checked = true;
                            }
                            else
                            {
                                checkBox1.Checked = false;
                            }
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
            byte[] foto = converterFotoParaByteArray();
            Aluno aluno = new Aluno(maskedTextBox1.Text, textBox1.Text, textBox2.Text, textBox5.Text, textBox3.Text, textBox6.Text, maskedTextBox2.Text, textBox4.Text, textBox7.Text, maskedTextBox3.Text, textBox8.Text,foto);
            if (aluno.verificaCPF())
            {
                if (aluno.consultarAluno() == false)
                {
                    if (aluno.cadastrarAluno())
                    {
                        MessageBox.Show("Cadastro realizado");
                    }
                    else
                    {
                        MessageBox.Show("Erro no cadastro");
                    }
                }
                else
                {
                    MessageBox.Show("Este CPF já existe no banco de dados!");
                }
            }
            else
            {
                MessageBox.Show("CPF Inválido, Cadastro não Realizado!");
            }

            maskedTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
        }


        private byte[] converterFotoParaByteArray()
        {
            using(var stream= new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(maskedTextBox1.Text, textBox1.Text, textBox2.Text, textBox5.Text, textBox3.Text, textBox6.Text, maskedTextBox2.Text, textBox4.Text, textBox7.Text, maskedTextBox3.Text, textBox8.Text);
            if (aluno.verificaCPF())
            {
                if (aluno.atualizarAluno())
                {
                    MessageBox.Show("Atualizado com Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar");
                }
            }
            else
            {
                MessageBox.Show("CPF Inválido, Atualização não Realizada!");
            }

            maskedTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir Foto";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";

            if(dialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Não foi possível carregar a foto: " + ex.Message);
                }
            }
            dialog.Dispose();

        }
    }
}