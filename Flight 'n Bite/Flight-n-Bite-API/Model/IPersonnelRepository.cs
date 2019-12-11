using System.Collections.Generic;

namespace Flight_n_Bite_API.Model
{
    public interface IPersonnelRepository
    {
        List<Personnel> GetAllPersonnel();
        Personnel GetPersonnel(string username);
        void Add(Personnel Personnel);
        void SaveChanges();
    }
}
