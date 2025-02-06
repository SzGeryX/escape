using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace escape;

public class GameScene : IScene {
    private ContentManager ContentManager;
    private SceneManager SceneManager;
    private Texture2D wizardTexture;

    private Player player;
    
    public GameScene(ContentManager contentManager, SceneManager sceneManager) {
        this.ContentManager = contentManager;
        this.SceneManager = sceneManager;

    }

    public void Load() {
        wizardTexture = ContentManager.Load<Texture2D>("Characters/wizard");
        player = new Player(wizardTexture, new Rectangle(0,0,128,128), new());
    }

    public void Draw(SpriteBatch spriteBatch) {
        player.Draw(spriteBatch, new Vector2(0,0));
    }

    public void Update(GameTime gameTime) {
        player.Update(gameTime);
    }
}