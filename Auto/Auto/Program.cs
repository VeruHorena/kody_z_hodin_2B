namespace Auto
{

    public class DopravniProstredek
    {
        public string Jmeno { get; set; }

        public void Jizda()
        {
            Console.WriteLine("Dopravní prostředek jede.");
        }
    }

    public class Auto : DopravniProstredek
    {
        public void ZapniMotor()
        {
            Console.WriteLine("Motor je zapnutý.");
        }
    }

    public class Kolo : DopravniProstredek
    {
        public void Slapej()
        {
            Console.WriteLine("Šlapání na kole.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Auto mojeAuto = new Auto();
            mojeAuto.Jmeno = "BMW";
            mojeAuto.Jizda();
            mojeAuto.ZapniMotor();

            Kolo mojeKolo = new Kolo();
            mojeKolo.Jmeno = "Favorit";
            mojeKolo.Jizda();
            mojeKolo.Slapej();
        }
    }

}


