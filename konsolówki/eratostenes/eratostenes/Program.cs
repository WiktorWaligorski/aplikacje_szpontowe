namespace eratostenes
{
    internal class Program
    {

        static void Wypelnienie_tablicy(bool[] Numbers)
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = true;
            }
        }
        static void Main(string[] args)
        {
            int n = 100;
            bool[] Tablica = new bool[n + 1];

            Wypelnienie_tablicy(Tablica);

            for (int i = 2; i <= n; i++)
            {
                if (Tablica[i])
                {
                    Console.WriteLine("Kolejna liczba pierwsza: " + i);
                    for (int j = i * 2; j <= n; j += i)
                    {
                        Tablica[j] = false;
                    }
                }
            }
        }
    }
}
