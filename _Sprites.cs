using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primero_de_muchos
{
    internal class _Sprites
    { 
        public Texture2D Textura;
        public Vector2 Posicion;

        public _Sprites(Texture2D Textura,Vector2 Posicion) 
        {
            this.Textura = Textura;
            this.Posicion = Posicion;
        }

        public virtual void Update()
        {

        }

    }
}
