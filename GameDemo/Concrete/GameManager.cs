using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("The " + game.GameName + " game has been added to the system!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("The " + game.GameName + " game has been deleted!");
        }

        public void Update(Game game, string newVersion)
        {
            newVersion = game.GameVersion;
            Console.WriteLine("The " + game.GameName + " game has been updated to the " + game.GameVersion + " version.");
            
        }
    }
}
