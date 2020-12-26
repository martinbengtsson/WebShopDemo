using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer;
using System.Collections.Generic;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class OrdersController : ControllerBase
    {
        public readonly UnitOfWork UoW;
        public OrdersController(IUnitOfWork _uow)
        {
            this.UoW = _uow as UnitOfWork;
        }

        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Orders> Get()
        {
            //UoW.productRepository.GetAllRecords();
            return UoW.OrderRepository.GetOrdersAndProducts();    
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrdersController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //   // UoW.OrderRepository.AddRecord();
        //}
        [HttpPost]
        public void PostItem([FromBody] Orders order)
        {
            UoW.OrderRepository.AddRecord(order);
            UoW.SaveChanges();
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
