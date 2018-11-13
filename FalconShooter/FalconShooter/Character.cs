using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconShooter
{
    class Character
    {
        private int coordX, coordY;
        private int width, height;
        private int hpMax;
        private int hpMin;

        public Character()
        {

        }
        public Character(int coordX, int coordY, int width, int height, int hpMax,int hpMin)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.width = width;
            this.height = height;
            this.hpMax = hpMax;
            this.hpMin = hpMin;
        }
        public Character(int coordX, int coordY, int width, int height)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.width = width;
            this.height = height;
        }
        public void setX(int x)
        {
            this.coordX = x;
        }
        public void setY(int y)
        {
            this.coordY = y;
        }
        public void setWidth(int aWidth)
        {
            this.width = aWidth;
        }
        public void setHeight(int aHeight)
        {
            this.height = aHeight;
        }
        public void setHpMax(int aHp)
        {
            this.hpMax = aHp;
        }
        public void setHpMin(int aHp)
        {
            this.hpMin = aHp;
        }
        public int getCoordX()
        {
            return coordX;
        }
        public int getCoordY()
        {
            return coordY;
        }
        public int getHeight()
        {
            return height;
        }
        public int getWidth()
        {
            return width;
        }
        public int getHpMax()
        {
            return hpMax;
        }
        public int getHpMin()
        {
            return hpMin;
        }
    }
}
