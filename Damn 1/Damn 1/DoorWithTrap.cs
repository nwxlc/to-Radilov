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

        public bool IsOpen { get; set; }
        public DoorWithTrap(Room room1, Room room2) : base(room1, room2)
        { }

        public override void Enter()
        {
            if (IsOpen)
            {
                Console.WriteLine("Дверь открыта");
            } 
            else
            {
                Console.WriteLine("Дверь закрылась, прохода нет");
            }
        }
    }
}
