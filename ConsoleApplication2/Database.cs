using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  public class Database
  {
    string _connectionString;
    NpgsqlConnection _connection;

    public Database(string connectionString = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=senha123;Database=alunosdb;")
    {
      this._connectionString = connectionString;
    }

    private NpgsqlDataReader ExecuteSql(string sqlQuery)
    {
      this._connection = new NpgsqlConnection(this._connectionString);
      this._connection.Open();

      NpgsqlCommand command = new NpgsqlCommand(sqlQuery, this._connection);
      return command.ExecuteReader();
    }

    public void ExecuteSqlInsertOrUpdateOrDelete(string sqlQuery)
    {
      ExecuteSql(sqlQuery);
      this._connection.Close();
    }

    public Aluno ExecuteSqlRead(string sqlQuery)
    {
      NpgsqlDataReader reader = ExecuteSql(sqlQuery);
      Aluno aluno = new Aluno();

      while (reader.Read())
      {
        aluno.CodAluno = Convert.ToInt32(reader["cod_alunos"]);
        aluno.Nome = reader["nome_alun"].ToString();
        aluno.Nascimento = reader["nascimento"].ToString();
        aluno.CPF = reader["cpf_aluno"].ToString();
        aluno.Telefone = reader["telefone"].ToString();
        aluno.Endereco = reader["endereco"].ToString();
        aluno.Email = reader["email"].ToString();
        aluno.CodigoPostal = reader["codigopostal"].ToString();
        aluno.Bairro = reader["bairroesub"].ToString();
        aluno.ResponsavelNascimento = reader["responsavel_nascimento"].ToString();
        aluno.ResponsavelCPF = reader["cpf_responsavel"].ToString();
      }

      this._connection.Close();
      return aluno;
    }

    public IEnumerable<Aluno> GetAllAlunos()
    {
      NpgsqlDataReader reader = ExecuteSql("Select * from alunos");
      var alunos = new Collection<Aluno>();

      while (reader.Read())
      {
        Aluno aluno = new Aluno();
        aluno.CodAluno = Convert.ToInt32(reader["cod_alunos"]);
        aluno.Nome = reader["nome_alun"].ToString();
        aluno.Nascimento = reader["nascimento"].ToString();
        aluno.CPF = reader["cpf_aluno"].ToString();
        aluno.Telefone = reader["telefone"].ToString();
        aluno.Endereco = reader["endereco"].ToString();
        aluno.Email = reader["email"].ToString();
        aluno.CodigoPostal = reader["codigopostal"].ToString();
        aluno.Bairro = reader["bairroesub"].ToString();
        aluno.ResponsavelNascimento = reader["responsavel_nascimento"].ToString();
        aluno.ResponsavelCPF = reader["cpf_responsavel"].ToString();
        yield return aluno;
      }

      this._connection.Close();
    }

    public bool ExecuteSqlHasData(string sqlQuery)
    {
      NpgsqlDataReader reader = ExecuteSql(sqlQuery);
      if (reader.Read())
      {
        this._connection.Close();
        return true;
      }
      this._connection.Close();
      return false;
    }
  }
}
