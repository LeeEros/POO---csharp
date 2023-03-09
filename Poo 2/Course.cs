namespace School
{
    class Course 
    {
        public string name = "";

        public double salary;

        public int quantityStudents; 

        public double Conta() {
            return salary * quantityStudents; 
        }
    }
}