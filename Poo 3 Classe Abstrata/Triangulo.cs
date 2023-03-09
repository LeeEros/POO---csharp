using System;

namespace Abstrato{
    class Triangulo{

        public double A;
        public double B;
        public double C;

        public double Area() 
        {
            double area = (A+B+C)/2;
            return Math.Sqrt(area * ( area - A) * (area - B) * (area - C));
        }
    }
}

//Class abstratas não são instanciadas