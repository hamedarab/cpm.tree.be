using Microsoft.AspNetCore.Mvc;

namespace cpm.tree.WebAppMvcIndividualAccount.Controllers
{
    public class HomeMvcEmptyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
