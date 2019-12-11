using System.Collections.Generic;

namespace Flight_n_Bite_API.Model
{
    public interface IGroupRepository
    {
        List<Group> GetGroups();
        void AddGroup(Group group);
        void SaveChanges();
        Group GetGroupByPassenger(int passengerId);
    }
}
