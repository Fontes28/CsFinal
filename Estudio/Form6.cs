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
    public partial class Form6 : Form
    {
       

        public Form6()
        {
            InitializeComponent();
        }

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                String descricao = txtDescricao.Text;
                float preco = float.Parse(txtPreco.Text);
                int qtdeAluno = int.Parse(txtAluno.Text);
                int qtdeAula = int.Parse(txtAula.Text);

                Modalidade m = new Modalidade(descricao, preco, qtdeAluno, qtdeAula);

                if (m.cadastrarModalidade())

                {
                    MessageBox.Show("Cadastro realizado");

                }
                else
                {
                    MessageBox.Show("Erro no cadastro");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não pode haver campos em branco");
            }
        }
    }
}
