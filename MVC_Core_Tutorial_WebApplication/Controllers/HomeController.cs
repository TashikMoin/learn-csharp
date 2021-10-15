using Microsoft.AspNetCore.Mvc;

namespace MVC_Core_WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public string index()
        {
            return "Hello from home controller's index action method";
        }
    }
}
