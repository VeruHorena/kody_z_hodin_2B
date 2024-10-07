namespace dedicnost_dopravni_prostredky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto otik = new Auto("Otik", 10, "zluta", 4, "benzin");
            Auto karlik = new Auto("Karlik", 20, "cervena", 4, "diesel");
            DopravniProstredek.vypisPocet();
        }
    }
}
