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
            return new Room(number);
        }

        public virtual Wall CreateWall()
        {
            return new Wall();
        }

        public Maze CreateMaze()
        {
            return new Maze();
        }

        public Door CreateDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}
