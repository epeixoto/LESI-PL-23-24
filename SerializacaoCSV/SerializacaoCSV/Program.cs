using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System;
using CsvHelper;
using CsvHelper.Configuration;

namespace SerializacaoCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> records = new List<Pessoa>();

            Pessoa p = new Pessoa("Filipe", 28);
            // add objetos à lista
            records.Add(p);
            records.Add(new Pessoa("José", 28));
            records.Add(new Pessoa("Maria", 30));

            // Serialização para CSV
            using (var writer = new StreamWriter("data.csv")) { 
                using (var csv = new CsvWriter(writer, 
                    new CsvConfiguration
                    (CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(records);
                }
            }



            // Desserialização de CSV
            using (var reader = new StreamReader("data.csv")) { 
                using (var csv = new CsvReader(reader,
                    new CsvConfiguration(
                        CultureInfo.InvariantCulture)))
                {
                    var loadedRecords = 
                        csv.GetRecords<Pessoa>().ToList();
                    foreach (var record in loadedRecords)
                    {
                        Console.WriteLine("Nome: {0}, Age: {1}",
                            record.Nome, record.Idade);
                    }
                }
            }


        }
    }
}