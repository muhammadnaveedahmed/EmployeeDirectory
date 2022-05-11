namespace EmployeeDirectory
{
    internal class Robot
    {
        private string name;
        private int age;


        public Robot(string name, int age)
        {
            //Validate
            this.name = name;
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            //Validate
            name = newName;
        }
    }
}