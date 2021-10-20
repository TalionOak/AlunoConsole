using System;


namespace ConsoleApplication1
{
  class Program
  {
    static string cod;
    static string nome;
    static string cpfaluno;
    static string cpfresponsavel;
    static string responsavelnascimento;
    static string nascimento;
    static string telefone;
    static string endereco;
    static string email;
    static string cep;
    static string bairroesub;
    static string voltar = "s";
    static Tela tela = new Tela();
    static bool temAluno = false;

    static void CadastrarAluno()
    {
      nome = tela.ReceberrValorPedido("Nome do Aluno");
      nascimento = tela.ReceberrValorPedido("Data de Nascimento do Aluno");
      responsavelnascimento = tela.ReceberrValorPedido("Data de Nascimento do Responsavel");
      cpfaluno = tela.ReceberrValorPedido("CPF Do Aluno");
      cpfresponsavel = tela.ReceberrValorPedido("CPF Do Responsavel");
      telefone = tela.ReceberrValorPedido("Telefone Do Responsavel");
      cep = tela.ReceberrValorPedido("Correio Postal (CEP)");
      bairroesub = tela.ReceberrValorPedido("Bairro e SubBairro");
      endereco = tela.ReceberrValorPedido("Endereço");
      email = tela.ReceberrValorPedido("Email Do Responsavel");
    }

    static void Main(string[] args)
    {
      Database data;

      while (voltar == "s")
      {

        tela.ExibirMenu();

        Console.Write("Digite o Numero Da Opção : ");

        var leitura = Console.ReadLine();

        switch (leitura)
        {
          case "1":
            Console.Clear(); //=======COR===============================================================
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ ▄▀█ █▀█     ▄▀█ █   █ █ █▄ █ █▀█");
            Console.WriteLine("█▄▄ █▀█ █▄▀ █▀█ ▄█  █  █▀▄ █▀█ █▀▄     █▀█ █▄▄ █▄█ █ ▀█ █▄█");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("");
            Console.WriteLine("");

            tela.ExibirCabecalho();
            cod = tela.ReceberrValorPedido("Numero de matricula");
            CadastrarAluno();
            tela.FecharCabecalho();

            data = new Database();
            data.ExecuteSqlInsertOrUpdateOrDelete("insert into alunos(cod_alunos,nome_alun,responsavel_nascimento,nascimento,cpf_aluno,cpf_responsavel,telefone,endereco,email,codigopostal,bairroesub) values ('" + cod + "','" + nome + "','" + responsavelnascimento + "','" + nascimento + "','" + cpfaluno + "','" + cpfresponsavel + "','" + telefone + "','" + endereco + "','" + email + "','" + cep + "','" + bairroesub + "')");

            Console.WriteLine("Aluno Cadastrado " + "'" + nome + "'" + " Com Êxito!");
            Console.Write("Deseja voltar para o menu:(S/N) ");
            voltar = Console.ReadLine().ToLower();
            break;
          case "2":
            Console.Clear(); //=======COR===============================================================
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("▄▀█ █   ▀█▀ █▀▀ █▀█ ▄▀█ █▀█     ▄▀█ █   █ █ █▄ █ █▀█");
            Console.WriteLine("█▀█ █▄▄  █  ██▄ █▀▄ █▀█ █▀▄     █▀█ █▄▄ █▄█ █ ▀█ █▄█");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("");
            Console.WriteLine("");
            tela.ExibirCabecalho();
            cod = tela.ReceberrValorPedido("Entre com o N° de matricula do aluno");

            data = new Database();
            temAluno = data.ExecuteSqlHasData("Select * from alunos where cod_alunos='" + cod + "'");

            if (temAluno)
            {
              CadastrarAluno();
              tela.FecharCabecalho();

              data = new Database();
              data.ExecuteSqlInsertOrUpdateOrDelete("update alunos set nome_alun='" + nome + "',NASCIMENTO= '" + nascimento + "', responsavel_nascimento= '" + responsavelnascimento + "', cpf_aluno= '" + cpfaluno + "', cpf_responsavel= '" + cpfresponsavel + "', telefone= '" + telefone + "', codigopostal= '" + cep + "', bairroesub= '" + bairroesub + "', endereco= '" + endereco + "', email= '" + email + "'  where cod_alunos='" + cod + "'");

              Console.Write("Deseja voltar para o menu:(S/N) ");
              voltar = Console.ReadLine();

            } else
            {
              Console.WriteLine("RAluno Não Encontrado!");
              Console.Write("Deseja voltar para o menu:(S/N) ");
              voltar = Console.ReadLine();
            }
            break;
          case "3":
            Console.Clear(); //=======COR===============================================================
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("█▀▀ ▀▄▀ █▀▀ █   █ █ █ █▀█   ▄▀█ █   █ █ █▄ █ █▀█");
            Console.WriteLine("██▄ █░█ █▄▄ █▄▄ █▄█ █ █▀▄   █▀█ █▄▄ █▄█ █ ▀█ █▄█");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("");
            Console.WriteLine("");
            cod = tela.ReceberrValorPedido("Entre com o código do aluno");

            data = new Database();
            var aluno = data.ExecuteSqlRead("Select * from alunos where cod_alunos='" + cod + "'");

            if (aluno != null)
            {
              string desejaexcluir = tela.ReceberrValorPedido("Tem certeza que deseja excluir o aluno  '" + aluno.Nome + "'?(S/N)");

              if (desejaexcluir == "s")
              {
                data = new Database();
                data.ExecuteSqlInsertOrUpdateOrDelete("delete from  alunos where cod_alunos='" + aluno.CodAluno + "'");

                voltar = tela.ReceberrValorPedido("Deseja voltar para o menu:(S/N)");
              } else
              {
                voltar = tela.ReceberrValorPedido("Deseja voltar para o menu:(S/N)");
              }

            } else
            {
              Console.WriteLine("Registro Não Encontrado!");
              voltar = tela.ReceberrValorPedido("Deseja voltar para o menu:(S/N)");
            }
            break;
          case "4":
            Console.Clear();

            data = new Database();

            Console.WriteLine("Alunos Cadastrados");
            Console.WriteLine("");

            foreach (var item in data.GetAllAlunos())
            {
              Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine("════════════════════════════════════════════════════════════════════════════════════════════");
              Console.WriteLine(String.Format("{0, -20}{1, -30}{2, -20}{3, -20}", "CÓDIGO", "NOME", "NASCIMENTO", "CPF DO ALUNO"));
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine(String.Format("{0, -20}{1, -30}{2, -20}{3, -20}", item.CodAluno, item.Nome, item.Nascimento, item.CPF));


              Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine(String.Format("{0, -30}{1, -30}{2, -30}{3, -22}", "EMAIL", "NASCIMENTO DO RESPONSAVEL", "CPF DO RESPONSAVEL", "TELEFONE"));
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine(String.Format("{0, -30}{1, -30}{2, -30}{3, -22}", item.Email, item.ResponsavelNascimento, item.ResponsavelCPF, item.Telefone));


              Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine(String.Format("{0, -20}{1, -30}{2, -20}", "CÓDIGO POSTAL", "BAIRRO", "ENDEREÇO"));
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine(String.Format("{0, -20}{1, -30}{2, -20}", item.CodigoPostal, item.Bairro, item.Endereco));

            }

            Console.Write("Deseja voltar para o menu:(S/N) ");
            voltar = Console.ReadLine();
            break;
        }
      }
    }
  }
}
