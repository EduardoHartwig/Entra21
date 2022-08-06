using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Crud
{
    class Menu
    {


        public static void ListarCadastros(List<Pessoa> pessoas)
        {
            Console.WriteLine("\nCadastros: \n");
            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine($"{p.Id} - {p.Nome}, {p.Cpf}, {p.Rg}, {p.DataNascimento}, {p.Naturalidade}");
            }
        }

        public static string CadastrarNome()
        {
            Console.WriteLine("\n\nInforme seu Nome: ");
            Console.Write("-> ");
            return Console.ReadLine();
        }

        public static string CadastrarCpf()
        {
            Console.WriteLine("\n\nInforme seu CPF: ");
            Console.Write("-> ");
            return Console.ReadLine();
        }

        public static string CadastrarRg()
        {
            Console.WriteLine("\n\nInforme seu RG: ");
            Console.Write("-> ");
            return Console.ReadLine();
        }

        public static string CadastrarDDD()
        {
            Console.WriteLine("\n\nInforme seu DDD: ");
            Console.Write("-> ");
            return Console.ReadLine();
        }

        public static string CadastrarNumero()
        {
            Console.WriteLine("\n\nInforme seu Número: ");
            Console.Write("-> ");
            return Console.ReadLine();
        }

        public static DateTime CadastrarDataNascimento()
        {
            Console.WriteLine("\n\nInforme sua Data de Nascimento: ");
            Console.Write("-> ");
            return Convert.ToDateTime(Console.ReadLine());
        }

        public static string CadastrarNaturalidade()
        {
            Console.WriteLine("\n\nInforme sua Naturalidade: ");
            Console.Write("-> ");
            return Console.ReadLine();
        }

        public static void MenuPrincipal()
        {
            int entrada = -1;
            List<Pessoa> pessoas = new List<Pessoa>();
            List<Telefone> telefones = new List<Telefone>();

            string connection = @"Data Source=ITELABD07\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True";
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();


            do
            {
                Console.WriteLine("\n(1) - Cadastrar Pessoa.");
                Console.WriteLine("(2) - Exibir Pessoas.");
                Console.WriteLine("(3) - Atualizar Pessoa.");
                Console.WriteLine("(4) - Deletar Pessoa.");
                Console.WriteLine("(5) - Cadastrar Telefone.");
                Console.WriteLine("(6) - Exibir Pessoa e seus Telefones.");
                Console.WriteLine("(7) - Deletar Telefone.");
                Console.WriteLine("(8) - Listar Telefones usando o nome.");
                Console.WriteLine("\n(0) - Sair.");
                Console.Write("-> ");
                entrada = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (entrada)
                {
                    case 0:
                        entrada = 010101;
                        break;

                    case 1:
                        pessoas.Clear();
                        telefones.Clear();
                        Console.WriteLine("Cadastro");

                        Pessoa pessoa = new Pessoa(CadastrarNome(), CadastrarCpf(), CadastrarRg(), CadastrarDataNascimento(), CadastrarNaturalidade());
                        pessoas.Add(pessoa);
                        cmd.CommandText = "insert into Pessoa (Nome, Cpf, Rg, DataNascimento, Naturalidade) values (@nome, @cpf, @rg, @dataNascimento, @naturalidade)";
                        cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
                        cmd.Parameters.AddWithValue("@cpf", pessoa.Cpf);
                        cmd.Parameters.AddWithValue("@rg", pessoa.Rg);
                        cmd.Parameters.AddWithValue("@dataNascimento", pessoa.DataNascimento);
                        cmd.Parameters.AddWithValue("@naturalidade", pessoa.Naturalidade);

                        try
                        {
                            cmd.Connection = conexao.Conectar();
                            cmd.ExecuteNonQuery();
                            conexao.Desconectar();
                            Console.WriteLine("Cadastrado com Sucesso.");
                        }
                        catch (SqlException e)
                        {
                            Console.WriteLine("Erro ao tentar se conectar com o Banco de Dados");
                        }
                        Console.Clear();
                        break;

                    case 2:
                        pessoas.Clear();
                        telefones.Clear();
                        Console.WriteLine("Exibir");



                        try
                        {
                            SqlDataReader resultado;
                            var query = @"SELECT Id, Nome, Cpf, Rg, DataNascimento, Naturalidade FROM Pessoa";
                            using (var sql = new SqlConnection(connection))
                            {
                                SqlCommand command = new SqlCommand(query, sql);
                                command.Connection.Open();
                                resultado = command.ExecuteReader();

                                while (resultado.Read())
                                {
                                    pessoas.Add(new Pessoa(resultado.GetInt32(resultado.GetOrdinal("Id")),
                                                           resultado.GetString(resultado.GetOrdinal("Nome")),
                                                           resultado.GetString(resultado.GetOrdinal("Cpf")),
                                                           resultado.GetString(resultado.GetOrdinal("Rg")),
                                                           resultado.GetDateTime(resultado.GetOrdinal("DataNascimento")),
                                                           resultado.GetString(resultado.GetOrdinal("Naturalidade"))));
                                }
                            }
                            Console.WriteLine("========Listagem========");
                            foreach (Pessoa p in pessoas)
                            {
                                Console.WriteLine("\n\n========Inicio========");
                                Console.WriteLine("Id: " + p.Id);
                                Console.WriteLine("Nome: " + p.Nome);
                                Console.WriteLine("CPF: " + p.Cpf);
                                Console.WriteLine("Rg: " + p.Rg);
                                Console.WriteLine("Naturalidade: " + p.Naturalidade);
                                Console.WriteLine("Data de Nascimento: " + p.DataNascimento);
                                Console.WriteLine("========Fim========");
                            }
                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
                        break;

                    case 3:
                        pessoas.Clear();
                        telefones.Clear();
                        Console.WriteLine("Update: ");

                        try
                        {
                            var query = @"select count(Id) from Pessoa where Id = @id";
                            SqlDataReader resultado;

                            Console.WriteLine("\nQual id deseja atualizar ?");
                            int id = Convert.ToInt32(Console.ReadLine());

                            bool existe = false;


                            using (var sql = new SqlConnection(connection))
                            {
                                SqlCommand command = new SqlCommand(query, sql);
                                command.Parameters.AddWithValue("@id", id);

                                command.Connection.Open();
                                resultado = command.ExecuteReader();

                                while (resultado.Read())
                                {
                                    existe = true;
                                }
                            }

                            var query2 = @"UPDATE Pessoa SET Nome = @nome, Cpf = @cpf, Rg = @rg, DataNascimento = @dataNascimento, Naturalida = @naturalidade WHERE Id = @id;";

                            if (existe)
                            {
                                using (var sql = new SqlConnection(connection))
                                {
                                    SqlCommand command = new SqlCommand(query2, sql);
                                    command.Connection.Open();

                                    command.Parameters.AddWithValue("@id", id);
                                    command.Parameters.AddWithValue("@nome", CadastrarNome());
                                    command.Parameters.AddWithValue("@cpf", CadastrarCpf());
                                    command.Parameters.AddWithValue("@rg", CadastrarRg());
                                    command.Parameters.AddWithValue("@dataNascimento", CadastrarDataNascimento());
                                    command.Parameters.AddWithValue("@naturalidade", CadastrarNaturalidade());

                                    command.ExecuteNonQuery();
                                    Console.WriteLine("\n\nUpdate realizado com Sucesso.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Id não encontrado.");
                            }
                        }
                        catch (Exception e)
                        {
                            throw;
                        }
                        break;

                    case 4:
                        pessoas.Clear();
                        telefones.Clear();
                        Console.WriteLine("Delete");

                        try
                        {
                            var query = @"select count(Id) from Pessoa where Id = @id";
                            SqlDataReader resultado;

                            Console.WriteLine("\nQual id deseja deletar ?");
                            int id = Convert.ToInt32(Console.ReadLine());

                            bool existe = false;


                            using (var sql = new SqlConnection(connection))
                            {
                                SqlCommand command = new SqlCommand(query, sql);
                                command.Parameters.AddWithValue("@id", id);

                                command.Connection.Open();
                                resultado = command.ExecuteReader();

                                while (resultado.Read())
                                {
                                    existe = true;
                                }
                            }

                            var query2 = @"delete from Pessoa where id = @id;";

                            if (existe)
                            {
                                using (var sql = new SqlConnection(connection))
                                {
                                    SqlCommand command = new SqlCommand(query2, sql);
                                    command.Parameters.AddWithValue("@id", id);
                                    command.Connection.Open();
                                    command.ExecuteNonQuery();
                                    Console.WriteLine("\n\nDelete realizado com Sucesso.");
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            throw;
                        }


                        break;

                    case 5:
                        pessoas.Clear();
                        telefones.Clear();
                        Console.WriteLine("Cadastrar Telefone: ");

                        try
                        {
                            var query = @"select count(Id) from Pessoa where Id = @id";
                            SqlDataReader resultado;

                            Console.WriteLine("\nQual id deseja Cadastrar um telefone ?");
                            int id = Convert.ToInt32(Console.ReadLine());

                            bool existe = false;


                            using (var sql = new SqlConnection(connection))
                            {
                                SqlCommand command = new SqlCommand(query, sql);
                                command.Parameters.AddWithValue("@id", id);

                                command.Connection.Open();
                                resultado = command.ExecuteReader();

                                while (resultado.Read())
                                {
                                    existe = true;
                                }
                            }

                            var query2 = @"insert into Telefone (DDD, Numero, IdPessoa) values (@dDD, @numero, @idPessoa)";

                            if (existe)
                            {
                                using (var sql = new SqlConnection(connection))
                                {
                                    SqlCommand command = new SqlCommand(query2, sql);
                                    command.Connection.Open();
                                    command.CommandText = "insert into Telefone (DDD, Numero, IdPessoa) values (@dDD, @numero, @idPessoa)";
                                    Telefone telefone = new Telefone(CadastrarDDD().Substring(0, 3), CadastrarNumero().Substring(0, 9), id);

                                    command.Parameters.AddWithValue("@dDD", telefone.DDD);
                                    command.Parameters.AddWithValue("@numero", telefone.Numero);
                                    command.Parameters.AddWithValue("@idPessoa", telefone.IdPessoa);
                                    command.ExecuteNonQuery();
                                    Console.WriteLine("\n\nCadastro realizado com Sucesso.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nId não encontrado.");
                            }
                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
                        break;

                    case 6:
                        pessoas.Clear();
                        telefones.Clear();

                        Console.WriteLine("\nExibir Pessoa e seus Telefones.");


                        try
                        {
                            SqlDataReader resultado;
                            Console.WriteLine("\nQual id deseja ver os Dados?");
                            int id = Convert.ToInt32(Console.ReadLine());
                            bool existe = false;
                            bool existeTelefone = false;

                            var query = @"SELECT p.Id as IdPessoa, p.Nome as Nome, p.Cpf as Cpf, p.Rg as RG, p.DataNascimento as DataNascimento, p.Naturalidade as Naturalidade FROM Pessoa p WHERE p.Id = @id";
                            using (var sql = new SqlConnection(connection))
                            {
                                SqlCommand command = new SqlCommand(query, sql);
                                command.Parameters.AddWithValue("@id", id);
                                command.Connection.Open();
                                resultado = command.ExecuteReader();

                                while (resultado.Read())
                                {
                                    pessoas.Add(new Pessoa(resultado.GetInt32(resultado.GetOrdinal("IdPessoa")),
                                                           resultado.GetString(resultado.GetOrdinal("Nome")),
                                                           resultado.GetString(resultado.GetOrdinal("Cpf")),
                                                           resultado.GetString(resultado.GetOrdinal("Rg")),
                                                           resultado.GetDateTime(resultado.GetOrdinal("DataNascimento")),
                                                           resultado.GetString(resultado.GetOrdinal("Naturalidade"))));
                                    existe = true;

 
                                }
                            }

                            if (existe)
                            {
                                var query2 = @"SELECT t.Id as IdTelefone, t.DDD as DDD, t.Numero as Numero FROM Pessoa p INNER JOIN Telefone t ON p.Id = t.IdPessoa where t.IdPessoa  = @id";
                                using (var sql = new SqlConnection(connection))
                                {
                                    SqlCommand command = new SqlCommand(query2, sql);
                                    command.Parameters.AddWithValue("@id", id);
                                    command.Connection.Open();
                                    resultado = command.ExecuteReader();

                                    while (resultado.Read())
                                    {
                                        pessoas[0].Telefone.Add(new Telefone(resultado.GetInt32(resultado.GetOrdinal("IdTelefone")),
                                                                             resultado.GetString(resultado.GetOrdinal("DDD")),
                                                                             resultado.GetString(resultado.GetOrdinal("Numero"))));
                                        existeTelefone = true;
                                    }
                                }

                                if (existeTelefone)
                                {
                                    Console.WriteLine("========Listagem========");
                                    foreach (Pessoa p in pessoas)
                                    {
                                        Console.WriteLine("\n\n========Inicio========");
                                        Console.WriteLine("Nome: " + p.Nome);
                                        Console.WriteLine("CPF: " + p.Cpf);
                                        Console.WriteLine("Rg: " + p.Rg);
                                        Console.WriteLine("Data de Nascimento: " + p.DataNascimento);
                                        Console.WriteLine("Naturalidade: " + p.Naturalidade);

                                        foreach (Telefone t in p.Telefone)
                                        {
                                            Console.WriteLine("\nTelefone: ");
                                            Console.WriteLine("Id: " + t.Id);
                                            Console.WriteLine("DDD: " + t.DDD);
                                            Console.WriteLine("Número: " + t.Numero);
                                        }
                                        Console.WriteLine("========Fim========");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Este Id não possui Telefone.");
                                }
                                
                            }
                            else
                            {
                                Console.WriteLine("\nId não encontrado.");
                            }
                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
                        break;

                    case 7:
                        pessoas.Clear();
                        telefones.Clear();
                        Console.WriteLine("\nDeletar Telefone de uma pessoa.");

                        try
                        {
                            SqlDataReader resultado;
                            var query = @"SELECT Id, Nome FROM Pessoa";
                            using (var sql = new SqlConnection(connection))
                            {
                                SqlCommand command = new SqlCommand(query, sql);
                                command.Connection.Open();
                                resultado = command.ExecuteReader();

                                while (resultado.Read())
                                {
                                    pessoas.Add(new Pessoa(resultado.GetInt32(resultado.GetOrdinal("Id")),
                                                           resultado.GetString(resultado.GetOrdinal("Nome"))));
                                }
                            }
                            Console.WriteLine("\n========Listagem========");
                            foreach (Pessoa p in pessoas)
                            {
                                Console.WriteLine("\n\n========Inicio========");
                                Console.WriteLine("Id: " + p.Id);
                                Console.WriteLine("Nome: " + p.Nome);
                                Console.WriteLine("========Fim========");
                            }

                            Console.WriteLine("\nQual id deseja Apagar um telefone ?");
                            int id = Convert.ToInt32(Console.ReadLine());
                            if (id <= pessoas.Count)
                            {
                                var query2 = @"SELECT t.Id as IdTelefone, t.DDD as DDD, t.Numero as Numero FROM Pessoa p INNER JOIN Telefone t ON p.Id = @id";
                                using (var sql = new SqlConnection(connection))
                                {
                                    SqlCommand command = new SqlCommand(query2, sql);
                                    command.Parameters.AddWithValue("@id", id);
                                    command.Connection.Open();
                                    resultado = command.ExecuteReader();

                                    while (resultado.Read())
                                    {
                                        pessoas[0].Telefone.Add(new Telefone(resultado.GetInt32(resultado.GetOrdinal("IdTelefone")),
                                                                             resultado.GetString(resultado.GetOrdinal("DDD")),
                                                                             resultado.GetString(resultado.GetOrdinal("Numero"))));
                                    }
                                }

                                foreach (Pessoa p in pessoas)
                                {
                                    foreach (Telefone t in p.Telefone)
                                    {
                                        Console.WriteLine("\nTelefone: ");
                                        Console.WriteLine("Id: " + t.Id);
                                        Console.WriteLine("DDD: " + t.DDD);
                                        Console.WriteLine("Número: " + t.Numero);
                                    }
                                    Console.WriteLine("========Fim========");
                                }

                                Console.WriteLine("Qual Telefone deseja apagar ?");
                                int id2 = Convert.ToInt32(Console.ReadLine());

                                if(id2 <= pessoas[0].Telefone.Count)
                                {
                                    var query3 = @"delete from Telefone where IdPessoa = @idPessoa and Id = @idTelefone";
                                    using (var sql = new SqlConnection(connection))
                                    {
                                        SqlCommand command = new SqlCommand(query3, sql);
                                        command.Parameters.AddWithValue("@idPessoa", id);
                                        command.Parameters.AddWithValue("@idTelefone", id2);
                                        command.Connection.Open();
                                        resultado = command.ExecuteReader();
                                        Console.WriteLine("Delete realizado com sucesso.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Este Id de Telefone não existe.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Id de Pessoa inválido.");
                            }
                        }
                        catch(Exception ex)
                        {
                            throw;
                        }
                        break;

                    case 8:
                        pessoas.Clear();
                        telefones.Clear();
                        Console.WriteLine("\nListar Telefones usando o nome.");

                        try
                        {
                            Console.WriteLine("Informe o Nome: ");
                            string imput = Console.ReadLine();
                            bool existe = false;

                            SqlDataReader resultado;
                            var query = @"SELECT p.Id as IdPessoa, p.Nome as Nome from Pessoa p where p.Nome like @entrada";
                            using (var sql = new SqlConnection(connection))
                            {
                                SqlCommand command = new SqlCommand(query, sql);
                                command.Parameters.AddWithValue("@entrada", "%" + imput + "%");
                                command.Connection.Open();
                                resultado = command.ExecuteReader();

                                while(resultado.Read())
                                {
                                    pessoas.Add(new Pessoa(resultado.GetInt32(resultado.GetOrdinal("IdPessoa")),
                                                           resultado.GetString(resultado.GetOrdinal("Nome"))));
                                    existe = true;
                                }

                            }

                            if (existe)
                            {
                                var query2 = @"SELECT t.Id as IdTelefone, t.DDD as DDD, t.Numero as Numero FROM Pessoa p INNER JOIN Telefone t ON p.Nome like @entrada";
                                using (var sql = new SqlConnection(connection))
                                {
                                    SqlCommand command = new SqlCommand(query2, sql);
                                    command.Parameters.AddWithValue("@entrada", "%" + imput + "%");
                                    command.Connection.Open();
                                    resultado = command.ExecuteReader();

                                    while (resultado.Read())
                                    {
                                        pessoas[0].Telefone.Add(new Telefone(resultado.GetInt32(resultado.GetOrdinal("IdTelefone")),
                                                                             resultado.GetString(resultado.GetOrdinal("DDD")),
                                                                             resultado.GetString(resultado.GetOrdinal("Numero"))));
                                    }
                                }
                                Console.WriteLine("========Listagem========");
                                foreach (Pessoa p in pessoas)
                                {
                                    Console.WriteLine("========Inicio========");
                                    Console.WriteLine("Id: " + p.Id);
                                    Console.WriteLine("Nome: " + p.Nome);

                                    foreach (Telefone t in p.Telefone)
                                    {
                                        Console.WriteLine("\nTelefone: ");
                                        Console.WriteLine("Id: " + t.Id);
                                        Console.WriteLine("DDD: " + t.DDD);
                                        Console.WriteLine("Número: " + t.Numero);
                                    }
                                    Console.WriteLine("========Fim========");
                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            throw;
                        }
                        break;

                    case 9:

                        break;

                    default:
                        Console.WriteLine("OPÇÃO INVÁLIDA");
                        break;
                }
            } while (entrada != 010101);
        }
    }
}
