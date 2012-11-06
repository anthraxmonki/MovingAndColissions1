using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;


namespace MovingAndColissions1
{
    class Paddle
    {

        public Vector2 vPosition;

        public int iYSpeed;





        public Paddle(Vector2 vPosition)
        {

            this.vPosition = vPosition;
        }




        public void UpdatePaddle()
        {

            vPosition.Y += iYSpeed;
        }








    }
}
