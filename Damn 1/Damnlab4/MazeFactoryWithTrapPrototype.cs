using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Damnlab1;

namespace Damnlab4
{
    internal class MazeFactoryWithTrapPrototype : MazeFactoryPrototype
    {

        protected MazeFactoryWithTrapPrototype()
            : base(new Maze(), new Wall(), new RoomWithTrap(), new DoorWithTrap())
        { 
        }
    }
}
