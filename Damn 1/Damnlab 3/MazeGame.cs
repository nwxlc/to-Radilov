using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Damnlab3
{
    public class MazeGame
    {
        public Maze Create()
        {
            Maze maze = CreateMaze();
            Room room1 = CreateRoom(1);
            Room room2 = CreateRoom(2);
            Door door = CreateDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, door);
            room1.SetSide(Direction.East, CreateWall());
            room1.SetSide(Direction.South, CreateWall());
            room1.SetSide(Direction.West, CreateWall());

            room2.SetSide(Direction.North, CreateWall());
            room2.SetSide(Direction.East, CreateWall());
            room2.SetSide(Direction.South, door);
            room2.SetSide(Direction.West, CreateWall());

            return maze;
        }

        protected virtual Room CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Номер комнаты не соответствует условию");
            }
            return new Room(number);
        }

        protected virtual Door CreateDoor(Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1), "Ошибка null ");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2), "Ошибка null");
            }
            return new Door(room1, room2);
        }

        protected virtual Wall CreateWall()
        {
            return new Wall();
        }

        protected virtual Maze CreateMaze()
        {
            return new Maze();
        }
    }
}
