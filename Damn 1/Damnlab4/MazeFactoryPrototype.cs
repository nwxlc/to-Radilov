using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Damnlab1;

namespace Damnlab4
{
    class MazeFactoryPrototype : MazeFactory
    {
        private Maze _prototypeMaze;
        private Room _prototypeRoom;
        private Door _prototypeDoor;
        private Wall _prototypeWall;

        public MazeFactoryPrototype(Maze maze, Wall wall, Room room, Door door)
        {
            _prototypeDoor = door;
            _prototypeMaze = maze;
            _prototypeRoom = room;
            _prototypeWall = wall;
        }

        public override Maze CreateMaze()
        {
            return _prototypeMaze.Clone();
        }
        public override Room CreateRoom(int roomNumber)
        {
            Room room = _prototypeRoom.Clone();
            if (roomNumber <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            room.Number = roomNumber;
            return room;
        }
    }
}
