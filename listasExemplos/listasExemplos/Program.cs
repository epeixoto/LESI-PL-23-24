using System.Collections;

namespace listasExemplos
{
    internal class Program
    {
        static Hashtable hashtable = new Hashtable();

        static void Main(string[] args)
        {

            
           // Criar um dicionário
            Dictionary<string, int> dict = new Dictionary<string, int>();

            // Adicionar elementos
            dict.Add("Maçã", 3);
            dict.Add("Pera", 5);
            dict.Add("Laranja", 2);

            // Remover um elemento
            dict.Remove("Maçã");

            // Verificar se uma chave está presente
            if (dict.ContainsKey("Pera"))
            {
                Console.WriteLine("Quantidade de Peras: " + dict["Pera"]);
            }

            // Iterar sobre pares chave-valor
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
             

            /*  
            // Criar uma lista ordenada
            SortedList<int, string> sortedList = new SortedList<int, string>();

            // Adicionar elementos
            sortedList.Add(3, "Três");
            sortedList.Add(1, "Um");
            sortedList.Add(2, "Dois");

            // Remover um elemento
            sortedList.Remove(1);

            // Verificar se uma chave está presente
            if (sortedList.ContainsKey(2))
            {
                Console.WriteLine("Valor associado a 2: " + sortedList[2]);
            }

            // Iterar sobre pares chave-valor (ordenados por chave)
            foreach (var kvp in sortedList)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            
             */

            /*
                // Criar um conjunto
                HashSet<string> set = new HashSet<string>();

                // Adicionar elementos
                set.Add("1");
                set.Add("1");
                set.Add("2");
                set.Add("3");

                // Remover um elemento
                set.Remove("3");

                // Verificar se existe um elemento no conjunto
                Console.WriteLine("Contém 3? " + set.Contains("3"));

                // Iterar sobre elementos
                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }*/
             


            /*
               // Criar uma Stack
                Stack<int> stack = new Stack<int>();

                // Adicionar elementos
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);

                // Converter num array para fazer uma pesquisa
                int[] array = stack.ToArray();

                // Fazer uma pesquisa num array
                int searchValue = 2;
                bool found = Array.Exists(array, element => element == searchValue);

                // Mostra resultado
                Console.WriteLine($"O valor {searchValue} foi encontrado na Stack? {found}");

                 // Remover e imprimir elementos (LIFO - Last In First Out)
                 while (stack.Count > 0)
                 {
                     int item = stack.Pop();
                      Console.WriteLine(item);
                 }
  
             */

            /*
             // Criar uma Queue
                Queue<int> queue = new Queue<int>();

                // Adicionar elementos
                queue.Enqueue(1);
                queue.Enqueue(2);
                queue.Enqueue(3);

                // Converter num array para fazer uma pesquisa
                int[] array = queue.ToArray();

                // fazer uma pesquisa no array
                int searchValue = 2;
                bool found = Array.Exists(array,
                    element => element == searchValue);

                // Mostra resultado
                Console.WriteLine($"O valor {searchValue} foi " +
                    $"encontrado na Queue? {found}");

                   // Remover e imprimir elementos (FIFO - First In First Out)
                    while (queue.Count > 0)
                    {
                        int item = queue.Dequeue();
                        Console.WriteLine(item);
                    }*/
  
             

            /*
            int[] numeros = new int[10];
            int tamanhoAtual = 0;

            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Procurar elemento");
                Console.WriteLine("3. Remover elemento");
                Console.WriteLine("4. Listar elementos");
                Console.WriteLine("5. Sair");

                int escolha;
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            if (tamanhoAtual < numeros.Length)
                            {
                                Console.Write("Introduza um elemento no array: ");
                                if (int.TryParse(Console.ReadLine(), out int elemento))
                                {
                                    numeros[tamanhoAtual] = elemento;
                                    tamanhoAtual++;
                                    Console.WriteLine("Elemento inserido com sucesso.");
                                }
                                else
                                {
                                    Console.WriteLine("Por favor, insira um número válido.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("A lista está cheia. Não é possível inserir mais elementos.");
                            }
                            break;

                        case 2:
                            Console.Write("Introduza um elemento a ser procurado no array: ");
                            if (int.TryParse(Console.ReadLine(), out int elementoPesquisa))
                            {
                                int indice = Array.IndexOf(numeros, elementoPesquisa, 0, tamanhoAtual);
                                if (indice != -1)
                                {
                                    Console.WriteLine($"O elemento '{elementoPesquisa}' foi encontrado na posição {indice}.");
                                }
                                else
                                {
                                    Console.WriteLine($"O elemento '{elementoPesquisa}' não foi encontrado no array.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Por favor, insira um número válido.");
                            }
                            break;

                        case 3:
                            Console.Write("Introduza um elemento a ser removido no array: ");
                            if (int.TryParse(Console.ReadLine(), out int elementoRemover))
                            {
                                int indiceRemover = Array.IndexOf(numeros, elementoRemover, 0, tamanhoAtual);
                                if (indiceRemover != -1)
                                {
                                    // Remover o elemento e ajustar o tamanhoAtual
                                    for (int i = indiceRemover; i < tamanhoAtual - 1; i++)
                                    {
                                        numeros[i] = numeros[i + 1];
                                    }
                                    tamanhoAtual--;
                                    Console.WriteLine($"O elemento '{elementoRemover}' foi removido com sucesso.");
                                }
                                else
                                {
                                    Console.WriteLine($"O elemento '{elementoRemover}' não foi encontrado no array.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Por favor, insira um número válido.");
                            }
                            break;

                        case 4:
                            if (tamanhoAtual == 0)
                            {
                                Console.WriteLine("O array está vazio.");
                            }
                            else
                            {
                                Console.WriteLine("Elementos no array:");
                                for (int i = 0; i < tamanhoAtual; i++)
                                {
                                    Console.WriteLine(numeros[i]);
                                }
                            }
                            break;

                        case 5:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }

                Console.WriteLine();
            }*/

            
            /*
            //Hastable
            // Adicionar elementos
            hashtable.Add("Maçã", 3);
            hashtable.Add("Pera", 5);
            hashtable.Add("Laranja", 2);

            // Remover um elemento
            Remover("Toranja");

            // Verificar se uma chave está presente
            Procurar("Pera");

            // Iterar sobre pares chave-valor
            Listar();
            */
        }

        static void Remover(string chave)
        {
            if (hashtable.ContainsKey(chave))
            {
                hashtable.Remove(chave);
                Console.WriteLine($"Elemento com chave '{chave}' removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Chave '{chave}' não encontrada na Hashtable.");
            }
        }

        static void Procurar(string chave)
        {
            if (hashtable.ContainsKey(chave))
            {
                Console.WriteLine($"Quantidade de {chave}: {hashtable[chave]}");
            }
            else
            {
                Console.WriteLine($"Chave '{chave}' não encontrada na Hashtable.");
            }
        }

        static void Listar()
        {
            Console.WriteLine("Elementos na Hashtable:");

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}