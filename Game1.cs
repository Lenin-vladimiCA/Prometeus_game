using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Prometeus;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Primero_de_muchos
{
    public class Game1 : Game
    {
        //referencia de clases o fucionalidades
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _imagen;
        Texture2D Roboto;
        Texture2D gema_azul;
        _Sprites _sprites;
        

        //lista de personajes para colissiones y demas 
        List<_Spites> spites;
        Player player;

        //Controladores 
        MouseState MO;
        Vector2 PosicionaMiento = new Vector2(300,300);
        Vector2 Posisinamiento_del_jugador;

        //Variables  generales
        bool Verificacion = true;
        bool Confirmacion_de_botones = false;
        private int TamañoAlto = 1366;
        private int TamañoAncho = 768;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            _graphics.PreferredBackBufferWidth = TamañoAlto;
            _graphics.PreferredBackBufferHeight = TamañoAncho;
            _graphics.ApplyChanges();

            Window.AllowUserResizing = true;

            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Texture2D texture = Content.Load<Texture2D>("Gema Elemental Agua");
            Texture2D texture1 = Content.Load<Texture2D>("parado de lado roboto");
            player =  new Player(playertexture , new Vector2(200,200))
            
            // Moving = new MovingSpeed(texture,Vector2.Zero, 1F);
     
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            //Mouse Fucionalidad
            if(Mouse.GetState().LeftButton == ButtonState.Pressed) 
            {
                Debug.WriteLine("hola");
            }

            //Arriba
            if(Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                Confirmacion_de_botones = true;
                PosicionaMiento.Y-=2;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Up))
            {
                Confirmacion_de_botones = false;
              
            }

            //Abajo
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                Confirmacion_de_botones = true;
                PosicionaMiento.Y+=2;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Down))
            {
                Confirmacion_de_botones = false;
               
            }

            //Izquierda
            if (Keyboard.GetState().IsKeyDown(Keys.Left)) 
            {
                Confirmacion_de_botones = true;
                PosicionaMiento.X-=2;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Left))
            {
                Confirmacion_de_botones = false;
            }


            //Derecha
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                Confirmacion_de_botones = true;
                PosicionaMiento.X+=2;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Right))
            {
                Confirmacion_de_botones = false;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
           
            _spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            //_spriteBatch.Draw(_imagen,Vector2.Zero,Color.White);
            _spriteBatch.End();
            
            // aqui se dibujan lo personajes 
            _spriteBatch.Begin(samplerState:SamplerState.PointClamp);
           
            _spriteBatch.Draw(Roboto,PosicionaMiento,Color.White);
            _spriteBatch.Draw(gema_azul, Vector2.Zero, Color.White);
      
            _spriteBatch.End();
          
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
