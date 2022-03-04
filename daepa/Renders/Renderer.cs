using System;
using Microsoft.Xna.Framework.Graphics;

namespace daepa.Renders {
  public class Renderer {
    private int lineLength = 0;
    private VertexPositionColor[] lines;

    public Span<VertexPositionColor> Lines => lines;

    public Renderer(int capacity = 1024) {
      lines = new VertexPositionColor[capacity];
		}

    public Span<VertexPositionColor> CreateLine(out int index) {
      var allocated = Lines.Slice(lineLength, 2);
      index = lineLength;
      lineLength += 2;
      return allocated;
		}

    public void Render(GraphicsDevice gd) {
      for (var i = 0; i < lineLength; i += 2) {
        gd.DrawUserPrimitives(PrimitiveType.LineList, lines, i, 2);
			}
    }
  }
}
