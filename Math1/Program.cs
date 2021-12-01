using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 50;
            Console.WriteLine("Write a number and it'll increase 50 times");
            string numberWrote = Console.ReadLine();                     
            int numberProduct = Convert.ToInt32(numberWrote);
            int total = number1 * numberProduct;
            Console.WriteLine(total);

            int number2 = 25;
            Console.WriteLine("Write a number and I'll plus 25");      
            string numberToAdd = Console.ReadLine();                   
            int numberAddition = Convert.ToInt32(numberToAdd);
            int total_2 = number2 + numberProduct;
            Console.WriteLine(total_2);

            float number3 = 12.5f;
            Console.WriteLine("Write a number and I'll divide for 12.5");
            string numberToDivide = Console.ReadLine();
            double numberDivition = Convert.ToInt32(numberToDivide);
            double total_3 = numberDivition / number3;
            Console.WriteLine(total_3);

            int number4 = 50;
            Console.WriteLine("Write a number below 50");
            string numberToCompare = Console.ReadLine();
            int numberComparation = Convert.ToInt32(numberToCompare);
            bool comparation = numberComparation < number4;
            Console.WriteLine(comparation);

            int number5 = 7;
            Console.WriteLine("Write a number diferent of 0");
            string numberToDivide1 = Console.ReadLine();
            double numberForRemainder = Convert.ToInt32(numberToDivide1);
            double remainder = numberForRemainder / number5;
            Console.WriteLine(remainder);



            Console.ReadLine();
        }
    }
}
