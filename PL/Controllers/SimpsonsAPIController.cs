using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace PL.Controllers
{
    public class SimpsonsAPIController : Controller
    {
        public ActionResult Simpsons()
        {
            return View();
        }
    }
}
