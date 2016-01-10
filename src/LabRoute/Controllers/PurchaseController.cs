using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LabRoute.Controllers
{   
    [Route("orders")]
    public class PurchaseController : Controller
    {
        [Route("index")]
        public IActionResult ShowAll()
        {
            return View();
        }
        [Route("details/{id:int}")]
        public IActionResult Show(int id)
        {
            return View();
        }
    }
}
