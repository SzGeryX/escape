using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace escape;

public class Player : Sprite{
    private bool direction;
    private bool flipped;
    public Player(Texture2D texture, Rectangle drect, Rectangle srect)
    : base(texture, drect, srect) {
        direction = false;
    }

    public override void Update(GameTime gameTime) {
        if (Keyboard.GetState().IsKeyDown(Keys.W)) {
            flipped = false;
            drect.Y -= 5;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.S)) {
            flipped = true;
            drect.Y += 5;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.A)) {
            direction = false;
            drect.X -= 5;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.D)) {
            direction = true;
            drect.X += 5;
        }
    }

    public override void Draw(SpriteBatch spriteBatch, Vector2 offset) {
        Rectangle dest = new(
            drect.X + (int)offset.X,
            drect.Y + (int)offset.Y,
            drect.Width,
            drect.Height
        );

        spriteBatch.Draw(
            texture,
            dest,
            null,
            Color.White,
            0.0f,
            new Vector2(0, 0),
            (direction ? SpriteEffects.FlipHorizontally : SpriteEffects.None) | (flipped ? SpriteEffects.FlipVertically : SpriteEffects.None),
            1.0f
        );
    }
}