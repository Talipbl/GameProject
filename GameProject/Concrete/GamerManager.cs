using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer context)
        {
            if (_gamerCheckService.CheckPerson(context))
            {
                Console.WriteLine($"Added Gamer - {context.FirstName} - {context.LastName} - {context.Identity} - {context.BirthYear}");
                return;
            }
            throw new Exception("Not a valid person");
        }

        public void Delete(Gamer context)
        {
            Console.WriteLine($"Deleted Gamer - {context.FirstName} - {context.LastName} - {context.Identity} - {context.BirthYear}");
        }

        public void Update(Gamer context)
        {
            Console.WriteLine($"Updated Gamer - {context.FirstName} - {context.LastName} - {context.Identity} - {context.BirthYear}");
        }
    }
}
