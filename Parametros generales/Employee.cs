using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametros_generales
{
    public class Employee<T>                      //Employee class take a generic type parameter
    {
        public int Id { get; set; }
        public List<T> things { get; set; }      //Add a property called “things” and have its data type be a generic list


    }
}
