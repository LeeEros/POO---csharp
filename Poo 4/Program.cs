using System;

namespace Calculo{
class Program{
    static void Main(string[] args){

        Perimetro novoPerimetro = new Perimetro();

        novoPerimetro.x = 3.00;
        novoPerimetro.y = 4.00;

        Console.WriteLine(novoPerimetro.perimetro());

        Area novaArea = new Area();

        novaArea.b = 3.00;
        novaArea.h = 4.00;


        Console.WriteLine(novaArea.area());

        Diagonal novaDiagonal = new Diagonal();

        novaDiagonal.b = 3.00;
        novaDiagonal.c = 4.00;

        Console.WriteLine(novaDiagonal.diagonal());
        }
    }
}