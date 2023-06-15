using GymManager.Core.Entities;

namespace GymManager.Web.Model
{
    public class MemberListViewModel
    {
        public int NewMembersCount { get; set; }
        public List<Member> Members { get; set; }
    }
}
