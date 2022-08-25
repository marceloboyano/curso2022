using ApiDapper.Data;
using ApiDapper.Models;

namespace ApiDapper.Rules
{
    public class ProductRule
    {
        public List<Product> GetAllProducts()
        {
            var data = new NorthwindData();
            return data.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            var data = new NorthwindData();
            var p = new Product()
            {
                ProductID = id
            };


            return data.GetProductById(p);      
        }
    }


}
