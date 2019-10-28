
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PlatformerStarterKit
{
    public interface IEnemy
    {
        Level Level { get; }

        Vector2 Position { get; set; }

        Rectangle BoundingRectangle { get; }

        void Draw(GameTime gameTime, SpriteBatch spriteBatch);

        void Update(GameTime gameTime);
    }
}