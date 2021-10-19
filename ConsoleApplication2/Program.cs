using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;


namespace ConsoleApplication1
{
  class Program
  {
    static void Main(string[] args)
    {
      //127.0.0.1 localhost 
      //private const string conn = "Server=fanny.db.elephantsql.com;Port=5432;User Id=poirawsh;Password=mfIOfIxr7rrNxrtBYQSBzZw6gnzsSmK0;Database=poirawsh;";
      //NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=pgadmin;Database=fecip;");
      string conn = "Server=TALIONDESEKTOP;Database=alunosdb;";

      Database data = new Database(conn);


      string cod, cod_alter, nome, nomedoresponsavel, cpfaluno, cpfresponsavel, responsavelnascimento, nascimento, telefone, endereco, email, cep, bairroesub, voltar = "s";


      while (voltar == "s")
      {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ Cadastro de Alunos ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("╔═════════════════MENU DE OPÇÕES════════════════╗    ");
        Console.WriteLine("║ 1 Cadastrar Aluno                             ║    ");
        Console.WriteLine("║                                               ║    ");
        Console.WriteLine("║ 2 Alterar  Aluno                              ║    ");
        Console.WriteLine("║                                               ║    ");
        Console.WriteLine("║ 3 Excluir Aluno                               ║    ");
        Console.WriteLine("║                                               ║    ");
        Console.WriteLine("║ 4 Consultar Registro de Aluno                 ║    ");
        Console.WriteLine("║                                               ║    ");
        Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
        Console.WriteLine(" ");

        Console.Write("Digite o Numero Da Opção : ");

        var leitura = Console.ReadLine();

        if (leitura == "1")
        {
          Console.Clear(); //=======COR===============================================================
          Console.BackgroundColor = ConsoleColor.White;
          Console.ForegroundColor = ConsoleColor.Blue;

          Console.WriteLine("█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ ▄▀█ █▀█     ▄▀█ █   █ █ █▄ █ █▀█");
          Console.WriteLine("█▄▄ █▀█ █▄▀ █▀█ ▄█  █  █▀▄ █▀█ █▀▄     █▀█ █▄▄ █▄█ █ ▀█ █▄█");

          Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.Green;

          Console.WriteLine("");
          Console.WriteLine("");

          Console.WriteLine("╔════════════════════════╗");
          Console.Write("║♦ Numero de matricula: ");
          Console.ForegroundColor = ConsoleColor.White;
          cod = Console.ReadLine();
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write("║♦ Nome do Aluno: ");
          Console.ForegroundColor = ConsoleColor.White;
          nome = Console.ReadLine();
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write("║♦ Nome do Responsavel:");
          Console.ForegroundColor = ConsoleColor.White;
          nomedoresponsavel = Console.ReadLine();
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write("║♦ Data de Nascimento do Aluno: ");
          Console.ForegroundColor = ConsoleColor.White;
          nascimento = Console.ReadLine();
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write("║♦ Data de Nascimento do Responsavel: ");
          Console.ForegroundColor = ConsoleColor.White;
          responsavelnascimento = Console.ReadLine();
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write("║♦ CPF Do Aluno: ");
          Console.ForegroundColor = ConsoleColor.White;
          cpfaluno = Console.ReadLine();
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write("║♦ CPF Do Responsavel: ");
          Console.ForegroundColor = ConsoleColor.White;
          cpfresponsavel = Console.ReadLine();
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write("║♦ Telefone Do Responsavel: ");
          Console.ForegroundColor = ConsoleColor.White;
          telefone = Console.ReadLine();
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write("║♦ Correio Postal (CEP): ");
          Console.ForegroundColor = ConsoleColor.White;
          cep = Console.ReadLine();
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write("║♦ Bairro e SubBairro: ");
          Console.ForegroundColor = ConsoleColor.White;
          bairroesub = Console.ReadLine();
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write("║♦ Endereço: ");
          Console.ForegroundColor = ConsoleColor.White;
          endereco = Console.ReadLine();
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write("║♦ Email Do Responsavel: ");
          Console.ForegroundColor = ConsoleColor.White;
          email = Console.ReadLine();
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("╚════════════════════════╝");

          conn.Open();

          string cmdSeleciona = "insert into alunos(cod_alunos,nome_alun,nome_responsavel,responsavel_nascimento,nascimento,cpf_aluno,cpf_responsavel,telefone,endereco,email,codigopostal,bairroesub) values ('" + cod + "','" + nome + "','" + nomedoresponsavel + "','" + responsavelnascimento + "','" + nascimento + "','" + cpfaluno + "','" + cpfresponsavel + "','" + telefone + "','" + endereco + "','" + email + "','" + cep + "','" + bairroesub + "')";

          NpgsqlCommand Lcmd = new NpgsqlCommand(cmdSeleciona, conn);
          Lcmd.ExecuteReader();
          conn.Close();
          Console.WriteLine("Aluno Cadastrado " + "'" + nome + "'" + " Com Êxito!");
          Console.Write("Deseja voltar para o menu:(S/N) ");
          voltar = Console.ReadLine();
        }

        if (leitura == "4")
        {
          Console.Clear();

          conn.Open();

          string cmdSeleciona = "Select * from alunos";

          NpgsqlCommand Lcmd = new NpgsqlCommand(cmdSeleciona, conn);
          NpgsqlDataReader lect = Lcmd.ExecuteReader();

          //OBJ DATAREADER "DADOS" -> RECEBE O RESULTADO DA CONSULTA 

          Console.WriteLine("Alunos Cadastrados");
          Console.WriteLine("");
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine("════════════════════════════════════════════════════════════════════════════════════════════");
          Console.WriteLine(String.Format("{0, -20}{1, -30}{2, -20}{3, -20}", "CÓDIGO", "NOME", "NASCIMENTO", "CPF DO ALUNO"));

          while (lect.Read())
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(String.Format("{0, -20}{1, -30}{2, -20}{3, -20}", lect["cod_alunos"], lect["nome_alun"], lect["nascimento"], lect["cpf_aluno"]));

          }

          NpgsqlCommand Lcmdd = new NpgsqlCommand(cmdSeleciona, conn);
          NpgsqlDataReader lectt = Lcmd.ExecuteReader();

          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine(String.Format("{0, -30}{1, -30}{2, -30}{3, -22}{4, -30}", "EMAIL DO RESPONSAVEL", "NOME DO RESPONSAVEL", "NASCIMENTO DO RESPONSAVEL", "CPF DO RESPONSAVEL", "TELEFONE"));

          while (lectt.Read())
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(String.Format("{0, -30}{1, -30}{2, -30}{3, -22}{4, -30}", lectt["email"], lectt["nome_responsavel"], lectt["responsavel_nascimento"], lectt["cpf_responsavel"], lectt["telefone"]));

          }

          NpgsqlCommand Lcmddd = new NpgsqlCommand(cmdSeleciona, conn);
          NpgsqlDataReader lecttt = Lcmd.ExecuteReader();

          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine(String.Format("{0, -20}{1, -30}{2, -20}", "CÓDIGO POSTAL", "BAIRRO", "ENDEREÇO"));

          while (lecttt.Read())
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(String.Format("{0, -20}{1, -30}{2, -20}", lecttt["codigopostal"], lecttt["bairroesub"], lecttt["endereco"]));

          }

