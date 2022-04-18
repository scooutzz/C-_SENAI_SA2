// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Cadastro_Pessoa_SA2___ER2.Classes;


PessoaFisica novaPf = new PessoaFisica();

// novaPf.nome = "Fabio";

// //cwl snippet
// Console.WriteLine("Nome: " + novaPf.nome);
// Console.WriteLine($"Nome: {novaPf.nome}");


novaPf.ValidarDataNascimento("01,01,2000");