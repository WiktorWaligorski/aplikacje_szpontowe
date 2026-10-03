namespace Generacja_hasel
{
    internal class Program
    {
        static string GeneratePassword()
        {
            string Capitals = "ABCDEFGHIJKLMNOPRSTQUVWXYZ";
            string Lowercase = Capitals.ToLower();
            string Digits = "0123456789";
            string Diacretic = "ąęćśłńżźó";
            Diacretic += Diacretic.ToUpper();
            string Symbols = "!@#$%^&*()";
            string[] ArrayOfStrings = {Capitals, Lowercase, Digits, Diacretic, Symbols};
            int[,] UseCounter = { { 0, 3 }, { 0, 3 }, { 0, 2 }, { 0, 2 }, { 0, 2 } };

            char[] password = new char[12];
            Random random = new Random();

            for (int i = 0; i < password.Length; i++)
            {
                bool NextSlot = false;
                while (!NextSlot)
                {
                    int PickString = random.Next(0, ArrayOfStrings.Length);
                    if (UseCounter[PickString, 0] < UseCounter[PickString, 1])
                    {
                        UseCounter[PickString, 0]++;
                        string UsedString = ArrayOfStrings[PickString];
                        int RollChar = random.Next(0, UsedString.Length);
                        password[i] = UsedString[RollChar];
                        NextSlot = true;
                      
                    }
                }
            }

            return new string(password);
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(GeneratePassword());
            }
        }
    }
}
