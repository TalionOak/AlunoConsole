using System;

namespace ConsoleApplication1
{
  public class Aluno
  {
    public int CodAluno { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Nascimento { get; set; }
    public string Telefone { get; set; }
    public string Endereco { get; set; }
    public string Email { get; set; }
    public string CodigoPostal { get; set; }
    public string Bairro { get; set; }

    public string ResponsavelCPF { get; set; }
    public string ResponsavelNascimento { get; set; }

    public void ExibirNoConsole()
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("════════════════════════════════════════════════════════════════════════════════════════════");
      Console.WriteLine(String.Format("{0, -20}{1, -30}{2, -20}{3, -20}", "CÓDIGO", "NOME", "NASCIMENTO", "CPF DO ALUNO"));
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(String.Format("{0, -20}{1, -30}{2, -20}{3, -20}", this.CodAluno, this.Nome, this.Nascimento, this.CPF));

      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine(String.Format("{0, -30}{1, -30}{2, -30}{3, -22}", "EMAIL", "NASCIMENTO DO RESPONSAVEL", "CPF DO RESPONSAVEL", "TELEFONE"));
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(String.Format("{0, -30}{1, -30}{2, -30}{3, -22}", this.Email, this.ResponsavelNascimento, this.ResponsavelCPF, this.Telefone));

      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine(String.Format("{0, -20}{1, -30}{2, -20}", "CÓDIGO POSTAL", "BAIRRO", "ENDEREÇO"));
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(String.Format("{0, -20}{1, -30}{2, -20}", this.CodigoPostal, this.Bairro, this.Endereco));
    }
  }
}