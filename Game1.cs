using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace monogametest1
{
    public class Game1 : Game
    {
        Random gen = new Random();
        string[] bgs = new string[] { "bg", "cave", "seafloor" };
        Texture2D dinoTexture;
        Texture2D loogi;
        Texture2D bgImage;
        Texture2D rocc;
        Texture2D fire;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 715;
            _graphics.ApplyChanges();
            this.Window.Title = "My first project !!!";
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            dinoTexture = Content.Load<Texture2D>("dino");
            loogi = Content.Load<Texture2D>("luigi");
            bgImage = Content.Load<Texture2D>(bgs[gen.Next(3)]);
            rocc = Content.Load<Texture2D>("rock");
            fire = Content.Load<Texture2D>("fireball");
                // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.PapayaWhip);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(bgImage, new Vector2(0,0), Color.White);
            _spriteBatch.Draw(dinoTexture, new Vector2(6, 105), Color.Red);
            _spriteBatch.Draw(fire, new Vector2(446, 125), Color.White);
            _spriteBatch.Draw(loogi, new Vector2(843, 78), Color.White);
            for (int i = 0; i < 7; i++)
                _spriteBatch.Draw(rocc, new Vector2(i * 180 + 10, 490), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
