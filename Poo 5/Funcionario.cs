using System;

namespace SalarioFinal{
    class Funcionario{
        public string? nome;
        public double salarioFuncionario;

        public double imposto;

        public double  impostoAplicado(){
            double impostoAplicado = (imposto/100) * salarioFuncionario;
            double impostoReal = impostoAplicado + salarioFuncionario; 
            return impostoReal;
        }
    }
}