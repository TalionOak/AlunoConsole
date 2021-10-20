using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public class Tela
  {
    public void ExibirMenu()
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
    }

    public void ExibirCabecalho()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("╔════════════════════════╗");
    }
    public void FecharCabecalho()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("╚════════════════════════╝");
    }

    public string ReceberrValorPedido(string mensagem)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write($"║♦ {mensagem}: ");
      Console.ForegroundColor = ConsoleColor.White;
      return Console.ReadLine();
    }
  }
}
