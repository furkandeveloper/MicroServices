using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetProducts()
        {
            return Ok(new string[] { "Samsung Galaxy Note 10 , Iphone 7 Plus , Xioami Redmi Note 7" });
        }
    }
}