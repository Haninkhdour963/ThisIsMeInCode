using Microsoft.AspNetCore.Mvc;
using HaneenWebApp.Models;

namespace HaneenWebApp.Controllers
{
    public class HaneenController : Controller
    {
        private static Haneen _han = new Haneen();

        public IActionResult Index()
        {
            return View(_han);
        }

        [HttpPost]
        public IActionResult TryAction()
        {
            _han.Try();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult LearnAction()
        {
            _han.Learn();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CoffeeAction()
        {
            _han.CoffeeBreak();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult PepTalkAction()
        {
            _han.SelfPepTalk();
            return RedirectToAction("Index");
        }
    }
}
