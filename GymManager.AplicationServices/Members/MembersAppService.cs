using GymManager.Core.Entities;
using GymManager.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.Members
{
    public class MembersAppService : IMembersAppService
    {
        private readonly IRepository<int, Member> _repository;

        public MembersAppService(IRepository<int, Member> repository)
        {
            _repository = repository;
        }

        public async Task<int> AddMemberAsync(Member member)
        {
            await _repository.AddAsync(member);
            return member.Id;
        }

        public async Task DeleteMemberAsync(int memberId) => await _repository.DeleteAsync(memberId);

        public async Task EditMemberAsync(Member member) => await _repository.UpdateAsync(member);

        public async Task<Member> GetMemberByIdAsync(int memberId) => await _repository.GetAsync(memberId);

        public async Task<List<Member>> GetMembersAsync() => await _repository.GetAll().ToListAsync();


    }


}
