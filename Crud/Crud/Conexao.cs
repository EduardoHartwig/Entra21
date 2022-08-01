 using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Crud
{
    public class Conexao
    {
        SqlConnection con;

        public Conexao()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-SCRT0T7\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
         
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
