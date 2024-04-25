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
    internal class ColoresTexturas:_Sprites
    {

        public Color color;
        public ColoresTexturas(Texture2D texturas, Vector2 pocicion ,Color color):base(texturas,pocicion)
        {
            this.color = color;
        }

        
    }
}