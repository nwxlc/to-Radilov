﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Room : IMapSite
    {
        public int Number { get; set; }
        protected IMapSite[] sides = new IMapSite[4];
        public Room(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Номер комнаты не соответствует условию");
            }
            Number = number;
        }

        public Room()
        {
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

        public void Initialize(int roomNumber)
        {
            Number = roomNumber;
        }

        public virtual Room Clone()
        {
            return (Room)this.MemberwiseClone();
        }
    }
}
