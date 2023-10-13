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
        public override Room CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            return new RoomWithTrap(number);
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            if (room1 == null || room2 == null)
            {
                throw new ArgumentNullException("Ошибка null");
            }
            return new DoorWithTrap(room1, room2);
        }

    }
}
