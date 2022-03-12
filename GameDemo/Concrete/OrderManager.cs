using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class OrderManager : IOrderService
    {
        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine("The " + game.GameName + " has been ordered for " + game.UnitPrice +" Thanks for your order  " + gamer.FirstName.ToUpper());
        }

        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            game.UnitPrice = game.UnitPrice - (game.UnitPrice * campaign.DiscountPercent / 100);
            Console.WriteLine("The " + game.GameName + " has been ordered discounted value: " + game.UnitPrice + 
                                "TL. Thanks for your order  " + gamer.FirstName.ToUpper());
        }

        public void cancelSale(Game game, Gamer gamer)
        {
            Console.WriteLine("The " + game.GameName + " game order has been canceled by " + gamer.FirstName.ToUpper());
        }
    }
}
