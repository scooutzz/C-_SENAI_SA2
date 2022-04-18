// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa_SA2___ER2.Classes;


PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

novaPf.nome = "Fabio";
novaPf.dataNascimento = "07/08/2004";
novaPf.cpf = "1234567890";
novaPf.rendimento = 15000.5f;

novoEnd.logradouro = "Alameda Barão de Limeira";
novoEnd.numero = 539;
novoEnd.complemento = "SENAI Informatica";
novoEnd.endComercial = true;

novaPf.endereco = novoEnd;

// Console.WriteLine($"Nome: {novaPf.nome}");
// Console.WriteLine($"Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
");

