using SerializacaoCSV;
using System.Text.Json;

namespace JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> records = new List<Pessoa>();

            // add objetos à lista
            records.Add(new Pessoa("João", 30));
            records.Add(new Pessoa("Ana", 30));

            // Serialização para JSON
            string json = JsonSerializer.
                Serialize(records); //Converter utf-8

            File.WriteAllText("data.json", json);




            // Desserialização de JSON
            string loadedJson = File.
                ReadAllText("data.json");
            var loadedRecords = JsonSerializer.
                Deserialize<List<Pessoa>>(loadedJson);

            foreach (var record in loadedRecords)
            {
                Console.WriteLine($"Name: {record.Nome}," +
                    $" Age: {record.Idade}");
            }
        }
    }
}