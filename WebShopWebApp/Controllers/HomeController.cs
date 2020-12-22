using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using WebShopWebApp.Models;

namespace WebShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UnitOfWork UoW;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork uow)
        {
            this.UoW = uow as UnitOfWork;

            _logger = logger;
            

        }

        public IActionResult Index()
        {

            return View(UoW.prodRepository.GetAllRecords().ToList());
          // var view = UoW.ProductRepository.GetAllRecords();
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
