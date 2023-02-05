using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaixaLanchonete.Models
{


	public class ModeloReferencia
	{

		public string Produto1 { get; set; }
		public string Produto2 { get; set; }
		public string Produto3 { get; set; }
		public string Produto4 { get; set; }
		public string Produto5 { get; set; }
		public string Produto6 { get; set; }
		public string Produto7 { get; set; }
		public string Produto8 { get; set; }
		public float Produtov1 { get; set; }
		public float Produtov2 { get; set; }
		public float Produtov3 { get; set; }
		public float Produtov4 { get; set; }
		public float Produtov5 { get; set; }
		public float Produtov6 { get; set; }
		public float Produtov7 { get; set; }
		public float Produtov8 { get; set; }
		public float Soma { get; set; }

		public void produtosNaLista()
		{

			Produto1 = "Cachorro quente";
			Produto2 = "Bauru simples";
			Produto3 = "Bauru com ovo";
			Produto4 = "Hamburger";
			Produto5 = "Cheeseburger";
			Produto6 = "Refrigerante";
			Produto7 = "Coxinha";
			Produto8 = "X tudo";

			Produtov1 = 10F;
			Produtov2 = 4.50F;
			Produtov3 = 5.50F;
			Produtov4 = 5F;
			Produtov5 = 6F;
			Produtov6 = 6F;
			Produtov7 = 2.50F;
			Produtov8 = 17F;

			Console.WriteLine($"Digite uma das opções,\n"
			+ $"[1] {Produto1} - {Produtov1.ToString("c2")}\n[2] {Produto2} - {Produtov2.ToString("c2")} \n[3] {Produto3} - {Produtov3.ToString("c2")}\n[4] {Produto4} - {Produtov4.ToString("c2")}\n"
		   + $"[5] {Produto5} - {Produtov5.ToString("c2")}\n[6] {Produto6} - {Produtov6.ToString("c2")}\n[7] {Produto7} - {Produtov7.ToString("c2")}\n[8] {Produto8} - {Produtov8.ToString("c2")}\n"
		   + "[9] Consultar compra \n[0] Finalizar comprak\n[10] Para remover todos os produtos ");

		}

	}
}
