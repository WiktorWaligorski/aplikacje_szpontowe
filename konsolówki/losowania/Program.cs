using System.Runtime;

namespace losowania
{
    internal class Program
    {
        static public void DisplayResults(int[] counter)
        {
            for (int i = 0; i < counter.Length; i++)
            {
                Console.WriteLine($"Wystąpienie liczby {i+1}: {counter[i]}");
            }
        }

        static public void SetResults(int[] counter, int number)
        {
            counter[number - 1]++;
        }

        static public void FillArray(int[,] array)
        {
            int[] count = new int[49];
            //fills counting array with 0s. Would've set it as a global array if I could

            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int roll = 0;
                Console.Write($"Losowanie {i + 1}: ");
                //rolls six values for {i} column and assigns them
                for (int j = 0; j < 6; j++)
                {
                    bool repeat = true;
                    //goes through each element in {i} column, looking for values equal to the new value
                    //if it finds a repeated value, for is stopped and while is used again
                    while (repeat == true)
                    {
                        repeat = false;
                        roll = rand.Next(1, 50);
                        for (int k = 0; k < 6; k++)
                        {
                            if (roll == array[i, k])
                            {
                                repeat = true;
                                break;
                            }
                        }
                    }
                    array[i, j] = roll;
                    Console.Write(roll + " ");
                    SetResults(count, roll);
                    
                }
                Console.WriteLine();
            }
            DisplayResults(count);
        }
        static void Main(string[] args)
        {
            int amount;

            Console.Write("Ile zestawów losować? ");
            while (!int.TryParse(Console.ReadLine(), out amount))
            {
                Console.Write("Spróbuj ponownie ");
            }

            int[,] results = new int[amount, 6];

            FillArray(results);

        }
    }
}
