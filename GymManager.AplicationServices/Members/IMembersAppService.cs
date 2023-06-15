using GymManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.Members
{
    public interface IMembersAppService
    {
        Task<List<Member>> GetMembersAsync();

        Task<int> AddMemberAsync(Member member);

        Task DeleteMemberAsync(int memberId);

        Task<Member> GetMemberByIdAsync(int memberId);

        Task EditMemberAsync(Member member);
    }
}
