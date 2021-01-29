
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //private readonly IProductService _productService;
        //private readonly IProductRepository _productService;
        //ProductController(IProductService productService) {
        //    this._productService = productService;
        //}
        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            //var result = _productService.list();
            return new JsonResult("oi");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
