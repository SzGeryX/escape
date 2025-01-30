using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace escape;

public class GameScene : IScene {
    private ContentManager ContentManager;
    private Texture2D wizardTexture;
    
    public GameScene(ContentManager contentManager) {
        this.ContentManager = contentManager;
    }

    public void Load() {
        wizardTexture = ContentManager.Load<Texture2D>("Characters/wizard");
    }

    public void Draw(SpriteBatch spriteBatch) {
        spriteBatch.Draw(wizardTexture, new Vector2(0, 0), Color.White);
    }

    public void Update(GameTime gameTime) {
        
    }
}