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
        public Form5()
        {
            InitializeComponent();
            Modalidade modalidade1 = new Modalidade();
            MySqlDataReader x=modalidade1.ConsultarTodasModalidades();
            while(x.Read())
            {

                comboBox1.Items.Add(x["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
