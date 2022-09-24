using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Manager : Worker
    {
        public Manager(string name, int age, double salary, int clients) : base(name, age, salary)
        {
            Console.WriteLine("Full manager constructor");
            Clients = clients;
        }
        public int Clients { get; set; }
        public Manager() : base()
        {
        }
        public override double GetResultSalary()
        {
            return Salary*Clients;
        }
    }
}
