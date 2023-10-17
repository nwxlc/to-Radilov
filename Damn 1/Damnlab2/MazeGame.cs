using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damnlab2
{
    public class MazeGame
    {
        public void Create(MazeBuilder builder)
        {
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);
        }
    }
}
