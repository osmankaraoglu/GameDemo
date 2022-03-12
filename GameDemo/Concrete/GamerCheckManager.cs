using System;
using GameDemo.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Entity;
using GameDemo.Adapter;

namespace GameDemo.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        IGamerCheckService _gamerCheckService;
        public bool CheckGamerIfRealPerson(Gamer gamer)
        {
            _gamerCheckService = new MernisServiceAdapter();
            return _gamerCheckService.CheckGamerIfRealPerson(gamer);
        }

    }
}
