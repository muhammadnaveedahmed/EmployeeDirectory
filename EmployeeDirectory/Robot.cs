namespace EmployeeDirectory
{
    internal class Robot
    {
        private string name;
        private int age;

       private int length ;

        public int Length
        {
            get { return length; }
            set 
            { 
                if( value < 0 )
                {
                    length = 0;
                }
                else
                {
                      length = value; 
                }
            }
        }


        public int Height { get; set; }



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