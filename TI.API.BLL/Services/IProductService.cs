using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.API.Entities;

namespace TL.API.BLL.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetByID(string ID);
        List<Product> GetByCategory(string Category);
    }
}
