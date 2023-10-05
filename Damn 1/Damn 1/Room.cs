using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Room : IMapSite
    {
        public int Number;
        IMapSite[] sides = new IMapSite[4];
        public Room(int number)
        {
            Number = number;
        }

        public IMapSite GetSide(Direction direction)
        {
            return sides[(int)direction];
        }

        public void SetSide(Direction direction, IMapSite side)
        {
            sides[(int)direction] = side;
        }

        public virtual void Enter()
        {
            Console.WriteLine("Вошли в комнату");
        }
    }
}
