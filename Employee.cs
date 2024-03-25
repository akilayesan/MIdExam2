using System;

public class Employee
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double BasicSalary { get; set; }
    public void Print(string FirstName, string LastName, double BasicSalary)
    {
        string fullname = FirstName + " " + LastName;
        double salary = BasicSalary;
        Console.WriteLine("Name: " + fullname + "," + "Salary: " + salary);
    }
   
}

