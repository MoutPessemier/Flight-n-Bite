using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Model
{
    public interface IPersonnelRepository
    {
        List<Personnel> GetAllPersonnel();
        Personnel GetPersonnel(int PersonnelId);
        void Add(Personnel Personnel);
        void SaveChanges();
    }
}
