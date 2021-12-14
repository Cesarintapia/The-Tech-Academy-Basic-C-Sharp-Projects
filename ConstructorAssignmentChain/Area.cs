using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignmentChain
{
    public class Area
    {
        public Area(int x) : this(x, x)                                 //contructor that recieve 1 parametrer and chians to the second constructor
        {

        }

        public Area(int x, int y)                                      //Contructor that recieve 2 parametrers 
        {
            int result = x * y;
            Console.WriteLine("El area es: " + result);
            Console.ReadLine();
        }
    }
}
