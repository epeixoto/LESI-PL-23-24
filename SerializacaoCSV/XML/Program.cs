using SerializacaoCSV;
using System.Reflection.PortableExecutable;
using System.Xml.Serialization;

namespace XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> records = new List<Pessoa>();

            // Adicionando objetos à lista
            records.Add(new Pessoa("Bruno", 31));
            records.Add(new Pessoa("Alice", 30));

            // Serialização para XML
            XmlSerializer serializer = new 
                XmlSerializer(typeof(List<Pessoa>));
            using (StreamWriter writer = new
                StreamWriter("data.xml"))
            {
                serializer.Serialize(writer, records);
            }

            // Desserialização de XML
            using (StreamReader reader = 
                new StreamReader("data.xml"))
            {
                var loadedRecords = 
                    (List<Pessoa>)serializer.
                    Deserialize(reader);

                foreach (var record in loadedRecords)
                {
                    Console.WriteLine($"Name: {record.Nome}," +
                        $" Age: {record.Idade}");
                }
            }
        }
    }
}