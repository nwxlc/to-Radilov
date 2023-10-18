using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;


namespace Damnlab2
{
    public class MazeBuilder
    {
        private Maze _maze = new Maze();
        public virtual void BuildRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            Room room = CreateRoom(number);

            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.West, new Wall());

            _maze.AddRoom(room);
        }

        public virtual void BuildDoor(int roomNumber1, int roomNumber2)
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
            Door door = CreateDoor(room1, room2);
            var (direction1, direction2) = FindWall(room1, room2);
            room1.SetSide(direction1, door);
            room2.SetSide(direction2, door);   
        }

        public virtual Maze GetMaze()
        {
            return _maze;
        }
        protected static (Direction, Direction) FindWall(Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1), "Ошибка null");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2), "Ошибка null");
            }
            return (Direction.North, Direction.South);
        }

        protected virtual Room CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Номер комнаты не соответствует условию");
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
    }
}
