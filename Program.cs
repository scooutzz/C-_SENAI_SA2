// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa_SA2___ER2.Classes;




PessoaFisica metodoPf = new PessoaFisica(); //usado para chamar metodos

PessoaFisica novaPf = new PessoaFisica(); //usado somente para receber valores
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

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maio de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
");



PessoaJuridica metodoPj = new PessoaJuridica();

PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "Nome Pj";
novaPj.cnpj = "00.000.000/0001-00";
novaPj.razaoSocial = "Razão Social Pj";
novaPj.rendimento = 8000.5f;

novoEndPj.logradouro = "Alameda Barão de Limeira";
novoEndPj.numero = 539;
novoEndPj.complemento = "SENAI Informatica";
novoEndPj.endComercial = true;

novaPj.endereco = novoEndPj;

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}
");
