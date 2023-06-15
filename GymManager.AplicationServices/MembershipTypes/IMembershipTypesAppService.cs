using GymManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.MembershipTypes
{
    public interface IMembershipTypesAppService
    {
        Task<List<MembershipType>> GetMembershipTypesAsync();

        Task<int> AddMembershipTypeAsync(MembershipType membershipType);

        Task DeleteMembershipTypeAsync(int membershipTypeId);

        Task<MembershipType> GetMembershipTypeByIdAsync(int membershipTypeId);

        Task EditMembershipTypeAsync(MembershipType membershipType);
    }
}
