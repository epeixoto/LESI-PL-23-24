using CsvHelper;
using CsvHelper.Configuration;
using System.Formats.Asn1;
using System.Globalization;

namespace appCrud
{
    internal class Program
    {
        static List<Person> people = new List<Person>();
        static string csvFilePath = "people.csv";
        static void Main(string[] args)
        {
            LoadData();

            bool runApp = true;
            while (runApp)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Listar o obj Pessoas");
                Console.WriteLine("2. Adicionar o obj Pessoa");
                Console.WriteLine("3. Editar o obj Pessoa");
                Console.WriteLine("4. Remover o obj Pessoa");
                Console.WriteLine("5. Sair");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ListPeople();
                        break;
                    case "2":
                        AddPerson();
                        break;
                    case "3":
                        EditPerson();
                        break;
                    case "4":
                        DeletePerson();
                        break;
                    case "5":
                        SaveData();
                        runApp = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        //-->Métodos

        static void LoadData()
        {
            if (File.Exists(csvFilePath))
            {

                using (var reader = new StreamReader(csvFilePath))
                {
                    using (var csv = new CsvReader(reader,
                        new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        //var loadedRecords = csv.GetRecords<Person>().ToList();
                        people = csv.GetRecords<Person>().ToList();
                        foreach (var record in people)
                        {
                            Console.WriteLine("Nome: {0}, Age: {1}", 
                                record.Name, record.Age);
                        }
                    }
                }
            }
        }
        static void ListPeople()
        {
            Console.WriteLine("Lista de Pessoas:");
            foreach (var person in people)
            {
                Console.WriteLine($"Nome: {person.Name}, Idade: {person.Age}");
            }
        }

        static void AddPerson()
        {
            Console.WriteLine("Adicionar Pessoa:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Idade: ");
            int age = int.Parse(Console.ReadLine());

            var person = new Person(name, age);
            people.Add(person);
            Console.WriteLine("Pessoa adicionada com sucesso.");
        }

        static void EditPerson()
        {
            Console.WriteLine("Editar Pessoa:");
            Console.Write("Índice da Pessoa a ser editada: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < people.Count)
            {
                Console.Write("Novo Nome: ");
                string name = Console.ReadLine();
                Console.Write("Nova Idade: ");
                int age = int.Parse(Console.ReadLine());

                people[index].Name = name;
                people[index].Age = age;
                Console.WriteLine("Pessoa editada com sucesso.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Nenhuma Pessoa editada.");
            }
        }

        static void DeletePerson()
        {
            Console.WriteLine("Remover Pessoa:");
            Console.Write("Índice da Pessoa a ser excluída: ");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < people.Count)
            {
                people.RemoveAt(index);
                Console.WriteLine("Pessoa excluída com sucesso.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Nenhuma Pessoa excluída.");
            }
        }

       

        static void SaveData()
        {
            // Serialização para CSV
            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(people);
            }
        }

    }
}