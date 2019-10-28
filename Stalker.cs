using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PlatformerStarterKit
{
    public class Stalker : Enemy
    {
        private FaceDirection direction = FaceDirection.Left;
        
        public Stalker(Level level, Vector2 position, string spriteSet) : base(level, position, spriteSet)
        {
        }

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            Sprite.PlayAnimation(IdleAnimation);
            
            // Draw facing the way the enemy is moving.
            SpriteEffects flip = direction > 0 ? SpriteEffects.FlipHorizontally : SpriteEffects.None;
            Sprite.Draw(gameTime, spriteBatch, Position, flip);
        }
    }
}