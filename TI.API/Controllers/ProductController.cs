using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TL.API.BLL.Services;

namespace TI.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        private IProductService _ProductService;

        protected IProductService ProductService
        {
            get
            {
                return _ProductService ?? new ProductService();
            }
        }

        [Route("")]
        [HttpGet]
        public IHttpActionResult GetProduct()
        {
            return Ok(ProductService.GetAll());
        }

        [Route("{id:guid}")]
        [HttpGet]
        public IHttpActionResult GetProduct(string ID)
        {
            return Ok(ProductService.GetByID(ID));
        }

        [Route("{category}")]
        [HttpGet]
        public IHttpActionResult GetProductByCategory(string Category)
        {
            return Ok(ProductService.GetByCategory(Category));
        }


    }
}
