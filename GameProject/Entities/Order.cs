using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Order:IEntity
    {
        public Order(float discount, float price)
        {
            DiscountRate = discount;
            Price = price;
        }
        public int OrderID { get; set; }
        public int GameId { get; set; }
        public int GamerId { get; set; }
        public float Price { get;}
        public float DiscountRate { get; }
        public decimal TotalPrice => Convert.ToDecimal(Price * ((100 - DiscountRate) / 100));

        public virtual Gamer Gamer { get; set; }
        public virtual Game Game { get; set; }

    }
}
