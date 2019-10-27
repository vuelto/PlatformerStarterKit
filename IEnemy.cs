
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PlatformerStarterKit {
    public interface IEnemy
    {
        Level Level { get; }

        Vector2 Position { get; }

        Rectangle BoundingRectangle { get; }

        void Draw(GameTime gameTime, SpriteBatch spriteBatch);

        void LoadContent(string spriteSet);

        void Update(GameTime gameTime);
    }
}