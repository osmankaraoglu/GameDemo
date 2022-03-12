using System;
using GameDemo.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IGamerCheckService
    {
        public bool CheckGamerIfRealPerson(Gamer gamer);
    }
}
