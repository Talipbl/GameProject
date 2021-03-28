using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Add(Order context)
        {
            Console.WriteLine($"Added Order - {context.Gamer.FirstName} - {context.Gamer.LastName} - {context.Game.GameName} - {context.Price.ToString("C2")} - {context.DiscountRate} - {context.TotalPrice.ToString("C2")}");
        }

        public void Delete(Order context)
        {
            Console.WriteLine($"Deleted Order - {context.Gamer.FirstName} - {context.Gamer.LastName} - {context.Game.GameName} - {context.Price.ToString("C2")} - {context.DiscountRate} - {context.TotalPrice.ToString("C2")}");
        }

        public void Update(Order context)
        {
            Console.WriteLine($"Updated Order - {context.Gamer.FirstName} - {context.Gamer.LastName} - {context.Game.GameName} - {context.Price.ToString("C2")} - {context.DiscountRate} - {context.TotalPrice.ToString("C2")}");
        }
    }
}
