using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    public class EquipmentTypesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
