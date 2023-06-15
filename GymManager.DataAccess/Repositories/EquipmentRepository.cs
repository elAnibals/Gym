using GymManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess.Repositories
{
    public class EquipmentRepository : Repository<int, Equipment>
    {
        public EquipmentRepository(GymManagerContext context) : base(context)
        {
        }
    }
}
