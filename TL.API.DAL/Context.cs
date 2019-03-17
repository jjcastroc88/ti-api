using TL.API.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.IO;
using System.Collections.Generic;

namespace TL.API.DAL
{
    public class Context: DbContext
    {
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder ModelBuilder)
        {
            ModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(ModelBuilder);
        }

        public void Init()
        {
            if (!this.Database.Exists())
            {
                List<Product> ProductInstance = JArray.Parse(Properties.Resources.data).ToObject<List<Product>>();

                foreach (Product Product in ProductInstance)
                {
                    DbSet Entity = this.Set<Product>();
                    Entity.Add(Product);
                    this.SaveChanges();
                }
            }
        }
    }
}
