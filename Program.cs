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

            Print(employee1.FirstName,employee1.LastName,employee1.BasicSalary);


        }
       
    }
}
