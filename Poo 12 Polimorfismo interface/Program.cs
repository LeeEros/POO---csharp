using System;

namespace Polimorfismo_interface
{
	interface IAnimal
	{
		public void EmitirSom()
		{
			Console.WriteLine("O animal emitiu som")
;		}
	}	
	
	interface Gato : IAnimal
	{
		public void EmitirSom()
		{
			Console.WriteLine("Miau");
		}
	}
	
	interface Cachorro : IAnimal 
	{
		public void EmitirSom()
		{
			Console.WriteLine("Au Au");
		}
	}
	
	interface Program
	{
		static void Main(string[] args)
		{
			Gato xaninho = new Gato();
			Cachorro titiu = new Cachorro();
			
			xaninho.EmitirSom();
			titiu.EmitirSom();
		}
	}
}