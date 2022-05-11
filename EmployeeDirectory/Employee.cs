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
        public int Salary { get; }

        public Employee(string name, int salary)
        {
            //Validate
            Name = name;
            Salary = salary;
        }

    }
}
