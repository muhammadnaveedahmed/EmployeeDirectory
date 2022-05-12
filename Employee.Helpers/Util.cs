using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Helpers
{
    public static class Util
    {
        public static string AskForString(string prompt, IUI ui)
        {
            bool success = false;
            string name;

            do
            {
                ui.Print($"{prompt}: ");
                name = ui.GetInput()!;

                if (string.IsNullOrWhiteSpace(name))
                {
                   ui.Print($"You must enter a valid {prompt}");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return name;
        }

        public static uint AskForUInt(string prompt, IUI ui)
        {
            do
            {
                string input = AskForString(prompt, ui);
                if (uint.TryParse(input, out uint answer))
                {
                    return answer;
                }

            } while (true);
        }
    }
}
