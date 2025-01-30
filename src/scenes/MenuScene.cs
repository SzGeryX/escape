using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
namespace escape;

public class MenuScene : IScene
{

    private ContentManager ContentManager;
    private SceneManager SceneManager;
    public MenuScene(ContentManager contentManager, SceneManager sceneManager) {
        this.ContentManager = contentManager;
        this.SceneManager = sceneManager;
    }

    public void Load() {

    }
    public void Draw(SpriteBatch spriteBatch) {

    }
    public void Update(GameTime gameTime) {
        if (Keyboard.GetState().IsKeyDown(Keys.Space)) 
        {
            SceneManager.AddScene(new GameScene(ContentManager));
        }
    }

};