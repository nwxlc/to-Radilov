using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;



namespace Damnlab1
{
    public class MazeWithBoombFactory : MazeFactory
    {
        public override Room CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Номер комнаты не соответствует условию");
            }
            return new RoomWithBoomb(number);
        }

        public override Wall CreateWall()
        {
            return new WallWithBoomb();
        }
    }
}
