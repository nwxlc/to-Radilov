﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Wall : IMapSite
    {
        public virtual void Enter()
        {
            Console.WriteLine("Вы врезались в стену");
        }

        public virtual Wall Clone()
        {
            return (Wall)this.MemberwiseClone();
        }
    }
}
