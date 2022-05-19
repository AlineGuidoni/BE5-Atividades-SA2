// See https://aka.ms/new-console-template for more information



using BE5.Classes;

Console.WriteLine(@$"
===============================================================
|           Bem vindo ao sistema de cadastro de               |  
|              Pessoas Físicas e Jurídicas                    |                         
===============================================================

");

BarraCarregamento("Carregando", 500);

string? opcao;
do
{

  Console.Clear();
  Console.WriteLine(@$"
  ===============================================================
  |              Escolha uma das opções abaixo:                 |      
  |-------------------------------------------------------------|
  |                 1 - Pessoa Física                           |
  |                 2 - Pessoa Jurídica                         |
  |                                                             |
  |                 0 - Sair                                    |                   
  ===============================================================

");
  opcao = Console.ReadLine(); // variavel opção(utilização)

  switch (opcao)
  {
    case "0":
      Console.Clear();
      Console.WriteLine($"Obrigado por usar o nosso sistema!!!");
      BarraCarregamento("Finalizando ", 400);
      break;

    case "1":
      PessoaFisica novaPF = new PessoaFisica();
      Endereco novoEnd = new Endereco();
      PessoaFisica metodoPf = new PessoaFisica();
      novaPF.nome = "Aline";
      novaPF.dataNascimento = "06/12/1984";
      novaPF.cpf = "12345678019";
      novaPF.rendimento = 1000.0f;
      novoEnd.logradouro = "Alameda Barao de Limeira";
      novoEnd.numero = 999;
      novoEnd.complemento = "Centro de Informatica";
      novoEnd.endComercial = true;
      novaPF.endereco = novoEnd;


      Console.WriteLine(@$"
          Nome: {novaPF.nome}
          Endereco: {novaPF.endereco.logradouro}, {novaPF.endereco.numero}
          Maior de idade: {metodoPf.ValidarDataNascimento(novaPF.dataNascimento)}
        ");
      Console.WriteLine($"Aperte 'Enter' para continuar...");
      Console.ReadLine();

      break;
    case "2":
      PessoaJuridica metodoPj = new PessoaJuridica();
      PessoaJuridica novaPj = new PessoaJuridica();
      Endereco novoEndPj = new Endereco();
      novaPj.nome = "Nome PJ";
      novaPj.cnpj = "00.000.000/0001-00";
      novaPj.razao = "Razao social Pj";
      novaPj.rendimento = 9000.0f;
      novoEndPj.logradouro = "Alameda Barao de Limeira";
      novoEndPj.numero = 989;
      novoEndPj.complemento = "SENAI Centro de Informática";
      novoEndPj.endComercial = true;
      novaPj.endereco = novoEndPj;
      Console.Clear();
      Console.WriteLine(@$"
        Nome: {novaPj.nome}
        Razao Social: {novaPj.razao}
        CNPJ: {novaPj.cnpj}
        CNPJ VÁLIDO: {metodoPj.ValidarCnpj(novaPj.cnpj)}
      ");
      Console.WriteLine($"Aperte 'Enter' para continuar...");
      Console.ReadLine();

      break;

    default:
      Console.Clear();
      Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
      Thread.Sleep(2000);
      break;

  }
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo)
{
  Console.BackgroundColor = ConsoleColor.DarkCyan;
  Console.ForegroundColor = ConsoleColor.Red;

  Console.Write($"{texto} ");

  for (var contador = 0; contador < 10; contador++)
  {
    Console.Write(". ");
    Thread.Sleep(tempo);
  }
  Console.ResetColor();
}
































