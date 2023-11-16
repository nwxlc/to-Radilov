using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Damnlab1;

namespace Damnlab5
{
    public class MazeSingleton : MazeFactory
    {
        private static MazeSingleton instance;

        private MazeSingleton()
        { }

        public static MazeSingleton getInstance()
        {
            if (instance == null)
                instance = new MazeSingleton();
            return instance;
        }
    }
}