          conn.Close();
          Console.Write("Deseja voltar para o menu:(S/N) ");
          voltar = Console.ReadLine();
        }

        if (leitura == "2")
        {
          Console.Clear(); //=======COR===============================================================
          Console.BackgroundColor = ConsoleColor.White;
          Console.ForegroundColor = ConsoleColor.Blue;

          Console.WriteLine("▄▀█ █   ▀█▀ █▀▀ █▀█ ▄▀█ █▀█     ▄▀█ █   █ █ █▄ █ █▀█");
          Console.WriteLine("█▀█ █▄▄  █  ██▄ █▀▄ █▀█ █▀▄     █▀█ █▄▄ █▄█ █ ▀█ █▄█");

          Console.BackgroundColor = ConsoleColor.Black;
          Console.ForegroundColor = ConsoleColor.White;

          Console.WriteLine("");
          Console.WriteLine("");
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("╔════════════════════════════════════╗");
          Console.Write("║♦ Entre com o N° de matricula do aluno :");
          Console.ForegroundColor = ConsoleColor.White;
          cod = Console.ReadLine();

          conn.Open();

          string cmdSeleciona = "Select * from alunos where cod_alunos='" + cod + "'";

          NpgsqlCommand Lcmd = new NpgsqlCommand(cmdSeleciona, conn);
          NpgsqlDataReader lect = Lcmd.ExecuteReader();

          if (lect.Read())
          {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("║♦ Nome do Aluno: ");
            Console.ForegroundColor = ConsoleColor.White;
            nome = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("║♦ Nome do Responsavel:");
            Console.ForegroundColor = ConsoleColor.White;
            nomedoresponsavel = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("║♦ Data de Nascimento do Aluno: ");
            Console.ForegroundColor = ConsoleColor.White;
            string nascimentoU;
            nascimentoU = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("║♦ Data de Nascimento do Responsavel: ");
            Console.ForegroundColor = ConsoleColor.White;
            responsavelnascimento = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("║♦ CPF Do Aluno: ");
            Console.ForegroundColor = ConsoleColor.White;
            cpfaluno = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("║♦ CPF Do Responsavel: ");
            Console.ForegroundColor = ConsoleColor.White;
            cpfresponsavel = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("║♦ Telefone Do Responsavel: ");
            Console.ForegroundColor = ConsoleColor.White;
            telefone = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("║♦ Correio Postal (CEP): ");
            Console.ForegroundColor = ConsoleColor.White;
            cep = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("║♦ Bairro e SubBairro: ");
            Console.ForegroundColor = ConsoleColor.White;
            bairroesub = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("║♦ Endereço: ");
            Console.ForegroundColor = ConsoleColor.White;
            endereco = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("║♦ Email Do Responsavel: ");
            Console.ForegroundColor = ConsoleColor.White;
            email = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╚════════════════════════╝");

            conn1.Open();

            string cmdupdate = "update alunos set nome_alun='" + nome + "', nome_responsavel= '" + nomedoresponsavel + "',NASCIMENTO= '" + nascimentoU + "', responsavel_nascimento= '" + responsavelnascimento + "', cpf_aluno= '" + cpfaluno + "', cpf_responsavel= '" + cpfresponsavel + "', telefone= '" + telefone + "', codigopostal= '" + cep + "', bairroesub= '" + bairroesub + "', endereco= '" + endereco + "', email= '" + email + "'  where cod_alunos='" + lect["cod_alunos"] + "'";

            NpgsqlCommand Ucmd = new NpgsqlCommand(cmdupdate, conn1);
            Ucmd.ExecuteReader();
            conn1.Close();
            conn.Close();
            Console.Write("Deseja voltar para o menu:(S/N) ");
            voltar = Console.ReadLine();

          } else
          {
            Console.WriteLine("RAluno Não Encontrado!");
            Console.Write("Deseja voltar para o menu:(S/N) ");
            voltar = Console.ReadLine();

          }
        }

