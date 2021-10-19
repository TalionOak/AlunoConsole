using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  public class Database
  {
    private string ConnectionString { get; set; }

    public Database(string connectionString)
    {
      this.ConnectionString = connectionString;
    }

    public void OpenConnection()
    {
      NpgsqlConnection conn = new NpgsqlConnection(this.ConnectionString);
      conn.Open();
    }
  }
}
