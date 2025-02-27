using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace escape;

public class Sprite {
    public Texture2D texture;
    public Rectangle drect, srect;

    public Sprite(Texture2D texture, Rectangle drect, Rectangle srect) {
        this.texture = texture;
        this.drect = drect;
        this.srect = srect;
    }

    public virtual void Update(GameTime gameTime) {

    }

    public virtual void Draw(SpriteBatch spriteBatch, Vector2 offset) {
        Rectangle dest = new(
            drect.X + (int)offset.X,
            drect.Y + (int)offset.Y,
            drect.Width,
            drect.Height
        );

        spriteBatch.Draw(
            texture,
            dest,
            srect,
            Color.White
        );

        spriteBatch.Draw(
            texture,
            dest,
            null,
            Color.White,
            0.0f,
            new Vector2(0, 0),
            (SpriteEffects.None),
            1.0f
        );
    }
}