using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Worker(string name, int age, double salary)
        {
            Console.WriteLine("Full worker constructor");
            Name = name;
            Age = age;
            Salary = salary;
        }
        public Worker()
        {
            Console.WriteLine("Default worker constructor");
        }
        public abstract double GetResultSalary();
        
    }
}
