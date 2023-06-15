using GymManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess.Repositories
{
    public class MembersRepository : Repository<int, Member>
    {
        public MembersRepository(GymManagerContext context) : base(context)
        {
        }




        public override async Task<Member> AddAsync(Member entity)
        {
            var city = await Context.cities.FindAsync(entity.City.Id);
            entity.City = null;
            var membershiptype = await Context.membershipTypes.FindAsync(entity.MembershipType.Id);
            entity.MembershipType = null;
            await Context.members.AddAsync(entity);
            membershiptype.Members.Add(entity);
            city.Members.Add(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public override async Task<Member> GetAsync(int id)
        {
            var member = await Context.members
                .Include(x => x.City).Include(x => x.MembershipType)
                .FirstOrDefaultAsync(x => x.Id == id);
            return member;
        }

        public override async Task<Member> UpdateAsync(Member entity)
        {
            var city = await Context.cities.FindAsync(entity.City.Id);
            var membershipType = await Context.membershipTypes.FindAsync(entity.MembershipType.Id);
            entity.MembershipType = null;
            entity.City = null;

            Context.members.Update(entity);
            
            membershipType.Members.Add(entity);
            city.Members.Add(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

    }
}
