

using DotnetCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;


        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public JsonResult Index()
        {

            //  return Json(new { type = "this annomous object on fly", Id = 123 });
            return Json(_employeeRepository.GetEmployee(1).Name);
        }
    }
}
