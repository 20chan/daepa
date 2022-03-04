using daepa.Renders;
using daepa.Renders.Samples;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace daepa {
  public class Daepa2D : Game {
    private Renderer renderer;

    private LineDrawer sampleLineDrawer;

    private GraphicsDeviceManager graphics;
    private SpriteBatch sb;
    private BasicEffect effect;

    public Daepa2D() {
      graphics = new GraphicsDeviceManager(this);
      Content.RootDirectory = "Content";
      IsMouseVisible = true;
    }

    protected override void Initialize() {
      renderer = new Renderer();
      sampleLineDrawer = new LineDrawer(renderer);

      base.Initialize();
    }

		protected override void LoadContent() {
      sb = new SpriteBatch(GraphicsDevice);
      effect = new BasicEffect(GraphicsDevice);
      effect.VertexColorEnabled = true;
      effect.Projection = Matrix.CreateOrthographicOffCenter(
        0, GraphicsDevice.Viewport.Width,
        GraphicsDevice.Viewport.Height, 0,
        0, 1);

      base.LoadContent();
		}

		protected override void Update(GameTime gameTime) {
      sampleLineDrawer.Update();
      base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime) {
      GraphicsDevice.Clear(Color.CornflowerBlue);
      effect.CurrentTechnique.Passes[0].Apply();

      renderer.Render(GraphicsDevice);

      base.Draw(gameTime);
    }
  }
}
