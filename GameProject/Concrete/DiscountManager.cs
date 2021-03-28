using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class DiscountManager : IDiscountService
    {
        public void Add(Discount context)
        {
            Console.WriteLine($"Added Discount - {context.DiscountRate} - {context.EndDate}");
        }

        public void Delete(Discount context)
        {
            Console.WriteLine($"Deleted Discount - {context.DiscountRate} - {context.EndDate}");
        }

        public void Update(Discount context)
        {
            Console.WriteLine($"Updated Discount - {context.DiscountRate} - {context.EndDate}");
        }
    }
}
