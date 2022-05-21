// See https://aka.ms/new-console-template for more information



using BE5.Classes;

Console.WriteLine(@$"
===============================================================
|           Bem vindo ao sistema de cadastro de               |  
|              Pessoas Físicas e Jurídicas                    |                         
===============================================================

");

BarraCarregamento("Carregando", 500);

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

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
      PessoaFisica metodoPf = new PessoaFisica();

      string? opcaoPf;
      do
      {
        Console.Clear();
        Console.WriteLine(@$"
          ===============================================================
          |                Escolha uma das opções abaixo:               |      
          |-------------------------------------------------------------|
          |                 1 - Cadastrar Pessoa Física                 |
          |                 2 - Mostar pessoas Físicas                  |
          |                                                             |
          |                 0 - Voltar ao menu anterior                 |                   
          ===============================================================
          ");
        opcaoPf = Console.ReadLine();

        switch (opcaoPf)
        {
          case "1":

            PessoaFisica novaPF = new PessoaFisica();
            Endereco novoEnd = new Endereco();

            Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar:");
            novaPF.nome = Console.ReadLine();


            bool dataValida;
            do
            {
              Console.WriteLine($"Digite a data de nascimento: Ex:DD/MM/AAAA");
              string dataNasc = Console.ReadLine();

              dataValida = metodoPf.ValidarDataNascimento(dataNasc);
              if (dataValida)
              {
                novaPF.dataNascimento = dataNasc;
              }
              else
              {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Data inválida, por favor digite uma data válida");
                Console.ResetColor();

              }
            } while (dataValida == false);

            Console.WriteLine($"Digite o número do CPF:");
            novaPF.cpf = Console.ReadLine();

            Console.WriteLine($"Digite o rendimento mensal:(digite apenas números)");
            novaPF.rendimento = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o logradouro:");
            novoEnd.logradouro = Console.ReadLine();

            Console.WriteLine($"Digite o número:");
            novoEnd.numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o complemento:(aparete ENTER para vazio)");
            novoEnd.complemento = Console.ReadLine();

            Console.WriteLine($"Este endereço é comercial? S/N");
            string endCom = Console.ReadLine().ToUpper();
            if (endCom == "S")
            {
              novoEnd.endComercial = true;
            }
            else
            {
              novoEnd.endComercial = false;
            }
            novaPF.endereco = novoEnd;
            listaPf.Add(novaPF);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Cadastro realizado com sucesso!!!");
            Console.ResetColor();
            Thread.Sleep(3000);
            //Console.Clear();

            break;

          case "2":

            Console.Clear();
            if (listaPf.Count > 0)
            {
              foreach (PessoaFisica cadaPessoa in listaPf)
              {
                Console.Clear();
                Console.WriteLine(@$"
                    Nome: {cadaPessoa.nome}
                    Endereco: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
                    Data de Nascimento: {cadaPessoa.dataNascimento}
                    Taxa de imposot a ser paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                    ");
                Console.WriteLine($"Aperte 'Enter' para continuar...");
                Console.ReadLine();
              }

            }
            else
            {
              Console.WriteLine($"Lista Vazia!!!");
              Thread.Sleep(3000);

            }
            break;

          case "0":
            break;
          default:
            Console.Clear();
            Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
            Thread.Sleep(2000);
            break;
        }
      } while (opcaoPf != "0");
      break;

    case "2":

      PessoaJuridica metodoPj = new PessoaJuridica();

      string? opcaoPj;
      do
      {
        Console.Clear();
        Console.WriteLine(@$"
          ===============================================================
          |                Escolha uma das opções abaixo:               |      
          |-------------------------------------------------------------|
          |                 1 - Cadastrar Pessoa Jurídica               |
          |                 2 - Mostar pessoas Jurídicas                |
          |                                                             |
          |                 0 - Voltar ao menu anterior                 |                   
          ===============================================================
          ");
        opcaoPj = Console.ReadLine();
        switch (opcaoPj)
        {
          case "1":

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            Console.WriteLine($"Digite o nome da Pessoa Jurídica:");
            novaPj.nome = Console.ReadLine();

            bool cnpjValido;
            do
            {
              Console.WriteLine($"Digite o número do CNPJ:");
              string cnpj = Console.ReadLine();

              cnpjValido = metodoPj.ValidarCnpj(cnpj);
              if (cnpjValido)
              {
                novaPj.cnpj = cnpj;
              }
              else
              {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"CNPJ inválido, por favor digite um número de CNPJ válido");
                Console.ResetColor();

              }
            } while (cnpjValido == false);



            //novaPj.cnpj = Console.ReadLine();


            Console.WriteLine($"Digite a razão social:");
            novaPj.razao = Console.ReadLine();

            Console.WriteLine($"Digite o rendimento mensal:(digite apenas núemros)");
            novaPj.rendimento = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o endereço:");
            novoEndPj.logradouro = Console.ReadLine();

            Console.WriteLine($"Digite o número:");
            novoEndPj.numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o complemento: (aperte 'ENTER' para vazio)");
            novoEndPj.complemento = Console.ReadLine();

            Console.WriteLine($"Este endereço é comercial? S/N");
            string endCom = Console.ReadLine().ToUpper();
            if (endCom == "S")
            {
              novoEndPj.endComercial = true;
            }
            else
            {
              novoEndPj.endComercial = false;
            }
            novaPj.endereco = novoEndPj;
            listaPj.Add(novaPj);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Cadastro realizado com sucesso!!!");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;

          case "2":
            Console.Clear();
            if (listaPj.Count > 0)
            {
              foreach (PessoaJuridica cadaPj in listaPj)
              {
                Console.Clear();
                Console.WriteLine(@$"
                      Nome: {cadaPj.nome}
                      Razao Social: {cadaPj.razao}
                      CNPJ: {cadaPj.cnpj}
                      Taxa de imposot a ser paga é: {metodoPj.PagarImposto(cadaPj.rendimento).ToString("C")}
                      ");
                Console.WriteLine($"Aperte 'Enter' para continuar...");
                Console.ReadLine();
              }
            }
            else
            {
              Console.WriteLine($"Lista Vazia!!!");
              Thread.Sleep(3000);
            }
            break;


          case "0":
            break;

          default:
            Console.Clear();
            Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
            Thread.Sleep(2000);
            break;
        }
      } while (opcaoPj != "0");
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
































