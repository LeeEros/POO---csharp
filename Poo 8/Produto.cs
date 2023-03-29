using System;
using System.Globalization;

namespace Shopping

{
	class Produto
	
	{
		public string? Nome;
		
		public double Preco;
		
		public int Quantidade;
		
		public Produto(string nome, double preco, int quantidade)
		
		{ //Metódo Construtor
			Nome = nome;
			Preco = preco;
			Quantidade = quantidade; 
		}
		
		public Produto(string nome, double preco)
		
		{
			Nome = nome;
			Preco = preco;
			Quantidade = 0;
		}
		
		
		public void AdicionarProduto(int quantidade)
		{
			Quantidade += quantidade;
		}
		
		public void RemoverProduto(int quantidade)
		
		{
			Quantidade -= quantidade;
		}
		
		public int RetornaQuantidade()
		{
			return Quantidade;
		}
		
		public double ValorTotalEstoque()
		
		{
			return Preco * Quantidade;
		}
	}
}