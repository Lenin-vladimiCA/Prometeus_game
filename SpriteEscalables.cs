using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Primero_de_muchos;

namespace Prometeus
{
     internal class SpriteEscalables : _Sprites
    {
            public Rectangle Rect {
                 get
                 {
                    return  new Rectangle((int)Posicion.X, (int)Posicion.Y, 100,200);
                 } 
                 
                 }
            public SpriteEscalables(Texture2D textures,Vector2 Position ):base(textures, Position)
            {

            }
    }
}