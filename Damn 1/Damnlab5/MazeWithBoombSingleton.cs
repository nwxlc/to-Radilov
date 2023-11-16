using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Damnlab1;

namespace Damnlab5
{
    class MazeWithBoombSingleton : MazeWithBoombFactory
    {
        private static MazeWithBoombSingleton instance;

        private MazeWithBoombSingleton()
        { }

        public static MazeWithBoombSingleton getInstance()
        {
            if (instance == null)
                instance = new MazeWithBoombSingleton();
            return instance;
        }
    }
}