        if (leitura == "3")
        {
          Console.Clear(); //=======COR===============================================================
          Console.ForegroundColor = ConsoleColor.Red;

          Console.WriteLine("█▀▀ ▀▄▀ █▀▀ █   █ █ █ █▀█   ▄▀█ █   █ █ █▄ █ █▀█");
          Console.WriteLine("██▄ █░█ █▄▄ █▄▄ █▄█ █ █▀▄   █▀█ █▄▄ █▄█ █ ▀█ █▄█");

          Console.ForegroundColor = ConsoleColor.White;

          Console.WriteLine("");
          Console.WriteLine("");
          Console.ForegroundColor = ConsoleColor.Green;
          Console.Write("♦ Entre com o código do aluno: ");
          Console.ForegroundColor = ConsoleColor.White;
          cod = Console.ReadLine();

          conn.Open();

          string cmdSeleciona = "Select * from alunos where cod_alunos='" + cod + "'";

          NpgsqlCommand Lcmd = new NpgsqlCommand(cmdSeleciona, conn);
          NpgsqlDataReader lect = Lcmd.ExecuteReader();

          if (lect.Read())
          {
            string desejaexcluir = "";
            string codigoexcluir;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("♦ Tem certeza que deseja excluir o aluno  '" + lect["nome_alun"] + "'?(S/N) ");
            Console.ForegroundColor = ConsoleColor.White;
            desejaexcluir = Console.ReadLine();


            if (desejaexcluir == "s")
            {

              conn1.Open();

              string cmdupdate = "delete from  alunos where cod_alunos='" + lect["cod_alunos"] + "'";

              NpgsqlCommand Ucmd = new NpgsqlCommand(cmdupdate, conn1);
              Ucmd.ExecuteReader();
              conn1.Close();
              Console.ForegroundColor = ConsoleColor.Green;
              Console.Write("Deseja voltar para o menu:(S/N) ");
              Console.ForegroundColor = ConsoleColor.White;
              voltar = Console.ReadLine();
            } else
            {
              Console.Write("Deseja voltar para o menu:(S/N) ");
              voltar = Console.ReadLine();
            }


          } else
          {
            Console.WriteLine("Registro Não Encontrado!");
            Console.Write("Deseja voltar para o menu:(S/N) ");
            voltar = Console.ReadLine();

          }
        }
      }
    }
  }
}
