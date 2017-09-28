using System.Threading.Tasks;
using System.Web.Mvc;

namespace FunnyTask.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            var service = new Service();
            var result = service.Perfom().Result;
            return result;
        }
    }
    public class Service
    {
        public async Task<string> Perfom()
        {
            var manager = new Manager();
            return await manager.Perfom();
        }
    }
    public class Manager
    {
        public async Task<string> Perfom()
        {
            await Task.Delay(100);
            return "Bang";
        }
    }

}