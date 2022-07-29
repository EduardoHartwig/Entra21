using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Crud
{
    class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public Cadastro(string nome, string cpf, string rg, DateTime dataNascimento, string naturalidade)
        {
            cmd.CommandText = "insert into Pessoa (Nome, Cpf, Rg, DataNascimento, Naturalidade) values (@Nome, @Cpf, @Rg, @DataNascimento, @Naturalidade)";
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Cpf", cpf);
            cmd.Parameters.AddWithValue("@Rg", rg);
            cmd.Parameters.AddWithValue("@DataNascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@Naturalidade", naturalidade);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.mensagem = "Cadastrado com Sucesso.";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o Banco de Dados";
            }
        }
    }
}
