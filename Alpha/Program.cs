namespace Kalkulacka
{
    internal class Program
    {
        public static double NactiDesetinneCisloZKonzole()
        {
            string cisloText = Console.ReadLine();
            bool jeCislo = double.TryParse(cisloText, out double cislo);
            while (jeCislo == false)
            {
                Console.WriteLine("Neplatné zadání, zkus to znovu:");
                cisloText = Console.ReadLine();
                jeCislo = double.TryParse(cisloText, out cislo);
            }
            return cislo;
        }
        public static string NactiOperatorZKonzole()
        {
            string operat = Console.ReadLine();
            while (operat != "+" && operat != "-" && operat != "*" && operat != "/" && operat != "^" && operat != "X")
            {
                Console.WriteLine("Zadal jsi špatně operátor, zkus to znovu:");
                operat = Console.ReadLine();
            }
            return operat;
        }
        static void Main(string[] args)
        {
            Kalkulacka kacka = new Kalkulacka { };

            Console.WriteLine("Ahoj, uživateli");
            Console.WriteLine("Zadej první číslo:");
            kacka.AktualniVysledek = NactiDesetinneCisloZKonzole();
            while (true)
            {
                Console.WriteLine("Zadej operátor:");
                Console.WriteLine("Pro ukončení kalkulačky zadej X");
                string operat = NactiOperatorZKonzole();
                if (operat == "X")
                {
                    return;
                }
                Console.WriteLine("Zadej druhé číslo:");
                double cisloUzivatele = NactiDesetinneCisloZKonzole();
                switch (operat)
                {
                    case "+":
                        kacka.Pricti(cisloUzivatele);
                        break;
                    case "-":
                        kacka.Odecti(cisloUzivatele);
                        break;
                    case "*":
                        kacka.Vynasob(cisloUzivatele);
                        break;
                    case "/":
                        kacka.Vydel(cisloUzivatele);
                        break;
                    case "^":
                        kacka.Umocni(cisloUzivatele);
                        break;
                }
                Console.WriteLine($"Výsledek: {kacka.VratAktualniVysledek()}");
                Console.WriteLine("");
            }
        }
    }
}
