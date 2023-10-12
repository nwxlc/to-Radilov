using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Damnlab1
{
    public class MazeWithTrapFactory : MazeFactory
    {
        public override Room CreateRoom(int Number)
        {
            return new RoomWithTrap(Number);
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            return new DoorWithTrap(room1, room2);
        }

    }
}
