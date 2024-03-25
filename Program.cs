namespace MIdExam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.FirstName = "Akila";
            employee1.LastName = "Yesan";
            employee1.BasicSalary = 50000.00;

            Employee.Print("akila","yesan",50000.00);


        }
       
    }
}
