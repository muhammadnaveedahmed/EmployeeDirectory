using System;

namespace EmployeeDirectory
{
    internal class Program
    {
        static PayRoll payRoll = new PayRoll();
        static void Main(string[] args)
        {

           

            SeedData();

            do
            {
                ShowMainMeny();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        PrintEmployees();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }



            } while (true);

        }

        private static void AddEmployee()
        {
            Console.WriteLine("Add an employee");

            string name = Util.AskForString("Name");
            uint salary = Util.AskForUInt("Salary");

            var emp = new Employee(name, salary);

            payRoll.AddEmployee(emp);


        }

        private static void PrintEmployees()
        {
            List<Employee> employees = payRoll.GetEmployees();

            foreach (var employee in employees)
            {
                //Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
                Console.WriteLine(employee);
            } 
        }

        private static void ShowMainMeny()
        {
            Console.WriteLine("1: add Employee");
            Console.WriteLine("2: print Employee");
            Console.WriteLine("3: quit");
        }

        private static void SeedData()
        {
            payRoll.AddEmployee("Nisse", 10000);
            payRoll.AddEmployee("Kalle", 20000);
            payRoll.AddEmployee("Anna", 30000);
            payRoll.AddEmployee("Pelle", 40000);
            payRoll.AddEmployee(new Employee("Owe", 50000));
        }
    }
}
