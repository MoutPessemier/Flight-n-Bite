using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Data
{
    public class GroupRepository : IGroupRepository
    {
        private readonly FlightDbContext _context;

        public GroupRepository(FlightDbContext context)
        {
            _context = context;
        }

        public void AddGroup(Group group)
        {
            _context.Groups.Add(group);
        }

        public List<Group> GetGroups()
        {
            return _context.Groups.Include(p => p.Companions).ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
