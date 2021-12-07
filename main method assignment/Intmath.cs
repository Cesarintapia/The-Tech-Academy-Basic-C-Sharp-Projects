using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_method_assignment
{
    class Intmath
    {
        public int OperaMath(int lenumero)
        {
            int paresult = lenumero + 11;
            return paresult;
        }

        public int OperaMath(decimal lenumero)
        {
            int paresult = Convert.ToInt32(lenumero) * 2;
            return paresult;
        }

        public int OperaMath(string lenumero)
        {
            int paresult = Convert.ToInt32(lenumero) - 2;
            return paresult;
        }
    }
}
