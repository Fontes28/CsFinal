using System;
using System.Windows.Forms;

namespace Estudio
{
    public partial class Form1 : Form
    {
        private bool att;
        int tipo;

        public Form1()
        {
            InitializeComponent();
            menuStrip1.Enabled = false;

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202236", "cl202236", "DDTL/2508"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de conexão");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipo = DAO_Conexao.login("davi", "202236");
            if (tipo == 0)
            {
                MessageBox.Show("Usuário ou senha invalidos");
            }
            if (tipo == 1)
            {
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;

            }
            if (tipo == 2)
            {
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarToolStripMenuItem.Enabled = false;
                excluirToolStripMenuItem.Enabled = false;
                atualizarToolStripMenuItem.Enabled = false;
                cadastrarToolStripMenuItem1.Enabled = false;
                excluirToolStripMenuItem1.Enabled = false;
                consultarAtualizarToolStripMenuItem.Text = "Consultar";
                cadastrarLoginToolStripMenuItem.Enabled = false;
            }
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            att = false;
            Form3 frm = new Form3(att);
            frm.MdiParent = this;
            frm.Show();
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
            groupBox1.Visible = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.MdiParent = this;
            frm.Show();
        }

        private void atualizarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            att = true;
            Form3 frm = new Form3(att);
            frm.MdiParent = this;
            frm.Show();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool att = true;
            Form5 frm = new Form5(att);
            frm.MdiParent = this;
            frm.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.MdiParent = this;
            frm.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool att = false;
            Form5 frm = new Form5(att);
            frm.MdiParent = this;
            frm.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadastrar_Turma frm = new cadastrar_Turma();
            frm.MdiParent = this;
            frm.Show();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormExcluir frm = new FormExcluir();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultarAtualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarTurma frm = new ConsultarTurma(tipo);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}