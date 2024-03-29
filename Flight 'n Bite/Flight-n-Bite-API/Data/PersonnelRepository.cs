﻿using Flight_n_Bite_API.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Flight_n_Bite_API.Data
{
    public class PersonnelRepository : IPersonnelRepository
    {
        private readonly FlightDbContext _context;

        public PersonnelRepository(FlightDbContext context)
        {
            _context = context;
        }

        public void Add(Personnel Personnel)
        {
            _context.Personnels.Add(Personnel);
        }

        public Personnel GetPersonnel(string username)
        {
            return _context.Personnels.Include(p => p.Messages).FirstOrDefault(p => p.UserName == username);
        }

        public List<Personnel> GetAllPersonnel()
        {
            return _context.Personnels.Include(p => p.Messages).ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }


    }
}
