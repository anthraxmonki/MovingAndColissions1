using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;




namespace MovingAndColissions1
{

    class Ball
    {

        public Point pPosition;

        public int xSpeed;
        public int ySpeed;




        public Ball(Point position)
        {
            pPosition = position;

        }


        public void UpdateBall()
        {
            pPosition.X += xSpeed;
            pPosition.Y += ySpeed;

        }

        public void Size()
        {

        }

    










    }

}
