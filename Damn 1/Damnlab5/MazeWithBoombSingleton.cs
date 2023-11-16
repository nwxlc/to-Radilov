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
        private static MazeWithBoombSingleton _instance;

        private MazeWithBoombSingleton()
        { }

        public static MazeWithBoombSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MazeWithBoombSingleton();
            }
            return _instance;
        }
    }
}
