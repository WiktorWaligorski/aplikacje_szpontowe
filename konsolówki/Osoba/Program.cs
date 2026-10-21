namespace Osoba
{

    class Osoba
    {
        private int id {  get; set; }
        private string name { get; set; }
        static public int instances;

        public Osoba()
        {
            instances = 0;
            id = 0;
            name = "";
            instances++;
        }
        public Osoba(int id, string name)
        {
            this.id = id;
            this.name = name;
            instances++;
        }
        public Osoba(Osoba osoba)
        {
            this.id = osoba.id;
            this.name = osoba.name;
            instances++;
        }

        public void SayHi(string your_name)
        {
            if (your_name == "")
            {
                Console.WriteLine("Brak danych");
            }
            else
            {
                Console.WriteLine($"Cześć {your_name}, mam na imię {this.name}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Osoba.instances);
            Osoba os1 = new Osoba();
            Console.WriteLine("Osoba 1 (bezparametrowa)");
            os1.SayHi("a");
            Console.WriteLine(Osoba.instances);
            Console.WriteLine("Osoba 2");
            Osoba os2 = new Osoba(1, "osoba2");
            os2.SayHi("b");
            Console.WriteLine(Osoba.instances);
        }
    }
}
