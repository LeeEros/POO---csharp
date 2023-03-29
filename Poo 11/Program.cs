using System;
using System.Globalization;

namespace Triangulo
{
	class Program
	{
		static void Main(string[] args)
		{
			Triangulo triangulo = new Triangulo();
			
			Console.WriteLine("Digite o lado xA");
			triangulo.xA = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("Digite o lado xB");
			triangulo.xB = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("Digite o lado xC");
			triangulo.xC = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("Digite o lado yA");
			triangulo.yA = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("Digite o lado yB");
			triangulo.yB = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("Digite o lado yC");
			triangulo.yC = Convert.ToDouble(Console.ReadLine());
			
			double X = triangulo.calcTrianguloAreaX();
			double Y = triangulo.calcTrianguloAreaY();
			
			Console.WriteLine("A area de X é: " + X);
			Console.WriteLine("A area de Y é: " + Y);
			
		if(X > Y)
		{
			Console.WriteLine("X é maior que Y!", X, Y);
		} else if(X < Y)
		{
			Console.WriteLine("Y é maior que X!", X, Y);
		}
		else
		{
			Console.WriteLine("X e Y são iguais.");
		}
		}
	}
}