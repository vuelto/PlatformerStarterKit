using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PlatformerStarterKit
{
    public class Enemy : IEnemy
    {
        public Level Level { get; private set; }

        public Vector2 Position { get; set; }

        private Rectangle localBounds;

        public Rectangle BoundingRectangle
        {
            get
            {

                int left = (int)Math.Round(Position.X - Sprite.Origin.X) + localBounds.X;
                int top = (int)Math.Round(Position.Y - Sprite.Origin.Y) + localBounds.Y;

                return new Rectangle(left, top, localBounds.Width, localBounds.Height);
            }
            private set
            {
                localBounds = value;
            }
        }

        public Enemy(Level level, Vector2 position, string spriteSet) {
            Level = level;
            Position = position;
            SpriteSet = spriteSet;
            LoadContent();
        }


        private string SpriteSet { get; set; }

        internal Animation RunAnimation { get; private set; }

        internal Animation IdleAnimation { get; private set; }

        internal AnimationPlayer Sprite { get; private set; } = new AnimationPlayer();

        private void LoadContent()
        {
            // Load animations.
            RunAnimation = new Animation(Level.Content.Load<Texture2D>(SpriteSet + "Run"), 0.1f, true);
            IdleAnimation = new Animation(Level.Content.Load<Texture2D>(SpriteSet + "Idle"), 0.15f, true);
            Sprite.PlayAnimation(IdleAnimation);

            // Calculate bounds within texture size.
            int width = (int)(IdleAnimation.FrameWidth * 0.35);
            int left = (IdleAnimation.FrameWidth - width) / 2;
            int height = (int)(IdleAnimation.FrameWidth * 0.7);
            int top = IdleAnimation.FrameHeight - height;
            BoundingRectangle = new Rectangle(left, top, width, height);
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Update(GameTime gameTime)
        {
            throw new System.NotImplementedException();
        }
    }
}