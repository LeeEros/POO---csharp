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
		

		
		public void SetName(string name)
		
		{
			_name = name;
		}
		
		public string? GetName()
		
		{
			return _name;
		}
		
		
		public double SetPrice(double price)
		{
			return _price;
		}
		
		public double GetPrice(double price)
		{
			return _price;
		}
		
		
		public double SetQuantity(int quantity)
		{
			return _quantity;
		}
		
		public int GetQuantity(int quantity)
		{
			return _quantity;
		}
	}
}
