using MySql.Data.MySqlClient;


namespace NapojeniDTB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conn = "server=localhost;database=studenti;user=root;password=;";
            MySqlConnection connection = new MySqlConnection(conn);
            connection.Open();
            string select = "SELECT * FROM students";
            MySqlCommand cmd = new MySqlCommand(select, connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Přečteme data podle názvu sloupců nebo indexů
                int id = reader.GetInt32("Cislo");
                string name = reader.GetString("Jmeno");
                string prijmeni = reader.GetString("Prijmeni");

                Console.WriteLine($"ID: {id}, Jméno: {name}, Věk: {prijmeni}");
            }

            reader.Close();
            connection.Close();
        }
    }
}
