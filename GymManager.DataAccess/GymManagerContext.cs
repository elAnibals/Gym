using GymManager.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public class GymManagerContext : IdentityDbContext
    {
        public GymManagerContext( DbContextOptions<GymManagerContext> options) : base(options) 
        {
            
        }
        public virtual DbSet<City> cities { get; set; }
        public virtual DbSet<Member> members { get; set; }
        public virtual DbSet<MembershipType> membershipTypes { get; set; }
        public virtual DbSet<Sale> sales { get; set; }

        public virtual DbSet<ProductType> productTypes { get; set; }
        public virtual DbSet<MesureType> mesureTypes { get; set;}

        public virtual DbSet<Inventory> inventories { get; set; }

        public virtual DbSet<ProductSale> productSales { get; set; }
        public virtual DbSet<MembershipSale> membershipSales { get; set; }

        public virtual DbSet<Equipment> equipment { get; set; }
        public virtual DbSet<EquipmentType> equipmentTypes { get; set; }
        public virtual DbSet<UnitsEquipment> unitsEquipment { get; set; }


    }
}
