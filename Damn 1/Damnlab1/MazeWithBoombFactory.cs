using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;



namespace Damnlab1
{
    class MazeWithBoombFactory : MazeFactory
    {
        public override Room CreateRoom(int no)
        {
            return new RoomWithBoomb(no);
        }

        public override WallWithBoomb CreateWall()
        {
            return new WallWithBoomb();
        }
    }
}
