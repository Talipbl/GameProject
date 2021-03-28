using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game context)
        {
            Console.WriteLine($"Added Game - {context.GameName} - {context.Company} - {context.Price.ToString("C2")}");
        }

        public void Delete(Game context)
        {
            Console.WriteLine($"Deleted Game - {context.GameName} - {context.Company} - {context.Price.ToString("C2")}");
        }

        public void Update(Game context)
        {
            Console.WriteLine($"Updated Game - {context.GameName} - {context.Company} - {context.Price.ToString("C2")}");
        }
    }
}
