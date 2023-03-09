using System;

namespace Boletim{
class Program{

    static void Main(string[] args){
        Aluno novoAluno = new Aluno();

        Console.WriteLine("Digite a primeira nota:");
        novoAluno.nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota:");
        novoAluno.nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota:");
        novoAluno.nota3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("O nome do aluno é: " + novoAluno.aluno);
        Console.WriteLine(novoAluno.resultadoBoletim());
        }
    }
}