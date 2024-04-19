namespace Kalkulacka
{

    public class Kalkulacka
    {
        public double AktualniVysledek = 0;
        public double Pricti(double cisloUzivatele)
        {
            return AktualniVysledek = AktualniVysledek + cisloUzivatele;
        }
        public double Odecti(double cisloUzivatele)
        {
            return AktualniVysledek = AktualniVysledek - cisloUzivatele;
        }
        public double Vynasob(double cisloUzivatele)
        {
            return AktualniVysledek = AktualniVysledek * cisloUzivatele;
        }
        public double Vydel(double cisloUzivatele)
        {
            return AktualniVysledek = AktualniVysledek / cisloUzivatele;
        }
        public double Umocni(double cisloUzivatele)
        {
            double mocnenec = AktualniVysledek;
            AktualniVysledek = 1;
            for (int i = 1; i <= cisloUzivatele; i++)
            {
                AktualniVysledek = AktualniVysledek * mocnenec;
            }
            return AktualniVysledek;
        }
        public double VratAktualniVysledek()
        {
            return AktualniVysledek;
        }
    }
}
