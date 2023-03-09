using System;

namespace Calculo{
    class Perimetro{
        public double x;

        public double y;


        public double perimetro(){
            double perimetro = 2 * (x+y);
            return perimetro;
        }
    }
}