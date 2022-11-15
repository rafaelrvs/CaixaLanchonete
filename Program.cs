
string opcao = string.Empty;
double Soma = 0;

List<string> ListaPro = new List<string>();

bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cachorro quente  -  R$ 3,50 ");
    Console.WriteLine("2 - Bauru Simples    -  R$ 3,80");
    Console.WriteLine("3 - Bauru C/ovo      -  R$ 4,50 ");
    Console.WriteLine("4 - Hamburger        -  R$ 4,70");
    Console.WriteLine("5 - Cheeseburger     -  R$ 5,30 ");
    Console.WriteLine("6 - Refrigerante     -  R$ 4,00 ");
    Console.WriteLine("7 - Encerrar");
    Console.WriteLine("8 - Consultar compra");


    switch (Console.ReadLine())
    {
        case "1":
            Soma = Soma + 3.50;
            ListaPro.Add("Cachorro Quente: R$ 3,50");

            break;

        case "2":
            Soma = Soma + 3.80;
            ListaPro.Add("Bauru Simples:  R$ 3,80 ");
            break;

        case "3":
            Soma = Soma + 4.50;
            ListaPro.Add("Bauru C / ovo:  R$ 4,50");
            break;

        case "4":
            Soma = Soma + 4.70;
            ListaPro.Add(" Hamburger: R$ 4,70 ");
            break;
        case "5":
            Soma = Soma + 5.30;
            ListaPro.Add("Cheeseburger: R$ 5,30");
            break;
        case "6":
            Soma = Soma + 4.00;
            ListaPro.Add("Refrigerante: R$ 4,00");
            break;

        case "7":
            exibirMenu = false;
            break;

        case "8":

            if (ListaPro.Any())
            {
                Console.WriteLine("Compra atual:");

                foreach (string item in ListaPro)
                {
                    Console.WriteLine(item);
                    Console.WriteLine($"O total é {Soma} ");
                   
                }
            }
            else
                Console.WriteLine("Não a compras no carrinho");

                break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine(" Pressione uma tecla para continuar");
    
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
Console.ReadKey();