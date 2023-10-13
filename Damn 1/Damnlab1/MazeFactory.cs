using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Damnlab1
{
    public class MazeFactory
    {
        public virtual Room CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            return new Room(number);
        }

        public virtual Wall CreateWall()
        {
            return new Wall();
        }

        public virtual Maze CreateMaze()
        {
            return new Maze();
        }

        public virtual Door CreateDoor(Room room1, Room room2)
        {

            if (room1 == null || room2 == null)
            {
                throw new ArgumentNullException("Ошибка null");
            }
            return new Door(room1, room2);
        }
    }
}
