namespace Závod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Vypsani informaci o zavodu");
            Zavod dukla = new Zavod("Beh Dukla", "Dukla Pardubice", 10, 20);
            Zavodnik karel = new Zavodnik("Karel", "Opicka", 20, dukla.getmax_pocet());
            Zavodnik bohous = new Zavodnik("Bohous", "Bernardyn", 30, dukla.getmax_pocet());
            Zavodnik pepa = new Zavodnik("Josef", "Vyskoc", 25, dukla.getmax_pocet());
            karel.PredstavSe();
            bohous.PredstavSe();
            pepa.PredstavSe();


            dukla.PredstavZavod();
            dukla.pridejZavodnika(karel);
            dukla.pridejZavodnika(bohous);
            dukla.pridejZavodnika(pepa);
            dukla.PredstavZavod();
           
            dukla.odeberZavodnika("Bohous");
          
            pepa.zmenUdaje("Pepa", "", "");
            pepa.PredstavSe();
            dukla.ukonciZavod();
        }
        
    }
}
