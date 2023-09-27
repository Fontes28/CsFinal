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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void mkCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(mkCPF.Text);
            if (e.KeyChar == 13)
            {

                if (aluno.consultarAluno())
                {
                    if (aluno.excluirAluno())
                    {
                        MessageBox.Show("Aluno Excluido");
                    }

                }
                else
                {
                    MessageBox.Show("Aluno inexistente");
                }
                mkCPF.Text = "";
            }
        }

        private void mkCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }

}
