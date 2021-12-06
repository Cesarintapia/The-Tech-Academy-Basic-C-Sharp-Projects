using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "jesse";
            string quote = "The man said, \\Hello\", Jesse. \nHello on a new line. \n \t Hello on a tab.";
            string fileName = @"C:\Users\Jesse";

            bool trueOrfalse = name.Contains("s");
            trueOrfalse = name.EndsWith("s");

            Console.WriteLine(trueOrfalse);

            

            int length = name.Length;
            Console.WriteLine(length);
            name = name.ToUpper();
            Console.WriteLine(name);

            StringBuilder sb = new StringBuilder();
            sb.Append("Add comments to each line or block of your code to\n explain what it does exactly, so that another developer");
            sb.Append("Adding comments to each line or block of your code\n to explain what it does exactly, so that another developer");
            Console.WriteLine(sb);

            Console.ReadLine();

        }
    }
}
