using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        public readonly UnitOfWork UoW;
        public ProductCategoryController(IUnitOfWork uow)
        {
            this.UoW = uow as UnitOfWork;
        }

        // GET: api/<ProductCategoryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
          throw new NotImplementedException();
        }

        // GET api/<ProductCategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

       
    }
}
