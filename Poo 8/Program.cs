using System;
using System.Globalization;

namespace Shopping

{
	class Program
	{
		static void Main(string[] args)
		
		{
			Produto p = new Produto("Pimenta Malagueta", 5.5, 200);
			
			Console.Write(p.Nome);
			Console.Write(p.Preco);
			Console.Write(p.Quantidade);
			
			
			
			/*Console.WriteLine("Entre com os dados do produto: ");
			Console.Write("Nome: ");
			
			p.Nome = Console.ReadLine();
			Console.Write("Preço: ");
			p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			
			Console.Write("Quantidade no Estoque: ");
			p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			
			Console.WriteLine("");

			Console.WriteLine("Dados do produto: " + p.Nome);
			Console.WriteLine("");
			Console.WriteLine("Dados do produto: " + p.Preco);
			Console.WriteLine("");
			Console.WriteLine("Dados do produto: " + p.Quantidade);	
			Console.WriteLine("");
			
			Console.WriteLine(p.RetornaQuantidade());
			
			p.AdicionarProduto(15);
			
			Console.WriteLine(p.RetornaQuantidade());		*/
			
			
		}
	}
}