using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Damnlab1;

namespace Damnlab4
{
    internal class MazeFactoryWithTrapPrototype : MazeFactoryPrototype
    {
        private Maze _prototypeMaze;
        private RoomWithTrap _prototypeRoomWithTrap;
        private DoorWithTrap _prototypeDoorWithTrap;
        private Wall _prototypeWall;

        public MazeFactoryWithTrapPrototype(Maze maze, Wall wall, RoomWithTrap roomWithTrap, DoorWithTrap doorWithTrap)
        {
            _prototypeDoorWithTrap = doorWithTrap;
            _prototypeRoomWithTrap = roomWithTrap;
            _prototypeWall = wall;
            _prototypeMaze = maze;
        }

        public override Maze CreateMaze()
        {
            return _prototypeMaze.Clone();
        }

        public override Wall CreateWall()
        {
            Wall wall = _prototypeWall.Clone();
            return wall;
        }

        public override Room CreateRoom(int roomNumber)
        {
            RoomWithTrap roomWithTrap = (RoomWithTrap)_prototypeRoomWithTrap.Clone();
            if (roomNumber <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            roomWithTrap.Initialize(roomNumber);
            return roomWithTrap;
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            DoorWithTrap doorWithTrap = (DoorWithTrap)_prototypeDoorWithTrap.Clone();
            doorWithTrap.Initialize(room1, room2);
            return doorWithTrap;
        }
    }
}
