using MySqlConnector;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Osoba
{
    public int Id { get; set; }
    public string Jmeno { get; set; }
    public string Prijmeni { get; set; }
}

public class DatabaseService
{
    private const string connectionString = "Server=localhost;Database=ukazka;User ID=root;Password=;";

    public async Task<List<Osoba>> GetOsobyAsync()
    {
        List<Osoba> osoby = new();

        using var connection = new MySqlConnection(connectionString);
        await connection.OpenAsync();

        var command = new MySqlCommand("SELECT * FROM osoby", connection);
        using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            osoby.Add(new Osoba
            {
                Id = reader.GetInt32("id"),
                Jmeno = reader.GetString("jmeno"),
                Prijmeni = reader.GetString("prijmeni")
            });
        }

        return osoby;
    }
}