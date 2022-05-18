// See https://aka.ms/new-console-template for more information



using BE5.Classes;

PessoaFisica novaPF = new PessoaFisica();
Endereco novoEnd = new Endereco();

//novaPF.ValidarDataNascimento(new DateTime(2000, 01, 01));
//novaPF.ValidarDataNascimento("01,01,2000");

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
Maior de idade: {novaPF.ValidarDataNascimento(novaPF.dataNascimento)}
");





