using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exhand
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing by two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divide by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please write a whole number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero it is impossible");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine("");
            }
        }
    }
}
