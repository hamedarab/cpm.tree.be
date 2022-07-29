using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cpm.tree.WebAppMvcIndividualAccount.Controllers
{
    public class HomeMvcReadWriteController : Controller
    {
        // GET: HomeMvcReadWriteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomeMvcReadWriteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeMvcReadWriteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeMvcReadWriteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeMvcReadWriteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeMvcReadWriteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeMvcReadWriteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeMvcReadWriteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
