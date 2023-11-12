using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class WallWithBoomb : Wall
    {
        public override void Enter()
        {
            Console.WriteLine("Стена взорвана");
        }
        public override Wall Clone()
        {
            return (WallWithBoomb)this.MemberwiseClone();
        }
    }
}
