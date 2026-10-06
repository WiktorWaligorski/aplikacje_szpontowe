using System;
using kostki2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kostki2_testy
{
    [TestClass]
    public class Kostka
    {
        [TestMethod]
        public void TestRzut()
        {
            var kostka = new kostki2.Kostka();
            kostka.Rzut();
            Assert.IsTrue(kostka.Wynik >= 1 && kostka.Wynik <= 6, "Wynik rzutu powinien być w zakresie od 1 do 6.");
        }

        [TestMethod]
        public void TestDostepnosc()
        {
            var kostka = new kostki2.Kostka();
            bool Dostepnosc_przed = kostka.Dostepna;
            int wartosc_przed = kostka.Wynik;
            kostka.Zablokuj();
            Assert.IsTrue(Dostepnosc_przed != kostka.Dostepna, "Kostka nie zmienia dostępności");
            Assert.AreEqual(kostka.Wynik, wartosc_przed);
           
        }
    }
}
