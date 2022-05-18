// See https://aka.ms/new-console-template for more information



using BE5.Classes;
/*
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
*/
/*
Console.WriteLine(@$"
Nome: {novaPF.nome}
Endereco: {novaPF.endereco.logradouro}, {novaPF.endereco.numero}
Maior de idade: {novaPF.ValidarDataNascimento(novaPF.dataNascimento)}
");
*/

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

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razao Social: {novaPj.razao}
CNPJ: {novaPj.cnpj}
CNPJ VÁLIDO? {metodoPj.ValidarCnpj(novaPj.cnpj)}");



//Console.WriteLine($"{metodoPj.ValidarCnpj("00.000.000/0001-00")}");
//Console.WriteLine($"{metodoPj.ValidarCnpj("00000000000000")}");

//Console.WriteLine($"{metodoPj.ValidarCnpj("00000000000100")}");
//Console.WriteLine($"{metodoPj.ValidarCnpj("00.000.000/0001-00")}");
























