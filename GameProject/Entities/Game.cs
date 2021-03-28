using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Game : IEntity
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public string Company { get; set; }
        public float Price { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
