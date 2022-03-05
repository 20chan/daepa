using Microsoft.Xna.Framework.Graphics;

namespace daepa.Renders.Primitives2D {
	public struct Line : IRenderable {
		public VertexPositionColor[] points;

		public ref VertexPositionColor Point0 => ref points[0];
		public ref VertexPositionColor Point1 => ref points[1];

		public Line(VertexPositionColor p0, VertexPositionColor p1) {
			points = new VertexPositionColor[2];
			Point0 = p0;
			Point1 = p1;
		}

		public void Render(GraphicsDevice gd) {
			gd.DrawUserPrimitives(PrimitiveType.LineList, points, 0, 1);
		}
	}
}
