using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace escape;

public class GameScene : IScene {
    private ContentManager ContentManager;
    private SceneManager SceneManager;
    private Texture2D wizardTexture;
    private Texture2D healthPotiTexture;
    private GraphicsDeviceManager _graphics;
    
    private Camera camera;
    private Player player;
    private Sprite healthPoti;
    
    public GameScene(ContentManager contentManager, SceneManager sceneManager, GraphicsDeviceManager graphics) {
        this.ContentManager = contentManager;
        this.SceneManager = sceneManager;
        this._graphics = graphics;
        camera = new(Vector2.Zero);
    }

    public void Load() {
        wizardTexture = ContentManager.Load<Texture2D>("Characters/wizard");
        healthPotiTexture = ContentManager.Load<Texture2D>("Characters/healthPoti");
        player = new Player(wizardTexture, new Rectangle(0,0,128,128), new());
        healthPoti = new Sprite(healthPotiTexture, new Rectangle(32, 23, 128, 128), new());
    }

    public void Draw(SpriteBatch spriteBatch) {
        healthPoti.Draw(spriteBatch, camera.position);
        player.Draw(spriteBatch, new Vector2(0,0));
        camera.Follow(player.drect, new Vector2(_graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight));
    }

    public void Update(GameTime gameTime) {
        player.Update(gameTime);
        healthPoti.Update(gameTime);
    }
}