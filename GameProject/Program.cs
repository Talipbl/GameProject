using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Discount> discounts = new List<Discount>()
            {
                new Discount { DiscountID = 1, DiscountRate = 20, EndDate=30 },
                new Discount { DiscountID = 2, DiscountRate = 25, EndDate=15 },
                new Discount { DiscountID = 3, DiscountRate = 5, EndDate=30 },
                new Discount { DiscountID = 4, DiscountRate = 50, EndDate=2 }
            };
            DiscountManager discountManager = new DiscountManager();

            foreach (var discount in discounts)
            {
                discountManager.Add(discount);
            }
            discountManager.Delete(discounts[1]);
            discountManager.Update(discounts[3]);

            Gamer gamer = new Gamer()
            {
                GamerID = 1,
                Identity = "123456789",
                FirstName = "Talip",
                LastName = "BULUNDU",
                BirthYear = 1900
            };
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer);

            List<Game> games = new List<Game>()
            {
                new Game{GameID = 1, GameName = "Game1", Company = "GameCompany1", Price = 25},
                new Game{GameID = 2, GameName = "Game2", Company = "GameCompany2", Price = 30},
                new Game{GameID = 3, GameName = "Game3", Company = "GameCompany3", Price = 35},
                new Game{GameID = 4, GameName = "Game4", Company = "GameCompany4", Price = 40},
                new Game{GameID = 5, GameName = "Game5", Company = "GameCompany5", Price = 45},
            };
            GameManager gameManager = new GameManager();
            foreach (var game in games)
            {
                gameManager.Add(game);
            }

            List<Order> orders = new List<Order>()
            {
                new Order(discounts[1].DiscountRate,games[1].Price){ OrderID = 1, GameId = 2, GamerId = 1, Game = games[2], Gamer = gamer},
                new Order(discounts[2].DiscountRate,games[2].Price){ OrderID = 2, GameId = 2, GamerId = 1, Game = games[2], Gamer = gamer},
                new Order(discounts[3].DiscountRate,games[4].Price){ OrderID = 3, GameId = 4, GamerId = 1, Game = games[4], Gamer = gamer},
            };
            OrderManager orderManager = new OrderManager();
            foreach (var order in orders)
            {
                orderManager.Add(order);
            }
            orderManager.Delete(orders[1]);

            Console.ReadKey();

        }
    }
}
