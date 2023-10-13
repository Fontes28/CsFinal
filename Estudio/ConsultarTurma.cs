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
        public ConsultarTurma()
        {
            InitializeComponent();
            try
            {
                Modalidade m = new Modalidade();
                Turma t = new Turma();
                MySqlDataReader r = m.ConsultarTodasModalidadesAtivas();
                while(r.Read())
                {
                    dataGridView1.Columns.Add(r["idEstudio_Modalidade"].ToString(), r["descricaoModalidade"].ToString());
                }
                DAO_Conexao.con.Close();
                MySqlDataReader rTurma = t.consultarTodasTurmas();
                while (rTurma.Read())
                {
                    
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
    }
}
