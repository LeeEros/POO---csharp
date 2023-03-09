using System;

namespace PessoaMaisVelha{
    class Idade{

        public string[]? nomes;

        public int[]? pessoaIdade;

        public int[]? pessoaMaisVelha(){

            int[]? idade = pessoaIdade;
            string[]? nomeVelha = nomes;

            for(int i = 0; i < idade?.Length; i++){
                if(idade?.Length >= i){
                  //string idade = nomes;  
                  int maiorIdade = idade.Length;
                  Console.WriteLine(maiorIdade);
                }                
            }

            return pessoaMaisVelha();
        }
    }
}