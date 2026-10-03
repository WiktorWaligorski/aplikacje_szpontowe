namespace szyfr
{
    internal class Program
    {

        static string Szyfrowanie(int k, string jawny)
        {
            string szyfr = "";
            int jawny_ascii = 0;
            for (int i = 0; i < jawny.Length; i++)
            {
                if (jawny[i] != ' ')
                {
                    jawny_ascii = (int)jawny[i];
                    if (jawny_ascii + k > 122)
                    {
                        szyfr += (char)(jawny_ascii - 26 + k);
                    }
                    else if (jawny_ascii + k < 97)
                    {
                        szyfr += (char)(jawny_ascii + 26 + k);
                    }
                    else
                    {
                        szyfr += (char)(jawny_ascii + k);
                    }
                }
                else
                {
                    szyfr += ' ';
                }
            }

            return szyfr;
        }
        static void Main(string[] args)
        {
            int klucz = 0;
            string tekst_jawny;
            Console.Write("podaj klucz: ");
            while (!int.TryParse(Console.ReadLine(), out klucz))
            {
                Console.WriteLine("niepoprawny klucz");
            }
            Console.Write("podaj tekst: ");
            tekst_jawny = Console.ReadLine();

            Console.WriteLine(Szyfrowanie(klucz, tekst_jawny));
        }
    }
}
