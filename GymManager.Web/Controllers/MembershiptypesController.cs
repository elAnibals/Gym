using GymManager.AplicationServices.MembershipTypes;
using GymManager.Core.Entities;
using GymManager.Web.Model;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    public class MembershipTypesController : Controller
    {
        private readonly IMembershipTypesAppService _membershipTypesAppService;

        public MembershipTypesController(IMembershipTypesAppService membershipTypesAppService)
        {
            _membershipTypesAppService = membershipTypesAppService;
        }


        public async Task<IActionResult> Index()
        {
            List<MembershipType> membershipTypes = await _membershipTypesAppService.GetMembershipTypesAsync();
            MembershipTypesListViewModel viewModel = new MembershipTypesListViewModel();
            viewModel.MembershipTypes = membershipTypes;
           
            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(MembershipTypeViewModel viewModel)
        {
            MembershipType member = new MembershipType
            {
                Name = viewModel.Name,
                Cost = viewModel.Cost,
                Duration = viewModel.Duration,
                CreationDate = DateTime.Now
            };
            await _membershipTypesAppService.AddMembershipTypeAsync(member);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int membershipTypeId)
        {
            await _membershipTypesAppService.DeleteMembershipTypeAsync(membershipTypeId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int membershipTypeId)
        {
            MembershipType membershipType = await _membershipTypesAppService.GetMembershipTypeByIdAsync(membershipTypeId);

            MembershipTypeViewModel model = new MembershipTypeViewModel()
            {
                Id = membershipTypeId,
                Name = membershipType.Name,
                Cost = membershipType.Cost,
                Duration = membershipType.Duration,
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(MembershipTypeViewModel viewModel)
        {
            MembershipType member = new MembershipType() 
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Duration = viewModel.Duration,
                Cost = viewModel.Cost,
                CreationDate = DateTime.Now 
            };

            await _membershipTypesAppService.EditMembershipTypeAsync(member);
            return RedirectToAction("Index");
        }
    }
}
