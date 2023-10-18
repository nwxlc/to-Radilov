using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Damnlab2
{
    public class MazeWithBoombBuilder : MazeBuilder
    {
        private Maze _maze = new Maze();

        public override void BuildRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            RoomWithBoomb room = CreateRoom(number);

            room.SetSide(Direction.East, new WallWithBoomb());
            room.SetSide(Direction.North, new WallWithBoomb());
            room.SetSide(Direction.South, new WallWithBoomb());
            room.SetSide(Direction.West, new WallWithBoomb());

            _maze.AddRoom(room);
        }
        protected override RoomWithBoomb CreateRoom(int number)
        {
            return new RoomWithBoomb(number);
        }
        public override Maze GetMaze()
        {
            return _maze;
        }
    }
}
