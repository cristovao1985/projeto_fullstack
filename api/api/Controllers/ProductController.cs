using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using domain.Entities;
using domain.Services;
using Microsoft.AspNetCore.Mvc;




// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
       
        public ProductController(IProductService productService)
        {
            this._productService = productService;
           
           
        }
        // GET: api/<ProductController>
        [HttpGet]
        public JsonResult Get()
        {
            var result = _productService.list();
            return new JsonResult(result);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var result = _productService.get(id);

            return new JsonResult(result);
            
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public JsonResult Put([FromBody] Product product)
        {
            var valid = _productService.validateProductID(product.id);
            if (valid.success)
            {
                var result = _productService.update(product);
                return new JsonResult(result);
            }
            else
            {
                return new JsonResult(valid);
            }
       
           
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            var valid = _productService.validateProductID(id);
            if (valid.success)
            {
                var result = _productService.delete(id);
                return new JsonResult(result);
            }
            else
            {
                return new JsonResult(valid);
            }
           
        }
    }
}
