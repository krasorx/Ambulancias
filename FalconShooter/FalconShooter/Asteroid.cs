using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconShooter
{
    class Asteroid : Character
    {
        private int speed;
        private bool destroyed;
        public Asteroid(int aCoordX, int aCoordY, int aWidth, int aHeight, int aHpMax, int aHpMin,int aSpeed)
            : base(aCoordX, aCoordY, aWidth, aHeight, aHpMax, aHpMin)
        {
            setX(aCoordX);
            setY(aCoordY);
            setWidth(aWidth);
            setHeight(aHeight);
            setHpMax(aHpMax);
            setHpMin(aHpMin);
            setSpeed(aSpeed);
            this.destroyed = false;
        }
        public void Destroy()
        {
            this.destroyed = true;
        }
        public bool IsDestroyed()
        {
            return destroyed;
        }
        public void setSpeed(int aSpeed)
        {
            speed = aSpeed;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public void DrawAsteroid()
        {
            
        }


    }
}
