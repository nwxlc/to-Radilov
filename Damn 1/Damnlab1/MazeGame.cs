using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Damnlab1
{
    public class MazeGame
    {
        public Maze Create(MazeFactory factory)
        {
            Maze maze = factory.CreateMaze();
            Room _room1 = factory.CreateRoom(1);
            Room _room2 = factory.CreateRoom(2);
            Door _door = factory.CreateDoor(_room1, _room2);

            maze.AddRoom(_room1);
            maze.AddRoom(_room2);

            _room1.SetSide(Direction.North, _door);
            _room1.SetSide(Direction.East, factory.CreateWall());
            _room1.SetSide(Direction.South, factory.CreateWall());
            _room1.SetSide(Direction.West, factory.CreateWall());

            _room2.SetSide(Direction.North, factory.CreateWall());
            _room2.SetSide(Direction.East, factory.CreateWall());
            _room2.SetSide(Direction.South, _door);
            _room2.SetSide(Direction.West, factory.CreateWall());

            return maze



        }
    }
}
