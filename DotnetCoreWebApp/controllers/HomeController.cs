

using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {

            return Json(new { type = "this annomous object on fly", Id = 123 });
        }
    }
}
