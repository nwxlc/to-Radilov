using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Room : IMapSite
    {
        public int Number { get; set; }
        private IMapSite[] _sides = new IMapSite[4];
        public Room(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            Number = number;
        }

        public IMapSite GetSide(Direction direction)
        {
            return _sides[(int)direction];
        }

        public void SetSide(Direction direction, IMapSite side)
        {
            _sides[(int)direction] = side;
        }

        public virtual void Enter()
        {
            Console.WriteLine("Вошли в комнату");
        }
    }
}
