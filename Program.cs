using System.ComponentModel.DataAnnotations;

namespace MIdExam2
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            int[] numbers = {1,2,3,4,5,6,7,8,9,10,};
            double total=0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }           
            double average = 0.00;
            average = total / numbers.Length;
            Console.WriteLine("Total of the array : " + total);
            Console.WriteLine("Average of the array : " + average);




        }
    }
}
