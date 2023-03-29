using System;
using System.Globalization;

namespace Triangulo
{
	class Triangulo
	{
		
			public double xA, xB, xC, yA, yB, yC;
			
			public double calcTrianguloAreaX() 
			{
				double pX = (xA + xB + xC)/2;
				double resultado = Math.Sqrt(pX * (pX-xA) * (pX-xB) * (pX - xC));
				return resultado;
			}
			
			public double calcTrianguloAreaY() 
			{
				double pY = (yA + yB + yC)/2;
				double resultado = Math.Sqrt(pY * (pY-yA) * (pY-yB) * (pY - yC));
				return resultado;
			}			
	}
}