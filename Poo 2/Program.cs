using  System;

namespace School
{
    class Program 
    {
        static void Main (string[] args)
        {

            Course courseMath = new Course(); 
            courseMath.name = "Matemática Avançada";
            double valueSalary = courseMath.salary;
            courseMath.quantityStudents = 40;
            Console.WriteLine("Insira o Salário");
            valueSalary = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(courseMath.name);
            //Console.WriteLine(courseMath.value);
            
            var multiplySalary = courseMath.Conta();
            Console.WriteLine("o seu salário: " + multiplySalary);
                        
           // Console.WriteLine("O valor arrecado é: " + courseMath.value * courseMath.quantityStudents );//courseMath.salary * courseMath.students);
        }
    }
}