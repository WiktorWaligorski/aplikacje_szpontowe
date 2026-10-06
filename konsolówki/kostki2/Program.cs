namespace kostki2
{
    public class Kostka
    {
        public static int Liczba_instancji = 0;
        public string[] Obrazy = { "kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png" };
        public int Wynik { get; set; }
        public bool Dostepna { get; set; }
        public int Idpliku { get; set; }

        public Kostka(int wynik)
        {
            if (wynik < 1 && wynik > 6)
            {
                wynik = 0;
            }
            Wynik = wynik;
            Idpliku = wynik;
            Dostepna = true;
            Liczba_instancji++;
        } 
        public Kostka()
        {
            Random rand = new Random();
            int rzut = rand.Next(1, 7);
            Wynik = rzut;
            Idpliku = rzut;
            Dostepna = true;
            Liczba_instancji++;
        }

        public void Rzut()
        {
            if (Dostepna)
            {
                Random rand = new Random();
                int rzut = rand.Next(1, 7);
                Wynik = rzut;
                Idpliku = rzut;
            }
        }

        public void Zablokuj()
        {
            Dostepna = false;
        }

        public string NapiszWynik()
        {
            string[] Wyniki = { "jeden", "dwa", "trzy", "cztery", "pięć", "sześć" };
            return Wyniki[Wynik - 1];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kostka kostka1 = new Kostka();
            Console.WriteLine("Po utworzeniu pierwszego obiektu");
            Console.WriteLine(Kostka.Liczba_instancji);
            Console.WriteLine(kostka1.Wynik.ToString() + "  " + kostka1.NapiszWynik());
            Console.WriteLine(kostka1.Obrazy[kostka1.Wynik]);



            Console.Write("Podaj wartość: ");
            if(!int.TryParse(Console.ReadLine(), out int wartosc))
            {
                Console.WriteLine("Spróbuj ponownie");
            }

            Kostka kostka2 = new Kostka(wartosc);

            Console.WriteLine("Po utworzeniu drugiego obiektu");
            Console.WriteLine(Kostka.Liczba_instancji);
            Console.WriteLine(kostka2.Wynik.ToString() + "  " + kostka2.NapiszWynik());
            Console.WriteLine(kostka2.Obrazy[kostka2.Wynik]);

        }
    }
}
