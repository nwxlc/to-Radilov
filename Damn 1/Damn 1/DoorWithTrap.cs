using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Вопрос: как мне при срабатывании ловушки выдавать сообщение

namespace Library
{
    public class DoorWithTrap : Door
    {

        internal bool IsOpen { get; set; }
        public DoorWithTrap(Room room1, Room room2) : base(room1, room2)
        { }

        public DoorWithTrap()
        {
        }

        public override void Enter()
        {
            if (IsOpen)
            {
                base.Enter();
            } 
            else
            {
                Console.WriteLine("Дверь закрылась, прохода нет");
            }
        }

        public override Door Clone()
        {
            return (DoorWithTrap)this.MemberwiseClone();
        }
    }
}
