using Cadastro_Pessoa_SA2___ER2.Classes;


Console.WriteLine(@$"
=================================================
|       Bem vindo ao sistema de cadastro de     |
|           Pessoas Físicas e Jurídicas         |
=================================================
");

BarraCarregamento("Carregando ", 500);

List<PessoaFisica> listaPf = new List<PessoaFisica>();

string? opcao;
do
{
    Console.Clear();
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

            string? opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
=================================================
|           Escolha uma das opções abaixo       |
|-----------------------------------------------|
|           1 - Cadastrar Pessoa Físcia         |
|           2 - Mostrar Pessoas Físicas         |
|                                               |
|           0 - Voltar ao menu anterior         |
=================================================
");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica(); //usado somente para receber valores
                        Endereco novoEnd = new Endereco();

                        Console.Clear();
                        Console.WriteLine($"Digite o nome da Pessoa Física que deseja cadastrar");
                        novaPf.nome = Console.ReadLine();

                        bool dataValida;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine($"Digite a data de nascimento. Ex.:DD/MM/AAAA");
                            string? dataNasc = Console.ReadLine();

                            dataValida = metodoPf.ValidarDataNascimento(dataNasc);
                            if (dataValida)
                            {
                                novaPf.dataNascimento = dataNasc;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada inválida. Por favor digite a data novamente");
                                Console.ResetColor();
                                Thread.Sleep(3000);
                            }

                        } while (dataValida == false);

                        Console.Clear();
                        Console.WriteLine($"Digite o número do CPF");
                        novaPf.cpf = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine($"Digite o rendimento mensal (Digite somente números)");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine($"Digite o logradouro");
                        novoEnd.logradouro = Console.ReadLine();


                        Console.Clear();
                        Console.WriteLine($"Digite o número");
                        novoEnd.numero = int.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine($"Digite o complemento (Aperte 'ENTER' para vazio)");
                        novoEnd.complemento = Console.ReadLine();

                        Console.Clear();
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

                        novaPf.endereco = novoEnd;

                        listaPf.Add(novaPf);

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Thread.Sleep(3000);
                        Console.ResetColor();


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
Data de nascimento: {cadaPessoa.dataNascimento}
Taxa de imposto a ser paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
");

                                Console.WriteLine($"Aperte 'Enter' para continuar");
                                Console.ReadLine();
                            }

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Lista vazia");
                            Thread.Sleep(3000);
                        }


                        break;

                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida, por favor digiter outra opção");
                        Thread.Sleep(2000);
                        break;
                }



            } while (opcaoPf != "0");

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