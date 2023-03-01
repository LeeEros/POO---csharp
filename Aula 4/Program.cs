using  System;

namespace School
{
    class Program 
    {
        static void Main (string[] args)
        {

            Course courseMath = new Course(); 
            courseMath.name = "Matemática Avançada";
            courseMath.value = 100.00;
            courseMath.quantityStudents = 40;

            Console.WriteLine(courseMath.name);
            Console.WriteLine(courseMath.value);
            
            var multiplySalary = courseMath.conta();
            
            Console.WriteLine(multiplySalary);
                        
           // Console.WriteLine("O valor arrecado é: " + courseMath.value * courseMath.quantityStudents );//courseMath.salary * courseMath.students);
        }
    }
}