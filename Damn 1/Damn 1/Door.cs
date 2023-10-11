using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Door : IMapSite
    {
        private bool _isOpen;
        private readonly Room _room1;
        private readonly Room _room2;

        public Door(Room room1, Room room2)
        {
            if (room1 == null || room2 == null)
            {
                throw new ArgumentNullException("Ошибка null");
            }
            this._room1 = room1;
            this._room2 = room2;
        }

        public void Enter()
        {
            if (_isOpen)
            { 
                Console.WriteLine("Дверь открыта"); 
            }
            else
            {
                Console.WriteLine("Дверь закрыта");
            }
        }

        public Room OtherSideFrom(Room room)
        {
            if (room.Number == _room1.Number)
            {
                return _room2;
            }
            else if (room.Number == _room2.Number)
            {
                return _room1;
            }
            else
            {
                throw new Exception("Куда пошел"); 
            }
        }
    }
}
