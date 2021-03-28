using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Discount:IEntity
    {
        public int DiscountID { get; set; }
        public float DiscountRate { get; set; }
        public int EndDate { get; set; }
    }
}
