using GymManager.AplicationServices.Cities;
using GymManager.AplicationServices.Members;
using GymManager.Core.Entities;
using GymManager.Web.Model;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace GymManager.Web.Controllers
{
    [Authorize]
    public class MembersController : Controller
    {
        private readonly IMembersAppService _membersAppService;
        private readonly ICititesAppService _citiesAppService;
        public MembersController(IMembersAppService membersAppService, ICititesAppService cititesAppService) 
        {
            _membersAppService = membersAppService;
            _citiesAppService = cititesAppService;

        }


        public async Task<IActionResult> Index()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File(@"Log/log.txt",
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} somone enter to members controller\n")
                .CreateLogger();
            Log.CloseAndFlush();

            List<Member> members = await _membersAppService.GetMembersAsync();
            MemberListViewModel viewModel = new MemberListViewModel(); 
            viewModel.Members = members;
            viewModel.NewMembersCount = members.Count;
            return View(viewModel);
        }

        public async Task<IActionResult> Create()
        {
            MemberViewModel viewModel = new MemberViewModel();
            viewModel.Cities = await _citiesAppService.GetCitiesAsync();
            return View(viewModel);
        }

        public async Task<IActionResult> Delete(int memberId) 
        {
            await _membersAppService.DeleteMemberAsync(memberId);
            return RedirectToAction("Index");
        }

        public IActionResult Test()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(MemberViewModel viewModel)
        {
            Member member = new Member
            {
                Name = viewModel.Name,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                City = new City
                {
                    Id = viewModel.CityId
                },
                MembershipType = new MembershipType
                {
                    Id = 1
                },
                Birthday = viewModel.Birthday,
                AllowNewsLetter = viewModel.AllowNewsLetter,
                isActive = false
            };
            await _membersAppService.AddMemberAsync(member);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MemberViewModel viewModel)
        {
            Member member = new Member
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                City = new City
                {
                    Id = viewModel.CityId
                },
                MembershipType = new MembershipType
                {
                    Id = viewModel.MembershipTypeId
                },
                Birthday = viewModel.Birthday,
                AllowNewsLetter = viewModel.AllowNewsLetter
            };

            await _membersAppService.EditMemberAsync(member);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Edit(int memberId)
        {
            Member member = await _membersAppService.GetMemberByIdAsync(memberId);

            MemberViewModel model = new MemberViewModel
            {
                Id = memberId,
                Name = member.Name,
                LastName = member.LastName,
                Email = member.Email,
                AllowNewsLetter = member.AllowNewsLetter,
                Birthday = member.Birthday,
                CityId = member.City.Id,
                Cities = await _citiesAppService.GetCitiesAsync(),
                MembershipTypeId = member.MembershipType.Id
            };
            
            return View(model);
        }
    }
}
