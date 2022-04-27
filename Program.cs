using Cadastro_Pessoa_SA2___ER2.Classes;


Console.WriteLine(@$"
=================================================
|       Bem vindo ao sistema de cadastro de     |
|           Pessoas Físicas e Jurídicas         |
=================================================
");

BarraCarregamento("Carregando ", 500);

Console.Clear();

string? opcao;
do
{
    Console.WriteLine(@$"
=================================================
|           Escolha uma das opções abaixo       |
|-----------------------------------------------|
|           1 - Pessoa Físcia                   |
|           2 - Pessoa Jurídica                 |
|                                               |
|           0 - Sair                            |
=================================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
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

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {(metodoPf.ValidarDataNascimento(novaPf.dataNascimento) ? "Sim" : "Não")}
Taxa de imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString("C")}
");

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();

            break;

        case "2":
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

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ válido: {(metodoPj.ValidarCnpj(novaPj.cnpj) ? "Sim" : "Não")}
Taxa de imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
");

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();

            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema");

            BarraCarregamento("Finalizando ", 300);

            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digiter outra opção");
            Thread.Sleep(2000);
            break;
    }

} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.Black;

    Console.Write($"{texto}");

    for (var contador = 0; contador < 10; contador++)
    {
        Console.Write(". ");
        Thread.Sleep(tempo);
    }

    Console.ResetColor();
    Console.Clear();
}