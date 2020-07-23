using BusinessLayer;
using BusinessLayer.ModelsDTO;
using System.Web.Mvc;

namespace HOMEWORK.Controllers
{
    public class HomeController : Controller
    {
        private readonly ManagerDisc _manager;
        public HomeController()
        {
            _manager = new ManagerDisc();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(DataForDiscrimDTO discrimDTO)
        {
            _manager.Calculate(discrimDTO);
         

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult IndexResult()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IndexResult(DataForDiscrimDTO discrimDTO, ManagerDisc managerDisc)
        {
            managerDisc.Calculate(discrimDTO);
            return View(managerDisc);
              
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}