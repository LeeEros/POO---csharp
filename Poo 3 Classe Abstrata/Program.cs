using System;

namespace  Abstrato
{
    class Program{
        static void Main(string[] args){

            Triangulo areaTriangulo1 = new Triangulo();
            Triangulo areaTriangulo2 = new Triangulo();

            areaTriangulo1.A = 4;
            areaTriangulo1.B = 5.5;
            areaTriangulo1.C = 4;

            areaTriangulo2.A = 10;
            areaTriangulo2.B = 5.7;
            areaTriangulo2.C = 4.5;

            Console.WriteLine(areaTriangulo1.Area());
            Console.WriteLine(areaTriangulo2.Area());

            Console.WriteLine(Calcudora.Pi);
        }
    }
}