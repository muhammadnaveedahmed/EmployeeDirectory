namespace EmployeeDirectory
{
    //Publik synlig för alla, Internal synlig inne i den här Assemblyn (Det här programmet)
    public class Robot
    {
        //Struktur på en klass
        // 1. privata fält
        // 2. publika properties (privata properties make no sense)
        // 3. Konstruktor/Konstruktorer
        // 4. Metoder


        //1. privata fält
        //private enbart tillgängligt inne i den här klassen!
        //Sätts här vi det publika propertyt
        private string name;
        private int age;

        private int length;

        //Exempel på publikt fält. OBS! Använd property istället
        //public string GörEJ;


        //2. Publika properties
        //Autoproperty om du inte behöver validera eller göra något, dvs skriva kod i gettern eller settern
        //Använd den här syntaxen istället för publika fält!
        //Snippet prop
        public int Height { get; set; }

        //När vi försöker sätta ett värde (set) till mindre än 0 sätter vi length till 0.
        //Returnerar värdet på det bakomliggande privata fältet (get)
        //Snippet propfull för att skapa ett property med bakomliggande fält.
        public int Length
        {
            get { return length; }
            set
            {
                if (value < 0)
                {
                    length = 0;
                }
                else
                {
                    length = value;
                }
            }
        }

      


        //3. Konstruktor
        //Snippet ctor
        //Det här en default konstruktor den finns även om den inte syns. Tills man skapar en annan konstuktor. Då måste man skriva ut den manuellt för att få tillgång till den.public Robot()
        //public Robot()
        //{

        //}


        //Konstruktor med parametrar
        //En konstruktor har aldrig någon retur typ och heter samma sak som klassen
        //Konstruktorn körs direkt när man skapar ett ny instans av klassen med nyckelordet new
        //Tex Robot robot = new Robot("Kalle");
        //Nu måste vi alltid skicka med ett namn och age för att få skapa en ny Robot
        public Robot(string name, int age)
        {
            //Validate
            this.name = name;
            this.age = age;
        }


        //4. Metoder
        //Så här gör man oftast i andra språk tex Java. När vi vill hämta och sätta värden.
        //I C# används nästan alltid properties istället om det inte är så att det är mer komplex logik.
        //Tex att man anropar andra metoder och klasser.
        public string GetName() => name;
        //{
        //    return name;
        //}

        public void SetName(string newName)
        {
            //Validate
            name = newName;
        }
    }
}