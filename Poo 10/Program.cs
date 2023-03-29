using System;
using System.Globalization;

namespace Revisao

{
	class Program 
	
	{
		static void Main(string[] args)
		{
		
		double xA, xB, xC, yA, yB, yC;
		
		Console.WriteLine("Entre com os lados para o triângulo X");
		xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		
		Console.WriteLine("Entre com os lados para o triângulo Y");
		yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			
		double pX = (xA + xB + xC)/2;
		double areaX = Math.Sqrt(pX * (pX-xA) * (pX-xB) * (pX - xC));
		
		double pY = (yA + yB + yC)/2;
		double areaY = Math.Sqrt(pY * (pY-yA) * (pY-yB) * (pY - yC));
		
		Console.WriteLine("Área de X é: " 
		+ areaX.ToString("F3", CultureInfo.InvariantCulture));		
		
		Console.WriteLine("Área de Y é: " 
		+ areaY.ToString("F3", CultureInfo.InvariantCulture));	
		
		if(areaX > areaY)
		{
			Console.WriteLine("X é maior que Y!", areaX, areaY);
		} else if(areaX < areaY)
		{
			Console.WriteLine("Y é maior que X!", areaX, areaY);
		}
		else
		{
			Console.WriteLine("X e Y são iguais.");
		}
		}
	}
}