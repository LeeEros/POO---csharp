using System;

namespace Boletim{
    class Aluno{
        public string? aluno;

        public double nota1;

        public double nota2;

        public double nota3;

        public double resultadoBoletim(){
            
            double resultado =  nota1 + nota2 + nota3;
            if(nota1 > 30.1){
                throw new Exception("Nota maior que trinta");
            }
            else if(nota2 > 30.1){
                throw new Exception("Nota maior que trinta");
            }
            if(nota3 > 35.1){
                throw new Exception("Nota maior que trinta e cinco");
            }
            if(resultado >= 60.0){
                Console.WriteLine($"Você foi aprovado com {resultado}");
            } else {
                double resultadoNegativo =  resultado - 60.0;
                double resultadoPositivo =  resultadoNegativo  * -1;
                Console.WriteLine($"Faltou {resultadoPositivo} pontos para ser aprovado(o) no curso.");
                return resultadoPositivo;                
            }
            return resultado; 
        }
    }
}