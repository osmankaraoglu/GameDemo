using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    interface IOrderService
    {
        public void Sale(Game game, Gamer gamer);
        public void Sale(Game game, Gamer gamer, Campaign campaign);
        public void cancelSale(Game game, Gamer gamer);
    }
}
