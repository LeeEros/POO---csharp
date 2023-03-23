using System;
using System.Globalization;

namespace Course
{
	class Produto
	{
		private string? _name;
		
		private double _price;
		
		private int _quantity;
		
		public Produto()
		{
			
		}
		
		public Produto(string name, double price, int quantity)
		
		{
			_name = name;
			_price = price;
			_quantity = quantity;
		}
		
		public string? GetNome()
		
		{
			return _name;
		}
		
		public void SetName(string name)
		
		{
			_name = name;
		}
	}
}
