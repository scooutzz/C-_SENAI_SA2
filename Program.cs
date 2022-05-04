using Cadastro_Pessoa_SA2___ER2.Classes;


Console.Clear();
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

                        // listaPf.Add(novaPf);


                        // StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt");
                        // sw.Write(novaPf.nome);
                        // sw.Close();

                        using (StreamWriter sw = new StreamWriter($"CadastrosTxT/{novaPf.nome}.txt"))
                        {
                            sw.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}, {novaPf.endereco.complemento}
Data de nascimento: {novaPf.dataNascimento}
Taxa de imposto a ser paga: {metodoPf.PagarImposto(novaPf.rendimento).ToString("C")}
                            ");
                        }

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Thread.Sleep(3000);
                        Console.ResetColor();

                        break;

                    case "2":

                        Console.Clear();

//                         if (listaPf.Count > 0)
//                         {

//                             foreach (PessoaFisica cadaPf in listaPf)
//                             {
//                                 Console.Clear();
//                                 Console.WriteLine(@$"
// Nome: {cadaPf.nome}
// Endereco: {cadaPf.endereco.logradouro}, {cadaPf.endereco.numero}
// Data de nascimento: {cadaPf.dataNascimento}
// Taxa de imposto a ser paga é: {metodoPf.PagarImposto(cadaPf.rendimento).ToString("C")}
// ");

//                                 Console.WriteLine($"Aperte 'Enter' para continuar");
//                                 Console.ReadLine();
//                             }

//                         }
//                         else
//                         {
//                             Console.Clear();
//                             Console.WriteLine($"Lista vazia");
//                             Thread.Sleep(3000);
//                         }

                            Console.WriteLine($"Insira o nome da Pessoa Física que deseja. (Escreva da maneira que foi cadastrado)");
                            string txtPf = Console.ReadLine();
                            

                            using (StreamReader sr = new StreamReader($"CadastrosTxT/{txtPf}.txt"))
                            {
                                string linha;
                                while ((linha = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine($"{linha}");
                                }
                            }

                            Console.WriteLine($"Aperte 'Enter' para continuar");
                            Console.ReadLine();


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

            string? opcaoPj;
            do
            {

                Console.Clear();
                Console.WriteLine(@$"
=================================================
|           Escolha uma das opções abaixo       |
|-----------------------------------------------|
|           1 - Cadastrar Pessoa Jurídicas      |
|           2 - Mostrar Pessoas Jurídicas       |
|                                               |
|           0 - Voltar ao menu anterior         |
=================================================
");
                opcaoPj = Console.ReadLine();

                switch (opcaoPj)
                {
                    case "1":
                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();

                        Console.Clear();
                        Console.WriteLine($"Digite o nome da Pessoa Jurídica");
                        novaPj.nome = Console.ReadLine();

                        bool cnpjValido;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine($"Digite o CNPJ");
                            string? cnpj = Console.ReadLine();

                            cnpjValido = metodoPj.ValidarCnpj(cnpj);
                            if (cnpjValido)
                            {
                                novaPj.cnpj = cnpj;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"CNPJ digitado inválido. Por favor digite um CNPJ válido");
                                Console.ResetColor();
                                Thread.Sleep(3000);
                            }


                        } while (cnpjValido == false);

                        Console.Clear();
                        Console.WriteLine($"Digite a razão social");
                        novaPj.razaoSocial = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine($"Digite o rendimento");
                        novaPj.rendimento = float.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine($"Digite o logradouro");
                        novoEndPj.logradouro = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine($"Digite o número");
                        novoEndPj.numero = int.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine($"Digite o complemento (Aperte 'ENTER' para vazio)");
                        novoEndPj.complemento = "SENAI Informatica";

                        Console.Clear();
                        Console.WriteLine($"Este endereço é comercial? S/N");
                        string endComPj = Console.ReadLine().ToUpper();

                        if (endComPj == "S")
                        {
                            novoEndPj.endComercial = true;
                        }
                        else
                        {
                            novoEndPj.endComercial = false;
                        }

                        novaPj.endereco = novoEndPj;

                        // listaPj.Add(novaPj);
                        
                        metodoPj.Inserir(novaPj);

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Thread.Sleep(3000);
                        Console.ResetColor();

                        break;

                    case "2":
                        Console.Clear();

                        List<PessoaJuridica> listaPj = metodoPj.Ler();

                        if (listaPj.Count > 0)
                        {
                            foreach (PessoaJuridica cadaItem in listaPj)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
");
                                Console.WriteLine($"Aperte 'Enter' para continuar");
                                Console.ReadLine();
                                
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Lista vazia");
                            Console.ResetColor();
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


            } while (opcaoPj != "0");

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