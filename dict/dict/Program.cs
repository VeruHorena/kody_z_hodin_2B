namespace dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocet = 0;
            Dictionary<char, int> tabulkaZnaku = new Dictionary<char, int>();
            Console.WriteLine("Zadej slovo k analyze:");
            string slovo = Console.ReadLine();
            List<char> projiteZnaky = new List<char>();
            for (int i = 0; i < slovo.Length; i++)
            {
                pocet = 0;
                if (projiteZnaky.Contains(slovo[i]) == false)
                {
                    projiteZnaky.Add(slovo[i]);
                    for (int j = 0; j < slovo.Length; j++)
                    {
                        if (slovo[j] == slovo[i])
                            pocet++;

                    }
                    tabulkaZnaku.Add(slovo[i], pocet);
                }
            }
            vypisSlovnik(tabulkaZnaku);
        }
        public static void vypisSlovnik(Dictionary<char, int> dict)
        {
            foreach (char c in dict.Keys)
            {
                int hodnota;
                dict.TryGetValue(c, out hodnota);
                Console.WriteLine("Znak " + c + " je " + hodnota);


            }
        }

    }
    
}

