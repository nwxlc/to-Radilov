﻿using System;
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
        private static MazeWithTrapSingleton _instance;

        private MazeWithTrapSingleton()
        { }

        public static MazeWithTrapSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MazeWithTrapSingleton();
            }
            return _instance;
        }
    }
}
