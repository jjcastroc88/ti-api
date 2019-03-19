using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.API.DAL;
using TL.API.Entities;

namespace TL.API.BLL.Services
{
    public class ProductService : IProductService
    {
        Context context = new Context();

        public ProductService()
        {
            this.context.Init();
        }

        public List<Product> GetAll()
        {
            return context.Product.ToList();
        }

        public List<Product> GetByCategory(string Category)
        {
            List<Product> ProductList = new List<Product>();

            Category = Category.ToLower();
            Category = char.ToUpper(Category[0]) + Category.Substring(1);

            foreach (Product Product in context.Product.ToList())
            {
                if (Product.Categories.Contains(Category))
                {
                    ProductList.Add(Product);
                }
            }

            return ProductList;
        }

        public Product GetByID(string ID)
        {
            return context.Product.Find(ID);
        }
    }
}
