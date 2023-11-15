using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damnlab1;
using Library;

namespace Damnlab4
{
    internal class MazeFactoryWithBoombPrototype : MazeFactoryPrototype
    {

        protected MazeFactoryWithBoombPrototype()
             : base(new Maze(), new WallWithBoomb(), new RoomWithBoomb(), new Door())
        {
        }

    }
}
