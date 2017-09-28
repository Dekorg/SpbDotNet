using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FunnyTask2.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            if (System.Web.HttpContext.Current == null)
                throw new Exception("Все пропало");

            await Task.Delay(100).ConfigureAwait(false);

            if (System.Web.HttpContext.Current == null)
                throw new Exception("Все совсем пропало");

            return View();
        }
    }
}