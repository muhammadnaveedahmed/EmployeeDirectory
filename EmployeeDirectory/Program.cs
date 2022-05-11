using System;

namespace EmployeeDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot kalle = new Robot("Kalle", 10);
            Robot nisse = new Robot("Nisse", 10);
            string name = kalle.GetName();
            string name2 = nisse.GetName();

            kalle.Length = 20;
            kalle.SetName("New name");
            kalle.Height = 13;
           
        }
    }
}
