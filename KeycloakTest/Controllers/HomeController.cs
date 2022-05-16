using Mikro.IDM.AspNet.Keycloak.CrossCutting;
using System.Web.Mvc;

namespace KeycloakTest.Controllers
{
    [KCAuthorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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