using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool CheckPerson(Gamer gamer)
        {
            return true;
        }
    }
}
