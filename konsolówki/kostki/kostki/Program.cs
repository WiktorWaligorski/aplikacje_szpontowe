namespace kostki
{
    internal class Program
    {
        public static int[] Throw(int amount)
        {
            Random random = new Random();
            int[] throws = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                throws[i] = random.Next(1, 7);
                Console.WriteLine("Kostka " + (i + 1) + ": " + throws[i]);
            }
            return throws;
        }

        public static int CountScore(int[] throws)
        {
            int score = 0;
            Dictionary<int, int> diceCount = new Dictionary<int, int>();
            
            foreach (int throwValue in throws)
            {
                int key = throwValue;
                if (diceCount.ContainsKey(key))
                {
                    diceCount[key]++;
                }
                else
                {
                    diceCount[key] = 1;
                }
            }

            foreach (var kvp in diceCount)
            {
                if (kvp.Value >= 2)
                {
                    score += kvp.Value * kvp.Key;
                }
            }
            
            return score;
        }
        static void Main(string[] args)
        {
            int totalScore = 0;
            int currentScore = 0;
            Console.WriteLine("Ile kostek chcesz rzucić? (3 - 10) ");
            int how_many_throws = int.Parse(Console.ReadLine());

            while (true) 
            {
                currentScore = 0;
                Random random = new Random();
                int[] throws = new int[how_many_throws];

                if (how_many_throws > 2 && how_many_throws < 11)
                {
                    throws = Program.Throw(how_many_throws);
                    currentScore = Program.CountScore(throws);
                    Console.WriteLine("Wynik: " + currentScore);
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa liczba kostek. Wprowadź liczbę od 3 do 10.");
                }
                totalScore += currentScore;
                Console.WriteLine("Łączny wynik: " + totalScore);
                Console.WriteLine("Chcesz rzucić jeszcze raz? (t/n)");
                string answer = Console.ReadLine();
                if (answer != "t")
                {
                    break;
                }
            }
            
        }
    }
}
