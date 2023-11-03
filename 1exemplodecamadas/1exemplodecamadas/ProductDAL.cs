using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _1exemplodecamadas
{
    //Acesso ao dados
    //Data Access Layer
    internal class ProductDAL
    {
        private const string dataFilePath = "products.json";

        public List<Product> GetAllProducts()
        {
            if (File.Exists(dataFilePath))
            {
                var json = File.ReadAllText(dataFilePath);
                return JsonConvert.DeserializeObject<List<Product>>(json);
            }
            return new List<Product>();
        }

        public void SaveProducts(List<Product> products)
        {
            var json = JsonConvert.SerializeObject(products, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(dataFilePath, json);
        }
    }
}
