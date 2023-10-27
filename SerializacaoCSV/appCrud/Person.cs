using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCrud
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            // Construtor vazio
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
