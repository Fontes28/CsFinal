using MySql.Data.MySqlClient;
using System;

namespace Estudio
{
    internal class Aluno
    {
        private String Bairro;
        private String CPF;
        private String Nome;
        private String Rua;
        private String Numero;
        private String Complemento;
        private String CEP;
        private String Cidade;
        private String Estado;
        private String Telefone;
        private String Email;
        private byte[] Foto;
        private int Ativo;

        public Aluno(String CPF, String nome, String rua,
            String numero, String bairro, String complemento,
            String CEP, String cidade, String estado,
            String telefone, String email, byte[] foto)
        {
            setCPF(CPF);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCEP(CEP);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
            setFoto(foto);
        }

        public Aluno(String CPF, String nome, String rua,
           String numero, String bairro, String complemento,
           String CEP, String cidade, String estado,
           String telefone, String email)
        {
            setCPF(CPF);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCEP(CEP);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
        }

        public Aluno(String CPF, String nome, String rua,
           String numero, String bairro, String complemento,
           String CEP, String cidade, String estado,
           String telefone, String email, int ativo)
        {
            setCPF(CPF);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCEP(CEP);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
            setAtivo(ativo);
        }

        public String getCPF()
        {
            return CPF;
        }

        public Aluno(String CPF)
        {
            setCPF(CPF);
        }

        public void setCPF(String CPF)
        {
            this.CPF = CPF;
        }

        public String getNome()
        {
            return Nome;
        }

        public void setNome(String nome)
        {
            Nome = nome;
        }

        public String getRua()
        {
            return Rua;
        }

        public void setRua(String rua)
        {
            Rua = rua;
        }

        public String getNumero()
        {
            return Numero;
        }

        public void setNumero(String numero)
        {
            Numero = numero;
        }

        public String getBairro()
        {
            return Bairro;
        }

        public void setBairro(String bairro)
        {
            Bairro = bairro;
        }

        public String getComplemento()
        {
            return Complemento;
        }

        public void setComplemento(String complemento)
        {
            Complemento = complemento;
        }

        public String getCEP()
        {
            return CEP;
        }

        public void setCEP(String CEP)
        {
            this.CEP = CEP;
        }

        public String getCidade()
        {
            return Cidade;
        }

        public void setCidade(String cidade)
        {
            Cidade = cidade;
        }

        public String getEstado()
        {
            return Estado;
        }

        public void setEstado(String estado)
        {
            Estado = estado;
        }

        public String getTelefone()
        {
            return Telefone;
        }

        public void setTelefone(String telefone)
        {
            Telefone = telefone;
        }

        public String getEmail()
        {
            return Email;
        }

        public void setEmail(String email)
        {
            Email = email;
        }

        public byte[] getFoto()
        {
            return Foto;
        }

        public void setFoto(byte[] foto)
        {
            Foto = foto;
        }

        public void setAtivo(int ativo)
        {
            Ativo = ativo;
        }

        public int getAtivo()
        {
            return Ativo;
        }

        public bool cadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno(CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno,CEPAluno,cidadeAluno,estadoAluno,telefoneAluno, emailAluno) values ('" + CPF + "','" + Nome + "','" + Rua + "','" + Numero + "','" + Bairro + "','" + Complemento + "','" + CEP + "','" + Cidade + "','" + Estado + "','" + Telefone + "','" + Email + "')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

        public bool consultarAluno()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT* FROM Estudio_Aluno WHERE CPFALuno='" + CPF + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                DAO_Conexao.con.Close();
            }

            return existe;
        }

        public MySqlDataReader consultarAluno01()
        {
            MySqlCommand consulta01 = null;
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();
                consulta01 = new MySqlCommand("SELECT * FROM Estudio_Aluno WHERE CPFALuno='" + CPF + "'", DAO_Conexao.con);
                resultado = consulta01.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
            }
            return resultado;
        }

        public bool excluirAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Aluno set ativo=1 where CPFAluno='" + CPF + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

        public bool atualizarAluno()
        {
            bool up = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand update = new MySqlCommand("update Estudio_Aluno set nomeAluno='" + Nome + "', ruaAluno='" + Rua + "', numeroAluno='" + Numero + "', bairroAluno='" + Bairro + "', complementoAluno='" + Complemento + "', CEPAluno='" + CEP + "', cidadeAluno='" + Cidade + "', estadoAluno='" + Estado + "', telefoneAluno='" + Telefone + "', emailAluno='" + Email + "', fotoAluno='" + Foto + "',ativo=" + Ativo + " where CPFAluno='" + CPF + "'", DAO_Conexao.con);
                update.ExecuteNonQuery();
                up = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return up;
        }
    }
}