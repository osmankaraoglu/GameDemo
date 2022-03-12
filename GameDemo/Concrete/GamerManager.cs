using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GamerManager : IGamerService
    {
        internal IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if(_gamerCheckService.CheckGamerIfRealPerson(gamer) == true)
                Console.WriteLine("The gamer has been Added succesfully!");
            else
                Console.WriteLine("The gamer could not been added, please check your informations.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("The gamer has been deleted!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("The gamer has been updated!");
        }
    }
}
