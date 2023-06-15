using GymManager.AplicationServices.Members;
using GymManager.Core.Entities;
using GymManager.Web.Model;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMembersAppService _membersAppService;
        public HomeController(IMembersAppService membersAppService)
        {
            _membersAppService = membersAppService;
        }
        public async Task<IActionResult> Index()
        {
            List<Member> members = await _membersAppService.GetMembersAsync();
            MemberListViewModel viewModel = new MemberListViewModel();
            viewModel.Members = members;
            viewModel.NewMembersCount = members.Count;
            return View(viewModel);
        }
    }
}
