﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Damnlab2
{
    public class MazeWithTrapBuilder : MazeBuilder
    {
        private Maze _maze = new Maze();

        public override void BuildRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            RoomWithTrap room = new RoomWithTrap(number);

            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.West, new Wall());

            _maze.AddRoom(room);
        }

        public override void BuildDoor(int roomNumber1, int roomNumber2)
        {
            if (roomNumber1 <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber1), "Номер комнаты не соответствует условию");
            }
            if (roomNumber2 <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber2), "Номер комнаты не соответствует условию");
            }
            Room room1 = _maze.RoomNo(roomNumber1);
            Room room2 = _maze.RoomNo(roomNumber2);
            DoorWithTrap door = new DoorWithTrap(room1, room2);
            var tuple = FindWall(room1, room2);
            room1.SetSide(tuple.Item1, door);
            room2.SetSide(tuple.Item2, door);
        }

        public override Maze GetMaze()
        {
            return _maze;
        }
        
    }
}
