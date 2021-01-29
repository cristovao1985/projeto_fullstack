using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace api.api.Controllers
{
  

    // Controller para CRUD básico da tabela product

    
    
    public class ProductController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        //private readonly IProductService _productService;
        public ProductController(/*IProductService productService*/)
        {
            //this._productService = productService;
        }

       
        public JsonResult Get()
        {
           
                //var response = _productService.list();
                //if (response != null)
                //{
                //    return new JsonResult( response);
                //}
                //else
                //{
                    return new JsonResult();
                //}
                
            
        

        }
    }
}
