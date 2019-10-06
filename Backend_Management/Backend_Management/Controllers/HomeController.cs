using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Backend_Management.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogInformation("Log message in the Index() mthod");

        }
        public IActionResult Index()
        {
            //_logger.LogInformation(e"Log message in the Index() mthod");
            return View();
        }
    }
}