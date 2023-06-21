using System;

namespace Polimorfismo
{
	class Animal
	{
		public virtual void EmitirSom()
		{
			Console.WriteLine("O animal emitiu som")
;		}
	}	
	
	class Gato : Animal
	{
		public override void EmitirSom()
		{
			Console.WriteLine("Miau");
		}
	}
	
	class Cachorro : Animal 
	{
		public override void EmitirSom()
		{
			Console.WriteLine("Au Au");
		}
	}
	
	class Program
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