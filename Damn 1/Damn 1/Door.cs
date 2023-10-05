using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Door : IMapSite
    {
        bool IsOpen;
        Wall wall;
        private readonly Room room1;
        private readonly Room room2;

        public Door(Room ro1, Room ro2)
        {
            room1 = ro1;
            room2 = ro2;
        }

        public void Enter()
        {
            if (IsOpen)
            { Console.WriteLine("Дверь открыта"); }
            else
            { wall.Enter(); }
        }

        public Room OtherSideFrom(Room room)
        {
            if (room.Number == room1.Number)
            { return room2; }
            else if (room.Number == room1.Number)
            { return room1; }
            else
                throw new Exception("Куда пошел");
        }
    }
}
