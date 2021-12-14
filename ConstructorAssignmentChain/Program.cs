using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignmentChain
{
    class Program
    {
        static void Main(string[] args)
        {
            const int x = 4;                                   //Declare constant type integer
            const int y = 78;                                  //Declare constant type integer
            var z = 4532;                                      //Declare constant type var

            Area rectangulo = new Area(x, y);                  //Claculate the rectangulo area

            Area cuadrado = new Area(z);                       //Claculate the square area
        }
    }
}
