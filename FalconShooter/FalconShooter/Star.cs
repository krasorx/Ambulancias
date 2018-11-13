using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconShooter
{
    class Star : Character
    {
        public Star(int aCoordX, int aCoordY, int aWidth, int aHeight)
    : base(aCoordX, aCoordY, aWidth, aHeight)
        {
            setX(aCoordX);
            setY(aCoordY);
            setWidth(aWidth);
            setHeight(aHeight);
        }
        public Star() :base()
        {

        }
    }
}
