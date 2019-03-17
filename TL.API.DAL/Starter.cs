using Newtonsoft.Json.Linq;
using TL.API.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace TL.API.DAL
{
    public class Starter
    {
        private List<Product> ProductInstance;

        public Starter(JArray Data)
        {
            ProductInstance = Data.ToObject<List<Product>>();
        }

        public void InitialData()
        {
            foreach (Product Product in ProductInstance)
            {
                using (var Db = new Context())
                {
                    DbSet Entity = Db.Set<Product>();

                    Entity.Add(Product);
                    Db.SaveChanges();
                }
            }
        }
    }
}