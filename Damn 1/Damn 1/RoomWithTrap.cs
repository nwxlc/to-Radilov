using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class RoomWithTrap : Room
    {
        
        private static Random _rnd = new Random();
        public RoomWithTrap(int number) : base(number)
        { }
        public override void Enter()
        {
            base.Enter();
            if (_rnd.Next(2) == 0)
            {
                Console.WriteLine("Сработала ловушка, дверь закрыта");
                sides.OfType<DoorWithTrap>().ToList().ForEach(door => door.IsOpen = false);

            }
        }
    }
}
