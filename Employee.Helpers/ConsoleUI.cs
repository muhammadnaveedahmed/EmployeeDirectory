using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Helpers
{
    public class ConsoleUI : IUI
    {
        public string? GetInput()
        {
            return Console.ReadLine();
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }

    }

    public class MockUI : IUI
    {
        public static string SetInput { get; set; } = "Kalle";

        public string? GetInput()
        {
            return SetInput;
        }

        public void Print(string message)
        {
            
        }
    }
}
