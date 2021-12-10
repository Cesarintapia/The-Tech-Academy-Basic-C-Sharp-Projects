using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEmployee
{
    public class Employee
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName{ get; set; }

        public Employee(int id, string fn, string ln) 
        {
            Id = id; firstName = fn; lastName = ln;
        }

    }
}
