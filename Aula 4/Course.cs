namespace School
{
    class Course 
    {
        public string name = "";

        public double value;

        public int quantityStudents; 

        public double conta() {
            return this.value * this.quantityStudents; 
        }
    }
}