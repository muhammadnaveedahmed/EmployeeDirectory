using Employee.Helpers;
using System;

namespace EmployeeDirectory
{
    internal class Program
    {
        static PayRoll payRoll = new PayRoll();
        static IUI ui = new ConsoleUI();
        static void Main(string[] args)
        {

           

            SeedData();

            do
            {
                ShowMainMeny();
                string input = ui.GetInput();

                switch (input)
                {
                    case MenyHelper.Add:
                        AddEmployee();
                        break;
                    case MenyHelper.Show:
                        PrintEmployees();
                        break;
                    case MenyHelper.Quit:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }



            } while (true);

        }

        private static void AddEmployee()
        {
            ui.Print("Add an employee");

            string name = Util.AskForString("Name", ui);
            uint salary = Util.AskForUInt("Salary", ui);

            var emp = new Employee(name, salary);

            payRoll.AddEmployee(emp);


        }

        private static void PrintEmployees()
        {
            List<Employee> employees = payRoll.GetEmployees();

            foreach (var employee in employees)
            {
                //Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
                ui.Print(employee.ToString());
            } 
        }

        private static void ShowMainMeny()
        {
            ui.Print($"{MenyHelper.Add}: add Employee");
            ui.Print($"{MenyHelper.Show}: print Employee");
            ui.Print($"{MenyHelper.Quit}: quit");
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
