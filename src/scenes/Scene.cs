using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace escape;

public interface IScene
{
    public void Load();
    public void Draw(SpriteBatch spriteBatch);
    public void Update(GameTime gameTime);
};

