using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;


/* MazeWithBoombFactory - это конкретная фабрика от абстрактной фабрики MazeFactory, получается нужно наследовать
все методы создания стен, дверей и т.д. и оверайднуть два метода?*/
namespace Damnlab1
{
    class MazeWithBoombFactory
    {
        public RoomWithBoomb CreateRoom(int no)
        {
            return new RoomWithBoomb(no);
        }

        public WallWithBoomb CreateWall()
        {
            return new WallWithBoomb();
        }
    }
}
