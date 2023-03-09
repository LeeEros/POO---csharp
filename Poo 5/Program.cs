using System;

namespace SalarioFinal{
    class Program{
        static void Main(string[] args){
        Funcionario novoFuncionario = new Funcionario();

        Console.WriteLine("Digite o nome do Funcionário");
        novoFuncionario.nome = Console.ReadLine();

        Console.WriteLine("Digite o salário do Funcionário");
        novoFuncionario.salarioFuncionario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o imposto do Funcionário");
        novoFuncionario.imposto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("O funcionário é :" + novoFuncionario.nome);
        Console.WriteLine(novoFuncionario.impostoAplicado());
        }
    }
}