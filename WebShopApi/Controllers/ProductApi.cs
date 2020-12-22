using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebShopApi.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class ProductApi : ControllerBase
    {
        public readonly UnitOfWork UoW;

        public ProductApi(IUnitOfWork uow)
        {
            this.UoW = uow as UnitOfWork;
        }
        // GET: api/<ProductApi>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return UoW.prodRepository.GetAllRecords();
        }

        // GET api/<ProductApi>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductApi>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductApi>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductApi>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
