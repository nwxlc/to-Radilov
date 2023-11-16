using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Damnlab1;

namespace Damnlab5
{
    class MazeWithTrapSingleton : MazeWithTrapFactory
    {
        private static MazeWithTrapSingleton instance;

        private MazeWithTrapSingleton()
        { }

        public static MazeWithTrapSingleton getInstance()
        {
            if (instance == null)
                instance = new MazeWithTrapSingleton();
            return instance;
        }
    }
}
