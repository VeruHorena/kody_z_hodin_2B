namespace Zamestnanec
{
    public class Zamestnanec
    {
        public string Jmeno { get; set; }

        public void Pracuj()
        {
            Console.WriteLine("Zaměstnanec pracuje.");
        }
    }

    public class Ucitel : Zamestnanec
    {
        public void Uc()
        {
            Console.WriteLine("Učitel učí.");
        }
    }

    public class Programator : Zamestnanec
    {
        public void Programuj()
        {
            Console.WriteLine("Programátor programuje.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ucitel ucitel = new Ucitel();
            ucitel.Jmeno = "Jan Novák";
            ucitel.Pracuj();
            ucitel.Uc();

            Programator programator = new Programator();
            programator.Jmeno = "Petr Svoboda";
            programator.Pracuj();
            programator.Programuj();
        }
    }

}
