using GymManager.Core.Entities;
using GymManager.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.MembershipTypes
{
    public class MembershipTypesAppService : IMembershipTypesAppService
    {

        private readonly IRepository<int, MembershipType> _repository;

        public MembershipTypesAppService(IRepository<int, MembershipType> repository)
        {
            _repository = repository;
        }


        public async Task<int> AddMembershipTypeAsync(MembershipType membershipType)
        {
            await _repository.AddAsync(membershipType);
            return membershipType.Id;
        }

        public async Task DeleteMembershipTypeAsync(int membershipTypeId) => await _repository.DeleteAsync(membershipTypeId);

        public async Task EditMembershipTypeAsync(MembershipType membershipType) => await _repository.UpdateAsync(membershipType);

        public async Task<MembershipType> GetMembershipTypeByIdAsync(int membershipTypeId) => await _repository.GetAsync(membershipTypeId);

        public async Task<List<MembershipType>> GetMembershipTypesAsync() => await _repository.GetAll().ToListAsync();
    }
}
