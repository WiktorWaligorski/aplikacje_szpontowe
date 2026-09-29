namespace pesel
{
    internal class Program
    {

        static public char CheckGender(string PESEL)
        {
            int Digit = int.Parse(PESEL[^2].ToString());
            if (Digit % 2 == 0)
            {
                return 'K';
            }
            else
            {
                return 'M';
            }
        }

/*
**********************************************
nazwa funkcji: ControlSum
opis funkcji: funkcja sprawdza poprawność podanego numeru pesel poprzez wyliczenie sumy kontrolnej
parametry: PESEL - zmienna tekstowa przechowująca podany przez użytkownika pesel
zwracany typ i opis: zwraca wartość logiczną: true jeżeli pesel spełnia warunek, lub false w przeciwnym wypadku
autor: <numer zdającego>
**********************************************
*/

        static public bool ControlSum(string PESEL)
        {
            int[] Value = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int S = 0;
            for (int i = 0; i < PESEL.Length - 1; i++)
            {
                S += int.Parse(PESEL[i].ToString()) * Value[i];
            }
            int M = S % 10;
            int R;
            if (M < 0)
            {
                R = 0;
            }
            else
            {
                R = 10 - M;
            }

            if (R == int.Parse(PESEL[^1].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    
        static void Main(string[] args)
        {
            string PESEL = "55030101193";
            Console.Write("Podaj pesel: ");
            PESEL = Console.ReadLine();

            char Gender = CheckGender(PESEL);

            Console.Write("płeć: ");
            switch (Gender)
            {
                case 'K':
                    Console.WriteLine("Kobieta");
                    break;
                case 'M':
                    Console.WriteLine("Mężczyzna");
                    break;
                default:
                    Console.WriteLine("Błąd");
                    break;
            }

            if (ControlSum(PESEL))
            {
                Console.WriteLine("pesel prawidłowy, suma kontrolna poprawnas");
            }
            else
            {
                Console.WriteLine("pesel nieprawidłowy, suma kontrolna niepoprawna");
            }
        }
    }
}
