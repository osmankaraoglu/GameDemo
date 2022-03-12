using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entity
{
    class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double UnitPrice { get; set; }
        public string GameVersion { get; set; }
    }
}
