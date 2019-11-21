using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public interface IGroupRepository
    {
        List<Group> GetGroups();
        void AddGroup(Group group);
        void SaveChanges();
        Group GetGroupByPassenger(int passengerId);
        Group GetGroupById(int groupId);
    }
}
