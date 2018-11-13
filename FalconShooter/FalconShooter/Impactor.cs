using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconShooter
{
    class Impactor : Character
    {
        private bool destroyed;
        private int speed;

        public Impactor(int aCoordX, int aCoordY, int aWidth, int aHeight,int aSpeed)
            : base(aCoordX, aCoordY, aWidth, aHeight)
        {
            setX(aCoordX);
            setY(aCoordY);
            setWidth(aWidth);
            setHeight(aHeight);
            destroyed = false;
            SetSpeed(aSpeed);
        }
        public void SetSpeed(int aSpeed)
        {
            this.speed = aSpeed;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public void CreateImpactor()
        {
            
        }
        public void Destroy()
        {
            destroyed = true;
            setX(0);
            setY(0);
            setWidth(0);
            setHeight(0);
        }
        public bool IsDestroyed()
        {
            return destroyed;
        }


    }
}
