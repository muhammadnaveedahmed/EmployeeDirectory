using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectory
{
    internal class Employee
    {
        public string Name { get; }
        public uint Salary { get; }

        //public static int Count { get; set; }

        public Employee()
        {

        }

        public Employee(string name, uint salary)
        {
            //Validate
            Name = name;
            Salary = salary;
            //Count++;
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }

    }
}
