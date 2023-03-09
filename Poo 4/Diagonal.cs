using System;

namespace Calculo{
    class Diagonal{

        public double b;

        public double c;

        public double diagonal()
        {
            double diagonal = Math.Sqrt((b*b)+(c*c));
            return diagonal;
        }
    }   
}