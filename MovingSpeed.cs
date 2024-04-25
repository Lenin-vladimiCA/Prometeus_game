using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Prometeus
{
    internal class MovingSpeed:SpriteEscalables
    {
        private float speed;
        public MovingSpeed(Texture2D texture, Vector2 position,float speed):base(texture, position)
        {
            this.speed = speed;
        }

        public override void Update()
        {
            base.Update();
            Posicion.X += speed;
        }
    }
}