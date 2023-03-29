using System;
using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			Produto p = new Produto();
			
			string? name = Console.ReadLine();			
			
			p.SetName("Alguma coisa");
			Console.WriteLine(p.GetName());
		}
	}
}