using System;

namespace SalarioFinal{
	class Funcionario{
		public string? nome;
		public double salarioFuncionario;

		public double imposto;

		public double  impostoAplicado(){
			double impostoAplicado = (imposto/100);
			Console.WriteLine(impostoAplicado);
			double impostoReal = (impostoAplicado - salarioFuncionario) * -1; 
			Console.WriteLine(impostoReal);
			return impostoReal;
		}
	}
}