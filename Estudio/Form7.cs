﻿using MySql.Data.MySqlClient;
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
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();
            Modalidade modalidade1 = new Modalidade();
            MySqlDataReader x = modalidade1.ConsultarTodasModalidades();
            while (x.Read())
            {

                comboBox1.Items.Add(x["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Modalidade m = new Modalidade();
                m.Descricao = comboBox1.Text;

                if (m.consultarBoolean())
                {
                    if (m.excluirModalidade())
                    {
                        MessageBox.Show("Modalidade Excluida");
                    }
                }
                else
                {
                    MessageBox.Show("Modalidade inexistente");
                }
                m.excluirModalidade();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao excluir");
            }
        }
    }
}
