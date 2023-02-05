using CaixaLanchonete.Models;
ModeloReferencia m = new ModeloReferencia();

List<string> ListaPro = new List<string>();


string opcao = string.Empty;
bool exibirMenu = true;
// Realiza o loop do menu
while (exibirMenu)
{

	m.produtosNaLista();

	switch (Console.ReadLine())
	{
		case "1":
			ListaPro.Add(m.Produto1);
            Console.Clear();
			Console.WriteLine($"{m.Produto1} adicionado com sucesso");
		
			m.Soma = m.Soma + m.Produtov1;
			break;

		case "2":
			ListaPro.Add(m.Produto2);
			Console.Clear();
			Console.WriteLine($"{m.Produto2} adicionado com sucesso");
			m.Soma = m.Soma + m.Produtov2;
			break;

		case "3":
			ListaPro.Add(m.Produto3);
			Console.Clear();
			Console.WriteLine($"{m.Produto3} adicionado com sucesso");
			m.Soma = m.Soma + m.Produtov3;
			break;
		case "4":
        	ListaPro.Add(m.Produto4);
				Console.Clear();
			Console.WriteLine($"{m.Produto4} adicionado com sucesso");
			m.Soma = m.Soma + m.Produtov4;
			break;
		case "5":
				ListaPro.Add(m.Produto5);
			Console.Clear();
			Console.WriteLine($"{m.Produto5} adicionado com sucesso");
			m.Soma = m.Soma + m.Produtov5;
			break;
		case "6":
			ListaPro.Add(m.Produto6);
			Console.Clear();
			Console.WriteLine($"{m.Produto6} adicionado com sucesso");
			m.Soma = m.Soma + m.Produtov6;
			break;
		case "7":
				ListaPro.Add(m.Produto7);
				Console.Clear();
			Console.WriteLine($"{m.Produto7} adicionado com sucesso");
			m.Soma = m.Soma + m.Produtov7;
			break;
		case "8":
			ListaPro.Add(m.Produto8);
						Console.Clear();
			Console.WriteLine($"{m.Produto8} adicionado com sucesso");
			m.Soma = m.Soma + m.Produtov8;
			break;
		case "9":
			if (ListaPro.Any())
			{
				Console.WriteLine("Compra atual:");
				foreach (string item in ListaPro)
				{
						Console.WriteLine($"{item} ");
				}
			}
			else
				Console.WriteLine("Não a compras no carrinho");
			break;
		case "0":
        		Console.WriteLine($"O valo total a  pagar é {m.Soma.ToString("c2")}");
			exibirMenu = false;
			break;
            case "10":
			Console.WriteLine("O carrinho foi esvaziado com sucesso");
			m.Soma = 0F;
			ListaPro.Remove(m.Produto1);
			ListaPro.Remove( m.Produto2 );
			ListaPro.Remove(m.Produto3);
			ListaPro.Remove(m.Produto4);
			ListaPro.Remove(m.Produto5);
			ListaPro.Remove(m.Produto6);
			ListaPro.Remove(m.Produto7);
			ListaPro.Remove( m.Produto8 );
			break;
		default:
			Console.WriteLine("Opção inválida");
			break;
	}
	

}
Console.WriteLine("Pressione uma tecla para continuar");

Console.WriteLine("O programa se encerrou");
Console.ReadKey();