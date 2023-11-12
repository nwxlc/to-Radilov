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
        private Maze _prototypeMaze;
        private RoomWithBoomb _prototypeRoomWithBoomb;
        private Door _prototypeDoor;
        private WallWithBoomb _prototypeWallWithBoomb;

        public MazeFactoryWithBoombPrototype(Maze maze, WallWithBoomb wall, RoomWithBoomb room, Door door)
        {
            _prototypeDoor = door;
            _prototypeMaze = maze;
            _prototypeRoomWithBoomb = room;
            _prototypeWallWithBoomb = wall;
        }

        public override Maze CreateMaze()
        {
            return _prototypeMaze.Clone();
        }
        public override Wall CreateWall()
        {
            WallWithBoomb wall = (WallWithBoomb)_prototypeWallWithBoomb.Clone();
            return wall;
        }
        public override Door CreateDoor(Room room1, Room room2)
        {
            Door door = _prototypeDoor.Clone();
            door.Initialize(room1, room2);
            return door;

        }
        public override Room CreateRoom(int roomNumber)
        {
            RoomWithBoomb roomWithBoomb = (RoomWithBoomb)_prototypeRoomWithBoomb.Clone();
            if (roomNumber <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            roomWithBoomb.Initialize(roomNumber);
            return roomWithBoomb;
        }
    }
}
