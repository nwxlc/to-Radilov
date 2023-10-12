using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class RoomWithBoomb : Room
    {
        private WallWithBoomb _wallWithBoomb = new WallWithBoomb();
        private static Random _rnd = new Random();
        public RoomWithBoomb(int number) : base(number)
        { }
        public override void Enter()
        {
            base.Enter();
            if (_rnd.Next(2) == 0)
            {
                Console.WriteLine("Бомба взорвалась");
                _wallWithBoomb.Enter();
                sides.OfType<WallWithBoomb>().ToList().ForEach(x => x.Enter());
            }
        }
    }
}
