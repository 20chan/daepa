using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace daepa.Renders {
  public class Renderer {
    private List<IRenderable> objects;

    public IList<IRenderable> Objects => objects;

    public Renderer(int capacity = 64) {
      objects = new List<IRenderable>(capacity);
		}

    public void Render(GraphicsDevice gd) {
      foreach (var obj in objects) {
        obj.Render(gd);
      }
    }
  }
}
