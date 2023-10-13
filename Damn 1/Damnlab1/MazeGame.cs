using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Library;

namespace Damnlab1
{
    public class MazeGame
    {
        public Maze Create(MazeFactory factory)
        {
            Maze maze = factory.CreateMaze();
            Room room1 = factory.CreateRoom(1);
            Room room2 = factory.CreateRoom(2);
            Door door = factory.CreateDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, door);
            room1.SetSide(Direction.East, factory.CreateWall());
            room1.SetSide(Direction.South, factory.CreateWall());
            room1.SetSide(Direction.West, factory.CreateWall());

            room2.SetSide(Direction.North, factory.CreateWall());
            room2.SetSide(Direction.East, factory.CreateWall());
            room2.SetSide(Direction.South, door);
            room2.SetSide(Direction.West, factory.CreateWall());

            return maze;

        }
    }
}
