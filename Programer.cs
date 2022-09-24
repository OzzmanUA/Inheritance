using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Programer : Worker
    {
        public int Str { get; set; }
        public override double GetResultSalary()
        {
            return Salary * Str;
        }
    }
}
