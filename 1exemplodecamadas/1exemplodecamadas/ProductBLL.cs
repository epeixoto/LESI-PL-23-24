using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1exemplodecamadas
{
    //Regras de negócio
    //Businness Logic Layer
    internal class ProductBLL
    {
        private ProductDAL productDAL;

        public ProductBLL()
        {
            productDAL = new ProductDAL();
        }

        public List<Product> GetAllProducts()
        {
            return productDAL.GetAllProducts();
        }

        public void AddProduct(Product product)
        {
            var products = GetAllProducts();
            products.Add(product);
            productDAL.SaveProducts(products);
        }
    }
}
