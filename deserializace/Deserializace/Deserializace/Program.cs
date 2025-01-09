using System.Text.Json;
using System.Xml.Serialization;

namespace Deserializace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trida tridaXml = DeserializujZXml("trida.xml");
            Console.WriteLine("Data načtená z XML souboru:");
            VypisData(tridaXml);

            // Načítání dat z JSON souboru
            Trida tridaJson = DeserializujZJson("trida.json");
            Console.WriteLine("\nData načtená z JSON souboru:");
            VypisData(tridaJson);

            static Trida DeserializujZXml(string soubor)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Trida));
                using (StreamReader reader = new StreamReader(soubor))
                {
                    return (Trida)serializer.Deserialize(reader);
                }
            }

            // Metoda pro deserializaci z JSON
            static Trida DeserializujZJson(string soubor)
            {
                string jsonString = File.ReadAllText(soubor);
                return JsonSerializer.Deserialize<Trida>(jsonString);
            }

            // Metoda pro výpis dat
            static void VypisData(Trida trida)
            {
                Console.WriteLine($"Třída: {trida.Nazev}");
                foreach (var student in trida.SeznamStudentu)
                {
                    double prumer = student.PrumernyVysledek();
                    Console.WriteLine($"{student.Jmeno} {student.Prijmeni} - Průměrná známka: {prumer:F2}");
                }
            }
        }
    }
    }

 public class Trida
{
    public string Nazev;
    public void setNazev(String nazev)
    {
        this.Nazev = nazev;
    }

    public String getNazev()
    {
        return this.Nazev;
    }
    public List<Student> SeznamStudentu = new List<Student>();
    public void setZnamka(Student s)
    {
        this.SeznamStudentu.Add(s);
    }
}

  public class Student
{
    public string Jmeno;

    public void setJmeno(String jmeno)
    {
        this.Jmeno = jmeno;
    }
    public String getJmeno()
    {
        return this.Jmeno;
    }
    public string Prijmeni;

    public void setPrijmeni(String prijmeni)
    {
        this.Prijmeni = prijmeni;
    }

    public String getPrijmeni()
    {
        return this.Prijmeni;
    }
    public List<int> Znamky = new List<int>();
    public void setZnamka(int znamka)
    {
        this.Znamky.Add(znamka);
    }
    public double PrumernyVysledek()
    {
        if (Znamky.Count == 0)
            return 0;
        double suma = 0;
        foreach (var znamka in Znamky)
        {
            suma += znamka;
        }
        return suma / Znamky.Count;
    }
}
