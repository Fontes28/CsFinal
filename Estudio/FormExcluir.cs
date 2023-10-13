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
    public partial class FormExcluir : Form
    {
        public FormExcluir()
        {
            InitializeComponent();
            Modalidade modalidade1 = new Modalidade();
            MySqlDataReader x = modalidade1.ConsultarTodasModalidades();
            if (x.HasRows)
            {
                while (x.Read())
                {
                    /*int a = int.Parse(x["ativo"].ToString());
                    if (a == 0)
                    {*/

                    cbxMod.Items.Add(x["descricaoModalidade"].ToString());

                }
            }
                
            
            DAO_Conexao.con.Close();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxSemana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
