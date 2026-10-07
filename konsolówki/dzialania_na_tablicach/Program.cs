namespace dzialania_na_tablicach
{
    public class ArrayHandler
    {
        static private int[] MainArray {  get; set; }
        private int MainArraySize = 0;

        public ArrayHandler(int set_size)
        {
            MainArray = new int[set_size];
            MainArraySize = set_size;
            for (int i = 0; i < set_size; i++)
            {
                Random rand = new Random();
                MainArray[i] = rand.Next(1, 1001);
            }
        }

        public void DisplayArray()
        {
            for (int i = 0; i < MainArraySize;i++)
            {
                Console.WriteLine($"{i}: {MainArray[i]}");
            }
        }

        public int FirstOccurrenceOfValue(int value)
        {
            int index = Array.IndexOf( MainArray, value );
            if (index != -1)
            {
                Console.WriteLine($"Indeks szukanej wartości: {index}");
            }
            return index;

        }

        public int AllOddNumbers()
        {
            int counter = 0;
            for (int i = 0;i < MainArraySize; i++)
            {
                if (MainArray[i] % 2 != 0)
                {
                    Console.WriteLine(MainArray[i]);
                    counter++;
                }
            }

            return counter;
        }
        public double CalculateAvgOfElements()
        {
            int sum = 0;
            for (int i = 0; i < MainArraySize;  i++)
            {
                sum += MainArray[i];
            }

            return ((double)sum/MainArraySize);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            bool correct = false;
            Console.Write("Jak duża ma być tablica? ");
            while (!correct)
            {
                if (int.TryParse(Console.ReadLine(), out length) && length > 20)
                {
                    correct = true;
                }
                Console.WriteLine("Nieprawidłowa wartość, spróbuj ponownie");
            }

            ArrayHandler array = new ArrayHandler(length);

            Console.WriteLine("Wyświetlanie całej tablicy: ");
            array.DisplayArray();
            Console.WriteLine(); //for better readability

            int value;
            Console.Write("Jakiej wartości szukasz? ");
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Nieprawidłowa wartość, spróbuj ponownie");
            }
            array.FirstOccurrenceOfValue(value);
            Console.WriteLine(); //for better readability

            Console.WriteLine("Liczby nieparzyste");
            int CountOfOddNumbers = array.AllOddNumbers();
            Console.WriteLine($"{CountOfOddNumbers} liczb nieparzystych w tablicy");
            Console.WriteLine(); //for better readability

            Console.Write("Średnia arytmetyczna elementów tablicy: " + array.CalculateAvgOfElements());
            Console.WriteLine(); //for better readability
        }
    }
}
