using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconShooter
{
    class Player : Character
    {
        private int[,] vectorPuntos;


        public Player(int aCoordX, int aCoordY, int aWidth, int aHeight, int aHpMax, int aHpMin,
            int[,] unvect) 
            : base(aCoordX, aCoordY, aWidth,aHeight,aHpMax,aHpMin)
        {
            setX(aCoordX);
            setY(aCoordY);
            setWidth(aWidth);
            setHeight(aHeight);
            setHpMax(aHpMax);
            setHpMin(aHpMin);
            setVectorPuntos(unvect);
        }
        public void setVectorPuntos(int[,] unVect)
        {
            vectorPuntos = new int[7, 2];
            vectorPuntos = unVect; 
            
        }
        public int getPunto(int i,int j)
        {
            if (i < 7 && j < 2) { return (vectorPuntos[i, j]); }
            else return 300;
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

        public void MoveLeft()
        {
            if (vectorPuntos[3,0] + 7 > 0 && vectorPuntos[6,0] + 7 < 560)
            {
                for (int i = 0;i<7;i++)
                { 
                   vectorPuntos[i, 0] = vectorPuntos[i, 0] - 7;
                   this.setX(getCoordX() - 1);
                }
            }
        }
        public void MoveRight()
        {
            if (vectorPuntos[3, 0] + 7 > 0 && vectorPuntos[6, 0] + 7 < 560)
            {
                for (int i = 0; i < 7; i++)
                {
                    vectorPuntos[i, 0] = vectorPuntos[i, 0] + 7;
                    this.setX(getCoordX() + 1);
                }
            }
        }
        public void MoveUp()
        {

        }
        public void MoveDown()
        {

        }
        public void Shoot()
        {

        }
    }
}
