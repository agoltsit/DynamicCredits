namespace WebApplication.Controllers
{
    using System.Web.Mvc;
    using log4net;

    public class HomeController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(nameof(HomeController));

        public ActionResult Index()
        {
            Log.Info(nameof(Index));

            return View();
        }

        public ActionResult About()
        {
            Log.Info(nameof(About));

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            Log.Info(nameof(Contact));

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}